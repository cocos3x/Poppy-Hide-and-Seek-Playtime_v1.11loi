using UnityEngine;
public static class ToastMessage
{
    // Methods
    public static void Show(string msg)
    {
        int val_7;
        var val_8;
        UnityEngine.AndroidJavaClass val_3 = new UnityEngine.AndroidJavaClass(className:  "android.widget.Toast");
        object[] val_4 = new object[3];
        val_7 = val_4.Length;
        val_4[0] = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        if(msg != null)
        {
                val_7 = val_4.Length;
        }
        
        val_4[1] = msg;
        val_4[2] = val_3.GetStatic<System.Int32>(fieldName:  "LENGTH_SHORT");
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_8 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_8 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_3.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "makeText", args:  val_4).Call(methodName:  "show", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
    }

}
