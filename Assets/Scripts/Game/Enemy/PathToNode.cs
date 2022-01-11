using UnityEngine;

namespace Game.Enemy
{
    public sealed class PathToNode : Node
    {
        // Fields
        private UnityEngine.Vector3 _position;
        private Game.Enemy.EnemyController _enemyController;
        private UnityEngine.AI.NavMeshAgent _meshAgent;
        
        // Properties
        public UnityEngine.Vector3 Position { get; set; }
        
        // Methods
        public UnityEngine.Vector3 get_Position()
        {
            return new UnityEngine.Vector3() {x = this._position};
        }
        public void set_Position(UnityEngine.Vector3 value)
        {
            this._position = value;
            mem[1152921507306800644] = value.y;
            mem[1152921507306800648] = value.z;
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this._meshAgent = this._enemyController._view.MeshAgent;
            bool val_1 = this._enemyController._view.MeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = this._position});
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
            return (string)this.ToString() + " Position: "(" Position: ") + this._position;
        }
        public PathToNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
