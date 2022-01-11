using UnityEngine;

namespace Game.Enemy
{
    public sealed class GoToRandomPointInRadiusNode : Node
    {
        // Fields
        private float _radius;
        private Game.Enemy.EnemyController _enemyController;
        private UnityEngine.AI.NavMeshAgent _meshAgent;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            UnityEngine.Vector3 val_2 = this._enemyController._view.transform.position;
            float val_3 = Utilities.MathUtil.RandomSystem(min:  0f, max:  6.283185f);
            float val_8 = this._radius;
            this._meshAgent = this._enemyController._view.MeshAgent;
            val_8 = val_3 * val_8;
            bool val_7 = this._enemyController._view.MeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_2.x + (val_3 * this._radius), y = val_2.y, z = val_2.z + val_8});
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
        public override string ToString()
        {
            return (string)this.ToString() + " Radius: "(" Radius: ") + this._radius;
        }
        public GoToRandomPointInRadiusNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
