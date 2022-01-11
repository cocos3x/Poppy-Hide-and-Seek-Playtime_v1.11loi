using UnityEngine;
public class Reporter.Sample
{
    // Fields
    public float time;
    public byte loadedScene;
    public float memory;
    public float fps;
    public string fpsText;
    
    // Methods
    public static float MemSize()
    {
        return 13f;
    }
    public string GetSceneName()
    {
        var val_1;
        var val_2;
        if(this.loadedScene != 255)
        {
                val_1 = null;
            val_1 = null;
            System.String[] val_1 = Reporter.scenes;
            val_1 = val_1 + ((this.loadedScene) << 3);
            return (string)val_2;
        }
        
        val_2 = "AssetBundleScene";
        return (string)val_2;
    }
    public Reporter.Sample()
    {
    
    }

}
