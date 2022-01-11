using UnityEngine;
public sealed class OneListener<T> : BaseOneListener<System.Action<T>>
{
    // Methods
    public void Invoke(T value)
    {
        object val_2 = value;
        if(true == 0)
        {
                return;
        }
        
        var val_2 = 0;
        label_9:
        if(val_2 >= (System.Math.Min(val1:  7454, val2:  __RuntimeMethodHiddenParam + 24 + 192)))
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
    public OneListener<T>()
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
