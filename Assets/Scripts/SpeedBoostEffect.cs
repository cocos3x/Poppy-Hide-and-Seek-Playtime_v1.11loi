using UnityEngine;
public class SpeedBoostEffect : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform footLeftTransform;
    public UnityEngine.Transform footRightTransform;
    public UnityEngine.Transform vfxLeftTransform;
    public UnityEngine.Transform vfxRightTransform;
    
    // Methods
    public void OnEnable()
    {
        this.vfxLeftTransform.gameObject.SetActive(value:  true);
        this.vfxRightTransform.gameObject.SetActive(value:  true);
    }
    public void OnDisable()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.vfxLeftTransform)) != false)
        {
                this.vfxLeftTransform.gameObject.SetActive(value:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.vfxRightTransform)) == false)
        {
                return;
        }
        
        this.vfxRightTransform.gameObject.SetActive(value:  false);
    }
    public void LateUpdate()
    {
        UnityEngine.Vector3 val_1 = this.footLeftTransform.position;
        this.vfxLeftTransform.position = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        UnityEngine.Vector3 val_2 = this.vfxRightTransform.position;
        this.vfxRightTransform.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
    }
    public SpeedBoostEffect()
    {
    
    }

}
