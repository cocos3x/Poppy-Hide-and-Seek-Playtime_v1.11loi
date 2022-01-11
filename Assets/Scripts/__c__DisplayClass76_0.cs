using UnityEngine;
private sealed class GameFlow.<>c__DisplayClass76_0
{
    // Fields
    public int type;
    public GameFlow <>4__this;
    
    // Methods
    public GameFlow.<>c__DisplayClass76_0()
    {
    
    }
    internal void <OnPlayWithBooster>b__0()
    {
        if(this.type == 0)
        {
            goto label_1;
        }
        
        if(this.type == 1)
        {
            goto label_2;
        }
        
        if(this.type != 2)
        {
            goto label_3;
        }
        
        this.<>4__this.useIgnoreWall = true;
        goto label_9;
        label_2:
        this.<>4__this.useInvisibility = true;
        goto label_9;
        label_1:
        this.<>4__this.useSpeedBoost = true;
        goto label_9;
        label_3:
        this = this.<>4__this;
        label_9:
        mem2[0] = 0;
        mem[this.<>4__this].OnGameStart();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "start_booster", succeeded:  true);
    }

}
