using UnityEngine;

namespace Game
{
    public sealed class CagesManager : Mediator<GameView>
    {
        // Fields
        private Game.GameManager _gameManager;
        private readonly System.Collections.Generic.Dictionary<Game.AnimationUnitView, UnityEngine.Transform> _cagesMap;
        
        // Methods
        public CagesManager()
        {
            this._cagesMap = new System.Collections.Generic.Dictionary<Game.AnimationUnitView, UnityEngine.Transform>();
        }
        protected override void Show()
        {
            System.Delegate val_2 = System.Delegate.Combine(a:  this._gameManager.UNIT_KILLED, b:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.CagesManager::UnitKilled(Game.AnimationUnitView unit)));
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_6;
            }
            
            }
            
            this._gameManager.UNIT_KILLED = val_2;
            System.Delegate val_4 = System.Delegate.Combine(a:  this._gameManager.UNIT_RESCUED, b:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.CagesManager::UnitRescued(Game.AnimationUnitView unit)));
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
        protected override void Hide()
        {
            this._cagesMap.Clear();
            ReleaseAllInstances();
            System.Delegate val_2 = System.Delegate.Remove(source:  this._gameManager.UNIT_KILLED, value:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.CagesManager::UnitKilled(Game.AnimationUnitView unit)));
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
            this._gameManager.UNIT_KILLED = val_2;
            System.Delegate val_4 = System.Delegate.Remove(source:  this._gameManager.UNIT_RESCUED, value:  new System.Action<Game.UnitView>(object:  this, method:  System.Void Game.CagesManager::UnitRescued(Game.AnimationUnitView unit)));
            if(val_4 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
            this._gameManager.UNIT_RESCUED = val_4;
            return;
            label_9:
        }
        private void UnitKilled(Game.AnimationUnitView unit)
        {
            UnityEngine.Transform val_1 = 83886080.Get<UnityEngine.Transform>();
            val_1.SetParent(p:  unit.transform);
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.zero;
            val_1.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            val_1.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            this._cagesMap.set_Item(key:  unit, value:  val_1);
        }
        private void UnitRescued(Game.AnimationUnitView unit)
        {
            83886080.Release<UnityEngine.Transform>(component:  this._cagesMap.Item[unit]);
            bool val_2 = this._cagesMap.Remove(key:  unit);
        }
    
    }

}
