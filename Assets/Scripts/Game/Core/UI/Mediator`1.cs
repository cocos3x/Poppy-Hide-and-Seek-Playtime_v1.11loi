using UnityEngine;

namespace Game.Core.UI
{
    public abstract class Mediator<T> : Mediator
    {
        // Fields
        protected T _view;
        
        // Methods
        public void Mediate(T view)
        {
            mem[1152921507315615344] = view;
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public override void Unmediate()
        {
            mem[1152921507315731440] = 0;
        }
        protected abstract void Show(); // 0
        protected abstract void Hide(); // 0
        protected Mediator<T>()
        {
            if(this != null)
            {
                    return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
