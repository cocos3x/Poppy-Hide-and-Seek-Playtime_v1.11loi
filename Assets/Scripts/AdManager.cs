using UnityEngine;
public class AdManager : SingletonMonoBehaviour<AdManager>
{
    // Fields
    private bool doneAdsInterval;
    private static System.Action rewardedAdSucceededEvent;
    private static System.Action interstitialAdClosedEvent;
    private static System.Action interstitialAdSucceededEvent;
    private static System.Action interstitialAdFailedEvent;
    private const string MaxSdkKey = "bmTTF_USp-Li1RtblN5tUGHwLh83crRSVPQ0bTT88LSlzTcX_J_lMrHcwXZ3L08PndktTp7gRFWXLpU2aJF5yn";
    private const string InterstitialAdUnitId = "9e63324a97b57ceb";
    private const string RewardedAdUnitId = "b1d613cf0e3951be";
    private const string BannerAdUnitId = "bdc4b7b07b54b99d";
    private bool isBannerShowing;
    private int interstitialRetryAttempt;
    private int rewardedRetryAttempt;
    private int rewardedInterstitialRetryAttempt;
    public System.Action AudioPauseAction;
    public System.Action AudioResumeAction;
    
    // Methods
    public override void Awake()
    {
        bool val_1 = UserData.Load(forceReload:  false);
    }
    private void Start()
    {
        MaxSdkCallbacks.add_OnSdkInitializedEvent(value:  new System.Action<SdkConfiguration>(object:  this, method:  System.Void AdManager::<Start>b__16_0(MaxSdkBase.SdkConfiguration sdkConfiguration)));
        MaxSdkAndroid.SetSdkKey(sdkKey:  "bmTTF_USp-Li1RtblN5tUGHwLh83crRSVPQ0bTT88LSlzTcX_J_lMrHcwXZ3L08PndktTp7gRFWXLpU2aJF5yn");
        MaxSdkAndroid.InitializeSdk(adUnitIds:  0);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.WaitAdsStartDelay());
    }
    private void SetAdsInterval()
    {
        this.doneAdsInterval = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WaitEndAdsInterval());
    }
    private System.Collections.IEnumerator WaitAdsStartDelay()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AdManager.<WaitAdsStartDelay>d__18();
    }
    private System.Collections.IEnumerator WaitEndAdsInterval()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new AdManager.<WaitEndAdsInterval>d__19();
    }
    private void InitializeInterstitialAds()
    {
        MaxSdkCallbacks.Interstitial.add_OnAdLoadedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Interstitial.add_OnAdLoadFailedEvent(value:  new System.Action<System.String, ErrorInfo>(object:  this, method:  System.Void AdManager::OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayFailedEvent(value:  new System.Action<System.String, ErrorInfo, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Interstitial.add_OnAdHiddenEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Interstitial.add_OnAdDisplayedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialDisplayedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Interstitial.add_OnAdClickedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialClickedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)));
        System.Action<System.String, AdInfo> val_7 = new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo));
        MaxSdkCallbacks.Interstitial.add_OnAdRevenuePaidEvent(value:  val_7);
        val_7.LoadInterstitial();
    }
    private void OnInterstitialAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        this.ImpressionSuccessEvent(adInfo:  adInfo);
    }
    private void ImpressionSuccessEvent(MaxSdkBase.AdInfo adInfo)
    {
        Firebase.Analytics.Parameter[] val_6;
        var val_7;
        string val_8;
        val_6 = adInfo;
        if(val_6 == null)
        {
                return;
        }
        
        val_7 = null;
        float val_2 = (UnityEngine.PlayerPrefs.GetFloat(key:  "TaichiTroasCache", defaultValue:  0f)) + ((float)adInfo.<Revenue>k__BackingField);
        val_7 = null;
        if(val_2 < RemoteConfigControl.taichi_Threshold)
        {
                val_8 = "TaichiTroasCache";
        }
        else
        {
                Firebase.Analytics.Parameter[] val_3 = new Firebase.Analytics.Parameter[2];
            val_6 = val_3;
            val_6[0] = new Firebase.Analytics.Parameter(parameterName:  "currency", parameterValue:  "usd");
            val_6[1] = new Firebase.Analytics.Parameter(parameterName:  "value", parameterValue:  (double)val_2);
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "ad_revenue_with_threshold", parameters:  val_3);
            val_8 = "TaichiTroasCache";
        }
        
        UnityEngine.PlayerPrefs.SetFloat(key:  val_8, value:  0f);
    }
    private void LoadInterstitial()
    {
        MaxSdkAndroid.LoadInterstitial(adUnitIdentifier:  "9e63324a97b57ceb");
    }
    public void ShowInterstitialAd(System.Action ClosedEvent, System.Action SucceededEvent, System.Action FailedEvent)
    {
        var val_2;
        if(this.doneAdsInterval != false)
        {
                val_2 = 1152921504750350336;
            if((MaxSdkAndroid.IsInterstitialReady(adUnitIdentifier:  "9e63324a97b57ceb")) != false)
        {
                this.doneAdsInterval = false;
            AdManager.interstitialAdClosedEvent = ClosedEvent;
            AdManager.interstitialAdSucceededEvent = SucceededEvent;
            AdManager.interstitialAdFailedEvent = FailedEvent;
            MaxSdkAndroid.ShowInterstitial(adUnitIdentifier:  "9e63324a97b57ceb");
            return;
        }
        
            if(FailedEvent != null)
        {
                FailedEvent.Invoke();
        }
        
        }
        
        ClosedEvent.Invoke();
    }
    private void OnInterstitialDisplayedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)
    {
        var val_1;
        if(this.AudioPauseAction != null)
        {
                this.AudioPauseAction.Invoke();
        }
        
        if(AdManager.interstitialAdSucceededEvent != null)
        {
                AdManager.interstitialAdSucceededEvent.Invoke();
            val_1 = 1152921504763666448;
        }
        
        AdManager.interstitialAdSucceededEvent = 0;
    }
    private void OnInterstitialClickedEvent(string adUnitID, MaxSdkBase.AdInfo adInfo)
    {
    
    }
    private void OnInterstitialLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        this.interstitialRetryAttempt = 0;
    }
    private void OnInterstitialLoadFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        int val_1 = this.interstitialRetryAttempt + 1;
        this.interstitialRetryAttempt = val_1;
        this.Invoke(methodName:  "LoadInterstitial", time:  (float)System.Math.Pow(x:  2, y:  (double)System.Math.Min(val1:  6, val2:  val_1)));
    }
    private void OnInterstitialAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        if(AdManager.interstitialAdFailedEvent != null)
        {
                AdManager.interstitialAdFailedEvent.Invoke();
            val_3 = null;
            val_4 = 1152921504763666456;
        }
        
        AdManager.interstitialAdFailedEvent = 0;
        if(AdManager.interstitialAdClosedEvent != null)
        {
                AdManager.interstitialAdClosedEvent.Invoke();
            val_5 = 1152921504763666440;
        }
        
        AdManager.interstitialAdClosedEvent = 0;
        this.doneAdsInterval = false;
        this.StartCoroutine(routine:  this.WaitEndAdsInterval()).LoadInterstitial();
    }
    private void OnInterstitialHiddenEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        var val_4;
        var val_5;
        string val_6;
        if(this.AudioResumeAction != null)
        {
                this.AudioResumeAction.Invoke();
        }
        
        this.doneAdsInterval = false;
        this.StartCoroutine(routine:  this.WaitEndAdsInterval()).LoadInterstitial();
        if(AdManager.interstitialAdClosedEvent != null)
        {
                AdManager.interstitialAdClosedEvent.Invoke();
            val_4 = 1152921504763666440;
        }
        
        AdManager.interstitialAdClosedEvent = 0;
        val_5 = null;
        val_5 = null;
        int val_3 = UserData.current.fullAdsCount + 1;
        UserData.current.fullAdsCount = val_3;
        if(val_3 > 10)
        {
                return;
        }
        
        if(UserData.current.session == 1)
        {
                AppEventTracker.PushEvent_FullAds_Session(session:  1, adsCount:  val_3);
        }
        
        if(UserData.current.dayActive == 1)
        {
                AppEventTracker.PushEvent_FullAds_DayActive(day:  1, adsCount:  UserData.current.fullAdsCount);
        }
        
        if(UserData.current.fullAdsCount != 5)
        {
                if(UserData.current.fullAdsCount != 3)
        {
                return;
        }
        
            val_6 = "fs_force_ad_3";
        }
        else
        {
                val_6 = "fs_force_ad_5";
        }
        
        AppEventTracker.PushEvent(name:  val_6);
    }
    private void InitializeRewardedAds()
    {
        MaxSdkCallbacks.Rewarded.add_OnAdLoadedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdLoadFailedEvent(value:  new System.Action<System.String, ErrorInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdDisplayFailedEvent(value:  new System.Action<System.String, ErrorInfo, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdDisplayedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdClickedEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdHiddenEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        MaxSdkCallbacks.Rewarded.add_OnAdReceivedRewardEvent(value:  new System.Action<System.String, Reward, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)));
        System.Action<System.String, AdInfo> val_8 = new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo));
        MaxSdkCallbacks.Rewarded.add_OnAdRevenuePaidEvent(value:  val_8);
        val_8.LoadRewardedAd();
    }
    private void OnRewardedAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        this.ImpressionSuccessEvent(adInfo:  adInfo);
    }
    private void LoadRewardedAd()
    {
        MaxSdkAndroid.LoadRewardedAd(adUnitIdentifier:  "b1d613cf0e3951be");
    }
    public void ShowRewardedAd(System.Action succeededEvent, System.Action failedEvent)
    {
        if((MaxSdkAndroid.IsRewardedAdReady(adUnitIdentifier:  "b1d613cf0e3951be")) != false)
        {
                AdManager.BannerAdUnitId = succeededEvent;
            MaxSdkAndroid.ShowRewardedAd(adUnitIdentifier:  "b1d613cf0e3951be");
            return;
        }
        
        if(failedEvent == null)
        {
                return;
        }
        
        failedEvent.Invoke();
    }
    private void OnRewardedAdLoadedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        this.rewardedRetryAttempt = 0;
    }
    private void OnRewardedAdFailedEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo)
    {
        int val_1 = this.rewardedRetryAttempt + 1;
        this.rewardedRetryAttempt = val_1;
        this.Invoke(methodName:  "LoadRewardedAd", time:  (float)System.Math.Pow(x:  2, y:  (double)System.Math.Min(val1:  6, val2:  val_1)));
    }
    private void OnRewardedAdFailedToDisplayEvent(string adUnitId, MaxSdkBase.ErrorInfo errorInfo, MaxSdkBase.AdInfo adInfo)
    {
        this.LoadRewardedAd();
    }
    private void OnRewardedAdDisplayedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        if(this.AudioPauseAction == null)
        {
                return;
        }
        
        this.AudioPauseAction.Invoke();
    }
    private void OnRewardedAdClickedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
    
    }
    private void OnRewardedAdDismissedEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        if(this.AudioResumeAction != null)
        {
                this.AudioResumeAction.Invoke();
        }
        
        this.AudioResumeAction.LoadRewardedAd();
    }
    private void OnRewardedAdReceivedRewardEvent(string adUnitId, MaxSdkBase.Reward reward, MaxSdkBase.AdInfo adInfo)
    {
        var val_6;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.WaitRewarded());
        this.doneAdsInterval = false;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.WaitEndAdsInterval());
        val_6 = null;
        val_6 = null;
        int val_5 = UserData.current.rewardAdsCount + 1;
        UserData.current.rewardAdsCount = val_5;
        if(val_5 > 10)
        {
                return;
        }
        
        if(UserData.current.session == 1)
        {
                AppEventTracker.PushEvent_RewardedAds_Session(session:  1, adsCount:  val_5);
        }
        
        if(UserData.current.dayActive != 1)
        {
                return;
        }
        
        AppEventTracker.PushEvent_RewardedAds_DayActive(day:  1, adsCount:  UserData.current.rewardAdsCount);
    }
    private System.Collections.IEnumerator WaitRewarded()
    {
        .<>1__state = 0;
        return (System.Collections.IEnumerator)new AdManager.<WaitRewarded>d__42();
    }
    private void InitializeBannerAds()
    {
        MaxSdkCallbacks.Banner.add_OnAdRevenuePaidEvent(value:  new System.Action<System.String, AdInfo>(object:  this, method:  System.Void AdManager::OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)));
        this.Invoke(methodName:  "DelayInitBanner", time:  1f);
    }
    private void DelayInitBanner()
    {
        null = null;
        if(UserData.current.removedAds != false)
        {
                return;
        }
        
        MaxSdkAndroid.CreateBanner(adUnitIdentifier:  "bdc4b7b07b54b99d", bannerPosition:  7);
        UnityEngine.Color val_1 = UnityEngine.Color.black;
        MaxSdkAndroid.SetBannerBackgroundColor(adUnitIdentifier:  "bdc4b7b07b54b99d", color:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a});
        ShowBanner();
    }
    private void OnBannerAdRevenuePaidEvent(string adUnitId, MaxSdkBase.AdInfo adInfo)
    {
        this.ImpressionSuccessEvent(adInfo:  adInfo);
    }
    public void ShowBanner()
    {
        null = null;
        if(UserData.current.removedAds != false)
        {
                return;
        }
        
        MaxSdkAndroid.ShowBanner(adUnitIdentifier:  "bdc4b7b07b54b99d");
    }
    public void HideBanner()
    {
        MaxSdkAndroid.HideBanner(adUnitIdentifier:  "bdc4b7b07b54b99d");
    }
    private void ToggleBannerVisibility()
    {
        if(this.isBannerShowing != false)
        {
                MaxSdkAndroid.HideBanner(adUnitIdentifier:  "bdc4b7b07b54b99d");
        }
        else
        {
                MaxSdkAndroid.ShowBanner(adUnitIdentifier:  "bdc4b7b07b54b99d");
        }
        
        bool val_1 = this.isBannerShowing;
        val_1 = val_1 ^ 1;
        this.isBannerShowing = val_1;
    }
    public AdManager()
    {
        this.doneAdsInterval = true;
    }
    private void <Start>b__16_0(MaxSdkBase.SdkConfiguration sdkConfiguration)
    {
        UnityEngine.Debug.Log(message:  "MAX SDK Initialized");
        this.InitializeInterstitialAds();
        this.InitializeRewardedAds();
        this.InitializeBannerAds();
    }

}
