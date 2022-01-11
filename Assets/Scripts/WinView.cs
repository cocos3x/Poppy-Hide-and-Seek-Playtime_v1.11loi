using UnityEngine;
public class WinView : MonoBehaviour
{
    // Fields
    public System.Action OnReplay;
    public System.Action OnNext;
    public TMPro.TextMeshProUGUI textTotalReward;
    public TMPro.TextMeshProUGUI textRescue;
    public TMPro.TextMeshProUGUI textRescueReward;
    public TMPro.TextMeshProUGUI textCollectedReward;
    public TMPro.TextMeshProUGUI textMultiply;
    public UnityEngine.RectTransform rectTransformNeedle;
    public UnityEngine.AnimationCurve animCurveNeedle;
    public UnityEngine.GameObject spinObject;
    private DG.Tweening.Tween tweenNeedleRotate;
    private int spinMutiply;
    private int prevSpinMutiply;
    private int totalReward;
    
    // Methods
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
    public void SetRewardHideMode(int rescueCount, int rewardPerRescue, int collected, int total)
    {
        this.textRescue.text = "Rescued " + rescueCount.ToString();
        int val_6 = rescueCount;
        val_6 = val_6 * rewardPerRescue;
        this.textRescueReward.text = val_6.ToString();
        this.textCollectedReward.text = collected.ToString();
        this.textTotalReward.text = total.ToString();
        this.totalReward = total;
    }
    public void SetRewardSeekMode(int catchCount, int rewardPerCatch, int collected, int total)
    {
        this.textRescue.text = "Found " + catchCount.ToString();
        int val_6 = catchCount;
        val_6 = val_6 * rewardPerCatch;
        this.textRescueReward.text = val_6.ToString();
        this.textCollectedReward.text = collected.ToString();
        this.textTotalReward.text = total.ToString();
        this.totalReward = total;
    }
    public void Update()
    {
        TMPro.TextMeshProUGUI val_6;
        int val_7;
        val_6 = this;
        UnityEngine.Vector3 val_1 = this.rectTransformNeedle.localEulerAngles;
        float val_6 = -360f;
        val_6 = val_1.z + val_6;
        float val_2 = (val_1.z > 180f) ? (val_6) : val_1.z;
        if(val_2 <= 18f)
        {
            goto label_2;
        }
        
        val_7 = 2;
        goto label_3;
        label_2:
        if(val_2 <= (-41f))
        {
            goto label_4;
        }
        
        val_7 = 3;
        label_3:
        this.spinMutiply = val_7;
        goto label_5;
        label_4:
        if(val_2 > (-78f))
        {
                val_7 = 4;
        }
        else
        {
                val_7 = 5;
        }
        
        mem2[0] = 5;
        label_5:
        if(this.prevSpinMutiply == 5)
        {
                return;
        }
        
        this.prevSpinMutiply = 5;
        this.textMultiply.text = "x" + this.spinMutiply.ToString();
        int val_7 = this.totalReward;
        val_6 = this.textTotalReward;
        val_7 = this.spinMutiply * val_7;
        val_6.text = val_7.ToString();
    }
    public void Open()
    {
        this.gameObject.SetActive(value:  true);
        this.spinObject.SetActive(value:  true);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.rectTransformNeedle.localEulerAngles = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.tweenNeedleRotate = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotate(target:  this.rectTransformNeedle, endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  1.7f, mode:  0), animCurve:  this.animCurveNeedle), loops:  0);
    }
    public void Close()
    {
        this.gameObject.SetActive(value:  false);
        if(this.tweenNeedleRotate == null)
        {
                return;
        }
        
        if((DG.Tweening.TweenExtensions.IsActive(t:  this.tweenNeedleRotate)) == false)
        {
                return;
        }
        
        DG.Tweening.TweenExtensions.Kill(t:  this.tweenNeedleRotate, complete:  false);
    }
    public void OnSpineClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = WinView.<>c.<>9__21_1;
        if(val_6 == null)
        {
                System.Action val_3 = null;
            val_6 = val_3;
            val_3 = new System.Action(object:  WinView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WinView.<>c::<OnSpineClicked>b__21_1());
            WinView.<>c.<>9__21_1 = val_6;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void WinView::<OnSpineClicked>b__21_0()), failedEvent:  val_3);
    }
    public WinView()
    {
    
    }
    private void <OnSpineClicked>b__21_0()
    {
        var val_3;
        if(this.tweenNeedleRotate != null)
        {
                if((DG.Tweening.TweenExtensions.IsActive(t:  this.tweenNeedleRotate)) != false)
        {
                DG.Tweening.TweenExtensions.Kill(t:  this.tweenNeedleRotate, complete:  false);
        }
        
        }
        
        this.spinObject.SetActive(value:  false);
        int val_3 = this.totalReward;
        val_3 = this.spinMutiply * val_3;
        this.textTotalReward.text = val_3.ToString();
        val_3 = null;
        val_3 = null;
        int val_4 = this.spinMutiply;
        int val_5 = UserData.current.coin;
        val_4 = val_4 - 1;
        val_5 = val_5 + (val_4 * this.totalReward);
        UserData.current.coin = val_5;
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "spin", succeeded:  true);
    }

}
