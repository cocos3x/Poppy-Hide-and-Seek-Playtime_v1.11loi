using UnityEngine;

namespace Game
{
    public sealed class GameStartBehaviour : MonoBehaviour
    {
        // Fields
        private Game.Core.Timer _timer;
        private Injection.Context <Context>k__BackingField;
        
        // Properties
        public Injection.Context Context { get; set; }
        
        // Methods
        public Injection.Context get_Context()
        {
            return (Injection.Context)this.<Context>k__BackingField;
        }
        private void set_Context(Injection.Context value)
        {
            this.<Context>k__BackingField = value;
        }
        private void Start()
        {
            this._timer = new Game.Core.Timer();
            UnityEngine.Application.targetFrameRate = 60;
            UnityEngine.QualitySettings.vSyncCount = 0;
            UnityEngine.Application.runInBackground = true;
            Injection.Context val_2 = new Injection.Context();
            object[] val_3 = new object[3];
            val_3[0] = new Game.GameManager();
            val_3[1] = new Game.States.GameStateManager();
            val_3[2] = new Injection.Injector(context:  val_2);
            val_2.Install(objects:  val_3);
            val_2.Install(objects:  this.GetComponents<UnityEngine.Component>());
            object[] val_8 = new object[1];
            val_8[0] = this._timer;
            val_2.Install(objects:  val_8);
            val_2.ApplyInstall();
            val_2.Get<Game.States.GameStateManager>().SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
            this.<Context>k__BackingField = val_2;
        }
        private void Update()
        {
            if(this._timer != null)
            {
                    this._timer.Update();
                return;
            }
            
            throw new NullReferenceException();
        }
        private void LateUpdate()
        {
            this._timer._postTickListener.Invoke();
        }
        public GameStartBehaviour()
        {
        
        }
    
    }

}
