using UnityEngine;
public class SettingView : MonoBehaviour
{
    // Fields
    public UnityEngine.Audio.AudioMixer audioMixer;
    public UnityEngine.CanvasGroup canvasGroup;
    public UnityEngine.RectTransform main;
    public System.Action CloseAction;
    public UnityEngine.GameObject buttonMusicEnabled;
    public UnityEngine.GameObject buttonMusicDisabled;
    public UnityEngine.GameObject buttonSoundEnabled;
    public UnityEngine.GameObject buttonSoundDisabled;
    public UnityEngine.GameObject buttonVibrateEnabled;
    public UnityEngine.GameObject buttonVibrateDisabled;
    private RectTransformSnapPoint snapPointMain;
    
    // Methods
    private void Awake()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "music", defaultValue:  1);
        int val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "sound", defaultValue:  1);
        int val_3 = UnityEngine.PlayerPrefs.GetInt(key:  "vibrate", defaultValue:  1);
        bool val_5 = this.audioMixer.SetFloat(name:  "MusicVolume", value:  (val_1 == 1) ? 0f : -80f);
        bool val_7 = this.audioMixer.SetFloat(name:  "EffectVolume", value:  (val_2 == 1) ? 0f : -80f);
        this.buttonMusicEnabled.SetActive(value:  (val_1 == 1) ? 1 : 0);
        this.buttonMusicDisabled.SetActive(value:  (val_1 != 1) ? 1 : 0);
        this.buttonSoundEnabled.SetActive(value:  (val_2 == 1) ? 1 : 0);
        this.buttonSoundDisabled.SetActive(value:  (val_2 != 1) ? 1 : 0);
        this.buttonVibrateEnabled.SetActive(value:  (val_3 == 1) ? 1 : 0);
        this.buttonVibrateDisabled.SetActive(value:  (val_3 != 1) ? 1 : 0);
        this.snapPointMain = new RectTransformSnapPoint(rt:  this.main, deltaX:  0f, deltaY:  200f, moveTo:  false);
    }
    private bool GetValue(string key)
    {
        return (bool)((UnityEngine.PlayerPrefs.GetInt(key:  key, defaultValue:  1)) == 1) ? 1 : 0;
    }
    private void SetValue(string key, bool value)
    {
        UnityEngine.PlayerPrefs.SetInt(key:  key, value:  value);
    }
    public void Open()
    {
        this.gameObject.SetActive(value:  true);
        this.canvasGroup.alpha = 0f;
        DG.Tweening.Tweener val_2 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  1f, duration:  0.5f);
        DG.Tweening.Tween val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  this.snapPointMain.MoveToInitializedPosition(duration:  0.2f, resetAtStart:  true), ease:  6);
    }
    public void Close()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  0f, duration:  0.4f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void SettingView::<Close>b__15_0()));
        if(this.CloseAction == null)
        {
                return;
        }
        
        this.CloseAction.Invoke();
    }
    public void ButtonSoundClicked()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "sound", defaultValue:  1);
        int val_2 = (val_1 != 1) ? 1 : 0;
        UnityEngine.PlayerPrefs.SetInt(key:  "sound", value:  val_2);
        bool val_4 = this.audioMixer.SetFloat(name:  "EffectVolume", value:  (val_1 == 1) ? -80f : 0f);
        this.buttonSoundEnabled.SetActive(value:  val_2);
        this.buttonSoundDisabled.SetActive(value:  (val_1 == 1) ? 1 : 0);
    }
    public void ButtonMusicClicked()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "music", defaultValue:  1);
        int val_2 = (val_1 != 1) ? 1 : 0;
        UnityEngine.PlayerPrefs.SetInt(key:  "music", value:  val_2);
        bool val_4 = this.audioMixer.SetFloat(name:  "MusicVolume", value:  (val_1 == 1) ? -80f : 0f);
        this.buttonMusicEnabled.SetActive(value:  val_2);
        this.buttonMusicDisabled.SetActive(value:  (val_1 == 1) ? 1 : 0);
    }
    public void ButtonVibrationClicked()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "vibrate", defaultValue:  1);
        int val_2 = (val_1 != 1) ? 1 : 0;
        UnityEngine.PlayerPrefs.SetInt(key:  "vibrate", value:  val_2);
        this.buttonVibrateEnabled.SetActive(value:  val_2);
        this.buttonVibrateDisabled.SetActive(value:  (val_1 == 1) ? 1 : 0);
    }
    public void ButtonPrivacyPolicyClicked()
    {
        UnityEngine.Application.OpenURL(url:  "https://zegostudio.com/dino-policy.html");
    }
    public SettingView()
    {
    
    }
    private void <Close>b__15_0()
    {
        this.gameObject.SetActive(value:  false);
    }

}
