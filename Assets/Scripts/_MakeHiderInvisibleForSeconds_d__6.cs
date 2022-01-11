using UnityEngine;
private sealed class IgnoreWall.<MakeHiderInvisibleForSeconds>d__6 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Seeker seeker;
    public IgnoreWall <>4__this;
    public float duration;
    private UnityEngine.SkinnedMeshRenderer <renderer>5__2;
    private UnityEngine.Material <previousMaterial>5__3;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public IgnoreWall.<MakeHiderInvisibleForSeconds>d__6(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_16;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        this.<renderer>5__2 = this.seeker.skinnedMeshRenderer;
        UnityEngine.Material[] val_1 = this.seeker.skinnedMeshRenderer.sharedMaterials;
        this.<previousMaterial>5__3 = val_1[0];
        val_1[0] = this.<>4__this.material;
        this.<renderer>5__2.sharedMaterials = val_1;
        UnityEngine.Physics.IgnoreLayerCollision(layer1:  this.seeker.gameObject.layer, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  "Wall"), ignore:  true);
        val_16 = 1;
        UnityEngine.Physics.IgnoreLayerCollision(layer1:  this.seeker.mainCollider.gameObject.layer, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  "Door"), ignore:  true);
        this.<>2__current = new UnityEngine.WaitForSeconds(seconds:  this.duration);
        this.<>1__state = val_16;
        return (bool)val_16;
        label_1:
        this.<>1__state = 0;
        UnityEngine.Physics.IgnoreLayerCollision(layer1:  this.seeker.gameObject.layer, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  "Wall"), ignore:  false);
        UnityEngine.Physics.IgnoreLayerCollision(layer1:  this.seeker.mainCollider.gameObject.layer, layer2:  UnityEngine.LayerMask.NameToLayer(layerName:  "Door"), ignore:  false);
        UnityEngine.Material[] val_15 = this.<renderer>5__2.sharedMaterials;
        val_15[0] = this.<previousMaterial>5__3;
        this.<renderer>5__2.sharedMaterials = val_15;
        label_2:
        val_16 = 0;
        return (bool)val_16;
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
