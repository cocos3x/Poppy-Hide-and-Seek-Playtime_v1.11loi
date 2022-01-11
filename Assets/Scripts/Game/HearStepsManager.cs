using UnityEngine;

namespace Game
{
    public sealed class HearStepsManager : Mediator<Game.LevelView>
    {
        // Fields
        private Game.Core.Timer _timer;
        private GameView _gameView;
        private Game.GameManager _gameManager;
        private Game.LevelView _levelView;
        private readonly bool _isShowEffects;
        private readonly System.Collections.Generic.List<UnityEngine.ParticleSystem> _effects;
        private Game.AnimationType[] _animations;
        
        // Methods
        public HearStepsManager(bool isShowEffects)
        {
            this._isShowEffects = isShowEffects;
            this._effects = new System.Collections.Generic.List<UnityEngine.ParticleSystem>();
        }
        protected override void Show()
        {
            this._animations = new Game.AnimationType[0];
            if(this._levelView.Doors.Length >= 1)
            {
                    var val_6 = 0;
                do
            {
                Game.DoorView val_5 = this._levelView.Doors[val_6];
                System.Delegate val_3 = System.Delegate.Combine(a:  this._levelView.Doors[0x0][0].COLLISION, b:  new System.Action<UnityEngine.Collider>(object:  this, method:  System.Void Game.HearStepsManager::OnCollisionDetected(UnityEngine.Collider collider)));
                if(val_3 != null)
            {
                    if(null != null)
            {
                goto label_9;
            }
            
            }
            
                this._levelView.Doors[0x0][0].COLLISION = val_3;
                val_6 = val_6 + 1;
            }
            while(val_6 < this._levelView.Doors.Length);
            
            }
            
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.HearStepsManager::TimerOnPostTick()));
            return;
            label_9:
        }
        protected override void Hide()
        {
            if(this._levelView.Doors.Length >= 1)
            {
                    var val_5 = 0;
                do
            {
                Game.DoorView val_4 = this._levelView.Doors[val_5];
                System.Delegate val_2 = System.Delegate.Remove(source:  this._levelView.Doors[0x0][0].COLLISION, value:  new System.Action<UnityEngine.Collider>(object:  this, method:  System.Void Game.HearStepsManager::OnCollisionDetected(UnityEngine.Collider collider)));
                if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_7;
            }
            
            }
            
                this._levelView.Doors[0x0][0].COLLISION = val_2;
                val_5 = val_5 + 1;
            }
            while(val_5 < this._levelView.Doors.Length);
            
            }
            
            this._gameView.StepsEffectPool.ReleaseAllInstances();
            this._effects.Clear();
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.HearStepsManager::TimerOnPostTick()));
            return;
            label_7:
        }
        private void TimerOnPostTick()
        {
            var val_7;
            System.Collections.Generic.List<UnityEngine.ParticleSystem> val_8;
            if(this._gameManager._player == null)
            {
                    return;
            }
            
            val_7 = 1152921504696250368;
            var val_7 = 0;
            label_23:
            if(val_7 >= W9)
            {
                goto label_5;
            }
            
            if(this._animations[0] != 1)
            {
                    if(this._isShowEffects != false)
            {
                    if(this._gameManager._player._view != Game.UnitView.__il2cppRuntimeField_byval_arg)
            {
                    this.CreateEffect(unit:  Game.UnitView.__il2cppRuntimeField_byval_arg);
            }
            
            }
            
                UnityEngine.Vector3 val_3 = Game.UnitView.__il2cppRuntimeField_byval_arg.transform.position;
                this._gameManager.FireSound(position:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
            }
            
            val_7 = val_7 + 1;
            this._animations[0] = Game.UnitView.__il2cppRuntimeField_byval_arg + 32;
            if(this._animations[0] != null)
            {
                goto label_23;
            }
            
            label_5:
            val_8 = this._effects;
            Game.UnitView val_4 = this._gameManager._player._view - 1;
            if(val_7 < 0)
            {
                    return;
            }
            
            val_7 = this._gameManager._player._view + 32;
            do
            {
                if(this._gameManager._player._view <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                if(1152921504776175616.IsAlive() != true)
            {
                    val_8 = this._gameView.StepsEffectPool;
                if(W9 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
                val_8.Release<UnityEngine.ParticleSystem>(component:  null);
                this._effects.RemoveAt(index:  val_4);
            }
            
                val_4 = val_4 - 1;
                if(W9 < 0)
            {
                    return;
            }
            
                val_8 = this._effects;
                val_7 = val_7 - 8;
            }
            while(val_8 != null);
            
            throw new NullReferenceException();
        }
        private void CreateEffect(Game.UnitView unit)
        {
            UnityEngine.ParticleSystem val_1 = this._gameView.StepsEffectPool.Get<UnityEngine.ParticleSystem>();
            UnityEngine.Vector3 val_4 = unit.transform.position;
            val_1.transform.position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            float val_6 = unit.Rotation;
            val_1.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            this._effects.Add(item:  val_1);
        }
        private void OnCollisionDetected(UnityEngine.Collider collider)
        {
            if(collider.gameObject.layer != (Utils.LayerUtils.GetVictimLayer(isVictim:  true)))
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = collider.transform.position;
            this._gameManager.FireSound(position:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        }
    
    }

}
