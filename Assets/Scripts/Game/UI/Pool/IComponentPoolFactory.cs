using UnityEngine;

namespace Game.UI.Pool
{
    public interface IComponentPoolFactory
    {
        // Properties
        public abstract UnityEngine.Transform Content { get; }
        public abstract int CountInstances { get; }
        
        // Methods
        public abstract UnityEngine.Transform get_Content(); // 0
        public abstract int get_CountInstances(); // 0
        public abstract T Get<T>(); // 0
        public abstract T Get<T>(int sublingIndex); // 0
        public abstract void Release<T>(T component); // 0
        public abstract void ReleaseAllInstances(); // 0
        public abstract void Dispose(); // 0
    
    }

}
