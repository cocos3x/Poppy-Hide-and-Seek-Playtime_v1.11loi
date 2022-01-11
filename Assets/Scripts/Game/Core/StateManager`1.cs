using UnityEngine;

namespace Game.Core
{
    public class StateManager<T> : IDisposable
    {
        // Fields
        protected readonly OneListener<T> _onChangeState;
        protected Injection.Injector _injector;
        private readonly System.Collections.Generic.Dictionary<System.Type, T> _statesMap;
        protected T _state;
        
        // Properties
        public virtual T Current { get; set; }
        
        // Methods
        public void add_CHANGE_STATE(System.Action<T> value)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public void remove_CHANGE_STATE(System.Action<T> value)
        {
            if(this != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        public StateManager<T>()
        {
            mem[1152921507312844688] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            mem[1152921507312844704] = __RuntimeMethodHiddenParam + 24 + 192 + 32;
            mem[1152921507312844712] = 0;
        }
        public void Dispose()
        {
            mem[1152921507312956712] = 0;
        }
        public virtual T get_Current()
        {
            return (Game.States.GameState)this;
        }
        protected virtual void set_Current(T value)
        {
            mem[1152921507313189000] = value;
            Game.Log.Info(message:  "Change state " + value);
            goto __RuntimeMethodHiddenParam + 24 + 192 + 56;
        }
        public void SwitchToState(T state)
        {
            this.Inject(value:  state);
            goto typeof(Game.Core.StateManager<T>).__il2cppRuntimeField_190;
        }
        public void SwitchToState(System.Type type)
        {
            if((this & 1) != 0)
            {
                goto label_1;
            }
            
            if((System.Activator.CreateInstance(type:  type)) != null)
            {
                    if(X0 == true)
            {
                goto label_5;
            }
            
            }
            
            label_5:
            label_1:
            __RuntimeMethodHiddenParam + 24 + 192 + 88.Inject(value:  X22);
            goto typeof(Game.Core.StateManager<T>).__il2cppRuntimeField_190;
        }
    
    }

}
