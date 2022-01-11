using UnityEngine;

namespace Game.Player.States
{
    public sealed class PlayerLiveState : PlayerState
    {
        // Fields
        private Game.Core.Timer _timer;
        private GameView _view;
        private Game.Player.PlayerController _playerController;
        private Game.Config.GameConfig _config;
        private Game.GameManager _gameManager;
        private TPSShooter.Joystick _joystick;
        private UnityEngine.Transform _transform;
        
        // Methods
        public PlayerLiveState()
        {
            val_1 = new System.Object();
        }
        public override void Initialize()
        {
            this._joystick = this._view.GameHud.Joystick;
            this._transform = this._playerController._view.transform;
            this._timer.add_TICK(value:  new System.Action(object:  this, method:  System.Void Game.Player.States.PlayerLiveState::TimerOnTICK()));
        }
        public override void Dispose()
        {
            this._timer.remove_TICK(value:  new System.Action(object:  this, method:  System.Void Game.Player.States.PlayerLiveState::TimerOnTICK()));
        }
        private void TimerOnTICK()
        {
            UnityEngine.Object val_27;
            UnityEngine.Collider val_1 = this._playerController._view.GetSeenVictim();
            val_27 = val_1;
            if(0 != val_27)
            {
                    val_27 = val_1.GetComponent<Game.UnitView>();
                this._gameManager.Kill(unitView:  val_27);
            }
            
            if(this._joystick.IsTouched != false)
            {
                    this._playerController._view.PlayAnimation(animationType:  1);
                UnityEngine.Vector3 val_4 = this._transform.forward;
                UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, d:  this._joystick.Vertical);
                UnityEngine.Vector3 val_6 = this._transform.right;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this._joystick.Horizontal);
                UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
                float val_27 = this._joystick.Horizontal;
                val_27 = val_27 * 57.29578f;
                UnityEngine.Vector3 val_9 = this._transform.localEulerAngles;
                float val_28 = System.Math.Abs(UnityEngine.Mathf.DeltaAngle(current:  val_9.y, target:  val_27));
                val_28 = val_28 / 90f;
                UnityEngine.Vector3 val_13 = this._transform.localEulerAngles;
                float val_14 = UnityEngine.Time.deltaTime;
                float val_17 = UnityEngine.Mathf.LerpAngle(a:  val_13.y, b:  val_27, t:  ((this._config.GetValue(param:  1)) * val_14) * val_14);
                this._transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
                UnityEngine.Vector3 val_18 = this._transform.forward;
                val_27 = 1f - (UnityEngine.Mathf.Clamp01(value:  val_28));
                float val_19 = this._config.GetValue(param:  0);
                val_19 = (val_27 * val_19) * val_19;
                UnityEngine.Vector3 val_22 = this._transform.position;
                UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, d:  UnityEngine.Time.deltaTime);
                UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, d:  UnityEngine.Mathf.Min(a:  val_19, b:  4f));
                UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
                this._transform.position = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
                return;
            }
            
            this._playerController._view.Idle();
        }
    
    }

}
