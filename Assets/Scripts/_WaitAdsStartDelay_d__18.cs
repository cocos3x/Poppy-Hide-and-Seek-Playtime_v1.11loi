using UnityEngine;
private sealed class AdManager.<WaitAdsStartDelay>d__18 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public AdManager <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AdManager.<WaitAdsStartDelay>d__18(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_2;
        int val_3;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<>4__this.doneAdsInterval = false;
        val_2 = null;
        val_2 = null;
        val_3 = 1;
        this.<>2__current = new UnityEngine.WaitForSecondsRealtime(time:  (float)RemoteConfigControl.interstitialAds_Interval);
        this.<>1__state = val_3;
        return (bool)val_3;
        label_1:
        this.<>1__state = 0;
        val_3 = 0;
        this.<>4__this.doneAdsInterval = true;
        return (bool)val_3;
        label_2:
        val_3 = 0;
        return (bool)val_3;
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
