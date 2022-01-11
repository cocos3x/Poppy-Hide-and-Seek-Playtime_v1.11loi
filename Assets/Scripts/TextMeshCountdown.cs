using UnityEngine;
public class TextMeshCountdown : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform cameraTransform;
    public TMPro.TextMeshPro textMesh;
    
    // Methods
    private void Update()
    {
        UnityEngine.Vector3 val_2 = this.cameraTransform.forward;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.textMesh.transform.forward = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
    }
    public void SetCoutdownTime(int second, bool anim = True)
    {
        this.textMesh.text = second.ToString();
    }
    public TextMeshCountdown()
    {
    
    }

}
