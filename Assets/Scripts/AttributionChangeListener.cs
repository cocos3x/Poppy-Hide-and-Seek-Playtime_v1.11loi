using UnityEngine;
private class AdjustAndroid.AttributionChangeListener : AndroidJavaProxy
{
    // Fields
    private System.Action<com.adjust.sdk.AdjustAttribution> callback;
    
    // Methods
    public AdjustAndroid.AttributionChangeListener(System.Action<com.adjust.sdk.AdjustAttribution> pCallback)
    {
        this.callback = pCallback;
    }
    public void onAttributionChanged(UnityEngine.AndroidJavaObject attribution)
    {
        com.adjust.sdk.AdjustAttribution val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        var val_54;
        var val_55;
        var val_56;
        var val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        if(this.callback == null)
        {
                return;
        }
        
        com.adjust.sdk.AdjustAttribution val_1 = null;
        val_36 = val_1;
        val_1 = new com.adjust.sdk.AdjustAttribution();
        val_37 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName), b:  "")) != true)
        {
                val_38 = null;
            val_38 = null;
        }
        
        .<trackerName>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
        val_39 = null;
        val_39 = null;
        val_40 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken), b:  "")) != true)
        {
                val_41 = null;
            val_41 = null;
        }
        
        .<trackerToken>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
        val_42 = null;
        val_42 = null;
        val_43 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork), b:  "")) != true)
        {
                val_44 = null;
            val_44 = null;
        }
        
        .<network>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
        val_45 = null;
        val_45 = null;
        val_46 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign), b:  "")) != true)
        {
                val_47 = null;
            val_47 = null;
        }
        
        .<campaign>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
        val_48 = null;
        val_48 = null;
        val_49 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup), b:  "")) != true)
        {
                val_50 = null;
            val_50 = null;
        }
        
        .<adgroup>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
        val_51 = null;
        val_51 = null;
        val_52 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative), b:  "")) != true)
        {
                val_53 = null;
            val_53 = null;
        }
        
        .<creative>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
        val_54 = null;
        val_54 = null;
        val_55 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel), b:  "")) != true)
        {
                val_56 = null;
            val_56 = null;
        }
        
        .<clickLabel>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
        val_57 = null;
        val_57 = null;
        val_58 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != true)
        {
                val_59 = null;
            val_59 = null;
        }
        
        .<adid>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
        val_60 = null;
        val_60 = null;
        val_61 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType), b:  "")) != true)
        {
                val_62 = null;
            val_62 = null;
        }
        
        .<costType>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
        val_63 = null;
        val_63 = null;
        if((attribution.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount)) == null)
        {
            goto label_54;
        }
        
        val_64 = null;
        val_64 = null;
        UnityEngine.AndroidJavaObject val_30 = attribution.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
        if(val_30 == null)
        {
            goto label_54;
        }
        
        val_65 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_65 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        val_65 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
        val_65 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
        double val_31 = val_30.Call<System.Double>(methodName:  "doubleValue", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        .<costAmount>k__BackingField = 0;
        goto label_61;
        label_54:
        .<costAmount>k__BackingField = 0;
        mem[1152921507344029200] = 0;
        label_61:
        val_66 = null;
        val_66 = null;
        val_67 = 0;
        if((System.String.op_Equality(a:  attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency), b:  "")) != true)
        {
                val_68 = null;
            val_68 = null;
        }
        
        .<costCurrency>k__BackingField = attribution.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
        this.callback.Invoke(obj:  val_1);
    }

}
