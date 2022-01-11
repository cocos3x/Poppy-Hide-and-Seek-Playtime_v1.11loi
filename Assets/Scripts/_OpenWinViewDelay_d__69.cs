using UnityEngine;
private sealed class GameFlow.<OpenWinViewDelay>d__69 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameFlow <>4__this;
    public float delay;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameFlow.<OpenWinViewDelay>d__69(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_6;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_6 = 1;
        this.<>4__this.blocker.gameObject.SetActive(value:  true);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        this.<>1__state = val_6;
        return (bool)val_6;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.blocker.gameObject.SetActive(value:  false);
        if((this.<>4__this.mode) != 0)
        {
                this.<>4__this.winView.SetRewardSeekMode(catchCount:  this.<>4__this.caughtHiderCount, rewardPerCatch:  this.<>4__this.rewardPerCatch, collected:  this.<>4__this.collectedCoin, total:  (this.<>4__this.collectedCoin) + ((this.<>4__this.rewardPerCatch) * (this.<>4__this.caughtHiderCount)));
        }
        else
        {
                this.<>4__this.winView.SetRewardHideMode(rescueCount:  this.<>4__this.rescuedHiderCount, rewardPerRescue:  this.<>4__this.rewardPerRescue, collected:  this.<>4__this.collectedCoin, total:  (this.<>4__this.collectedCoin) + ((this.<>4__this.rewardPerRescue) * (this.<>4__this.rescuedHiderCount)));
        }
        
        this.<>4__this.winView.Open();
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
