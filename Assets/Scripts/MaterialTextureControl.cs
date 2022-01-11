using UnityEngine;
public class MaterialTextureControl : MonoBehaviour
{
    // Fields
    public int materialIndex;
    public string property;
    public UnityEngine.Texture texture;
    
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
        val_2.SetTexture(name:  this.property, value:  this.texture);
        val_1.SetPropertyBlock(properties:  val_2, materialIndex:  this.materialIndex);
    }
    public MaterialTextureControl()
    {
        this.property = "_MainTex";
    }

}
