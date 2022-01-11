using UnityEngine;

namespace Game.UI
{
    public sealed class RadarHudMediator : Mediator<GameHud>
    {
        // Fields
        private Game.Core.Timer _timer;
        private Game.LevelView _levelView;
        private float _minX;
        private float _maxX;
        private float _minY;
        private float _maxY;
        private UnityEngine.Camera _camera;
        
        // Methods
        protected override void Show()
        {
            this._camera = UnityEngine.Camera.main;
            UnityEngine.Vector2 val_2 = 0.sizeDelta;
            val_2.x = val_2.x * 0.5f;
            this._minX = val_2.x;
            UnityEngine.Vector2 val_4 = 0.sizeDelta;
            val_4.x = val_4.x * (-0.5f);
            val_4.x = (float)UnityEngine.Screen.width + val_4.x;
            this._maxX = val_4.x;
            UnityEngine.Vector2 val_5 = 0.sizeDelta;
            this._minY = val_5.y * 0.5f;
            UnityEngine.Vector2 val_8 = 0.sizeDelta;
            float val_10 = (float)UnityEngine.Screen.height;
            val_8.y = val_8.y * (-0.5f);
            val_10 = val_10 + val_8.y;
            this._maxY = val_10;
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.UI.RadarHudMediator::TimerOnPOST_TICK()));
        }
        protected override void Hide()
        {
            0.gameObject.SetActive(value:  false);
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.UI.RadarHudMediator::TimerOnPOST_TICK()));
        }
        private void TimerOnPOST_TICK()
        {
            var val_33;
            float val_34;
            float val_35;
            bool val_36;
            float val_37;
            var val_38;
            val_33 = this;
            UnityEngine.Vector3 val_2 = this._levelView.Units[0].transform.position;
            UnityEngine.Vector3 val_3 = this._camera.WorldToScreenPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            val_34 = val_3.z;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_34});
            val_35 = val_4.x;
            val_36 = 1;
            if((val_35 >= this._minX) && (val_35 <= this._maxX))
            {
                    val_36 = ((val_4.y < this._minY) ? 1 : 0) | ((val_4.y > this._maxY) ? 1 : 0);
            }
            
            val_4.y < this._minY ? 1 : 0 + 80.gameObject.SetActive(value:  val_36);
            if(val_36 == 0)
            {
                    return;
            }
            
            float val_32 = (float)UnityEngine.Screen.width;
            float val_33 = 0.5f;
            val_32 = val_32 * val_33;
            val_33 = (float)UnityEngine.Screen.height * val_33;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  val_32, y:  val_33);
            val_37 = val_10.x;
            val_38 = UnityEngine.Screen.width;
            if((LineIntersection.FindIntersection(x1:  val_37, y1:  val_10.y, x2:  val_35, y2:  val_4.y, x3:  (float)UnityEngine.Screen.width, y3:  0f, x4:  (float)val_38, y4:  (float)UnityEngine.Screen.height, checkOnInside:  true, point: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, tolerance:  0.01f)) != true)
            {
                    val_37 = val_10.x;
                if((LineIntersection.FindIntersection(x1:  val_37, y1:  val_10.y, x2:  val_35, y2:  val_4.y, x3:  0f, y3:  0f, x4:  0f, y4:  (float)UnityEngine.Screen.height, checkOnInside:  true, point: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, tolerance:  0.01f)) != true)
            {
                    val_37 = val_10.x;
                if((LineIntersection.FindIntersection(x1:  val_37, y1:  val_10.y, x2:  val_35, y2:  val_4.y, x3:  0f, y3:  0f, x4:  (float)UnityEngine.Screen.width, y4:  0f, checkOnInside:  true, point: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, tolerance:  0.01f)) != true)
            {
                    val_37 = val_10.x;
                val_38 = UnityEngine.Screen.width;
                bool val_22 = LineIntersection.FindIntersection(x1:  val_37, y1:  val_10.y, x2:  val_35, y2:  val_4.y, x3:  0f, y3:  (float)UnityEngine.Screen.height, x4:  (float)val_38, y4:  (float)UnityEngine.Screen.height, checkOnInside:  true, point: out  new UnityEngine.Vector2() {x = 0f, y = 0f}, tolerance:  0.01f);
            }
            
            }
            
            }
            
            val_34 = UnityEngine.Mathf.Clamp(value:  val_35, min:  this._minX, max:  this._maxX);
            float val_24 = UnityEngine.Mathf.Clamp(value:  val_4.y, min:  this._minY, max:  this._maxY);
            UnityEngine.Vector3 val_25 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_34, y = val_24});
            UnityEngine.Mathf.__il2cppRuntimeField_cctor_finished + 80.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            UnityEngine.Vector2 val_26 = new UnityEngine.Vector2(x:  val_35, y:  val_4.y);
            UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_34, y = val_24});
            val_35 = val_27.y * 57.29578f;
            val_33 = UnityEngine.Vector2.__il2cppRuntimeField_cctor_finished + 80.transform;
            UnityEngine.Quaternion val_30 = UnityEngine.Quaternion.Euler(x:  0f, y:  0f, z:  val_35 + (-90f));
            val_33.rotation = new UnityEngine.Quaternion() {x = val_30.x, y = val_30.y, z = val_30.z, w = val_30.w};
        }
        private bool IsBetweenInclusive(float value, float bound1, float bound2)
        {
            return (bool)((value >= bound1) ? 1 : 0) & ((value <= bound2) ? 1 : 0);
        }
        public RadarHudMediator()
        {
        
        }
    
    }

}
