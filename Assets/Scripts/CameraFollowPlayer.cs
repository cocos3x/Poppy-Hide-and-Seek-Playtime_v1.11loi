using UnityEngine;
public class CameraFollowPlayer : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform target;
    public UnityEngine.Vector3 offset;
    public UnityEngine.Transform audioListenerTransform;
    private UnityEngine.Transform cachedTransform;
    
    // Methods
    private void Awake()
    {
        this.cachedTransform = this.transform;
    }
    public void SetTarget(UnityEngine.Transform target, UnityEngine.Vector3 offset)
    {
        this.target = target;
        this.offset = offset;
        mem[1152921507121087844] = offset.y;
        mem[1152921507121087848] = offset.z;
    }
    private void LateUpdate()
    {
        UnityEngine.Vector3 val_1 = this.target.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V12.16B, z = V11.16B});
        UnityEngine.Vector3 val_3 = this.cachedTransform.localPosition;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, t:  UnityEngine.Time.deltaTime * 10f);
        this.cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        this.audioListenerTransform.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
    }
    public CameraFollowPlayer()
    {
    
    }

}
