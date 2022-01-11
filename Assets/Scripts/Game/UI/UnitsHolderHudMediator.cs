using UnityEngine;

namespace Game.UI
{
    public sealed class UnitsHolderHudMediator : Mediator<Game.UI.UnitsHolderHud>
    {
        // Fields
        private Game.GameManager _gameManager;
        private Game.LevelView _levelView;
        private readonly bool _isHided;
        
        // Methods
        public UnitsHolderHudMediator(bool isHided)
        {
            this._isHided = isHided;
        }
        protected override void Show()
        {
            11797.SwitchToMode(isGreen:  (this._isHided == false) ? 1 : 0, maxCount:  this._levelView.Units.Length - 1);
            System.Delegate val_4 = System.Delegate.Combine(a:  this._gameManager.UNIT_KILLED, b:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.UI.UnitsHolderHudMediator::OnUnitKilled(Game.UnitView obj)));
            if(val_4 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
            this._gameManager.UNIT_KILLED = val_4;
            System.Delegate val_6 = System.Delegate.Combine(a:  this._gameManager.UNIT_RESCUED, b:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.UI.UnitsHolderHudMediator::OnUnitRescued(Game.UnitView obj)));
            if(val_6 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
            this._gameManager.UNIT_RESCUED = val_6;
            return;
            label_9:
        }
        protected override void Hide()
        {
            System.Delegate val_2 = System.Delegate.Remove(source:  this._gameManager.UNIT_KILLED, value:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.UI.UnitsHolderHudMediator::OnUnitKilled(Game.UnitView obj)));
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_6;
            }
            
            }
            
            this._gameManager.UNIT_KILLED = val_2;
            System.Delegate val_4 = System.Delegate.Remove(source:  this._gameManager.UNIT_RESCUED, value:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.UI.UnitsHolderHudMediator::OnUnitRescued(Game.UnitView obj)));
            if(val_4 != null)
            {
                    if(null != null)
            {
                goto label_6;
            }
            
            }
            
            this._gameManager.UNIT_RESCUED = val_4;
            return;
            label_6:
        }
        private void OnUnitKilled(Game.UnitView obj)
        {
            if(this != null)
            {
                    this.Count = W8 + 1;
                return;
            }
            
            throw new NullReferenceException();
        }
        private void OnUnitRescued(Game.UnitView obj)
        {
            if(this != null)
            {
                    this.Count = W8 - 1;
                return;
            }
            
            throw new NullReferenceException();
        }
    
    }

}
