using UnityEngine;
public class Shining : MonoBehaviour
{
    // Fields
    private float width;
    private float shiningTime;
    private UnityEngine.UI.Image image;
    private UnityEngine.SpriteRenderer sprite;
    private UnityEngine.WaitForSeconds waitForSeconds;
    
    // Methods
    private void Awake()
    {
        this.image = this.GetComponent<UnityEngine.UI.Image>();
        this.sprite = this.GetComponent<UnityEngine.SpriteRenderer>();
        this.waitForSeconds = new UnityEngine.WaitForSeconds(seconds:  1f);
    }
    private void OnEnable()
    {
        if(this.image != 0)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Shine());
        }
        
        if(this.sprite == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.Shine2());
    }
    private System.Collections.IEnumerator Shine()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Shining.<Shine>d__7();
    }
    private System.Collections.IEnumerator Shine2()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Shining.<Shine2>d__8();
    }
    public Shining()
    {
        this.width = 0.2f;
        this.shiningTime = 1f;
    }

}
