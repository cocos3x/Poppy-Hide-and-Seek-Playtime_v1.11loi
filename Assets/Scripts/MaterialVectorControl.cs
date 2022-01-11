using UnityEngine;
public class MaterialVectorControl : MonoBehaviour
{
    // Fields
    public int materialIndex;
    public string property;
    public UnityEngine.Vector4 vector;
    
    // Methods
    public void Start()
    {
        this.UpdateMaterialProperty();
    }
    public void UpdateMaterialProperty()
    {
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        UnityEngine.MaterialPropertyBlock val_2 = new UnityEngine.MaterialPropertyBlock();
        val_1.GetPropertyBlock(properties:  val_2, materialIndex:  this.materialIndex);
        val_2.SetVector(name:  this.property, value:  new UnityEngine.Vector4() {x = this.vector});
        val_1.SetPropertyBlock(properties:  val_2, materialIndex:  this.materialIndex);
    }
    public MaterialVectorControl()
    {
        this.property = "_Vector";
    }

}
