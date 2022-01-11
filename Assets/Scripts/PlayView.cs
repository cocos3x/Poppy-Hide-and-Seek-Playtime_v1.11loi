using UnityEngine;
public class PlayView : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioSource audioSource10s;
    public UnityEngine.RectTransform rectTransformSeekerPointer;
    public UnityEngine.RectTransform rectTransformSeekerHear;
    public UnityEngine.Camera cameraGameplay;
    public TMPro.TextMeshProUGUI textTime;
    public TMPro.TextMeshProUGUI textCountdown;
    public UnityEngine.GameObject topObject;
    public UnityEngine.UI.Image imageTimeProgress;
    public TPSShooter.Joystick joystick;
    public UnityEngine.UI.Image[] imagesCount;
    public Seeker seeker;
    private bool seekerVisiblePrevious;
    private UnityEngine.Vector2 canvasSize;
    private float aspectRatio;
    private bool isSeekerHearing;
    private float duration;
    private bool isPlaying;
    private GameMode currentMode;
    private int timeInSecond;
    private UnityEngine.Color colorCountDefault;
    
    // Methods
    private void Awake()
    {
        this.rectTransformSeekerPointer.gameObject.SetActive(value:  false);
        this.rectTransformSeekerHear.gameObject.SetActive(value:  false);
        float val_6 = (float)UnityEngine.Screen.width;
        val_6 = val_6 / (float)UnityEngine.Screen.height;
        this.aspectRatio = val_6;
        UnityEngine.Color val_5 = this.imagesCount[0].color;
        this.colorCountDefault = val_5;
        mem[1152921507173918312] = val_5.g;
        mem[1152921507173918316] = val_5.b;
        mem[1152921507173918320] = val_5.a;
    }
    private void Start()
    {
        UnityEngine.Vector2 val_2 = this.GetComponent<UnityEngine.RectTransform>().sizeDelta;
        this.canvasSize = val_2;
        mem[1152921507174092744] = val_2.y;
    }
    public void OnGameStart(GameMode mode, float dur)
    {
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.imageTimeProgress.color = new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a};
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.textTime.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.duration = dur;
        this.isPlaying = true;
        this.currentMode = mode;
    }
    public void OnGameEnd()
    {
        this.isPlaying = false;
        this.textCountdown.transform.parent.gameObject.SetActive(value:  false);
        this.topObject.SetActive(value:  false);
        this.rectTransformSeekerPointer.gameObject.SetActive(value:  false);
        this.rectTransformSeekerHear.gameObject.SetActive(value:  false);
        if(this.audioSource10s.isPlaying == false)
        {
                return;
        }
        
        this.audioSource10s.Stop();
    }
    public void SetMinCaught(int count)
    {
        var val_7 = 0;
        do
        {
            if(val_7 >= this.imagesCount.Length)
        {
                return;
        }
        
            this.imagesCount[val_7].transform.parent.GetChild(index:  1).gameObject.SetActive(value:  (val_7 >= count) ? 1 : 0);
            val_7 = val_7 + 1;
        }
        while(this.imagesCount != null);
        
        throw new NullReferenceException();
    }
    public void SetCount(int count, bool flag)
    {
        if(count == 0)
        {
            goto label_0;
        }
        
        if(flag == false)
        {
            goto label_9;
        }
        
        if(this.currentMode == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Color val_1 = UnityEngine.Color.green;
        goto label_9;
        label_0:
        var val_5 = 0;
        do
        {
            if(val_5 >= this.imagesCount.Length)
        {
                return;
        }
        
            this.imagesCount[val_5].color = new UnityEngine.Color() {r = this.colorCountDefault};
            val_5 = val_5 + 1;
        }
        while(this.imagesCount != null);
        
        throw new NullReferenceException();
        label_2:
        UnityEngine.Color val_2 = UnityEngine.Color.yellow;
        label_9:
        this.imagesCount[count - 1].color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
    }
    public void SetTime(float time)
    {
        float val_6;
        TMPro.TextMeshProUGUI val_7;
        TMPro.TextMeshProUGUI val_8;
        string val_10;
        val_6 = time;
        float val_6 = this.duration;
        val_6 = val_6 / val_6;
        this.imageTimeProgress.fillAmount = val_6;
        if(this.timeInSecond == (int)val_6)
        {
                return;
        }
        
        if((int)val_6 >= (1.401298E-44f))
        {
            goto label_3;
        }
        
        if(this.timeInSecond > 9)
        {
            goto label_4;
        }
        
        val_7 = this.textTime;
        goto label_5;
        label_3:
        val_8 = this.textTime;
        string val_1 = (int)val_6.ToString();
        val_10 = "0:";
        goto label_6;
        label_4:
        this.audioSource10s.Play();
        if(this.currentMode != 0)
        {
                UnityEngine.Color val_2 = UnityEngine.Color.red;
        }
        else
        {
                UnityEngine.Color val_3 = UnityEngine.Color.green;
        }
        
        val_6 = val_3.r;
        this.imageTimeProgress.color = new UnityEngine.Color() {r = val_6, g = val_3.g, b = val_3.b, a = val_3.a};
        val_7 = this;
        this.textTime.color = new UnityEngine.Color() {r = val_6, g = val_3.g, b = val_3.b, a = val_3.a};
        label_5:
        val_8 = null;
        val_10 = "0:0";
        label_6:
        string val_5 = val_10 + (int)val_6.ToString();
        this.timeInSecond = (int)val_6;
    }
    public void OnStartCountdown()
    {
        this.textCountdown.transform.parent.gameObject.SetActive(value:  true);
    }
    public void SetCoutdownTime(int second, bool anim = True)
    {
        this.textCountdown.text = second.ToString();
        if(anim == false)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  1.5f);
        this.textCountdown.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        DG.Tweening.Tweener val_7 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.textCountdown.transform, endValue:  1f, duration:  0.35f), ease:  6);
    }
    public void OnFinishCountdown()
    {
        this.topObject.SetActive(value:  true);
        this.textCountdown.transform.parent.gameObject.SetActive(value:  false);
    }
    public void Update()
    {
        if(this.isPlaying == false)
        {
                return;
        }
        
        this.UpdateSeekerHearingMark();
        this.UpdateSeekerPointer();
    }
    private void UpdateSeekerPointer()
    {
        UnityEngine.RectTransform val_13;
        float val_14;
        bool val_15;
        float val_16;
        float val_17;
        var val_20;
        float val_21;
        val_13 = this;
        UnityEngine.Vector3 val_2 = this.seeker.transform.localPosition;
        UnityEngine.Vector3 val_3 = this.cameraGameplay.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        val_14 = val_3.y;
        if(((val_3.y <= (-0.1f)) || (val_3.x <= (-0.1f))) || (val_3.x >= 0))
        {
            goto label_6;
        }
        
        val_15 = this.seekerVisiblePrevious;
        if(val_14 >= 0)
        {
            goto label_7;
        }
        
        if(val_15 == true)
        {
                return;
        }
        
        this.seekerVisiblePrevious = true;
        this.rectTransformSeekerPointer.gameObject.SetActive(value:  false);
        return;
        label_6:
        val_15 = this.seekerVisiblePrevious;
        label_7:
        if(val_15 != false)
        {
                this.seekerVisiblePrevious = false;
            this.rectTransformSeekerPointer.gameObject.SetActive(value:  true);
        }
        
        float val_13 = -0.5f;
        val_3.x = val_3.x + val_13;
        val_13 = val_14 + val_13;
        UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_3.x, y:  val_13);
        float val_14 = val_6.x;
        float val_15 = val_6.y;
        val_14 = val_14 * this.canvasSize;
        val_15 = val_15 * S3;
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  val_14, y:  val_15);
        float val_16 = val_7.x;
        val_16 = val_16 / val_7.y;
        val_16 = val_16 * 3f;
        val_16 = val_16 + 1f;
        val_16 = 2f / val_16;
        float val_8 = UnityEngine.Mathf.Clamp(value:  val_16, min:  0.75f, max:  1f);
        if(System.Math.Abs(val_16) > this.aspectRatio)
        {
                val_16 = val_7.x;
            val_17 = val_7.y;
            UnityEngine.Vector2 val_9 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16, y = val_17}, d:  this.canvasSize);
            val_20 = null;
            val_21 = val_7.x;
        }
        else
        {
                val_16 = val_7.x;
            val_17 = val_7.y;
            UnityEngine.Vector2 val_10 = UnityEngine.Vector2.op_Multiply(a:  new UnityEngine.Vector2() {x = val_16, y = val_17}, d:  V12.16B);
            val_20 = null;
            val_21 = val_7.y;
        }
        
        UnityEngine.Vector2 val_12 = UnityEngine.Vector2.op_Division(a:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y}, d:  System.Math.Abs(val_21 + val_21));
        this.rectTransformSeekerPointer.anchoredPosition = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        val_14 = val_7.y * 57.29578f;
        this.rectTransformSeekerPointer.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_13 = this.rectTransformSeekerPointer;
        val_13.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void UpdateSeekerHearingMark()
    {
        if(this.seeker.state == 3)
        {
                if(this.isSeekerHearing != true)
        {
                this.isSeekerHearing = true;
            this.rectTransformSeekerHear.gameObject.SetActive(value:  true);
        }
        
            UnityEngine.Vector3 val_3 = this.seeker.transform.localPosition;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_5 = this.cameraGameplay.WorldToViewportPoint(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            val_5.x = val_5.x + (-0.5f);
            val_5.y = val_5.y + (-0.5f);
            val_5.x = this.canvasSize * val_5.x;
            val_5.y = val_5.y * 0f;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  val_5.x, y:  val_5.y);
            this.rectTransformSeekerHear.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
            return;
        }
        
        if(this.isSeekerHearing == false)
        {
                return;
        }
        
        this.isSeekerHearing = false;
        this.rectTransformSeekerHear.gameObject.SetActive(value:  false);
    }
    public PlayView()
    {
    
    }

}
