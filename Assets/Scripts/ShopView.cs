using UnityEngine;
public class ShopView : MonoBehaviour
{
    // Fields
    public CharacterPreview characterPreview;
    public TMPro.TextMeshProUGUI textCash;
    public UnityEngine.UI.RawImage rawImage;
    public UnityEngine.GameObject blocker;
    public UnityEngine.GameObject buttonNextPage;
    public UnityEngine.GameObject buttonPrevPage;
    public UnityEngine.GameObject unlockButtons;
    public System.Action<int> OnCashUpdated;
    public UnityEngine.AnimationCurve unlockRandomTimeCurve;
    public SelectionPageView[] pages;
    public UnityEngine.UI.Image[] dotImages;
    public UnityEngine.RectTransform selectionDotRectTransform;
    private int pageIndex;
    private UnityEngine.RenderTexture previewTargetTexture;
    private string previousHiderId;
    private string previousSeekerId;
    public System.Action OnHiderIdChange;
    public System.Action OnSeekerIdChange;
    
    // Methods
    public void Awake()
    {
        var val_4;
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  256, height:  256, depth:  16);
        this.previewTargetTexture = val_1;
        this.rawImage.texture = val_1;
        this.characterPreview.camera.targetTexture = this.previewTargetTexture;
        SelectionPageView val_4 = this.pages[0];
        val_4 = null;
        val_4 = null;
        this.pages[0].currentId = UserData.current.currentHiderId;
        SelectionPageView val_5 = this.pages[0];
        this.pages[0].OnSelectId = new System.Action<System.Boolean, System.String>(object:  this, method:  System.Void ShopView::<Awake>b__18_0(bool unlock, string id));
        SelectionPageView val_6 = this.pages[1];
        this.pages[1].currentId = UserData.current.currentSeekerId;
        SelectionPageView val_7 = this.pages[1];
        this.pages[1].OnSelectId = new System.Action<System.Boolean, System.String>(object:  this, method:  System.Void ShopView::<Awake>b__18_1(bool unlock, string id));
        this.Open();
    }
    public void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.previewTargetTexture)) == false)
        {
                return;
        }
        
        if(this.previewTargetTexture.IsCreated() == false)
        {
                return;
        }
        
        this.previewTargetTexture.Release();
    }
    public void Open()
    {
        var val_3;
        this.gameObject.SetActive(value:  true);
        this.characterPreview.gameObject.SetActive(value:  true);
        val_3 = null;
        val_3 = null;
        this.previousHiderId = UserData.current.currentHiderId;
        this.previousSeekerId = UserData.current.currentSeekerId;
        this.UpdateTextCash();
        this.OnPageChange(newPageIndex:  0);
    }
    public void Close()
    {
        var val_5;
        this.characterPreview.gameObject.SetActive(value:  false);
        this.gameObject.SetActive(value:  false);
        val_5 = null;
        val_5 = null;
        if(((System.String.op_Inequality(a:  this.previousHiderId, b:  UserData.current.currentHiderId)) != false) && (this.OnHiderIdChange != null))
        {
                this.OnHiderIdChange.Invoke();
        }
        
        if((System.String.op_Inequality(a:  this.previousSeekerId, b:  UserData.current.currentSeekerId)) == false)
        {
                return;
        }
        
        if(this.OnSeekerIdChange == null)
        {
                return;
        }
        
        this.OnSeekerIdChange.Invoke();
    }
    public void NextPageClicked()
    {
        this.OnPageChange(newPageIndex:  this.pageIndex + 1);
    }
    public void PrevPageClicked()
    {
        this.OnPageChange(newPageIndex:  this.pageIndex - 1);
    }
    private void OnPageChange(int newPageIndex)
    {
        SelectionPageView[] val_9;
        if(this.pageIndex != newPageIndex)
        {
                val_9 = this.pages;
            if((this.pageIndex & 2147483648) == 0)
        {
                if(this.pageIndex < this.pages.Length)
        {
                val_9[this.pageIndex].gameObject.SetActive(value:  false);
            val_9 = this.pages;
            SelectionPageView val_10 = val_9[this.pageIndex];
        }
        
            this.pageIndex = newPageIndex;
        }
        else
        {
                this.pageIndex = newPageIndex;
        }
        
            val_9[newPageIndex].gameObject.SetActive(value:  true);
            this.pages[this.pageIndex].OnOpen();
            SelectionPageView val_13 = this.pages[this.pageIndex];
            this.unlockButtons.gameObject.SetActive(value:  (this.pages[this.pageIndex][0].isFullUnlocked == false) ? 1 : 0);
            UnityEngine.Vector2 val_6 = this.dotImages[this.pageIndex].rectTransform.anchoredPosition;
            this.selectionDotRectTransform.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        }
        
        this.buttonPrevPage.SetActive(value:  (this.pageIndex != 0) ? 1 : 0);
        int val_15 = this.pages.Length;
        val_15 = val_15 - 1;
        this.buttonNextPage.SetActive(value:  (this.pageIndex != val_15) ? 1 : 0);
    }
    public void ButtonUnlockByCashClicked()
    {
        var val_4;
        UserData val_5;
        val_4 = null;
        val_4 = null;
        val_5 = UserData.current;
        if(UserData.current.coin < 100)
        {
                return;
        }
        
        val_5 = UserData.current;
        int val_4 = UserData.current.coin;
        val_4 = val_4 - 100;
        UserData.current.coin = val_4;
        this.UpdateTextCash();
        this.blocker.SetActive(value:  true);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.pages[this.pageIndex].UnlockRandom(unlockRandomTimeCurve:  this.unlockRandomTimeCurve, OnComplete:  new System.Action(object:  this, method:  System.Void ShopView::<ButtonUnlockByCashClicked>b__25_0())));
    }
    public void ButtonUnlockByAdsClicked()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = ShopView.<>c.<>9__26_1;
        if(val_6 == null)
        {
                System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  ShopView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ShopView.<>c::<ButtonUnlockByAdsClicked>b__26_1());
            ShopView.<>c.<>9__26_1 = val_6;
        }
        
        SingletonMonoBehaviour<System.Object>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  this, method:  System.Void ShopView::<ButtonUnlockByAdsClicked>b__26_0()), failedEvent:  val_2);
    }
    private void UpdateTextCash()
    {
        null = null;
        this.textCash.text = UserData.current.coin.ToString();
        if(this.OnCashUpdated == null)
        {
                return;
        }
        
        this.OnCashUpdated.Invoke(obj:  UserData.current.coin);
    }
    private bool IsSeeker(string id)
    {
        return id.Contains(value:  "seeker");
    }
    public ShopView()
    {
        this.unlockRandomTimeCurve = UnityEngine.AnimationCurve.Linear(timeStart:  0f, valueStart:  0f, timeEnd:  1f, valueEnd:  1f);
        this.pageIndex = 0;
    }
    private void <Awake>b__18_0(bool unlock, string id)
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = val_1;
        SelectionPageView val_1 = this.pages[0];
        this.pages[0].currentId = id;
        UserData.current.currentHiderId = id;
        if(unlock != false)
        {
                val_2 = 1152921504768454840;
            Add(item:  id);
            SelectionPageView val_2 = this.pages[0];
            if(this.pages[0].isFullUnlocked != false)
        {
                this.unlockButtons.SetActive(value:  false);
        }
        
        }
        
        this.characterPreview.SpawnCharacter(id:  id);
    }
    private void <Awake>b__18_1(bool unlock, string id)
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        val_2 = val_1;
        SelectionPageView val_1 = this.pages[1];
        this.pages[1].currentId = id;
        UserData.current.currentSeekerId = id;
        if(unlock != false)
        {
                val_2 = 1152921504768454840;
            Add(item:  id);
            SelectionPageView val_2 = this.pages[1];
            if(this.pages[1].isFullUnlocked != false)
        {
                this.unlockButtons.SetActive(value:  false);
        }
        
        }
        
        this.characterPreview.SpawnCharacter(id:  id);
    }
    private void <ButtonUnlockByCashClicked>b__25_0()
    {
        if(this.blocker != null)
        {
                this.blocker.SetActive(value:  false);
            return;
        }
        
        throw new NullReferenceException();
    }
    private void <ButtonUnlockByAdsClicked>b__26_0()
    {
        null = null;
        int val_1 = UserData.current.coin;
        val_1 = val_1 + 100;
        UserData.current.coin = val_1;
        this.UpdateTextCash();
        AppEventTracker.PushEvent_Rewarded_Ads(position:  "+100", succeeded:  true);
    }

}
