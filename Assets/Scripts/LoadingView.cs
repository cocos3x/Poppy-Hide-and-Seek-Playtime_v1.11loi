using UnityEngine;
public class LoadingView : MonoBehaviour
{
    // Fields
    public UnityEngine.UI.Image imageFilled;
    public TMPro.TextMeshProUGUI textMesh;
    public System.Action OnClose;
    
    // Methods
    public void Open()
    {
        this.gameObject.SetActive(value:  true);
        SingletonMonoBehaviour<AdManager>.Instance.HideBanner();
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.LoadingEffectDelay());
    }
    public void Close()
    {
        this.gameObject.SetActive(value:  false);
        SingletonMonoBehaviour<AdManager>.Instance.ShowBanner();
        if(this.OnClose == null)
        {
                return;
        }
        
        this.OnClose.Invoke();
    }
    private System.Collections.IEnumerator LoadingEffectDelay()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new LoadingView.<LoadingEffectDelay>d__5();
    }
    public LoadingView()
    {
    
    }

}
