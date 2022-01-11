using UnityEngine;
public sealed class OneListener<T1, T2, T3> : BaseOneListener<System.Action<T1, T2, T3>>
{
    // Methods
    public void Invoke(T1 value1, T2 value2, T3 value3)
    {
        object val_2 = value3;
        if(true == 0)
        {
                return;
        }
        
        var val_2 = 0;
        label_9:
        if(val_2 >= (System.Math.Min(val1:  7456, val2:  __RuntimeMethodHiddenParam + 24 + 192)))
        {
            goto label_6;
        }
        
        val_2 = val_2 + 1;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 16) != 0)
        {
            goto label_9;
        }
        
        label_6:
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = 1152921504617123839;
        if(val_2 < 0)
        {
                return;
        }
        
        do
        {
            val_2 = 1152921504617123838;
        }
        while(val_2 >= 0);
    
    }
    public OneListener<T1, T2, T3>()
    {
        if(this != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }

}
