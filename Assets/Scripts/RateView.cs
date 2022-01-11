using UnityEngine;
public class RateView : MonoBehaviour
{
    // Fields
    public UnityEngine.CanvasGroup canvasGroup;
    public UnityEngine.RectTransform main;
    public System.Action CloseAction;
    public UnityEngine.UI.Image[] imagesStarGray;
    public UnityEngine.UI.Image[] imagesStarGold;
    private int starScore;
    private RectTransformSnapPoint snapPointMain;
    
    // Methods
    private void Awake()
    {
        this.snapPointMain = new RectTransformSnapPoint(rt:  this.main, deltaX:  0f, deltaY:  200f, moveTo:  false);
    }
    public void UpdateStars()
    {
        var val_8 = 0;
        do
        {
            this.imagesStarGray[val_8].gameObject.SetActive(value:  (val_8 >= this.starScore) ? 1 : 0);
            this.imagesStarGold[val_8].gameObject.SetActive(value:  (val_8 < this.starScore) ? 1 : 0);
            val_8 = val_8 + 1;
        }
        while((val_8 - 1) < 4);
    
    }
    public void Open()
    {
        this.starScore = 5;
        this.UpdateStars();
        this.gameObject.SetActive(value:  true);
        this.canvasGroup.alpha = 0f;
        DG.Tweening.Tweener val_2 = DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  1f, duration:  0.5f);
        DG.Tweening.Tween val_4 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tween>(t:  this.snapPointMain.MoveToInitializedPosition(duration:  0.2f, resetAtStart:  true), ease:  6);
    }
    public void Close()
    {
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.DOTweenModuleUI.DOFade(target:  this.canvasGroup, endValue:  0f, duration:  0.4f), action:  new DG.Tweening.TweenCallback(object:  this, method:  System.Void RateView::<Close>b__10_0()));
        if(this.CloseAction == null)
        {
                return;
        }
        
        this.CloseAction.Invoke();
    }
    public void SelectStar(int index)
    {
        this.starScore = index;
        this.UpdateStars();
    }
    public void Submit()
    {
        var val_1;
        if(this.starScore >= 4)
        {
                val_1 = null;
            val_1 = null;
            UserData.current.rated = true;
            UnityEngine.Application.OpenURL(url:  "https://play.google.com/store/apps/details?id=com.dino.hide.seek.poppygame");
        }
        
        this.Close();
    }
    public RateView()
    {
    
    }
    private void <Close>b__10_0()
    {
        this.gameObject.SetActive(value:  false);
    }

}
