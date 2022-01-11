using UnityEngine;
public abstract class BaseOneListener<T> : IEnumerable<T>, IEnumerable
{
    // Fields
    protected readonly System.Collections.Generic.List<T> _list;
    protected int _count;
    
    // Properties
    public int Count { get; }
    
    // Methods
    public void Add(T action)
    {
        var val_6;
        var val_7;
        var val_8;
        val_6 = this;
        val_7 = __RuntimeMethodHiddenParam;
        val_8 = action;
        if(this != 1)
        {
                if((__RuntimeMethodHiddenParam + 24 + 192) == 1)
        {
                return;
        }
        
            val_6 = ???;
            val_8 = ???;
            val_7 = ???;
        }
        else
        {
                var val_6 = val_6 + 24;
            val_6 = val_6 + 1;
            mem2[0] = val_6;
        }
    
    }
    public void Remove(T action)
    {
        if(this == 1)
        {
                return;
        }
        
        var val_1 = __RuntimeMethodHiddenParam + 24 + 192 + 16;
        val_1 = val_1 - 1;
        mem[1152921507102118520] = val_1;
    }
    public void RemoveAll()
    {
        mem[1152921507102234616] = 0;
    }
    public bool Contains(T action)
    {
        if(this != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }
    public int get_Count()
    {
        return (int)this;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        if(this != null)
        {
            
        }
        else
        {
                throw new NullReferenceException();
        }
    
    }
    public System.Collections.Generic.IEnumerator<T> GetEnumerator()
    {
        return (System.Collections.Generic.IEnumerator<T>);
    }
    protected BaseOneListener<T>()
    {
        mem[1152921507102802800] = __RuntimeMethodHiddenParam + 24 + 192 + 64;
    }

}
