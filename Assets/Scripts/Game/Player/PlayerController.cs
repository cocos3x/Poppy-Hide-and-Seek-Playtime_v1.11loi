using UnityEngine;

namespace Game.Player
{
    public sealed class PlayerController : IDisposable
    {
        // Fields
        private Game.Config.GameConfig _config;
        private readonly Game.UnitView _view;
        private readonly Game.Core.StateManager<Game.Player.States.PlayerState> _playerStateManager;
        
        // Properties
        public Game.UnitView View { get; }
        public UnityEngine.Vector2 Position { get; }
        public bool IsDied { get; }
        
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
        public bool get_IsDied()
        {
            if(this._view != null)
            {
                    return (bool)(this._view == 2) ? 1 : 0;
            }
            
            throw new NullReferenceException();
        }
        public PlayerController(Injection.Context context, Game.UnitView player)
        {
            Injection.Context val_1 = new Injection.Context(parent:  context);
            Injection.Injector val_2 = new Injection.Injector(context:  val_1);
            object[] val_3 = new object[1];
            val_3[0] = this;
            val_1.Install(objects:  val_3);
            object[] val_4 = new object[1];
            val_4[0] = val_2;
            val_1.Install(objects:  val_4);
            this._view = player;
            Game.Core.StateManager<Game.Player.States.PlayerState> val_5 = new Game.Core.StateManager<Game.Player.States.PlayerState>();
            this._playerStateManager = val_5;
            val_2.Inject(value:  val_5);
            this._view.name = "Player";
            GameView val_6 = context.Get<GameView>();
            this._view.SetOutline(materials:  val_6.OutlineMaterials);
        }
        public void Dispose()
        {
            this._playerStateManager.Dispose();
        }
        public void Live(bool isVictim)
        {
            isVictim = isVictim;
            this._view.IsVictim = isVictim;
            this._view._enemyBehaviour.enabled = false;
            this._view.IsVissible = true;
            this._view.Idle();
            this._playerStateManager.SwitchToState(state:  new Game.Player.States.PlayerLiveState());
        }
        public void Kill()
        {
            this._playerStateManager.Dispose();
            goto typeof(Game.UnitView).__il2cppRuntimeField_180;
        }
        public UnityEngine.Collider RaycastVictim()
        {
            if(this._view != null)
            {
                    return this._view.GetSeenVictim();
            }
            
            throw new NullReferenceException();
        }
    
    }

}
