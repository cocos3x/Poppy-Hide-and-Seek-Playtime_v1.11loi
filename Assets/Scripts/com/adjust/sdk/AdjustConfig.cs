using UnityEngine;

namespace com.adjust.sdk
{
    public class AdjustConfig
    {
        // Fields
        public const string AdjustUrlStrategyChina = "china";
        public const string AdjustUrlStrategyIndia = "india";
        public const string AdjustDataResidencyEU = "data-residency-eu";
        public const string AdjustAdRevenueSourceMopub = "mopub";
        public const string AdjustAdRevenueSourceAdmob = "admob";
        public const string AdjustAdRevenueSourceFbNativeAd = "facebook_native_ad";
        public const string AdjustAdRevenueSourceFbAudienceNetwork = "facebook_audience_network";
        public const string AdjustAdRevenueSourceIronsource = "ironsource";
        public const string AdjustAdRevenueSourceFyber = "fyber";
        public const string AdjustAdRevenueSourceAerserv = "aerserv";
        public const string AdjustAdRevenueSourceAppodeal = "appodeal";
        public const string AdjustAdRevenueSourceAdincube = "adincube";
        public const string AdjustAdRevenueSourceFusePowered = "fusepowered";
        public const string AdjustAdRevenueSourceAddaptr = "addapptr";
        public const string AdjustAdRevenueSourceMillenialMediation = "millennial_mediation";
        public const string AdjustAdRevenueSourceFlurry = "flurry";
        public const string AdjustAdRevenueSourceAdmost = "admost";
        public const string AdjustAdRevenueSourceDeltadna = "deltadna";
        public const string AdjustAdRevenueSourceUpsight = "upsight";
        public const string AdjustAdRevenueSourceUnityads = "unityads";
        public const string AdjustAdRevenueSourceAdtoapp = "adtoapp";
        public const string AdjustAdRevenueSourceTapdaq = "tapdaq";
        internal string appToken;
        internal string sceneName;
        internal string userAgent;
        internal string defaultTracker;
        internal string externalDeviceId;
        internal string urlStrategy;
        internal System.Nullable<long> info1;
        internal System.Nullable<long> info2;
        internal System.Nullable<long> info3;
        internal System.Nullable<long> info4;
        internal System.Nullable<long> secretId;
        internal System.Nullable<double> delayStart;
        internal System.Nullable<bool> isDeviceKnown;
        internal System.Nullable<bool> sendInBackground;
        internal System.Nullable<bool> eventBufferingEnabled;
        internal System.Nullable<bool> allowSuppressLogLevel;
        internal System.Nullable<bool> needsCost;
        internal bool launchDeferredDeeplink;
        internal System.Nullable<com.adjust.sdk.AdjustLogLevel> logLevel;
        internal com.adjust.sdk.AdjustEnvironment environment;
        internal System.Action<string> deferredDeeplinkDelegate;
        internal System.Action<com.adjust.sdk.AdjustEventSuccess> eventSuccessDelegate;
        internal System.Action<com.adjust.sdk.AdjustEventFailure> eventFailureDelegate;
        internal System.Action<com.adjust.sdk.AdjustSessionSuccess> sessionSuccessDelegate;
        internal System.Action<com.adjust.sdk.AdjustSessionFailure> sessionFailureDelegate;
        internal System.Action<com.adjust.sdk.AdjustAttribution> attributionChangedDelegate;
        internal System.Nullable<bool> readImei;
        internal System.Nullable<bool> preinstallTrackingEnabled;
        internal string processName;
        internal System.Nullable<bool> allowiAdInfoReading;
        internal System.Nullable<bool> allowAdServicesInfoReading;
        internal System.Nullable<bool> allowIdfaReading;
        internal System.Nullable<bool> skAdNetworkHandling;
        internal System.Action<string> logDelegate;
        
