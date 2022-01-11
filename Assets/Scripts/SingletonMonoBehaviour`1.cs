using UnityEngine;
public class SingletonMonoBehaviour<T> : MonoBehaviour
{
    // Fields
    protected static T instance;
    public bool dontDestroyOnLoad;
    protected bool isDuplicateIntance;
    
    // Properties
    public static T Instance { get; }
    public static bool IsInstanceExisting { get; }
    
    // Methods
    public static T get_Instance()
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
                val_6 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_6 = __RuntimeMethodHiddenParam + 24 + 302;
            val_7 = __RuntimeMethodHiddenParam + 24;
            if((val_6 & 1) == 0)
        {
                val_7 = mem[__RuntimeMethodHiddenParam + 24];
            val_7 = __RuntimeMethodHiddenParam + 24;
            val_6 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_6 = __RuntimeMethodHiddenParam + 24 + 302;
        }
        
            mem2[0] = __RuntimeMethodHiddenParam + 24 + 192 + 16;
            if((__RuntimeMethodHiddenParam + 24 + 192 + 184) == 0)
        {
                val_8 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 302;
            val_9 = __RuntimeMethodHiddenParam + 24;
            if((val_8 & 1) == 0)
        {
                val_9 = mem[__RuntimeMethodHiddenParam + 24];
            val_9 = __RuntimeMethodHiddenParam + 24;
            val_8 = mem[__RuntimeMethodHiddenParam + 24 + 302];
            val_8 = __RuntimeMethodHiddenParam + 24 + 302;
        }
        
            mem2[0] = new UnityEngine.GameObject();
            __RuntimeMethodHiddenParam + 24 + 192 + 184.name = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192 + 32});
        }
        
            if((X0 + 24) != 0)
        {
                UnityEngine.Object.DontDestroyOnLoad(target:  X0.gameObject);
        }
        
        }
        
        if(((__RuntimeMethodHiddenParam + 24 + 192 + 302) & 1) != 0)
        {
                return (AdManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
        }
        
        return (AdManager)__RuntimeMethodHiddenParam + 24 + 192 + 184;
    }
    public static bool get_IsInstanceExisting()
    {
        return UnityEngine.Object.op_Inequality(x:  __RuntimeMethodHiddenParam + 24 + 192 + 184, y:  0);
    }
    public virtual void Awake()
    {
        var val_6;
        var val_7;
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184) != 0)
        {
            goto label_5;
        }
        
        val_6 = mem[__RuntimeMethodHiddenParam + 24 + 192 + 8];
        val_6 = __RuntimeMethodHiddenParam + 24 + 192 + 8;
        if(X0 == false)
        {
            goto label_8;
        }
        
        if(X0 == true)
        {
            goto label_9;
        }
        
        label_5:
        if((__RuntimeMethodHiddenParam + 24 + 192 + 184.GetInstanceID()) == this.GetInstanceID())
        {
                return;
        }
        
        mem[1152921507163078393] = 1;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        return;
        label_8:
        val_7 = 0;
        label_9:
        mem2[0] = val_7;
        if((__RuntimeMethodHiddenParam + 24 + 192 + 8 + 302) == 0)
        {
                return;
        }
        
        UnityEngine.Object.DontDestroyOnLoad(target:  __RuntimeMethodHiddenParam + 24 + 192 + 184.gameObject);
    }
    public SingletonMonoBehaviour<T>()
    {
        mem[1152921507163198584] = 1;
        if(val_1 != null)
        {
                return;
        }
        
        throw new NullReferenceException();
    }

}
