using UnityEngine;

namespace TPSShooter
{
    public class Joystick : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject circle;
        private UnityEngine.GameObject dot;
        private UnityEngine.Vector2 touchPosition;
        private UnityEngine.Vector2 moveDirection;
        public float maxRadius;
        public bool IsTouched;
        public float Horizontal;
        public float Vertical;
        private float speedKoef;
        private UnityEngine.EventSystems.BaseInput _input;
        private float _lastAxisUsedTime;
        
        // Methods
        private void Start()
        {
            this.circle.SetActive(value:  false);
            this.dot.SetActive(value:  false);
        }
        private void Update()
        {
            if(0 == this._input)
            {
                    UnityEngine.EventSystems.EventSystem val_2 = UnityEngine.EventSystems.EventSystem.current;
                this._input = val_2.m_CurrentInputModule.input;
            }
            
            if(UnityEngine.Input.touchCount >= 1)
            {
                    UnityEngine.Touch val_5 = UnityEngine.Input.GetTouch(index:  0);
                if((TouchUtility.TouchedUI(fingerId:  user_properties)) == true)
            {
                    return;
            }
            
                this.IsTouched = true;
                this.touchPosition = new UnityEngine.Vector2();
                mem[1152921507317336044] = ???;
                if(status_internet > 3)
            {
                    return;
            }
            
                var val_13 = 11346640 + (val_8) << 2;
                val_13 = val_13 + 11346640;
            }
            else
            {
                    this.IsTouched = false;
                this.circle.SetActive(value:  false);
                this.dot.SetActive(value:  false);
            }
        
        }
        private void MovePlayer()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = this.touchPosition, y = V8.16B});
            this.dot.transform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector3 val_5 = this.dot.transform.localPosition;
            UnityEngine.Vector2 val_6 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.ClampMagnitude(vector:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, maxLength:  this.maxRadius);
            UnityEngine.Vector3 val_8 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y});
            this.dot.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Vector3 val_10 = this.dot.transform.position;
            UnityEngine.Vector3 val_12 = this.circle.transform.position;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, d:  this.speedKoef);
            UnityEngine.Vector2 val_15 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
            this.moveDirection = val_15;
            mem[1152921507317542308] = val_15.y;
            this.Horizontal = val_15.x;
            this.Vertical = val_15.y;
        }
        private UnityEngine.Touch GetTouch()
        {
            var val_5;
            UnityEngine.EventSystems.BaseInput val_6;
            Analytics.USER_PROPERTIES_TYPE val_7;
            float val_8;
            UnityEngine.Touch val_0;
            if(this._input >= 1)
            {
                    val_6;
                val_7 = 1;
            }
            else
            {
                    val_6 = this._input;
                if((this._input & 1) != 0)
            {
                    val_7 = 2;
            }
            else
            {
                    val_5 = "Horizontal";
                val_8 = System.Math.Abs(V0.16B);
                float val_5 = System.Math.Abs(S0);
                val_5 = val_8 + val_5;
                if((UnityEngine.Mathf.Approximately(a:  val_5, b:  0f)) != false)
            {
                    val_7 = 0;
            }
            else
            {
                    float val_2 = UnityEngine.Time.time;
                this._lastAxisUsedTime = val_2;
                val_8 = val_2;
                float val_6 = this.speedKoef;
                float val_3 = val_8 * this.speedKoef;
                val_3 = this.maxRadius * val_3;
                val_2 = val_2 * val_6;
                val_6 = val_2 * this.maxRadius;
                UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  val_3, y:  val_6);
                val_7 = 3;
            }
            
            }
            
            }
            
            user_properties = val_7;
            return val_0;
        }
        public Joystick()
        {
            this.speedKoef = 0.02f;
        }
    
    }

}
