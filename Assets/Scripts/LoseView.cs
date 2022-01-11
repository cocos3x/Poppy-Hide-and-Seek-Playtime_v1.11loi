using UnityEngine;
public class LoseView : MonoBehaviour
{
    // Fields
    public System.Action OnReplay;
    public System.Action OnSkip;
    public System.Action OnNext;
    public System.Action OnSpeedUp;
    public System.Action OnIgnoreWall;
    public System.Action OnInvisible;
    public UnityEngine.GameObject objectModeHide;
    public UnityEngine.GameObject objectModeSeek;
    public UnityEngine.GameObject skipButton;
    public UnityEngine.GameObject nextButton;
    public UnityEngine.GameObject[] boosterButtons;
    
    // Methods
    public void SetMode(GameMode gameMode, bool canNext)
    {
        UnityEngine.GameObject[] val_6;
        var val_7;
        this.objectModeHide.SetActive(value:  (gameMode == 0) ? 1 : 0);
        this.objectModeSeek.SetActive(value:  (gameMode != 0) ? 1 : 0);
        val_6 = this.boosterButtons;
        var val_7 = 0;
        label_6:
        if(val_7 >= this.boosterButtons.Length)
        {
            goto label_3;
        }
        
        val_6[val_7].SetActive(value:  false);
        val_6 = this.boosterButtons;
        val_7 = val_7 + 1;
        if(val_6 != null)
        {
            goto label_6;
        }
        
        throw new NullReferenceException();
        label_3:
        if(gameMode != 0)
        {
                val_7 = 2;
        }
        else
        {
                val_7 = 3;
        }
        
        val_6[UnityEngine.Random.Range(min:  0, max:  3)].SetActive(value:  true);
        this.nextButton.SetActive(value:  canNext);
        this.skipButton.SetActive(value:  (~canNext) & 1);
    }
    public void ReplayButtonClicked()
    {
        if(this.OnReplay != null)
        {
                this.OnReplay.Invoke();
        }
        
        this.Close();
    }
    public void NextButtonClicked()
    {
        if(this.OnNext != null)
        {
                this.OnNext.Invoke();
        }
        
        this.Close();
    }
    public void SkipButtonClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = LoseView.<>c.<>9__14_1;
        if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  LoseView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoseView.<>c::<SkipButtonClicked>b__14_1());
            LoseView.<>c.<>9__14_1 = val_6;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void LoseView::<SkipButtonClicked>b__14_0()), failedEvent:  val_3);
    }
    public void SpeedUpButtonClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = LoseView.<>c.<>9__15_1;
        if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  LoseView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoseView.<>c::<SpeedUpButtonClicked>b__15_1());
            LoseView.<>c.<>9__15_1 = val_6;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void LoseView::<SpeedUpButtonClicked>b__15_0()), failedEvent:  val_3);
    }
    public void IgnoreWallButtonClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = LoseView.<>c.<>9__16_1;
        if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  LoseView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoseView.<>c::<IgnoreWallButtonClicked>b__16_1());
            LoseView.<>c.<>9__16_1 = val_6;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void LoseView::<IgnoreWallButtonClicked>b__16_0()), failedEvent:  val_3);
    }
    public void InvisibleButtonClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = LoseView.<>c.<>9__17_1;
        if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  LoseView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void LoseView.<>c::<InvisibleButtonClicked>b__17_1());
            LoseView.<>c.<>9__17_1 = val_6;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void LoseView::<InvisibleButtonClicked>b__17_0()), failedEvent:  val_3);
    }
    public void Open()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void Close()
    {
        this.gameObject.SetActive(value:  false);
    }
    public LoseView()
    {
    
    }
    private void <SkipButtonClicked>b__14_0()
    {
        if(this.OnSkip != null)
        {
                this.OnSkip.Invoke();
        }
        
        this.Close();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "skip", succeeded:  true);
    }
    private void <SpeedUpButtonClicked>b__15_0()
    {
        if(this.OnSpeedUp != null)
        {
                this.OnSpeedUp.Invoke();
        }
        
        this.Close();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "speed_up", succeeded:  true);
    }
    private void <IgnoreWallButtonClicked>b__16_0()
    {
        if(this.OnIgnoreWall != null)
        {
                this.OnIgnoreWall.Invoke();
        }
        
        this.Close();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "ignore_wall", succeeded:  true);
    }
    private void <InvisibleButtonClicked>b__17_0()
    {
        if(this.OnInvisible != null)
        {
                this.OnInvisible.Invoke();
        }
        
        this.Close();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "invisible", succeeded:  true);
    }

}
