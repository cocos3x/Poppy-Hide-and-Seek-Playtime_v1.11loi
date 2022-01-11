using UnityEngine;
private sealed class GameFlow.<Countdown>d__63 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public GameFlow <>4__this;
    public System.Action OnCompleted;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameFlow.<Countdown>d__63(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        if((this.<>1__state) <= 4)
        {
                var val_5 = 11344592 + (this.<>1__state) << 2;
            val_5 = val_5 + 11344592;
        }
        else
        {
                val_5 = 0;
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
