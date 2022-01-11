using UnityEngine;
public class TeleportGate : MonoBehaviour
{
    // Fields
    public TeleportGate output;
    private System.Collections.Generic.List<Character> enterredCharacters;
    
    // Methods
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.output)) == false)
        {
                return;
        }
        
        Character val_3 = other.attachedRigidbody.GetComponent<Character>();
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        if((this.enterredCharacters.Contains(item:  val_3)) != false)
        {
                return;
        }
        
        this.enterredCharacters.Add(item:  val_3);
        UnityEngine.Vector3 val_7 = this.output.transform.position;
        val_3.Teleport(position:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        this.output.enterredCharacters.Add(item:  val_3);
    }
    public void OnTriggerExit(UnityEngine.Collider other)
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.output)) == false)
        {
                return;
        }
        
        Character val_3 = other.attachedRigidbody.GetComponent<Character>();
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) == false)
        {
                return;
        }
        
        if((this.enterredCharacters.Contains(item:  val_3)) == false)
        {
                return;
        }
        
        bool val_6 = this.enterredCharacters.Remove(item:  val_3);
    }
    public TeleportGate()
    {
        this.enterredCharacters = new System.Collections.Generic.List<Character>();
    }

}
