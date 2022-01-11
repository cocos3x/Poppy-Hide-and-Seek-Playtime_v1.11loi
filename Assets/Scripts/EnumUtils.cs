using UnityEngine;
public class EnumUtils
{
    // Fields
    private static readonly System.Collections.Generic.Dictionary<System.Type, int> EnumCount;
    
    // Methods
    public static int GetCount<T>()
    {
        var val_6;
        var val_7;
        System.Type val_1 = System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48});
        if((val_1 & 1) == 0)
        {
                return val_5;
        }
        
        val_6 = null;
        val_6 = null;
        if((EnumUtils.EnumCount.TryGetValue(key:  val_1, value: out  0)) == true)
        {
                return val_5;
        }
        
        int val_5 = System.Enum.GetValues(enumType:  val_1).Length;
        val_7 = null;
        val_7 = null;
        EnumUtils.EnumCount.Add(key:  val_1, value:  val_5);
        return val_5;
    }
    public static TEnum[] GetValues<TEnum>()
    {
        System.Array val_2 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}));
        goto __RuntimeMethodHiddenParam + 48 + 16;
    }
    public static TEnum Parse<TEnum>(object value)
    {
        var val_3;
        if((System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), value:  value)) != null)
        {
                if(X0 == true)
        {
                return (object)val_3;
        }
        
        }
        
        val_3 = 0;
        return (object)val_3;
    }
    public static bool TryParse<TEnum>(object value, out TEnum result)
    {
        var val_5;
        object val_6;
        object val_7;
        var val_8;
        val_5 = 1152921507107217536;
        val_6 = value;
        if((System.Enum.IsDefined(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), value:  val_6)) == false)
        {
            goto label_5;
        }
        
        val_6 = System.Enum.Parse(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48}), value:  val_6);
        if(val_6 == null)
        {
            goto label_12;
        }
        
        if(X0 == true)
        {
            goto label_13;
        }
        
        label_5:
        val_8 = 0;
        result = 0;
        return (bool)val_8;
        label_12:
        val_7 = 0;
        label_13:
        result = val_7;
        val_5 = mem[__RuntimeMethodHiddenParam + 48 + 8];
        val_5 = __RuntimeMethodHiddenParam + 48 + 8;
        if(val_6 != null)
        {
                if(X0 == false)
        {
            goto label_17;
        }
        
        }
        
        val_8 = 1;
        return (bool)val_8;
        label_17:
    }
    public EnumUtils()
    {
    
    }
    private static EnumUtils()
    {
        EnumUtils.EnumCount = new System.Collections.Generic.Dictionary<System.Type, System.Int32>();
    }

}
