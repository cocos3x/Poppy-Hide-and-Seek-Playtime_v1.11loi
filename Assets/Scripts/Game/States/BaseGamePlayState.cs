using UnityEngine;

namespace Game.States
{
    public abstract class BaseGamePlayState : GameState
    {
        // Fields
        protected Game.GameManager _gameManager;
        protected Game.LevelView _levelView;
        protected GameView _gameView;
        protected Game.Core.Timer _timer;
        protected Game.States.GameStateManager _gameStateManager;
        protected Game.GameModel _gameModel;
        protected Injection.Injector _injector;
        protected Game.Config.GameConfig _config;
        private readonly System.Collections.Generic.List<Game.Core.UI.Mediator> _mediators;
        protected float _startTime;
        
        // Methods
        protected BaseGamePlayState()
        {
            this = new System.Object();
            this._mediators = new System.Collections.Generic.List<Game.Core.UI.Mediator>();
        }
        public override void Initialize()
        {
            this._gameView.GameHud.gameObject.SetActive(value:  true);
            float val_3 = this._config.GetValue(param:  4);
            val_3 = UnityEngine.Time.time + val_3;
            this._startTime = val_3;
            this.AddMediator<GameView>(mediator:  new Game.CagesManager(), hud:  this._gameView);
            this.AddMediator<Game.LevelView>(mediator:  new Game.RescueUnitsManager(), hud:  this._levelView);
            this.AddMediator<Game.LevelView>(mediator:  new Game.CoinsManager(), hud:  this._levelView);
        }
        public override void Dispose()
        {
            this._gameView.GameHud.gameObject.SetActive(value:  false);
            List.Enumerator<T> val_2 = this._mediators.GetEnumerator();
            label_7:
            if(((-1605828632) & 1) == 0)
            {
                goto label_5;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            goto label_7;
            label_5:
            0.Add(driver:  public System.Void List.Enumerator<Game.Core.UI.Mediator>::Dispose(), rectTransform:  0, drivenProperties:  null);
            this._mediators.Clear();
        }
        protected void AddMediator<T>(Game.Core.UI.Mediator<T> mediator, T hud)
        {
            this._injector.Inject(value:  mediator);
            this._mediators.Add(item:  mediator);
        }
    
    }

}
