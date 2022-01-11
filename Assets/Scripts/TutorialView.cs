using UnityEngine;
public class TutorialView : MonoBehaviour
{
    // Fields
    public UnityEngine.CanvasGroup canvasGroup;
    public UnityEngine.Animation animation;
    public float fadeDuration;
    private DG.Tweening.Tween OpenTween;
    private bool isClosing;
    
    // Methods
    public void Open()
    {
        this.isClosing = false;
        this.gameObject.SetActive(value:  true);
        this.canvasGroup.alpha = 0f;
        this.OpenTween = DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  1f, duration:  0.35f);
        bool val_3 = this.animation.Play();
    }
    public void Close()
    {
        DG.Tweening.Tween val_5 = this.OpenTween;
        if(val_5 != null)
        {
            goto label_1;
        }
        
        if((DG.Tweening.TweenExtensions.IsActive(t:  val_5 = this.OpenTween)) == false)
        {
            goto label_2;
        }
        
        val_5 = this.OpenTween;
        label_1:
        DG.Tweening.TweenExtensions.Kill(t:  val_5, complete:  false);
        label_2:
        this.isClosing = true;
        DG.Tweening.Tweener val_4 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  0f, duration:  0.35f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void TutorialView::<Close>b__6_0()));
    }
    public void Update()
    {
        if(this.isClosing != false)
        {
                return;
        }
        
        if(UnityEngine.Input.touchCount < 1)
        {
                return;
        }
        
        UnityEngine.Touch val_3 = UnityEngine.Input.GetTouch(index:  0);
        if((UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(pointerId:  user_properties)) == true)
        {
                return;
        }
        
        this.Close();
    }
    public TutorialView()
    {
        this.fadeDuration = 0.35f;
    }
    private void <Close>b__6_0()
    {
        this.gameObject.SetActive(value:  false);
    }

}
