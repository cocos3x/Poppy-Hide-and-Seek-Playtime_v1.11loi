using UnityEngine;

namespace Game.Enemy
{
    public sealed class GoToLastSeePlayerPositionNode : Node
    {
        // Fields
        private Game.Enemy.EnemyController _enemyController;
        private UnityEngine.AI.NavMeshAgent _meshAgent;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this._meshAgent = this._enemyController._view.MeshAgent;
            bool val_1 = this._enemyController._view.MeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            this._meshAgent.isStopped = false;
            this._enemyController._view.PlayAnimation(animationType:  1);
        }
        public override void Dispose()
        {
            this._meshAgent.isStopped = true;
            this._meshAgent = 0;
            this._enemyController._view.Idle();
        }
        public override void Process()
        {
            if(this._meshAgent.remainingDistance > 0f)
            {
                    return;
            }
            
            if(this._meshAgent.pathPending != false)
            {
                    return;
            }
            
            this.NextNode();
        }
        public GoToLastSeePlayerPositionNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
