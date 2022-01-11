using UnityEngine;
public class CameraHolder : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform Holder;
    public float currDistance;
    public float xRotate;
    public float yRotate;
    public float yMinLimit;
    public float yMaxLimit;
    public float prevDistance;
    private float x;
    private float y;
    
    // Methods
    private void Start()
    {
        UnityEngine.Vector3 val_2 = this.transform.eulerAngles;
        this.x = val_2.y;
        this.y = val_2.x;
    }
    private void LateUpdate()
    {
        float val_25;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        val_25 = this.currDistance;
        if(val_25 < 0)
        {
                val_25 = 2f;
            this.currDistance = 2f;
        }
        
        float val_1 = UnityEngine.Input.GetAxis(axisName:  "Mouse ScrollWheel");
        val_1 = val_1 * (-20f);
        val_1 = val_25 + val_1;
        this.currDistance = val_1;
        if((UnityEngine.Object.op_Implicit(exists:  this.Holder)) == false)
        {
            goto label_6;
        }
        
        if((UnityEngine.Input.GetMouseButton(button:  0)) != true)
        {
                if((UnityEngine.Input.GetMouseButton(button:  1)) == false)
        {
            goto label_6;
        }
        
        }
        
        UnityEngine.Vector3 val_5 = UnityEngine.Input.mousePosition;
        val_25 = val_5.y;
        float val_6 = UnityEngine.Screen.dpi;
        if(UnityEngine.Screen.dpi >= 0)
        {
            goto label_7;
        }
        
        val_27 = 1f;
        goto label_8;
        label_6:
        UnityEngine.Cursor.visible = true;
        UnityEngine.Cursor.lockState = 0;
        goto label_9;
        label_7:
        val_27 = UnityEngine.Screen.dpi / 200f;
        label_8:
        val_28 = val_27 * 380f;
        if(val_5.x < 0)
        {
                float val_25 = (float)UnityEngine.Screen.height;
            val_25 = val_25 - val_25;
            val_28 = val_27 * 250f;
            if(val_25 < 0)
        {
                return;
        }
        
        }
        
        UnityEngine.Cursor.visible = false;
        UnityEngine.Cursor.lockState = 1;
        float val_10 = UnityEngine.Input.GetAxis(axisName:  "Mouse X");
        val_10 = val_10 * this.xRotate;
        double val_26 = (double)val_10;
        val_26 = val_26 * 0.02;
        float val_27 = (float)val_26;
        val_27 = this.x + val_27;
        this.x = val_27;
        float val_11 = UnityEngine.Input.GetAxis(axisName:  "Mouse Y");
        val_11 = val_11 * this.yRotate;
        double val_28 = (double)val_11;
        val_28 = val_28 * 0.02;
        float val_29 = (float)val_28;
        val_29 = this.y - val_29;
        this.y = val_29;
        float val_12 = CameraHolder.ClampAngle(angle:  val_29, min:  this.yMinLimit, max:  this.yMaxLimit);
        this.y = val_12;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Euler(x:  val_12, y:  this.x, z:  0f);
        val_27 = val_13.z;
        UnityEngine.Vector3 val_14 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_27, w = val_13.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_15 = this.Holder.position;
        val_25 = val_15.y;
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_25, z = val_15.z});
        val_29 = val_16.x;
        val_30 = val_16.z;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_27, w = val_13.w};
        this.transform.position = new UnityEngine.Vector3() {x = val_29, y = val_16.y, z = val_30};
        label_9:
        if(this.prevDistance == this.currDistance)
        {
                return;
        }
        
        this.prevDistance = this.currDistance;
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.Euler(x:  this.y, y:  this.x, z:  0f);
        val_27 = val_19.z;
        UnityEngine.Vector3 val_20 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_27, w = val_19.w}, point:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_21 = this.Holder.position;
        val_25 = val_21.y;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_25, z = val_21.z});
        val_29 = val_22.x;
        val_30 = val_22.z;
        this.transform.rotation = new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_27, w = val_19.w};
        this.transform.position = new UnityEngine.Vector3() {x = val_29, y = val_22.y, z = val_30};
    }
    private static float ClampAngle(float angle, float min, float max)
    {
        float val_4 = angle;
        float val_3 = -360f;
        float val_2 = (val_4 < 0) ? (val_4 + 360f) : (val_4);
        val_3 = val_2 + val_3;
        val_4 = (val_2 > 360f) ? (val_3) : (val_2);
        return UnityEngine.Mathf.Clamp(value:  val_4, min:  min, max:  max);
    }
    public CameraHolder()
    {
        this.yMaxLimit = 80f;
        this.currDistance = ;
        this.xRotate = ;
        this.yRotate = 120f;
        this.yMinLimit = -20f;
    }

}
