using UnityEngine;

namespace Game.Enemy
{
    public sealed class PathToRandomPositionNode : Node
    {
        // Fields
        private Game.GameModel _model;
        private Game.Enemy.EnemyController _enemyController;
        private Game.LevelView _levelView;
        private Game.Config.GameConfig _config;
        private UnityEngine.AI.NavMeshAgent _meshAgent;
        private float _previousDistanceToEnemy;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            float val_7;
            var val_8;
            var val_9;
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            this._meshAgent = this._enemyController._view.MeshAgent;
            val_7 = 0f;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_8 = 0f;
            val_9 = val_7;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = 0f, y = val_7, z = 0f}, rhs:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z})) != false)
            {
                    val_7 = this._model.LevelBounds;
                float val_3 = Utilities.MathUtil.RandomSystem(min:  val_7, max:  0f);
            }
            
            UnityEngine.Vector2 val_5 = UnityEngine.Vector2.zero;
            this._enemyController.<LastHearVictim>k__BackingField = val_5;
            mem2[0] = val_5.y;
            bool val_6 = this._meshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_3, y = 0f, z = Utilities.MathUtil.RandomSystem(min:  val_3, max:  0f)});
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
            float val_11;
            float val_12;
            UnityEngine.Vector2 val_1 = this._enemyController._view.Position;
            UnityEngine.Vector2 val_2 = this._levelView.Units[0].Position;
            val_11 = val_2.x;
            val_12 = val_1.x;
            float val_3 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_12, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_11, y = val_2.y});
            if(this._enemyController._view._isVictim != false)
            {
                    float val_4 = this._config.GetValue(param:  11);
                if(val_3 < 0)
            {
                    val_12 = this._previousDistanceToEnemy;
                if(val_3 < 0)
            {
                    UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
                float val_6 = Utilities.MathUtil.RandomSystem(min:  this._model.LevelBounds, max:  val_2.y);
                val_11 = val_6;
                val_12 = val_11;
                bool val_8 = this._meshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_12, y = val_5.y, z = Utilities.MathUtil.RandomSystem(min:  val_6, max:  val_2.y)});
            }
            
            }
            
            }
            
            this._previousDistanceToEnemy = val_3;
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
        public PathToRandomPositionNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
