using UnityEngine;
public class Invisibility : SingletonMonoBehaviour<Invisibility>
{
    // Fields
    public float duration;
    public UnityEngine.Material material;
    
    // Methods
    public void ApplyToTarget(Hider hider)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.MakeHiderInvisibleForSeconds(hider:  hider, duration:  this.duration));
    }
    public void Stop()
    {
        this.StopAllCoroutines();
    }
    private System.Collections.IEnumerator MakeHiderInvisibleForSeconds(Hider hider, float duration)
    {
        .<>1__state = 0;
        .hider = hider;
        .<>4__this = this;
        .duration = duration;
        return (System.Collections.IEnumerator)new Invisibility.<MakeHiderInvisibleForSeconds>d__4();
    }
    public Invisibility()
    {
        this.duration = 5f;
    }

}
