using UnityEngine;
private sealed class SelectionPageView.<UnlockRandom>d__7 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public SelectionPageView <>4__this;
    public UnityEngine.AnimationCurve unlockRandomTimeCurve;
    public System.Action OnComplete;
    private System.Collections.Generic.List<int> <lockIndices>5__2;
    private int <selectedIndex>5__3;
    private float <interval>5__4;
    private int <loopCount>5__5;
    private int <currentLoopCount>5__6;
    private int <p_r>5__7;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SelectionPageView.<UnlockRandom>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        System.Collections.Generic.List<System.Int32> val_18;
        System.Action val_19;
        int val_21;
        int val_22;
        float val_23;
        if((this.<>1__state) == 2)
        {
            goto label_1;
        }
        
        if((this.<>1__state) == 1)
        {
            goto label_2;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_3;
        }
        
        this.<>1__state = 0;
        this.<lockIndices>5__2 = new System.Collections.Generic.List<System.Int32>();
        label_12:
        if(0 >= (this.<>4__this.selectionButtonImages.Length))
        {
            goto label_6;
        }
        
        string val_3 = this.<>4__this.selectionButtonImages[0].gameObject.name;
        if((val_3.IsUnlocked(id:  val_3)) != true)
        {
                this.<lockIndices>5__2.Add(item:  0);
        }
        
        val_18 = 0 + 1;
        if((this.<>4__this.selectionButtonImages) != null)
        {
            goto label_12;
        }
        
        throw new NullReferenceException();
        label_1:
        this.<>1__state = 0;
        this.<>4__this.Unlock(selectionImage:  this.<>4__this.selectionButtonImages[this.<selectedIndex>5__3], unlocked:  true);
        if((this.<lockIndices>5__2) == 1)
        {
                this.<>4__this.isFullUnlocked = this.<lockIndices>5__2;
        }
        
        if((this.<>4__this.OnSelectId) != null)
        {
                this.<>4__this.OnSelectId.Invoke(arg1:  true, arg2:  this.<>4__this.selectionButtonImages[this.<selectedIndex>5__3].gameObject.name);
        }
        
        val_19 = this.OnComplete;
        if(val_19 == null)
        {
                return (bool)val_19;
        }
        
        val_19.Invoke();
        label_3:
        val_19 = 0;
        return (bool)val_19;
        label_2:
        this.<>1__state = 0;
        int val_8 = UnityEngine.Random.Range(min:  0, max:  (this.<lockIndices>5__2) - 1);
        int val_22 = this.<p_r>5__7;
        val_18 = val_8;
        if(val_8 != val_22)
        {
            goto label_26;
        }
        
        int val_9 = val_18 + 1;
        val_18 = val_9 - ((val_9 / val_22) * val_22);
        goto label_28;
        label_6:
        val_18 = this.<lockIndices>5__2;
        this.<selectedIndex>5__3 = 0;
        this.<interval>5__4 = 0.3988281f;
        if(0 >= 2)
        {
            goto label_30;
        }
        
        if(0 == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.<selectedIndex>5__3 = mem[4525048015441887264];
        UnityEngine.Vector2 val_12 = this.<>4__this.selectionButtonImages[mem[4525048015441887264]].rectTransform.anchoredPosition;
        this.<>4__this.selectedImage.anchoredPosition = new UnityEngine.Vector2() {x = val_12.x, y = val_12.y};
        goto label_37;
        label_26:
        label_28:
        if(val_22 <= val_18)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_22 = val_22 + (val_18 << 2);
        this.<selectedIndex>5__3 = (this.<p_r>5__7 + (val_8) << 2) + 32;
        UnityEngine.Vector2 val_14 = this.<>4__this.selectionButtonImages[(this.<p_r>5__7 + (val_8) << 2) + 32].rectTransform.anchoredPosition;
        this.<>4__this.selectedImage.anchoredPosition = new UnityEngine.Vector2() {x = val_14.x, y = val_14.y};
        val_21 = this.<loopCount>5__5;
        val_22 = (this.<currentLoopCount>5__6) + 1;
        this.<currentLoopCount>5__6 = val_22;
        this.<p_r>5__7 = val_18;
        if(val_22 <= val_21)
        {
            goto label_46;
        }
        
        label_37:
        val_23 = this.<interval>5__4;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  val_23);
        this.<>1__state = 2;
        val_19 = 1;
        return (bool)val_19;
        label_30:
        val_22 = 0;
        this.<p_r>5__7 = 0;
        val_21 = 20;
        this.<loopCount>5__5 = 20;
        this.<currentLoopCount>5__6 = 0;
        label_46:
        float val_24 = 0f;
        val_24 = val_24 / 20f;
        float val_16 = this.unlockRandomTimeCurve.Evaluate(time:  val_24);
        val_23 = val_16;
        UnityEngine.WaitForSeconds val_17 = null;
        val_16 = (this.<interval>5__4) * val_23;
        val_17 = new UnityEngine.WaitForSeconds(seconds:  val_16);
        val_19 = 1;
        this.<>2__current = val_17;
        this.<>1__state = val_19;
        return (bool)val_19;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
