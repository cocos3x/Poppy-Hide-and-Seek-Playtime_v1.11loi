using UnityEngine;

namespace Game
{
    public sealed class CoinsManager : Mediator<Game.LevelView>
    {
        // Fields
        private Game.Core.Timer _timer;
        private Game.Config.GameConfig _config;
        private Game.GameManager _gameManager;
        private GameView _gameView;
        private readonly System.Collections.Generic.List<UnityEngine.ParticleSystem> _effects;
        
        // Methods
        public CoinsManager()
        {
            this._effects = new System.Collections.Generic.List<UnityEngine.ParticleSystem>();
        }
        protected override void Show()
        {
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.CoinsManager::TimerOnPOST_TICK()));
        }
        protected override void Hide()
        {
            this._effects.Clear();
            this._gameView.SparksEffectPool.ReleaseAllInstances();
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.CoinsManager::TimerOnPOST_TICK()));
        }
        private void TimerOnPOST_TICK()
        {
            UnityEngine.ParticleSystem val_17;
            System.Collections.Generic.List<UnityEngine.ParticleSystem> val_18;
            System.Collections.Generic.List<UnityEngine.ParticleSystem> val_19;
            if((mem[-3458764513820540904]) >= 1)
            {
                    var val_18 = 0;
                do
            {
                var val_2 = 0 + 0;
                if(((0 + 0) + 32.enabled) != false)
            {
                    UnityEngine.Vector3 val_5 = (0 + 0) + 32.transform.position;
                if(val_6.Length >= 1)
            {
                    do
            {
                Game.UnitView val_7 = UnityEngine.Physics.OverlapSphere(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, radius:  this._config.GetValue(param:  5))[0].GetComponent<Game.UnitView>();
                if(0 != val_7)
            {
                    (0 + 0) + 32.Collect();
                UnityEngine.ParticleSystem val_9 = this._gameView.SparksEffectPool.Get<UnityEngine.ParticleSystem>();
                val_17 = val_9;
                UnityEngine.Vector3 val_12 = (0 + 0) + 32.transform.position;
                val_9.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
                val_17.Stop(withChildren:  true);
                val_17.Play(withChildren:  true);
                this._effects.Add(item:  val_17);
                this._gameManager.CollectCoin(unit:  val_7, value:  (0 + 0) + 32 + 32);
                if(val_7._isVictim != false)
            {
                    UnityEngine.Vector3 val_14 = (0 + 0) + 32.transform.position;
                this._gameManager.FireSound(position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            }
            
            }
            
                val_18 = 0 + 1;
            }
            while(val_18 < val_6.Length);
            
            }
            
            }
            
                val_18 = val_18 + 1;
            }
            while(val_18 < (mem[-3458764513820540904]));
            
            }
            
            val_19 = this._effects;
            int val_15 = (mem[-3458764513820540904]) - 1;
            if(val_18 < 0)
            {
                    return;
            }
            
            val_17 = (mem[-3458764513820540904]) + 32;
            do
            {
                if((mem[-3458764513820540904]) <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if((mem[-3458764513820540904] + (mem[-3458764513820540904] + 32).IsAlive()) != true)
            {
                    val_18 = this._effects;
                val_19 = this._gameView.SparksEffectPool;
                if(0 <= val_15)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_19.Release<UnityEngine.ParticleSystem>(component:  null);
                this._effects.RemoveAt(index:  val_15);
            }
            
                val_15 = val_15 - 1;
                if(0 < 0)
            {
                    return;
            }
            
                val_19 = this._effects;
                val_17 = val_17 - 8;
            }
            while(val_19 != null);
            
            throw new NullReferenceException();
        }
    
    }

}
