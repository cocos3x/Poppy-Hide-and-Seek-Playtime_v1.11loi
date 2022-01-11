using UnityEngine;
public static class ActionExtentions
{
    // Methods
    public static void SafeInvoke(System.Action invocationTarget)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        invocationTarget.Invoke();
    }
    public static void SafeInvoke<T>(System.Action<T> invocationTarget, T arg)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void SafeInvoke<T1, T2>(System.Action<T1, T2> invocationTarget, T1 arg1, T2 arg2)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void SafeInvoke<T1, T2, T3>(System.Action<T1, T2, T3> invocationTarget, T1 arg1, T2 arg2, T3 arg3)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void SafeInvoke<T1, T2, T3, T4>(System.Action<T1, T2, T3, T4> invocationTarget, T1 arg1, T2 arg2, T3 arg3, T4 arg4)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        goto __RuntimeMethodHiddenParam + 48;
    }
    public static void SafeInvoke(System.Action invocationTarget, System.Action<System.Exception> exceptionAction)
    {
        if(invocationTarget == null)
        {
                return;
        }
        
        invocationTarget.Invoke();
    }
    public static void SafeInvoke<T>(System.Action<T> invocationTarget, T arg, System.Action<System.Exception> exceptionAction)
    {
        if(invocationTarget == null)
        {
                return;
        }
    
    }
    public static void SafeInvoke<T1, T2>(System.Action<T1, T2> invocationTarget, T1 arg1, T2 arg2, System.Action<System.Exception> exceptionAction)
    {
        if(invocationTarget == null)
        {
                return;
        }
    
    }
    public static void SafeInvoke<T1, T2, T3>(System.Action<T1, T2, T3> invocationTarget, T1 arg1, T2 arg2, T3 arg3, System.Action<System.Exception> exceptionAction)
    {
        if(invocationTarget == null)
        {
                return;
        }
    
    }

}
