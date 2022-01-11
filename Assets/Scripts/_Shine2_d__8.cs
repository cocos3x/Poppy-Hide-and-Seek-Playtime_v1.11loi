using UnityEngine;
private sealed class Shining.<Shine2>d__8 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Shining <>4__this;
    private float <currentTime>5__2;
    private float <speed>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Shining.<Shine2>d__8(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_7;
        float val_8;
        UnityEngine.WaitForSeconds val_9;
        int val_10;
        var val_11;
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
        
        val_7 = this;
        this.<currentTime>5__2 = 0f;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_2:
        this.<>1__state = 0;
        val_7 = this.<currentTime>5__2;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.sprite.material.SetFloat(name:  "_Width", value:  0f);
        val_7 = this;
        this.<currentTime>5__2 = 0f;
        label_4:
        float val_7 = this.<>4__this.shiningTime;
        val_7 = 1f / val_7;
        this.<speed>5__3 = val_7;
        this.<>4__this.sprite.material.SetFloat(name:  "_Width", value:  this.<>4__this.width);
        label_7:
        val_8 = this.<currentTime>5__2;
        if(val_8 > (this.<>4__this.shiningTime))
        {
                val_9 = this.<>4__this.waitForSeconds;
            val_10 = 2;
        }
        else
        {
                val_8 = val_8 + UnityEngine.Time.deltaTime;
            this.<currentTime>5__2 = val_8;
            val_8 = UnityEngine.Mathf.Lerp(a:  0f, b:  1f, t:  val_8 * (this.<speed>5__3));
            this.<>4__this.sprite.material.SetFloat(name:  "_TimeController", value:  val_8);
            val_9 = 0;
            val_10 = 1;
        }
        
        val_11 = 1;
        this.<>2__current = val_9;
        this.<>1__state = val_10;
        return (bool)val_11;
        label_3:
        val_11 = 0;
        return (bool)val_11;
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
