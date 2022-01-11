using UnityEngine;
public sealed class OneListener : BaseOneListener<System.Action>
{
    // Methods
    public void Invoke()
    {
        var val_5;
        int val_6;
        if(true == 0)
        {
                return;
        }
        
        val_5 = 0;
        val_6 = 13638;
        goto label_3;
        label_10:
        if(val_5 >= 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_5 = 28377088;
        val_5 = val_5 + 0;
        if(((28377088 + 0) + 32) != 0)
        {
                (28377088 + 0) + 32.Invoke();
        }
        
        val_6 = mem[(28377088 + 0) + 24];
        val_6 = (28377088 + 0) + 24;
        val_5 = 1;
        label_3:
        if(val_5 < ((System.Math.Min(val1:  13638, val2:  val_6)) << ))
        {
            goto label_10;
        }
        
        if(W9 == ((28377088 + 0) + 24 + 24))
        {
                return;
        }
        
        if(W9 < 0)
        {
                return;
        }
        
        var val_7 = (long)((28377088 + 0) + 24 + 24) - 1;
        var val_3 = ((28377088 + 0) + 24 + 24) - 2;
        do
        {
            if(val_7 >= ((28377088 + 0) + 24 + 24))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            var val_6 = (28377088 + 0) + 24 + 16;
            val_6 = val_6 + (((long)(int)(((28377088 + 0) + 24 + 24 - 1))) << 3);
            if((((28377088 + 0) + 24 + 16 + ((long)(int)(((28377088 + 0) + 24 + 24 - 1))) << 3) + 32) == 0)
        {
                0.RemoveAt(index:  val_3 + 1);
        }
        
            if((val_3 & 2147483648) != 0)
        {
                return;
        }
        
            val_7 = val_7 - 1;
            val_3 = val_3 - 1;
        }
        while(val_6 != 0);
        
        throw new NullReferenceException();
    }
    public OneListener()
    {
    
    }

}
