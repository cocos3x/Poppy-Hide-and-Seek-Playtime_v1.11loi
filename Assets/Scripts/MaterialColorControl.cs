using UnityEngine;
public class MaterialColorControl : MonoBehaviour
{
    // Fields
    public int materialIndex;
    public string property;
    public UnityEngine.Color color;
    
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
        val_2.SetColor(name:  this.property, value:  new UnityEngine.Color() {r = this.color});
        val_1.SetPropertyBlock(properties:  val_2, materialIndex:  this.materialIndex);
    }
    public MaterialColorControl()
    {
        this.property = "_Color";
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921507150082636] = val_1.g;
        mem[1152921507150082640] = val_1.b;
        mem[1152921507150082644] = val_1.a;
    }

}
