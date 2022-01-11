using UnityEngine;
public class PaintPuddle : MonoBehaviour
{
    // Fields
    public UnityEngine.Renderer renderer;
    public UnityEngine.Color color;
    public float fadeDuration;
    public float stickDuration;
    
    // Methods
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        FootStepParticleController val_2 = other.attachedRigidbody.GetComponent<FootStepParticleController>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return;
        }
        
        val_2.StopSpawning();
    }
    public void OnTriggerExit(UnityEngine.Collider other)
    {
        FootStepParticleController val_2 = other.attachedRigidbody.GetComponent<FootStepParticleController>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return;
        }
        
        val_2.Show(color:  new UnityEngine.Color() {r = this.color}, stickDuration:  this.stickDuration, fadeDuration:  this.fadeDuration);
    }
    public void Start()
    {
        this.UpdateMaterialProperty();
    }
    public void UpdateMaterialProperty()
    {
        UnityEngine.MaterialPropertyBlock val_1 = new UnityEngine.MaterialPropertyBlock();
        this.renderer.GetPropertyBlock(properties:  val_1);
        val_1.SetColor(name:  "_Color", value:  new UnityEngine.Color() {r = this.color});
        this.renderer.SetPropertyBlock(properties:  val_1);
    }
    public PaintPuddle()
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.color = val_1;
        mem[1152921507152151764] = val_1.g;
        mem[1152921507152151768] = val_1.b;
        mem[1152921507152151772] = val_1.a;
        this.fadeDuration = 5f;
        this.stickDuration = 3f;
    }

}
