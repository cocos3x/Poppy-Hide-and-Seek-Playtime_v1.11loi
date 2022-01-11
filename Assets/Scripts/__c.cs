using UnityEngine;
[Serializable]
private sealed class GameLoadState.<>c
{
    // Fields
    public static readonly Game.States.GameLoadState.<>c <>9;
    public static System.Func<UnityEngine.Vector3, float> <>9__5_0;
    public static System.Func<UnityEngine.Vector3, float> <>9__5_1;
    public static System.Func<UnityEngine.Vector3, float> <>9__5_2;
    public static System.Func<UnityEngine.Vector3, float> <>9__5_3;
    
    // Methods
    private static GameLoadState.<>c()
    {
        GameLoadState.<>c.<>9 = new GameLoadState.<>c();
    }
    public GameLoadState.<>c()
    {
    
    }
    internal float <SceneManagerOnSceneLoaded>b__5_0(UnityEngine.Vector3 temp)
    {
        return (float)temp.x;
    }
    internal float <SceneManagerOnSceneLoaded>b__5_1(UnityEngine.Vector3 temp)
    {
        return (float)temp.z;
    }
    internal float <SceneManagerOnSceneLoaded>b__5_2(UnityEngine.Vector3 temp)
    {
        return (float)temp.x;
    }
    internal float <SceneManagerOnSceneLoaded>b__5_3(UnityEngine.Vector3 temp)
    {
        return (float)temp.z;
    }

}
