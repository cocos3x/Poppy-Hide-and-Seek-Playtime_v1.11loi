using UnityEngine;

namespace Game.States
{
    public sealed class GameInitializeState : GameState
    {
        // Fields
        private Game.States.GameStateManager _gameStateManager;
        private Injection.Context _context;
        
        // Methods
        public static Game.Config.GameConfig LoadConfig()
        {
            return 0;
        }
        public override void Initialize()
        {
            object[] val_1 = new object[1];
            val_1[0] = 0;
            this._context.Install(objects:  val_1);
            this._gameStateManager.SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override void Dispose()
        {
        
        }
        public GameInitializeState()
        {
            val_1 = new System.Object();
        }
    
    }

}
