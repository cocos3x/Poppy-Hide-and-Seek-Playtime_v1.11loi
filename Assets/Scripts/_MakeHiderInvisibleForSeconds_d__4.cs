using UnityEngine;
private sealed class Invisibility.<MakeHiderInvisibleForSeconds>d__4 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Hider hider;
    public Invisibility <>4__this;
    public float duration;
    private UnityEngine.SkinnedMeshRenderer <renderer>5__2;
    private UnityEngine.Material <previousMaterial>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Invisibility.<MakeHiderInvisibleForSeconds>d__4(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_4;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        UnityEngine.SkinnedMeshRenderer val_4 = this.hider.skinnedMeshRenderers[0];
        this.<renderer>5__2 = val_4;
        UnityEngine.Material[] val_1 = val_4.sharedMaterials;
        this.<previousMaterial>5__3 = val_1[0];
        val_1[0] = this.<>4__this.material;
        this.<renderer>5__2.sharedMaterials = val_1;
        this.hider.canBeCaught = false;
        val_4 = 1;
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.duration);
        this.<>1__state = val_4;
        return (bool)val_4;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Material[] val_3 = this.<renderer>5__2.sharedMaterials;
        val_3[0] = this.<previousMaterial>5__3;
        this.<renderer>5__2.sharedMaterials = val_3;
        val_4 = 0;
        this.hider.canBeCaught = true;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
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
