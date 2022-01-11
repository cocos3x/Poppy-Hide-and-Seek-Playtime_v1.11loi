using UnityEngine;
public sealed class GameHud : MonoBehaviour
{
    // Fields
    private TMPro.TextMeshProUGUI _txtTimeToHide;
    private TMPro.TextMeshProUGUI _txtTimeToHideLabel;
    private TimeCounterColors _colors;
    private TMPro.TextMeshProUGUI _txtTimeLeft;
    private UnityEngine.UI.Image _imgTimeLeft;
    private TMPro.TextMeshProUGUI _txtCoins;
    public TPSShooter.Joystick Joystick;
    public UnityEngine.RectTransform TrRadarIcon;
    private int _roundedTime;
    private int _coins;
    private float _time;
    
    // Properties
    set; }
    public int Coins { get; set; }
    public float TimeToHide { get; set; }
    
    // Methods
    public void set_TimeToHideLabelText(string value)
    {
        if(this._txtTimeToHideLabel != null)
        {
                this._txtTimeToHideLabel.text = value;
            return;
        }
        
        throw new NullReferenceException();
    }
    public int get_Coins()
    {
        return (int)this._coins;
    }
    public void set_Coins(int value)
    {
        int val_3 = DG.Tweening.DOTween.Kill(targetOrId:  this._txtCoins.transform.parent, complete:  false);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        this._txtCoins.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        this._coins = value;
        this._txtCoins.text = value.ToString();
        if(value < 1)
        {
                return;
        }
        
        this = this._txtCoins.transform.parent;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  1.2f);
        DG.Tweening.Tweener val_12 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this, endValue:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, duration:  0.25f), loops:  2, loopType:  1);
    }
    public float get_TimeToHide()
    {
        return (float)this._time;
    }
    public void set_TimeToHide(float value)
    {
        this._time = value;
        this._txtTimeToHide.gameObject.SetActive(value:  ((UnityEngine.Mathf.CeilToInt(f:  value)) >> 31) ^ 1);
        this._txtTimeToHideLabel.gameObject.SetActive(value:  ((UnityEngine.Mathf.CeilToInt(f:  value)) >> 31) ^ 1);
        if(this._roundedTime == (UnityEngine.Mathf.CeilToInt(f:  value)))
        {
                return;
        }
        
        this._roundedTime = UnityEngine.Mathf.CeilToInt(f:  value);
        if(this._txtTimeToHide.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        int val_14 = DG.Tweening.DOTween.Kill(targetOrId:  this._txtTimeToHide.transform, complete:  false);
        UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
        this._txtTimeToHide.transform.localScale = new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z};
        this._txtTimeToHide.text = this._roundedTime.ToString();
        UnityEngine.Vector3 val_19 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  2f);
        DG.Tweening.Tweener val_22 = DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this._txtTimeToHide.transform, endValue:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z}, duration:  0.25f), loops:  2, loopType:  1);
        if(this._roundedTime != 0)
        {
                this._txtTimeToHide.alpha = 1f;
            this._txtTimeToHideLabel.alpha = 1f;
            return;
        }
        
        DG.Tweening.Tweener val_23 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this._txtTimeToHide, endValue:  0f, duration:  1f);
        DG.Tweening.Tweener val_24 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this._txtTimeToHideLabel, endValue:  0f, duration:  1f);
    }
    public bool SetTimeLeft(float startTime, float duration, bool isGreenTimeRemain)
    {
        UnityEngine.Color val_17;
        UnityEngine.Color val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        float val_13 = startTime;
        this._txtTimeLeft.gameObject.SetActive(value:  (duration > 0f) ? 1 : 0);
        this._imgTimeLeft.transform.parent.gameObject.SetActive(value:  (duration > 0f) ? 1 : 0);
        if(duration <= 0f)
        {
            goto label_7;
        }
        
        duration = val_13 + duration;
        val_13 = duration - UnityEngine.Time.time;
        float val_8 = UnityEngine.Mathf.Max(a:  val_13, b:  0f);
        this._txtTimeLeft.text = System.String.Format(format:  "0:{0:D2}", arg0:  UnityEngine.Mathf.CeilToInt(f:  val_8));
        val_17 = this._colors.regular;
        val_8 = val_8 / duration;
        this._imgTimeLeft.fillAmount = val_8;
        if((UnityEngine.Mathf.CeilToInt(f:  val_8)) > 10)
        {
            goto label_13;
        }
        
        if(isGreenTimeRemain == false)
        {
            goto label_15;
        }
        
        val_21 = this._colors.green;
        val_22 = this._colors + 44;
        val_23 = this._colors + 48;
        val_24 = this._colors + 52;
        goto label_16;
        label_7:
        val_25 = 0;
        return (bool)(val_8 <= 0f) ? 1 : 0;
        label_15:
        val_21 = this._colors.pink;
        val_22 = this._colors + 60;
        val_23 = this._colors + 64;
        val_24 = this._colors + 68;
        label_16:
        val_17 = mem[this._colors.pink];
        val_17 = this._colors.pink.r;
        label_13:
        this._imgTimeLeft.color = new UnityEngine.Color() {r = val_17, g = 2.531545E-33f, b = 2.531545E-33f, a = 2.531545E-33f};
        this._txtTimeLeft.color = new UnityEngine.Color() {r = val_17, g = 2.531545E-33f, b = 2.531545E-33f, a = 2.531545E-33f};
        return (bool)(val_8 <= 0f) ? 1 : 0;
    }
    public GameHud()
    {
    
    }

}
