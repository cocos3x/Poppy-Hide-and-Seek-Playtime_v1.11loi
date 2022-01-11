using UnityEngine;

namespace Game.Enemy
{
    public sealed class EnemyController : IDisposable
    {
        // Fields
        private Game.Config.GameConfig _config;
        private readonly Game.UnitView _view;
        private readonly Game.Core.StateManager<Game.Enemy.States.EnemyState> _enemyStateManager;
        private UnityEngine.Vector2 <LastHearVictim>k__BackingField;
        
        // Properties
        public Game.UnitView View { get; }
        public UnityEngine.Vector2 Position { get; set; }
        public float Speed { get; }
        public float RotationSpeed { get; }
        public UnityEngine.Vector2 LastHearVictim { get; set; }
        
        // Methods
        public Game.UnitView get_View()
        {
            return (Game.UnitView)this._view;
        }
        public UnityEngine.Vector2 get_Position()
        {
            if(this._view != null)
            {
                    return this._view.Position;
            }
            
            throw new NullReferenceException();
        }
        public void set_Position(UnityEngine.Vector2 value)
        {
            if(this._view != null)
            {
                    this._view.Position = new UnityEngine.Vector2() {x = value.x, y = value.y};
                return;
            }
            
            throw new NullReferenceException();
        }
        public float get_Speed()
        {
            if(this._config != null)
            {
                    return this._config.GetValue(param:  3);
            }
            
            throw new NullReferenceException();
        }
        public float get_RotationSpeed()
        {
            if(this._config != null)
            {
                    return this._config.GetValue(param:  2);
            }
            
            throw new NullReferenceException();
        }
        public UnityEngine.Vector2 get_LastHearVictim()
        {
            return new UnityEngine.Vector2() {x = this.<LastHearVictim>k__BackingField};
        }
        public void set_LastHearVictim(UnityEngine.Vector2 value)
        {
            this.<LastHearVictim>k__BackingField = value;
            mem[1152921507303680492] = value.y;
        }
        public EnemyController(Game.UnitView view, Injection.Context context)
        {
            val_1 = new System.Object();
            this._view = view;
            view.SetOutline(materials:  0);
            Injection.Context val_2 = new Injection.Context(parent:  Injection.Context val_1 = context);
            Injection.Injector val_3 = new Injection.Injector(context:  val_2);
            object[] val_4 = new object[1];
            val_4[0] = this;
            val_2.Install(objects:  val_4);
            object[] val_5 = new object[1];
            val_5[0] = val_3;
            val_2.Install(objects:  val_5);
            Game.Core.StateManager<Game.Enemy.States.EnemyState> val_6 = new Game.Core.StateManager<Game.Enemy.States.EnemyState>();
            this._enemyStateManager = val_6;
            val_3.Inject(value:  val_6);
        }
        public void Dispose()
        {
            this._enemyStateManager.Dispose();
        }
        public void Kill()
        {
            this._enemyStateManager.Dispose();
            goto typeof(Game.UnitView).__il2cppRuntimeField_180;
        }
        public void Live(bool isVictim)
        {
            string val_5;
            this._view.MeshAgent.speed = this.Speed;
            this._view.MeshAgent.angularSpeed = this.RotationSpeed;
            this._view.MeshAgent.acceleration = 10000f;
            this._view.IsVictim = isVictim;
            this._view._enemyBehaviour.enabled = true;
            this._view.IsVissible = true;
            this._view.Idle();
            this._enemyStateManager.SwitchToState(state:  new Game.Enemy.States.EnemyLiveState());
            if(isVictim != false)
            {
                    val_5 = "Enemy_Victim";
            }
            else
            {
                    val_5 = "Enemy";
            }
            
            this._view.name = val_5;
        }
        public UnityEngine.Collider GetSeenVictim()
        {
            if(this._view != null)
            {
                    return this._view.GetSeenVictim();
            }
            
            throw new NullReferenceException();
        }
    
    }

}
