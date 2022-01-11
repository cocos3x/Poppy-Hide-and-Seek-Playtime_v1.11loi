using UnityEngine;

namespace Game.Enemy
{
    public abstract class Node : StateMachineBehaviour, IDisposable
    {
        // Fields
        private UnityEngine.Animator <Animator>k__BackingField;
        
        // Properties
        protected UnityEngine.Animator Animator { get; set; }
        public bool IsCompleted { get; }
        
        // Methods
        protected UnityEngine.Animator get_Animator()
        {
            return (UnityEngine.Animator)this.<Animator>k__BackingField;
        }
        private void set_Animator(UnityEngine.Animator value)
        {
            this.<Animator>k__BackingField = value;
        }
        public bool get_IsCompleted()
        {
            return (bool)((this.<Animator>k__BackingField.speed) > 0f) ? 1 : 0;
        }
        public override void OnStateEnter(UnityEngine.Animator animator, UnityEngine.AnimatorStateInfo stateInfo, int layerIndex)
        {
            this.<Animator>k__BackingField = animator;
            animator.speed = 0f;
            this.<Animator>k__BackingField.GetComponent<Game.UnitView>().FireNodeEnter(node:  this);
        }
        public abstract void Dispose(); // 0
        protected void NextNode()
        {
            if((this.<Animator>k__BackingField) != null)
            {
                    this.<Animator>k__BackingField.speed = 10000f;
                return;
            }
            
            throw new NullReferenceException();
        }
        public abstract void Process(); // 0
        public override string ToString()
        {
            return System.String.Format(format:  "({0})", arg0:  this.GetType());
        }
        protected Node()
        {
        
        }
    
    }

}
