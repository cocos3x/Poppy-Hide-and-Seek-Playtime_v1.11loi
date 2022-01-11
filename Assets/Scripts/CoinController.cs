using UnityEngine;
public class CoinController : MonoBehaviour
{
    // Fields
    public int value;
    public UnityEngine.Collider collider;
    public UnityEngine.Transform pivot;
    public UnityEngine.AudioSource audioSourceCollected;
    public UnityEngine.ParticleSystem particleNormal;
    public UnityEngine.ParticleSystem particleCollected;
    private static System.Action<Character, CoinController> CoinCollectedEvent;
    
    // Methods
    public static void add_CoinCollectedEvent(System.Action<Character, CoinController> value)
    {
        if((System.Delegate.Combine(a:  CoinController.CoinCollectedEvent, b:  value)) == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    public static void remove_CoinCollectedEvent(System.Action<Character, CoinController> value)
    {
        if((System.Delegate.Remove(source:  CoinController.CoinCollectedEvent, value:  value)) == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
    
    }
    public void Update()
    {
        float val_2 = 100f;
        val_2 = UnityEngine.Time.deltaTime * val_2;
        this.pivot.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, relativeTo:  1);
    }
    private void OnTriggerEnter(UnityEngine.Collider other)
    {
        if((other.CompareTag(tag:  "Hider")) != true)
        {
                if((other.CompareTag(tag:  "Seeker")) == false)
        {
                return;
        }
        
        }
        
        this.OnCollected(character:  other.attachedRigidbody.GetComponent<Character>());
    }
    private void OnCollected(Character character)
    {
        this.particleNormal.Stop();
        this.collider.enabled = false;
        this.pivot.gameObject.SetActive(value:  false);
        this.particleCollected.Play();
        this.audioSourceCollected.Play();
        if(CoinController.CoinCollectedEvent == null)
        {
                return;
        }
        
        CoinController.CoinCollectedEvent.Invoke(arg1:  character, arg2:  this);
    }
    public CoinController()
    {
        this.value = 1;
    }

}
