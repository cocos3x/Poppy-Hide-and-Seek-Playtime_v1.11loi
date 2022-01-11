using UnityEngine;
public class SpeedBooster : SingletonMonoBehaviour<SpeedBooster>
{
    // Fields
    public float duration;
    public float boostValue;
    private DG.Tweening.Tween tweenSlowdown;
    
    // Methods
    public void Stop()
    {
        this.StopAllCoroutines();
        if(this.tweenSlowdown == null)
        {
                return;
        }
        
        if((DG.Tweening.TweenExtensions.IsActive(t:  this.tweenSlowdown)) == false)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tweenSlowdown, complete:  false);
    }
    public void SetTarget(SeekerPlayerControler seekerPlayerControler)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.BoostSpeed(seekerPlayerControler:  seekerPlayerControler, second:  this.duration));
    }
    public void SetTarget(HiderPlayerController hiderPlayerController)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.BoostSpeed(hiderPlayerController:  hiderPlayerController, second:  this.duration));
    }
    private System.Collections.IEnumerator BoostSpeed(SeekerPlayerControler seekerPlayerControler, float second)
    {
        .<>1__state = 0;
        .seekerPlayerControler = seekerPlayerControler;
        .<>4__this = this;
        .second = second;
        return (System.Collections.IEnumerator)new SpeedBooster.<BoostSpeed>d__6();
    }
    private System.Collections.IEnumerator BoostSpeed(HiderPlayerController hiderPlayerController, float second)
    {
        .hiderPlayerController = hiderPlayerController;
        .<>4__this = this;
        .second = second;
        return (System.Collections.IEnumerator)new SpeedBooster.<BoostSpeed>d__7(<>1__state:  0);
    }
    public SpeedBooster()
    {
        this.duration = 15f;
        this.boostValue = 1.5f;
    }

}
