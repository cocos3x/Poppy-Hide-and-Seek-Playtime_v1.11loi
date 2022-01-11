using UnityEngine;
public class SelectionPageView : MonoBehaviour
{
    // Fields
    public UnityEngine.Sprite spriteUnlocked;
    public UnityEngine.Sprite spriteLocked;
    public UnityEngine.RectTransform selectedImage;
    public UnityEngine.UI.Image[] selectionButtonImages;
    public System.Action<bool, string> OnSelectId;
    public string currentId;
    public bool isFullUnlocked;
    
    // Methods
    public System.Collections.IEnumerator UnlockRandom(UnityEngine.AnimationCurve unlockRandomTimeCurve, System.Action OnComplete)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .unlockRandomTimeCurve = unlockRandomTimeCurve;
        .OnComplete = OnComplete;
        return (System.Collections.IEnumerator)new SelectionPageView.<UnlockRandom>d__7();
    }
    private void Unlock(UnityEngine.UI.Image selectionImage, bool unlocked)
    {
        var val_1 = (unlocked != true) ? 24 : 32;
        selectionImage.sprite = null;
        bool val_5 = unlocked;
        selectionImage.transform.GetChild(index:  0).gameObject.SetActive(value:  val_5);
        selectionImage.raycastTarget = val_5;
    }
    public void UpdateSelectButtons()
    {
        this.isFullUnlocked = true;
        var val_8 = 4;
        do
        {
            if((val_8 - 4) >= this.selectionButtonImages.Length)
        {
                return;
        }
        
            string val_3 = this.selectionButtonImages[0].gameObject.name;
            bool val_4 = val_3.IsUnlocked(id:  val_3);
            if(val_4 != true)
        {
                this.isFullUnlocked = false;
        }
        
            this.Unlock(selectionImage:  this.selectionButtonImages[0], unlocked:  val_4);
            val_8 = val_8 + 1;
        }
        while(this.selectionButtonImages != null);
        
        throw new NullReferenceException();
    }
    private bool IsUnlocked(string id)
    {
        null = null;
        return Contains(item:  id);
    }
    public void OnOpen()
    {
        var val_6;
        var val_7;
        UnityEngine.RectTransform val_8;
        val_6 = 4;
        label_7:
        if((val_6 - 4) >= this.selectionButtonImages.Length)
        {
            goto label_13;
        }
        
        string val_3 = this.selectionButtonImages[0].gameObject.name;
        if((System.String.op_Equality(a:  val_3, b:  this.currentId)) == true)
        {
            goto label_6;
        }
        
        val_7 = val_6 + 1;
        if(this.selectionButtonImages != null)
        {
            goto label_7;
        }
        
        throw new NullReferenceException();
        label_6:
        val_8 = this.selectedImage;
        UnityEngine.Vector2 val_6 = 1152921505848476448.rectTransform.anchoredPosition;
        val_8.anchoredPosition = new UnityEngine.Vector2() {x = val_6.x, y = val_6.y};
        if(this.OnSelectId != null)
        {
                this.OnSelectId.Invoke(arg1:  false, arg2:  val_3);
        }
        
        label_13:
        this.UpdateSelectButtons();
    }
    public void OnClose()
    {
    
    }
    public void SelectId(int idx)
    {
        UnityEngine.Vector2 val_2 = this.selectionButtonImages[(long)idx].rectTransform.anchoredPosition;
        this.selectedImage.anchoredPosition = new UnityEngine.Vector2() {x = val_2.x, y = val_2.y};
        string val_4 = this.selectionButtonImages[(long)idx].gameObject.name;
        if((System.String.op_Inequality(a:  this.currentId, b:  val_4)) == false)
        {
                return;
        }
        
        if(this.OnSelectId == null)
        {
                return;
        }
        
        this.OnSelectId.Invoke(arg1:  false, arg2:  val_4);
    }
    public SelectionPageView()
    {
    
    }

}
