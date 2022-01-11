using UnityEngine;
private sealed class SpeedBooster.<BoostSpeed>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public HiderPlayerController hiderPlayerController;
    public SpeedBooster <>4__this;
    public float second;
    private SpeedBooster.<>c__DisplayClass7_0 <>8__1;
    private float <cachedSpeedMultiplier>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpeedBooster.<BoostSpeed>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SpeedBooster.<>c__DisplayClass7_0 val_9;
        int val_10;
        val_9 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new SpeedBooster.<>c__DisplayClass7_0();
        .hiderPlayerController = this.hiderPlayerController;
        this.<>8__1.effect = this.<>8__1.hiderPlayerController.hider.movingEffect.GetComponent<SpeedBoostEffect>();
        this.<>8__1.effect.enabled = true;
        float val_9 = this.<>8__1.hiderPlayerController.speedMultiplier;
        this.<cachedSpeedMultiplier>5__2 = val_9;
        val_9 = val_9 * (this.<>4__this.boostValue);
        this.<>8__1.hiderPlayerController.SetSpeedMultiplier(value:  val_9);
        UnityEngine.WaitForSeconds val_3 = null;
        float val_10 = -2f;
        val_10 = this.second + val_10;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  val_10);
        val_10 = 1;
        this.<>2__current = val_3;
        this.<>1__state = val_10;
        return (bool)val_10;
        label_1:
        this.<>1__state = 0;
        this.<>8__1.speedMultiplier = this.<>8__1.hiderPlayerController.speedMultiplier;
        val_9 = this.<>8__1;
        val_10 = 0;
        this.<>4__this.tweenSlowdown = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this.<>8__1, method:  System.Single SpeedBooster.<>c__DisplayClass7_0::<BoostSpeed>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  System.Void SpeedBooster.<>c__DisplayClass7_0::<BoostSpeed>b__1(float value)), endValue:  this.<cachedSpeedMultiplier>5__2, duration:  2f), action:  new DG.Tweening.TweenCallback(object:  val_9, method:  System.Void SpeedBooster.<>c__DisplayClass7_0::<BoostSpeed>b__2()));
        return (bool)val_10;
        label_2:
        val_10 = 0;
        return (bool)val_10;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
