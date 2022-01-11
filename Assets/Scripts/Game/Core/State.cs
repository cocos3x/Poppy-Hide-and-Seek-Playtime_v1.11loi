using UnityEngine;

namespace Game.Core
{
    public abstract class State : IDisposable
    {
        // Methods
        public abstract void Initialize(); // 0
        public abstract void Dispose(); // 0
        protected State()
        {
        
        }
    
    }

}
