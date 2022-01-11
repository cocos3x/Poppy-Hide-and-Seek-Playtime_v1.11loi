using UnityEngine;

namespace Game.UI
{
    public sealed class GameHudMediator : Mediator<GameHud>
    {
        // Fields
        private Game.Config.GameConfig _config;
        private Game.Core.Timer _timer;
        private Game.LevelView _levelView;
        private Game.GameModel _gameModel;
        private Game.GameManager _gameManager;
        private readonly bool _isHided;
        private float _startTime;
        
        // Methods
        public GameHudMediator(bool isHided)
        {
            this._isHided = isHided;
        }
        protected override void Show()
        {
            var val_1 = (this._isHided == false) ? "Starting in" : "Time to Hide";
            float val_2 = this._config.GetValue(param:  4);
            this._config.TimeToHide = val_2;
            DG.Tweening.Core.DOSetter<System.Single> val_4 = new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void Game.UI.GameHudMediator::<Show>b__8_1(float x));
            DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single Game.UI.GameHudMediator::<Show>b__8_0()), setter:  val_4, endValue:  0f, duration:  val_2), target:  val_4), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void Game.UI.GameHudMediator::OnHideTimeCompleted())), ease:  1).SetTimeLeft(startTime:  0f, duration:  0f, isGreenTimeRemain:  this._isHided).Coins = 0;
            System.Delegate val_12 = System.Delegate.Combine(a:  this._gameManager.COINS_COLLECTED, b:  new System.Action<Game.UnitView, System.Int32>(object:  this, method:  System.Void Game.UI.GameHudMediator::OnCoinsCollected(Game.UnitView unit, int value)));
            if(val_12 != null)
            {
                    if(null != null)
            {
                goto label_11;
            }
            
            }
            
            this._gameManager.COINS_COLLECTED = val_12;
            return;
            label_11:
        }
        protected override void Hide()
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  15704064, complete:  false);
            System.Delegate val_3 = System.Delegate.Remove(source:  this._gameManager.COINS_COLLECTED, value:  new System.Action<Game.UnitView, System.Int32>(object:  this, method:  System.Void Game.UI.GameHudMediator::OnCoinsCollected(Game.UnitView unit, int value)));
            if(val_3 != null)
            {
                    if(null != null)
            {
                goto label_5;
            }
            
            }
            
            this._gameManager.COINS_COLLECTED = val_3;
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.UI.GameHudMediator::TimerOnPOST_TICK()));
            return;
            label_5:
        }
        private void OnHideTimeCompleted()
        {
            this._startTime = UnityEngine.Time.time;
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.UI.GameHudMediator::TimerOnPOST_TICK()));
            bool val_3 = this._timer.SetTimeLeft(startTime:  this._startTime, duration:  this._levelView.Duration, isGreenTimeRemain:  this._isHided);
        }
        private void TimerOnPOST_TICK()
        {
            if((5154.SetTimeLeft(startTime:  this._startTime, duration:  this._levelView.Duration, isGreenTimeRemain:  this._isHided)) == false)
            {
                    return;
            }
            
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.UI.GameHudMediator::TimerOnPOST_TICK()));
            this._gameModel.IsTimeOut = true;
        }
        private void OnCoinsCollected(Game.UnitView unit, int value)
        {
            if(this._gameManager._player == null)
            {
                    return;
            }
            
            bool val_1 = UnityEngine.Object.op_Equality(x:  this._gameManager._player._view, y:  unit);
            if(val_1 == false)
            {
                    return;
            }
            
            val_1.Coins = (val_1 + 92) + value;
        }
        private float <Show>b__8_0()
        {
            if(X8 != 0)
            {
                    return (float)X8 + 96;
            }
            
            throw new NullReferenceException();
        }
        private void <Show>b__8_1(float x)
        {
            if(this != null)
            {
                    this.TimeToHide = x;
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
