using UnityEngine;
private sealed class SpeedBooster.<BoostSpeed>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SeekerPlayerControler seekerPlayerControler;
    public SpeedBooster <>4__this;
    public float second;
    private SpeedBooster.<>c__DisplayClass6_0 <>8__1;
    private float <cachedSpeedMultiplier>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpeedBooster.<BoostSpeed>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        SpeedBooster.<>c__DisplayClass6_0 val_10;
        int val_11;
        val_10 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>8__1 = new SpeedBooster.<>c__DisplayClass6_0();
        .seekerPlayerControler = this.seekerPlayerControler;
        this.<>8__1.effect = this.<>8__1.seekerPlayerControler.seeker.GetComponent<SpeedBoostEffect>();
        if((UnityEngine.Object.op_Implicit(exists:  this.<>8__1.effect)) != false)
        {
                this.<>8__1.effect.enabled = true;
        }
        
        float val_10 = this.<>8__1.seekerPlayerControler.speedMultiplier;
        this.<cachedSpeedMultiplier>5__2 = val_10;
        val_10 = val_10 * (this.<>4__this.boostValue);
        this.<>8__1.seekerPlayerControler.SetSpeedMultiplier(value:  val_10);
        UnityEngine.WaitForSeconds val_4 = null;
        float val_11 = -2f;
        val_11 = this.second + val_11;
        val_4 = new UnityEngine.WaitForSeconds(seconds:  val_11);
        val_11 = 1;
        this.<>2__current = val_4;
        this.<>1__state = val_11;
        return (bool)val_11;
        label_1:
        this.<>1__state = 0;
        this.<>8__1.speedMultiplier = this.<>8__1.seekerPlayerControler.speedMultiplier;
        val_10 = this.<>8__1;
        val_11 = 0;
        this.<>4__this.tweenSlowdown = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this.<>8__1, method:  System.Single SpeedBooster.<>c__DisplayClass6_0::<BoostSpeed>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this.<>8__1, method:  System.Void SpeedBooster.<>c__DisplayClass6_0::<BoostSpeed>b__1(float value)), endValue:  this.<cachedSpeedMultiplier>5__2, duration:  2f), action:  new DG.Tweening.TweenCallback(object:  val_10, method:  System.Void SpeedBooster.<>c__DisplayClass6_0::<BoostSpeed>b__2()));
        return (bool)val_11;
        label_2:
        val_11 = 0;
        return (bool)val_11;
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
