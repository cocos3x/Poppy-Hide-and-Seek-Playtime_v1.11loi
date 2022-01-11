using UnityEngine;
public class Character : MonoBehaviour
{
    // Fields
    public bool isPlayer;
    protected bool isPlaying;
    public UnityEngine.Rigidbody rigidbody;
    public System.Action<UnityEngine.Vector3> OnTeleport;
    
    // Methods
    public void Teleport(UnityEngine.Vector3 position)
    {
        this.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        if(this.OnTeleport == null)
        {
                return;
        }
        
        this.OnTeleport.Invoke(obj:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
    }
    public Character()
    {
    
    }

}
