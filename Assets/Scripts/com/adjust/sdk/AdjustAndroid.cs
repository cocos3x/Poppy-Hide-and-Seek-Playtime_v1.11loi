using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustAndroid
    {
        // Fields
        private const string sdkPrefix = "unity4.28.0";
        private static bool launchDeferredDeeplink;
        private static UnityEngine.AndroidJavaClass ajcAdjust;
        private static UnityEngine.AndroidJavaObject ajoCurrentActivity;
        private static com.adjust.sdk.AdjustAndroid.DeferredDeeplinkListener onDeferredDeeplinkListener;
        private static com.adjust.sdk.AdjustAndroid.AttributionChangeListener onAttributionChangedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingFailedListener onEventTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.EventTrackingSucceededListener onEventTrackingSucceededListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingFailedListener onSessionTrackingFailedListener;
        private static com.adjust.sdk.AdjustAndroid.SessionTrackingSucceededListener onSessionTrackingSucceededListener;
        
        // Methods
        public static void Start(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            System.Object[] val_53;
            var val_54;
            int val_55;
            var val_56;
            var val_57;
            int val_58;
            var val_59;
            var val_60;
            string val_61;
            var val_62;
            var val_63;
            string val_64;
            var val_65;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            object val_1 = (adjustConfig.environment == 1) ? "production" : "sandbox";
            if(W11 != 0)
            {
                    val_53 = new object[4];
                val_54 = null;
                val_54 = null;
                val_55 = val_2.Length;
                val_53[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                if(adjustConfig.appToken != null)
            {
                    val_55 = val_2.Length;
            }
            
                val_53[1] = adjustConfig.appToken;
                if(val_1 != 0)
            {
                    val_55 = val_2.Length;
            }
            
                val_53[2] = val_1;
                val_56 = 1152921504622981120;
                val_53[3] = adjustConfig.allowSuppressLogLevel;
            }
            else
            {
                    object[] val_3 = new object[3];
                val_53 = val_3;
                val_57 = null;
                val_57 = null;
                val_58 = val_3.Length;
                val_53[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
                if(adjustConfig.appToken != null)
            {
                    val_58 = val_3.Length;
            }
            
                val_53[1] = adjustConfig.appToken;
                if(val_1 != 0)
            {
                    val_58 = val_3.Length;
            }
            
                val_53[2] = val_1;
            }
            
            UnityEngine.AndroidJavaObject val_4 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustConfig", args:  val_3);
            val_59 = null;
            val_59 = null;
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = adjustConfig.launchDeferredDeeplink;
            if(com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink != false)
            {
                    val_60 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel).Equals(value:  "SUPPRESS");
                if(val_60 != false)
            {
                    val_56 = 1152921507168217872;
                val_61 = "SUPRESS";
                val_62 = public UnityEngine.AndroidJavaObject UnityEngine.AndroidJavaObject::GetStatic<UnityEngine.AndroidJavaObject>(string fieldName);
            }
            else
            {
                    val_61 = com.adjust.sdk.AdjustLogLevelExtension.ToUppercaseString(AdjustLogLevel:  adjustConfig.logLevel);
                val_62 = public UnityEngine.AndroidJavaObject UnityEngine.AndroidJavaObject::GetStatic<UnityEngine.AndroidJavaObject>(string fieldName);
            }
            
                UnityEngine.AndroidJavaObject val_9 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.LogLevel").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  val_61);
                if(val_9 != null)
            {
                    object[] val_10 = new object[1];
                val_10[0] = val_9;
                val_4.Call(methodName:  "setLogLevel", args:  val_10);
            }
            
            }
            
            object[] val_11 = new object[1];
            val_11[0] = "unity4.28.0";
            val_4.Call(methodName:  "setSdkPrefix", args:  val_11);
            object[] val_12 = new object[1];
            val_12[0] = adjustConfig.delayStart;
            val_4.Call(methodName:  "setDelayStart", args:  val_12);
            object[] val_13 = new object[1];
            val_13[0] = adjustConfig.eventBufferingEnabled & 1;
            object[] val_16 = new object[1];
            val_16[0] = new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_13);
            val_4.Call(methodName:  "setEventBufferingEnabled", args:  val_16);
            object[] val_17 = new object[1];
            val_17[0] = adjustConfig.sendInBackground & 1;
            val_4.Call(methodName:  "setSendInBackground", args:  val_17);
            object[] val_19 = new object[1];
            val_19[0] = adjustConfig.needsCost & 1;
            val_4.Call(methodName:  "setNeedsCost", args:  val_19);
            object[] val_21 = new object[1];
            val_21[0] = adjustConfig.preinstallTrackingEnabled & 1;
            val_4.Call(methodName:  "setPreinstallTrackingEnabled", args:  val_21);
            if(adjustConfig.userAgent != null)
            {
                    object[] val_23 = new object[1];
                val_23[0] = adjustConfig.userAgent;
                val_4.Call(methodName:  "setUserAgent", args:  val_23);
            }
            
            if((System.String.IsNullOrEmpty(value:  adjustConfig.processName)) != true)
            {
                    object[] val_25 = new object[1];
                val_25[0] = adjustConfig.processName;
                val_4.Call(methodName:  "setProcessName", args:  val_25);
            }
            
            if(adjustConfig.defaultTracker != null)
            {
                    object[] val_26 = new object[1];
                val_26[0] = adjustConfig.defaultTracker;
                val_4.Call(methodName:  "setDefaultTracker", args:  val_26);
            }
            
            if(adjustConfig.externalDeviceId != null)
            {
                    object[] val_27 = new object[1];
                val_27[0] = adjustConfig.externalDeviceId;
                val_4.Call(methodName:  "setExternalDeviceId", args:  val_27);
            }
            
            if(adjustConfig.urlStrategy == null)
            {
                goto label_105;
            }
            
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  "china")) == false)
            {
                goto label_99;
            }
            
            UnityEngine.AndroidJavaClass val_29 = null;
            val_63 = val_29;
            val_29 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.AdjustConfig");
            val_64 = "URL_STRATEGY_CHINA";
            goto label_104;
            label_99:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  "india")) == false)
            {
                goto label_102;
            }
            
            UnityEngine.AndroidJavaClass val_31 = null;
            val_63 = val_31;
            val_31 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.AdjustConfig");
            val_64 = "URL_STRATEGY_INDIA";
            goto label_104;
            label_102:
            if((System.String.op_Equality(a:  adjustConfig.urlStrategy, b:  "data-residency-eu")) == false)
            {
                goto label_105;
            }
            
            UnityEngine.AndroidJavaClass val_33 = null;
            val_63 = val_33;
            val_33 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.AdjustConfig");
            val_64 = "DATA_RESIDENCY_EU";
            label_104:
            object[] val_35 = new object[1];
            val_35[0] = val_33.GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  val_64);
            val_4.Call(methodName:  "setUrlStrategy", args:  val_35);
            label_105:
            if((com.adjust.sdk.AdjustAndroid.IsAppSecretSet(adjustConfig:  adjustConfig)) != false)
            {
                    object[] val_37 = new object[5];
                val_60 = 1152921507338665776;
                val_37[0] = adjustConfig.secretId;
                val_37[1] = adjustConfig.info1;
                val_37[2] = adjustConfig.info2;
                val_37[3] = adjustConfig.info3;
                val_37[4] = adjustConfig.info4;
                val_4.Call(methodName:  "setAppSecret", args:  val_37);
            }
            
            object[] val_38 = new object[1];
            val_38[0] = adjustConfig.isDeviceKnown & 1;
            val_4.Call(methodName:  "setDeviceKnown", args:  val_38);
            if(adjustConfig.attributionChangedDelegate != null)
            {
                    val_65 = null;
                val_65 = null;
                com.adjust.sdk.AdjustAndroid.onAttributionChangedListener = new AdjustAndroid.AttributionChangeListener(pCallback:  adjustConfig.attributionChangedDelegate);
                object[] val_41 = new object[1];
                val_41[0] = com.adjust.sdk.AdjustAndroid.onAttributionChangedListener;
                val_4.Call(methodName:  "setOnAttributionChangedListener", args:  val_41);
            }
            
            if(adjustConfig.eventSuccessDelegate != null)
            {
                    val_66 = null;
                val_66 = null;
                com.adjust.sdk.AdjustAndroid.onEventTrackingSucceededListener = new AdjustAndroid.EventTrackingSucceededListener(pCallback:  adjustConfig.eventSuccessDelegate);
                object[] val_43 = new object[1];
                val_43[0] = com.adjust.sdk.AdjustAndroid.onEventTrackingSucceededListener;
                val_4.Call(methodName:  "setOnEventTrackingSucceededListener", args:  val_43);
            }
            
            if(adjustConfig.eventFailureDelegate != null)
            {
                    val_67 = null;
                val_67 = null;
                com.adjust.sdk.AdjustAndroid.onEventTrackingFailedListener = new AdjustAndroid.EventTrackingFailedListener(pCallback:  adjustConfig.eventFailureDelegate);
                object[] val_45 = new object[1];
                val_45[0] = com.adjust.sdk.AdjustAndroid.onEventTrackingFailedListener;
                val_4.Call(methodName:  "setOnEventTrackingFailedListener", args:  val_45);
            }
            
            if(adjustConfig.sessionSuccessDelegate != null)
            {
                    val_68 = null;
                val_68 = null;
                com.adjust.sdk.AdjustAndroid.onSessionTrackingSucceededListener = new AdjustAndroid.SessionTrackingSucceededListener(pCallback:  adjustConfig.sessionSuccessDelegate);
                object[] val_47 = new object[1];
                val_47[0] = com.adjust.sdk.AdjustAndroid.onSessionTrackingSucceededListener;
                val_4.Call(methodName:  "setOnSessionTrackingSucceededListener", args:  val_47);
            }
            
            if(adjustConfig.sessionFailureDelegate != null)
            {
                    val_69 = null;
                val_69 = null;
                com.adjust.sdk.AdjustAndroid.onSessionTrackingFailedListener = new AdjustAndroid.SessionTrackingFailedListener(pCallback:  adjustConfig.sessionFailureDelegate);
                object[] val_49 = new object[1];
                val_49[0] = com.adjust.sdk.AdjustAndroid.onSessionTrackingFailedListener;
                val_4.Call(methodName:  "setOnSessionTrackingFailedListener", args:  val_49);
            }
            
            if(adjustConfig.deferredDeeplinkDelegate != null)
            {
                    val_70 = null;
                val_70 = null;
                com.adjust.sdk.AdjustAndroid.onDeferredDeeplinkListener = new AdjustAndroid.DeferredDeeplinkListener(pCallback:  adjustConfig.deferredDeeplinkDelegate);
                object[] val_51 = new object[1];
                val_51[0] = com.adjust.sdk.AdjustAndroid.onDeferredDeeplinkListener;
                val_4.Call(methodName:  "setOnDeeplinkResponseListener", args:  val_51);
            }
            
            val_71 = null;
            val_71 = null;
            object[] val_52 = new object[1];
            val_52[0] = val_4;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onCreate", args:  val_52);
            val_72 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_72 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_72 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_72 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onResume", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void TrackEvent(com.adjust.sdk.AdjustEvent adjustEvent)
        {
            int val_11;
            System.Collections.Generic.List<System.String> val_12;
            var val_13;
            object val_14;
            int val_15;
            System.Collections.Generic.List<System.String> val_16;
            object val_17;
            int val_18;
            var val_19;
            object[] val_1 = new object[1];
            val_1[0] = adjustEvent.eventToken;
            UnityEngine.AndroidJavaObject val_2 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustEvent", args:  val_1);
            object[] val_3 = new object[2];
            val_11 = val_3.Length;
            val_3[0] = ???;
            if(adjustEvent.currency != null)
            {
                    val_11 = val_3.Length;
            }
            
            val_3[1] = adjustEvent.currency;
            val_2.Call(methodName:  "setRevenue", args:  val_3);
            val_12 = adjustEvent.callbackList;
            if(val_12 == null)
            {
                goto label_16;
            }
            
            val_13 = "addCallbackParameter";
            label_29:
            if(0 >= "setRevenue")
            {
                goto label_16;
            }
            
            if("setRevenue" > 0)
            {
                    val_14 = 15849432;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_12 = adjustEvent.callbackList;
                val_14 = X9 + 0;
            }
            
            val_14 = val_14 + 32;
            var val_4 = 0 + 1;
            if(W9 <= val_4)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_14 = val_14 + (val_4 << 3);
            object[] val_5 = new object[2];
            val_15 = val_5.Length;
            val_5[0] = val_14;
            if(((((X9 + 0) + 32) + ((0 + 1)) << 3) + 32) != 0)
            {
                    val_15 = val_5.Length;
            }
            
            val_5[1] = (((X9 + 0) + 32) + ((0 + 1)) << 3) + 32;
            val_2.Call(methodName:  "addCallbackParameter", args:  val_5);
            var val_6 = val_4 + 1;
            if(adjustEvent.callbackList != null)
            {
                goto label_29;
            }
            
            label_16:
            val_16 = adjustEvent.partnerList;
            if(val_16 == null)
            {
                goto label_32;
            }
            
            val_13 = "addPartnerParameter";
            label_45:
            if(0 >= "setRevenue")
            {
                goto label_32;
            }
            
            if("setRevenue" > 0)
            {
                    val_17 = 15849432;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_16 = adjustEvent.partnerList;
                val_17 = X9 + 0;
            }
            
            val_17 = val_17 + 32;
            var val_7 = 0 + 1;
            if(W9 <= val_7)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_17 = val_17 + (val_7 << 3);
            object[] val_8 = new object[2];
            val_18 = val_8.Length;
            val_8[0] = val_17;
            if(((((X9 + 0) + 32) + ((0 + 1)) << 3) + 32) != 0)
            {
                    val_18 = val_8.Length;
            }
            
            val_8[1] = (((X9 + 0) + 32) + ((0 + 1)) << 3) + 32;
            val_2.Call(methodName:  "addPartnerParameter", args:  val_8);
            var val_9 = val_7 + 1;
            if(adjustEvent.partnerList != null)
            {
                goto label_45;
            }
            
            label_32:
            if(adjustEvent.transactionId != null)
            {
                    object[] val_10 = new object[1];
                val_10[0] = adjustEvent.transactionId;
                val_2.Call(methodName:  "setOrderId", args:  val_10);
            }
            
            if(adjustEvent.callbackId != null)
            {
                    object[] val_11 = new object[1];
                val_11[0] = adjustEvent.callbackId;
                val_2.Call(methodName:  "setCallbackId", args:  val_11);
            }
            
            val_19 = null;
            val_19 = null;
            object[] val_12 = new object[1];
            val_12[0] = val_2;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "trackEvent", args:  val_12);
        }
        public static bool IsEnabled()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.Boolean>(methodName:  "isEnabled", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void SetEnabled(bool enabled)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = enabled;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setEnabled", args:  val_2);
        }
        public static void SetOfflineMode(bool enabled)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = enabled;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setOfflineMode", args:  val_2);
        }
        public static void SendFirstPackages()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "sendFirstPackages", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void SetDeviceToken(string deviceToken)
        {
            var val_2;
            int val_3;
            val_2 = null;
            val_2 = null;
            object[] val_1 = new object[2];
            val_3 = val_1.Length;
            val_1[0] = deviceToken;
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setPushToken", args:  val_1);
        }
        public static string GetAdid()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAdid", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void GdprForgetMe()
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "gdprForgetMe", args:  val_1);
        }
        public static void DisableThirdPartySharing()
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "disableThirdPartySharing", args:  val_1);
        }
        public static com.adjust.sdk.AdjustAttribution GetAttribution()
        {
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
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            val_37 = null;
            val_37 = null;
            val_38 = public static T[] System.Array::Empty<System.Object>();
            val_39 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_39 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_39 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_39 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    throw new NullReferenceException();
            }
            
            UnityEngine.AndroidJavaObject val_1 = com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "getAttribution", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            if(val_1 == null)
            {
                goto label_10;
            }
            
            com.adjust.sdk.AdjustAttribution val_2 = null;
            val_40 = val_2;
            val_2 = new com.adjust.sdk.AdjustAttribution();
            val_41 = null;
            val_41 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName), b:  "")) == false)
            {
                goto label_13;
            }
            
            val_42 = 0;
            if(val_40 != null)
            {
                goto label_14;
            }
            
            label_13:
            val_43 = null;
            val_43 = null;
            label_14:
            .<trackerName>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerName);
            val_44 = null;
            val_44 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken), b:  "")) != false)
            {
                    val_45 = 0;
            }
            else
            {
                    val_46 = null;
                val_46 = null;
            }
            
            .<trackerToken>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyTrackerToken);
            val_47 = null;
            val_47 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork), b:  "")) != false)
            {
                    val_48 = 0;
            }
            else
            {
                    val_49 = null;
                val_49 = null;
            }
            
            .<network>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyNetwork);
            val_50 = null;
            val_50 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign), b:  "")) != false)
            {
                    val_51 = 0;
            }
            else
            {
                    val_52 = null;
                val_52 = null;
            }
            
            .<campaign>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCampaign);
            val_53 = null;
            val_53 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup), b:  "")) != false)
            {
                    val_54 = 0;
            }
            else
            {
                    val_55 = null;
                val_55 = null;
            }
            
            .<adgroup>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdgroup);
            val_56 = null;
            val_56 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative), b:  "")) != false)
            {
                    val_57 = 0;
            }
            else
            {
                    val_58 = null;
                val_58 = null;
            }
            
            .<creative>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCreative);
            val_59 = null;
            val_59 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel), b:  "")) != false)
            {
                    val_60 = 0;
            }
            else
            {
                    val_61 = null;
                val_61 = null;
            }
            
            .<clickLabel>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyClickLabel);
            val_62 = null;
            val_62 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid), b:  "")) != false)
            {
                    val_63 = 0;
            }
            else
            {
                    val_64 = null;
                val_64 = null;
            }
            
            .<adid>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyAdid);
            val_65 = null;
            val_65 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType), b:  "")) != false)
            {
                    val_66 = 0;
            }
            else
            {
                    val_67 = null;
                val_67 = null;
            }
            
            .<costType>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostType);
            val_68 = null;
            val_68 = null;
            val_38 = 1152921507340525776;
            if((val_1.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount)) == null)
            {
                goto label_72;
            }
            
            val_69 = null;
            val_69 = null;
            UnityEngine.AndroidJavaObject val_31 = val_1.Get<UnityEngine.AndroidJavaObject>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostAmount);
            val_38 = val_31;
            if(val_31 == null)
            {
                goto label_72;
            }
            
            val_70 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_70 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_70 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_70 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            double val_32 = val_38.Call<System.Double>(methodName:  "doubleValue", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
            .<costAmount>k__BackingField = 0;
            goto label_79;
            label_72:
            .<costAmount>k__BackingField = 0;
            mem[1152921507340605520] = 0;
            label_79:
            val_71 = null;
            val_71 = null;
            if((System.String.op_Equality(a:  val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency), b:  "")) != false)
            {
                    val_72 = 0;
            }
            else
            {
                    val_73 = null;
                val_73 = null;
            }
            
            .<costCurrency>k__BackingField = val_1.Get<System.String>(fieldName:  com.adjust.sdk.AdjustUtils.KeyCostCurrency);
            return (com.adjust.sdk.AdjustAttribution)val_40;
            label_10:
            val_40 = 0;
            return (com.adjust.sdk.AdjustAttribution)val_40;
        }
        public static void AddSessionPartnerParameter(string key, string value)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[2];
            val_4 = val_2.Length;
            val_2[0] = key;
            if(value != null)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[1] = value;
            val_1.CallStatic(methodName:  "addSessionPartnerParameter", args:  val_2);
        }
        public static void AddSessionCallbackParameter(string key, string value)
        {
            var val_3;
            int val_4;
            val_3 = null;
            val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[2];
            val_4 = val_2.Length;
            val_2[0] = key;
            if(value != null)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[1] = value;
            val_1.CallStatic(methodName:  "addSessionCallbackParameter", args:  val_2);
        }
        public static void RemoveSessionPartnerParameter(string key)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = key;
            val_1.CallStatic(methodName:  "removeSessionPartnerParameter", args:  val_2);
        }
        public static void RemoveSessionCallbackParameter(string key)
        {
            var val_3 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_3 = null;
                val_3 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = key;
            val_1.CallStatic(methodName:  "removeSessionCallbackParameter", args:  val_2);
        }
        public static void ResetSessionPartnerParameters()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1.CallStatic(methodName:  "resetSessionPartnerParameters", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void ResetSessionCallbackParameters()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_2 = null;
                val_2 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_1.CallStatic(methodName:  "resetSessionCallbackParameters", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void AppWillOpenUrl(string url)
        {
            var val_5;
            int val_6;
            object[] val_2 = new object[1];
            val_2[0] = url;
            val_5 = null;
            val_5 = null;
            object[] val_4 = new object[2];
            val_6 = val_4.Length;
            val_4[0] = new UnityEngine.AndroidJavaClass(className:  "android.net.Uri").CallStatic<UnityEngine.AndroidJavaObject>(methodName:  "parse", args:  val_2);
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                    val_6 = val_4.Length;
            }
            
            val_4[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "appWillOpenUrl", args:  val_4);
        }
        public static void TrackAdRevenue(string source, string payload)
        {
            var val_5;
            var val_6;
            var val_7;
            int val_8;
            val_5 = null;
            val_5 = null;
            if(com.adjust.sdk.AdjustAndroid.ajcAdjust == null)
            {
                    UnityEngine.AndroidJavaClass val_1 = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
                val_6 = null;
                val_6 = null;
                com.adjust.sdk.AdjustAndroid.ajcAdjust = val_1;
            }
            
            object[] val_2 = new object[1];
            val_2[0] = payload;
            UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaObject(className:  "org.json.JSONObject", args:  val_2);
            val_7 = null;
            val_7 = null;
            object[] val_4 = new object[2];
            val_8 = val_4.Length;
            val_4[0] = source;
            if(val_3 != null)
            {
                    val_8 = val_4.Length;
            }
            
            val_4[1] = val_3;
            val_1.CallStatic(methodName:  "trackAdRevenue", args:  val_4);
        }
        public static void TrackPlayStoreSubscription(com.adjust.sdk.AdjustPlayStoreSubscription subscription)
        {
            int val_15;
            System.Collections.Generic.List<System.String> val_16;
            var val_17;
            var val_18;
            int val_19;
            System.Collections.Generic.List<System.String> val_20;
            var val_21;
            int val_22;
            var val_23;
            object[] val_1 = new object[6];
            val_15 = val_1.Length;
            val_1[0] = System.Convert.ToInt64(value:  subscription.price);
            if(subscription.currency != null)
            {
                    val_15 = val_1.Length;
            }
            
            val_1[1] = subscription.currency;
            if(subscription.sku != null)
            {
                    val_15 = val_1.Length;
            }
            
            val_1[2] = subscription.sku;
            if(subscription.orderId != null)
            {
                    val_15 = val_1.Length;
            }
            
            val_1[3] = subscription.orderId;
            if(subscription.signature != null)
            {
                    val_15 = val_1.Length;
            }
            
            val_1[4] = subscription.signature;
            if(subscription.purchaseToken != null)
            {
                    val_15 = val_1.Length;
            }
            
            val_1[5] = subscription.purchaseToken;
            UnityEngine.AndroidJavaObject val_3 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustPlayStoreSubscription", args:  val_1);
            if(subscription.purchaseTime != null)
            {
                    object[] val_4 = new object[1];
                val_4[0] = System.Convert.ToInt64(value:  subscription.purchaseTime);
                val_3.Call(methodName:  "setPurchaseTime", args:  val_4);
            }
            
            val_16 = subscription.callbackList;
            if(val_16 == null)
            {
                goto label_32;
            }
            
            val_17 = "addCallbackParameter";
            label_45:
            if(0 >= "setPurchaseTime")
            {
                goto label_32;
            }
            
            if("setPurchaseTime" > 0)
            {
                    val_18 = 15750360;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_16 = subscription.callbackList;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            object[] val_9 = new object[2];
            val_19 = val_9.Length;
            val_9[0] = null;
            val_19 = val_9.Length;
            val_9[1] = (((System.Convert.__il2cppRuntimeField_cctor_finished + 0) + 32) + ((0 + 1)) << 3) + 32;
            val_3.Call(methodName:  "addCallbackParameter", args:  val_9);
            var val_10 = (0 + 1) + 1;
            if(subscription.callbackList != null)
            {
                goto label_45;
            }
            
            label_32:
            val_20 = subscription.partnerList;
            if(val_20 == null)
            {
                goto label_48;
            }
            
            val_17 = "addPartnerParameter";
            label_61:
            if(0 >= "setPurchaseTime")
            {
                goto label_48;
            }
            
            if("setPurchaseTime" > 0)
            {
                    val_21 = 15750360;
            }
            else
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
                val_20 = subscription.partnerList;
            }
            
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            object[] val_14 = new object[2];
            val_22 = val_14.Length;
            val_14[0] = null;
            val_22 = val_14.Length;
            val_14[1] = (((System.Convert.__il2cppRuntimeField_cctor_finished + 0) + 32) + ((0 + 1)) << 3) + 32;
            val_3.Call(methodName:  "addPartnerParameter", args:  val_14);
            var val_15 = (0 + 1) + 1;
            if(subscription.partnerList != null)
            {
                goto label_61;
            }
            
            label_48:
            val_23 = null;
            val_23 = null;
            object[] val_16 = new object[1];
            val_16[0] = val_3;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "trackPlayStoreSubscription", args:  val_16);
        }
        public static void TrackThirdPartySharing(com.adjust.sdk.AdjustThirdPartySharing thirdPartySharing)
        {
            object val_9;
            var val_13;
            System.Object[] val_14;
            UnityEngine.DrivenTransformProperties val_15;
            object val_16;
            var val_17;
            var val_18;
            if(true != 0)
            {
                    object[] val_1 = new object[1];
                System.Nullable<System.Boolean> val_2 = thirdPartySharing.isEnabled & 1;
                val_1[0] = val_2;
                val_13 = 1152921504713555968;
                object[] val_4 = new object[1];
                val_4[0] = new UnityEngine.AndroidJavaObject(className:  "java.lang.Boolean", args:  val_1);
                UnityEngine.AndroidJavaObject val_5 = null;
                val_14 = val_4;
                val_15 = 0;
                val_16 = val_5;
                val_5 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustThirdPartySharing", args:  val_4);
            }
            else
            {
                    UnityEngine.AndroidJavaObject val_6 = null;
                val_14 = 0;
                val_15 = 0;
                val_16 = val_6;
                val_6 = new UnityEngine.AndroidJavaObject(className:  "com.adjust.sdk.AdjustThirdPartySharing", args:  val_14);
            }
            
            if(thirdPartySharing.granularOptions == null)
            {
                goto label_46;
            }
            
            Dictionary.Enumerator<TKey, TValue> val_7 = thirdPartySharing.granularOptions.GetEnumerator();
            val_13 = 1152921507342209456;
            label_15:
            if(((-1559582448) & 1) == 0)
            {
                goto label_13;
            }
            
            var val_16 = 1;
            label_29:
            if(val_9 == 0)
            {
                    throw new NullReferenceException();
            }
            
            var val_10 = val_16 - 1;
            if(val_10 >= (val_9 + 24))
            {
                goto label_15;
            }
            
            object[] val_11 = new object[3];
            if(val_11 == null)
            {
                    throw new NullReferenceException();
            }
            
            if(val_9 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_11.Length == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_11[0] = val_9;
            if((val_9 + 24) <= val_10)
            {
                    val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_14 = val_9 + 16;
            val_14 = val_14 + (val_10 << 3);
            if(((val_9 + 16 + ((1 - 1)) << 3) + 32) != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_11.Length <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_11[1] = (val_9 + 16 + ((1 - 1)) << 3) + 32;
            if((val_9 + 24) <= (val_10 + 1))
            {
                    val_17 = 0;
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            var val_15 = val_9 + 16;
            val_15 = val_15 + 8;
            if(((val_9 + 16 + 8) + 32) != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_11.Length <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_11[2] = (val_9 + 16 + 8) + 32;
            if(val_16 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_16 = val_16 + 2;
            val_6.Call(methodName:  "addGranularOption", args:  val_11);
            goto label_29;
            label_13:
            val_2.Add(driver:  public System.Void Dictionary.Enumerator<System.String, System.Collections.Generic.List<System.String>>::Dispose(), rectTransform:  val_14, drivenProperties:  val_15);
            label_46:
            val_18 = null;
            val_18 = null;
            object[] val_13 = new object[1];
            val_13[0] = val_16;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "trackThirdPartySharing", args:  val_13);
        }
        public static void TrackMeasurementConsent(bool measurementConsent)
        {
            var val_3 = null;
            object[] val_2 = new object[1];
            val_2[0] = measurementConsent;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "trackMeasurementConsent", args:  val_2);
        }
        public static void OnPause()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onPause", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void OnResume()
        {
            var val_1;
            var val_2;
            val_1 = null;
            val_1 = null;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_2 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_2 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "onResume", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184);
        }
        public static void SetReferrer(string referrer)
        {
            var val_2;
            int val_3;
            val_2 = null;
            val_2 = null;
            object[] val_1 = new object[2];
            val_3 = val_1.Length;
            val_1[0] = referrer;
            if(com.adjust.sdk.AdjustAndroid.ajoCurrentActivity != null)
            {
                    val_3 = val_1.Length;
            }
            
            val_1[1] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setReferrer", args:  val_1);
        }
        public static void GetGoogleAdId(System.Action<string> onDeviceIdsRead)
        {
            var val_3;
            int val_4;
            AdjustAndroid.DeviceIdsReadListener val_1 = new AdjustAndroid.DeviceIdsReadListener(pCallback:  onDeviceIdsRead);
            val_3 = null;
            val_3 = null;
            object[] val_2 = new object[2];
            val_4 = val_2.Length;
            val_2[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            if(val_1 != null)
            {
                    val_4 = val_2.Length;
            }
            
            val_2[1] = val_1;
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "getGoogleAdId", args:  val_2);
        }
        public static string GetAmazonAdId()
        {
            null = null;
            object[] val_1 = new object[1];
            val_1[0] = com.adjust.sdk.AdjustAndroid.ajoCurrentActivity;
            return com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getAmazonAdId", args:  val_1);
        }
        public static string GetSdkVersion()
        {
            var val_2;
            var val_3;
            val_2 = null;
            val_2 = null;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            val_3 = mem[public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302];
            val_3 = public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 302;
            return "unity4.28.0@" + com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getSdkVersion", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184)(com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic<System.String>(methodName:  "getSdkVersion", args:  public static T[] System.Array::Empty<System.Object>().__il2cppRuntimeField_30 + 184));
        }
        public static void SetTestOptions(System.Collections.Generic.Dictionary<string, string> testOptions)
        {
            null = null;
            object[] val_2 = new object[1];
            val_2[0] = com.adjust.sdk.AdjustUtils.TestOptionsMap2AndroidJavaObject(testOptionsMap:  testOptions, ajoCurrentActivity:  com.adjust.sdk.AdjustAndroid.ajoCurrentActivity);
            com.adjust.sdk.AdjustAndroid.ajcAdjust.CallStatic(methodName:  "setTestOptions", args:  val_2);
        }
        private static bool IsAppSecretSet(com.adjust.sdk.AdjustConfig adjustConfig)
        {
            var val_2;
            if((((true != 0) && (true != 0)) && (true != 0)) && (true != 0))
            {
                    var val_1 = (true != 0) ? 1 : 0;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        public AdjustAndroid()
        {
        
        }
        private static AdjustAndroid()
        {
            com.adjust.sdk.AdjustAndroid.launchDeferredDeeplink = true;
            com.adjust.sdk.AdjustAndroid.ajcAdjust = new UnityEngine.AndroidJavaClass(className:  "com.adjust.sdk.Adjust");
            com.adjust.sdk.AdjustAndroid.ajoCurrentActivity = new UnityEngine.AndroidJavaClass(className:  "com.unity3d.player.UnityPlayer").GetStatic<UnityEngine.AndroidJavaObject>(fieldName:  "currentActivity");
        }
    
    }

}
