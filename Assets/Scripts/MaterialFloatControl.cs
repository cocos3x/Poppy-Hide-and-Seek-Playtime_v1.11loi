using UnityEngine;
public class MaterialFloatControl : MonoBehaviour
{
    // Fields
    public int materialIndex;
    public string property;
    public float value;
    
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
        val_2.SetFloat(name:  this.property, value:  this.value);
        val_1.SetPropertyBlock(properties:  val_2, materialIndex:  this.materialIndex);
    }
    public MaterialFloatControl()
    {
        this.property = "_Value";
    }

}
