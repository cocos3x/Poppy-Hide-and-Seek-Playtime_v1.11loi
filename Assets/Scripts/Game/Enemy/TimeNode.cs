using UnityEngine;

namespace Game.Enemy
{
    public class TimeNode : Node
    {
        // Fields
        private float _time;
        private float _endTime;
        
        // Methods
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.OnStateEnter(animator:  animator, stateInfo:  new UnityEngine.AnimatorStateInfo() {m_Name = stateInfo.m_Name, m_Path = stateInfo.m_Path, m_FullPath = stateInfo.m_FullPath, m_NormalizedTime = stateInfo.m_NormalizedTime, m_Length = stateInfo.m_Length, m_Speed = stateInfo.m_Speed, m_SpeedMultiplier = stateInfo.m_SpeedMultiplier, m_Tag = stateInfo.m_Tag, m_Loop = stateInfo.m_Loop}, layerIndex:  layerIndex);
            float val_1 = UnityEngine.Time.time;
            val_1 = val_1 + this._time;
            this._endTime = val_1;
        }
        public override void Dispose()
        {
        
        }
        public override void Process()
        {
            if(UnityEngine.Time.time <= this._endTime)
            {
                    return;
            }
            
            this.NextNode();
        }
        protected virtual void Completed()
        {
        
        }
        public override string ToString()
        {
            return (string)this.ToString() + " Time: "(" Time: ") + this._time;
        }
        public TimeNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
