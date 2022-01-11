using UnityEngine;
private sealed class Shining.<Shine>d__7 : IEnumerator<object>, IEnumerator, IDisposable
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
    public Shining.<Shine>d__7(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_4;
        float val_5;
        UnityEngine.WaitForSeconds val_6;
        int val_7;
        var val_8;
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
        
        val_4 = this;
        this.<currentTime>5__2 = 0f;
        this.<>1__state = 0;
        if((this.<>4__this) != null)
        {
            goto label_4;
        }
        
        label_2:
        this.<>1__state = 0;
        val_4 = this.<currentTime>5__2;
        goto label_7;
        label_1:
        this.<>1__state = 0;
        this.<>4__this.image.SetFloat(name:  "_Width", value:  0f);
        val_4 = this;
        this.<currentTime>5__2 = 0f;
        label_4:
        float val_4 = this.<>4__this.shiningTime;
        val_4 = 1f / val_4;
        this.<speed>5__3 = val_4;
        this.<>4__this.image.SetFloat(name:  "_Width", value:  this.<>4__this.width);
        label_7:
        val_5 = this.<currentTime>5__2;
        if(val_5 > (this.<>4__this.shiningTime))
        {
                val_6 = this.<>4__this.waitForSeconds;
            val_7 = 2;
        }
        else
        {
                val_5 = val_5 + UnityEngine.Time.deltaTime;
            this.<currentTime>5__2 = val_5;
            val_5 = UnityEngine.Mathf.Lerp(a:  -0.3f, b:  1.3f, t:  val_5 * (this.<speed>5__3));
            this.<>4__this.image.SetFloat(name:  "_TimeController", value:  val_5);
            val_6 = 0;
            val_7 = 1;
        }
        
        val_8 = 1;
        this.<>2__current = val_6;
        this.<>1__state = val_7;
        return (bool)val_8;
        label_3:
        val_8 = 0;
        return (bool)val_8;
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
