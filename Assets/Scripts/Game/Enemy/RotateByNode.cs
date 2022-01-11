using UnityEngine;

namespace Game.Enemy
{
    public sealed class RotateByNode : Node
    {
        // Fields
        private float _angle;
        private Game.Enemy.EnemyController _enemyController;
        private float _time;
        private float _startAngle;
        private float _startTime;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            UnityEngine.Vector3 val_2 = this.transform.localEulerAngles;
            this._startAngle = val_2.y;
            this._startTime = UnityEngine.Time.time;
            float val_4 = this._enemyController.RotationSpeed;
            val_4 = this._angle / val_4;
            this._time = val_4;
            this._enemyController._view.PlayAnimation(animationType:  1);
        }
        public override void Dispose()
        {
            this._enemyController._view.Idle();
        }
        public override void Process()
        {
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 - this._startTime;
            float val_2 = val_1 / this._time;
            float val_4 = UnityEngine.Mathf.Lerp(a:  this._startAngle, b:  this._startAngle + this._angle, t:  val_2);
            0.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(val_2 < 1f)
            {
                    return;
            }
            
            this.NextNode();
        }
        public override string ToString()
        {
            return (string)this.ToString() + " Angle: "(" Angle: ") + this._angle;
        }
        public RotateByNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
