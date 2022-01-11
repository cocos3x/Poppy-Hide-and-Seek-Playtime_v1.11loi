using UnityEngine;
private sealed class Reporter.<readInfo>d__188 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public Reporter <>4__this;
    private UnityEngine.Networking.UnityWebRequest <www>5__2;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public Reporter.<readInfo>d__188(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_16;
        string val_17;
        string val_18;
        int val_19;
        val_16 = this;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_2;
        }
        
        this.<>1__state = 0;
        val_17 = "build_info";
        if((IndexOf(value:  "://")) == 1)
        {
                string val_2 = UnityEngine.Application.streamingAssetsPath;
            val_18 = val_2;
            if((System.String.op_Equality(a:  val_2, b:  "")) != false)
        {
                val_18 = UnityEngine.Application.dataPath + "/StreamingAssets/"("/StreamingAssets/");
        }
        
            val_17 = System.IO.Path.Combine(path1:  val_18, path2:  val_17);
        }
        
        if((val_17.Contains(value:  "://")) != true)
        {
                val_17 = "file://"("file://") + val_17;
        }
        
        UnityEngine.Networking.UnityWebRequest val_9 = UnityEngine.Networking.UnityWebRequest.Get(uri:  val_17);
        this.<www>5__2 = val_9;
        this.<>2__current = val_9.SendWebRequest();
        val_19 = 1;
        this.<>1__state = val_19;
        return (bool)val_19;
        label_1:
        this.<>1__state = 0;
        if((System.String.IsNullOrEmpty(value:  this.<www>5__2.error)) != false)
        {
                val_19 = 0;
            this.<>4__this.buildDate = this.<www>5__2.downloadHandler.text;
            return (bool)val_19;
        }
        
        val_16 = this.<www>5__2.error;
        UnityEngine.Debug.LogError(message:  val_16);
        label_2:
        val_19 = 0;
        return (bool)val_19;
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
