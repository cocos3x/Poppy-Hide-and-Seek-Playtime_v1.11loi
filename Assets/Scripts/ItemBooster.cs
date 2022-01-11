using UnityEngine;
public class ItemBooster : MonoBehaviour
{
    // Fields
    public ItemBooster.Type type;
    public UnityEngine.ParticleSystem particleSystemOnPick;
    public UnityEngine.Collider collider;
    public UnityEngine.GameObject visual;
    
    // Methods
    public void OnTriggerEnter(UnityEngine.Collider other)
    {
        var val_17;
        var val_18;
        Character val_2 = other.attachedRigidbody.GetComponent<Character>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) == false)
        {
                return;
        }
        
        if(val_2.isPlayer == false)
        {
                return;
        }
        
        if(this.type == 0)
        {
                return;
        }
        
        if(this.type == 2)
        {
            goto label_9;
        }
        
        if(this.type != 1)
        {
                return;
        }
        
        val_17 = SingletonMonoBehaviour<SpeedBooster>.Instance;
        goto label_12;
        label_9:
        val_18 = 0;
        val_17 = SingletonMonoBehaviour<IgnoreWall>.Instance;
        System.Collections.IEnumerator val_7 = val_17.MakeHiderInvisibleForSeconds(hider:  val_2, duration:  val_6.duration);
        goto label_27;
        label_12:
        SetTarget(seekerPlayerControler:  val_2.GetComponent<SeekerPlayerControler>());
        goto label_36;
        label_27:
        UnityEngine.Coroutine val_14 = StartCoroutine(routine:  null);
        label_36:
        this.particleSystemOnPick.Play();
        this.collider.gameObject.SetActive(value:  false);
        this.visual.SetActive(value:  false);
    }
    public ItemBooster()
    {
    
    }

}
