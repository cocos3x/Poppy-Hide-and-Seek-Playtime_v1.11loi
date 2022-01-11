using UnityEngine;
public class IgnoreWall : SingletonMonoBehaviour<IgnoreWall>
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
        return (System.Collections.IEnumerator)new IgnoreWall.<MakeHiderInvisibleForSeconds>d__4();
    }
    public void ApplyToTarget(Seeker seeker)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.MakeHiderInvisibleForSeconds(seeker:  seeker, duration:  this.duration));
    }
    private System.Collections.IEnumerator MakeHiderInvisibleForSeconds(Seeker seeker, float duration)
    {
        .<>1__state = 0;
        .seeker = seeker;
        .<>4__this = this;
        .duration = duration;
        return (System.Collections.IEnumerator)new IgnoreWall.<MakeHiderInvisibleForSeconds>d__6();
    }
    public IgnoreWall()
    {
    
    }

}
