using UnityEngine;
private sealed class LoadingView.<LoadingEffectDelay>d__5 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public LoadingView <>4__this;
    private LoadingView.<>c__DisplayClass5_0 <>8__1;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LoadingView.<LoadingEffectDelay>d__5(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_27;
        if((this.<>1__state) <= 6)
        {
                var val_21 = 11346832 + (this.<>1__state) << 2;
            val_21 = val_21 + 11346832;
        }
        else
        {
                val_27 = 0;
            return (bool);
        }
    
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
