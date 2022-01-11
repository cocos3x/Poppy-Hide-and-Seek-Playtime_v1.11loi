using UnityEngine;

namespace Game
{
    public sealed class RescueUnitsManager : Mediator<Game.LevelView>
    {
        // Fields
        private Game.Core.Timer _timer;
        private Game.GameManager _gameManager;
        private Game.Config.GameConfig _config;
        private float[] _lastRescueTime;
        private int _victimLayerMask;
        
        // Methods
        protected override void Show()
        {
            this._lastRescueTime = new float[0];
            this._victimLayerMask = Utils.LayerUtils.GetVictimLayerMask();
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.RescueUnitsManager::TimerOnPOST_TICK()));
        }
        protected override void Hide()
        {
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.RescueUnitsManager::TimerOnPOST_TICK()));
        }
        private void TimerOnPOST_TICK()
        {
            var val_13;
            Game.GameManager val_14;
            if((UnityEngine.Time.frameCount & 1) == 0)
            {
                    return;
            }
            
            float val_2 = this._config.GetValue(param:  12);
            val_13 = 0;
            do
            {
                var val_13 = 13638;
                if(val_13 >= mem[4611686018427401566])
            {
                    return;
            }
            
                val_13 = val_13 + 0;
                if(((13638 + 0) + 32 + 32) == 2)
            {
                    float val_3 = UnityEngine.Time.time;
                val_3 = val_3 - this._lastRescueTime[val_13];
                if(val_3 >= 0)
            {
                    UnityEngine.Vector3 val_5 = (13638 + 0) + 32.transform.position;
                val_14 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, radius:  (13638 + 0) + 32 + 80.radius, layerMask:  this._victimLayerMask);
                if(val_7.Length != 0)
            {
                    this._lastRescueTime[val_13] = UnityEngine.Time.time;
                this._gameManager.Rescue(unit:  (13638 + 0) + 32);
                this._gameManager.CollectCoin(unit:  val_14[0].GetComponent<Game.UnitView>(), value:  (int)this._config.GetValue(param:  9));
                val_14 = this._gameManager;
                UnityEngine.Vector3 val_12 = (13638 + 0) + 32.transform.position;
                val_14.FireSound(position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            }
            
            }
            
            }
            
                val_13 = val_13 + 1;
            }
            while(this._config != null);
            
            throw new NullReferenceException();
        }
        public RescueUnitsManager()
        {
        
        }
    
    }

}