        // Methods
        public AdjustConfig(string appToken, com.adjust.sdk.AdjustEnvironment environment)
        {
            this.environment = environment;
            this.appToken = appToken;
            this.sceneName = "";
            this.processName = "";
        }
        public AdjustConfig(string appToken, com.adjust.sdk.AdjustEnvironment environment, bool allowSuppressLogLevel)
        {
            bool val_1 = allowSuppressLogLevel;
            this.environment = environment;
            this.appToken = appToken;
            this.sceneName = "";
            this.processName = "";
            this.allowSuppressLogLevel = 0;
        }
        public void setLogLevel(com.adjust.sdk.AdjustLogLevel logLevel)
        {
            this.logLevel = 0;
        }
        public void setDefaultTracker(string defaultTracker)
        {
            this.defaultTracker = defaultTracker;
        }
        public void setExternalDeviceId(string externalDeviceId)
        {
            this.externalDeviceId = externalDeviceId;
        }
        public void setLaunchDeferredDeeplink(bool launchDeferredDeeplink)
        {
            this.launchDeferredDeeplink = launchDeferredDeeplink;
        }
        public void setSendInBackground(bool sendInBackground)
        {
            sendInBackground = sendInBackground;
            this.sendInBackground = 0;
        }
        public void setEventBufferingEnabled(bool eventBufferingEnabled)
        {
            eventBufferingEnabled = eventBufferingEnabled;
            this.eventBufferingEnabled = 0;
        }
        public void setNeedsCost(bool needsCost)
        {
            needsCost = needsCost;
            this.needsCost = 0;
        }
        public void setDelayStart(double delayStart)
        {
            this.delayStart = 0;
        }
        public void setUserAgent(string userAgent)
        {
            this.userAgent = userAgent;
        }
        public void setIsDeviceKnown(bool isDeviceKnown)
        {
            isDeviceKnown = isDeviceKnown;
            this.isDeviceKnown = 0;
        }
        public void setUrlStrategy(string urlStrategy)
        {
            this.urlStrategy = urlStrategy;
        }
        public void deactivateSKAdNetworkHandling()
        {
            this.skAdNetworkHandling = 0;
        }
        public void setDeferredDeeplinkDelegate(System.Action<string> deferredDeeplinkDelegate, string sceneName = "Adjust")
        {
            this.deferredDeeplinkDelegate = deferredDeeplinkDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<string> getDeferredDeeplinkDelegate()
        {
            return (System.Action<System.String>)this.deferredDeeplinkDelegate;
        }
        public void setAttributionChangedDelegate(System.Action<com.adjust.sdk.AdjustAttribution> attributionChangedDelegate, string sceneName = "Adjust")
        {
            this.attributionChangedDelegate = attributionChangedDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<com.adjust.sdk.AdjustAttribution> getAttributionChangedDelegate()
        {
            return (System.Action<com.adjust.sdk.AdjustAttribution>)this.attributionChangedDelegate;
        }
        public void setEventSuccessDelegate(System.Action<com.adjust.sdk.AdjustEventSuccess> eventSuccessDelegate, string sceneName = "Adjust")
        {
            this.eventSuccessDelegate = eventSuccessDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<com.adjust.sdk.AdjustEventSuccess> getEventSuccessDelegate()
        {
            return (System.Action<com.adjust.sdk.AdjustEventSuccess>)this.eventSuccessDelegate;
        }
        public void setEventFailureDelegate(System.Action<com.adjust.sdk.AdjustEventFailure> eventFailureDelegate, string sceneName = "Adjust")
        {
            this.eventFailureDelegate = eventFailureDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<com.adjust.sdk.AdjustEventFailure> getEventFailureDelegate()
        {
            return (System.Action<com.adjust.sdk.AdjustEventFailure>)this.eventFailureDelegate;
        }
        public void setSessionSuccessDelegate(System.Action<com.adjust.sdk.AdjustSessionSuccess> sessionSuccessDelegate, string sceneName = "Adjust")
        {
            this.sessionSuccessDelegate = sessionSuccessDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<com.adjust.sdk.AdjustSessionSuccess> getSessionSuccessDelegate()
        {
            return (System.Action<com.adjust.sdk.AdjustSessionSuccess>)this.sessionSuccessDelegate;
        }
        public void setSessionFailureDelegate(System.Action<com.adjust.sdk.AdjustSessionFailure> sessionFailureDelegate, string sceneName = "Adjust")
        {
            this.sessionFailureDelegate = sessionFailureDelegate;
            this.sceneName = sceneName;
        }
        public System.Action<com.adjust.sdk.AdjustSessionFailure> getSessionFailureDelegate()
        {
            return (System.Action<com.adjust.sdk.AdjustSessionFailure>)this.sessionFailureDelegate;
        }
        public void setAppSecret(long secretId, long info1, long info2, long info3, long info4)
        {
            this.secretId = 0;
            this.info1 = 0;
            this.info2 = 0;
            this.info3 = 0;
            this.info4 = 0;
        }
        public void setAllowiAdInfoReading(bool allowiAdInfoReading)
        {
            allowiAdInfoReading = allowiAdInfoReading;
            this.allowiAdInfoReading = 0;
        }
        public void setAllowAdServicesInfoReading(bool allowAdServicesInfoReading)
        {
            allowAdServicesInfoReading = allowAdServicesInfoReading;
            this.allowAdServicesInfoReading = 0;
        }
        public void setAllowIdfaReading(bool allowIdfaReading)
        {
            allowIdfaReading = allowIdfaReading;
            this.allowIdfaReading = 0;
        }
        public void setProcessName(string processName)
        {
            this.processName = processName;
        }
        public void setReadMobileEquipmentIdentity(bool readMobileEquipmentIdentity)
        {
        
        }
        public void setPreinstallTrackingEnabled(bool preinstallTrackingEnabled)
        {
            preinstallTrackingEnabled = preinstallTrackingEnabled;
            this.preinstallTrackingEnabled = 0;
        }
        public void setLogDelegate(System.Action<string> logDelegate)
        {
            this.logDelegate = logDelegate;
        }
    
    }

}
