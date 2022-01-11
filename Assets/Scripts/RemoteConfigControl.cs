using UnityEngine;
public class RemoteConfigControl : SingletonMonoBehaviour<RemoteConfigControl>
{
    // Fields
    public System.Action OnFetchDone;
    public bool isDataFetched;
    public static int interstitialAds_Interval;
    public static int interstitialAds_MinLevel;
    public static string levelRateData;
    public static float taichi_Threshold;
    public static System.Collections.Generic.List<int> rateLevels;
    
    // Methods
    public void InitializeFirebase()
    {
        var val_4;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_4 = null;
        val_4 = null;
        val_1.Add(key:  "interstitialAds_Interval", value:  RemoteConfigControl.interstitialAds_Interval);
        val_1.Add(key:  "interstitialAds_MinLevel", value:  RemoteConfigControl.interstitialAds_MinLevel);
        val_1.Add(key:  "taichi_Threshold", value:  RemoteConfigControl.taichi_Threshold);
        val_1.Add(key:  "levelRateData", value:  RemoteConfigControl.levelRateData);
        System.Threading.Tasks.Task val_3 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.SetDefaultsAsync(defaults:  val_1);
        UnityEngine.Debug.Log(message:  "RemoteConfig configured and ready!");
        this.FetchDataAsync();
    }
    public void FetchDataAsync()
    {
        UnityEngine.Debug.Log(message:  "Fetching data...");
        System.Threading.Tasks.Task val_4 = Firebase.Extensions.TaskExtension.ContinueWithOnMainThread(task:  Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.FetchAsync(cacheExpiration:  new System.TimeSpan() {_ticks = System.TimeSpan.Zero}), continuation:  new System.Action<System.Threading.Tasks.Task>(object:  this, method:  System.Void RemoteConfigControl::FetchComplete(System.Threading.Tasks.Task fetchTask)));
    }
    private void FetchComplete(System.Threading.Tasks.Task fetchTask)
    {
        object val_14;
        var val_15;
        object val_16;
        if(fetchTask.IsCanceled == false)
        {
            goto label_2;
        }
        
        val_14 = "Fetch canceled.";
        goto label_9;
        label_2:
        if(fetchTask.IsFaulted == false)
        {
            goto label_6;
        }
        
        val_14 = "Fetch encountered an error.";
        goto label_9;
        label_6:
        if(fetchTask.IsCompleted == false)
        {
            goto label_10;
        }
        
        val_14 = "Fetch completed successfully!";
        label_9:
        UnityEngine.Debug.Log(message:  val_14);
        label_10:
        Firebase.RemoteConfig.ConfigInfo val_5 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.Info;
        Firebase.RemoteConfig.LastFetchStatus val_6 = val_5.LastFetchStatus;
        if(val_6 == 2)
        {
            goto label_17;
        }
        
        if(val_6 == 1)
        {
            goto label_18;
        }
        
        if(val_6 != 0)
        {
            goto label_27;
        }
        
        System.Threading.Tasks.Task<System.Boolean> val_8 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.ActivateAsync();
        System.DateTime val_9 = val_5.FetchTime;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Remote data loaded and ready (last fetch time {0}).", arg0:  val_9));
        this.RefrectProperties();
        goto label_27;
        label_18:
        Firebase.RemoteConfig.FetchFailureReason val_11 = val_5.LastFetchFailureReason;
        if(val_11 == 1)
        {
            goto label_26;
        }
        
        if(val_11 != 2)
        {
            goto label_27;
        }
        
        val_15 = "Fetch failed for unknown reason";
        goto label_33;
        label_17:
        val_15 = "Latest Fetch call still pending.";
        goto label_33;
        label_26:
        System.DateTime val_12 = val_5.ThrottledEndTime;
        val_16 = "Fetch throttled until " + val_12;
        label_33:
        UnityEngine.Debug.Log(message:  val_16);
        label_27:
        if(this.OnFetchDone == null)
        {
                return;
        }
        
        this.OnFetchDone.Invoke();
    }
    private void RefrectProperties()
    {
        var val_16;
        Firebase.RemoteConfig.ConfigValue val_2 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "interstitialAds_Interval");
        val_16 = null;
        val_16 = null;
        RemoteConfigControl.interstitialAds_Interval = ;
        Firebase.RemoteConfig.ConfigValue val_4 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "interstitialAds_MinLevel");
        RemoteConfigControl.interstitialAds_MinLevel = ;
        Firebase.RemoteConfig.ConfigValue val_6 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "taichi_Threshold");
        RemoteConfigControl.taichi_Threshold = (float)D0;
        Firebase.RemoteConfig.ConfigValue val_8 = Firebase.RemoteConfig.FirebaseRemoteConfig.DefaultInstance.GetValue(key:  "levelRateData");
        RemoteConfigControl.levelRateData = ;
        RemoteConfigControl.ParseRateLevelData();
        UnityEngine.Debug.LogWarning(message:  "Fetch Values: ");
        UnityEngine.Debug.LogWarning(message:  "interstitialAds_Interval: "("interstitialAds_Interval: ") + RemoteConfigControl.interstitialAds_Interval.ToString());
        UnityEngine.Debug.LogWarning(message:  "interstitialAds_MinLevel: "("interstitialAds_MinLevel: ") + RemoteConfigControl.interstitialAds_MinLevel.ToString());
        UnityEngine.Debug.LogWarning(message:  "taichi_Threshold: "("taichi_Threshold: ") + RemoteConfigControl.taichi_Threshold.ToString());
        string val_15 = "levelRateData: "("levelRateData: ") + val_8.<Data>k__BackingField(val_8.<Data>k__BackingField);
        UnityEngine.Debug.LogWarning(message:  val_15);
        val_15.SaveData();
        this.isDataFetched = true;
    }
    private void SaveData()
    {
        null = null;
        UnityEngine.PlayerPrefs.SetInt(key:  "interstitialAds_Interval", value:  RemoteConfigControl.interstitialAds_Interval);
        UnityEngine.PlayerPrefs.SetFloat(key:  "taichi_Threshold", value:  RemoteConfigControl.taichi_Threshold);
        UnityEngine.PlayerPrefs.SetString(key:  "levelRateData", value:  RemoteConfigControl.levelRateData);
    }
    public void LoadCachedData()
    {
        var val_5 = null;
        RemoteConfigControl.interstitialAds_Interval = UnityEngine.PlayerPrefs.GetInt(key:  "interstitialAds_Interval", defaultValue:  30);
        RemoteConfigControl.interstitialAds_MinLevel = UnityEngine.PlayerPrefs.GetInt(key:  "interstitialAds_MinLevel", defaultValue:  1);
        RemoteConfigControl.taichi_Threshold = UnityEngine.PlayerPrefs.GetFloat(key:  "taichi_Threshold", defaultValue:  0.01f);
        RemoteConfigControl.levelRateData = UnityEngine.PlayerPrefs.GetString(key:  "levelRateData", defaultValue:  "3|10|20");
        RemoteConfigControl.ParseRateLevelData();
    }
    private static void ParseRateLevelData()
    {
        var val_6;
        System.Collections.Generic.List<T> val_7;
        var val_8;
        var val_9;
        val_6 = null;
        val_6 = null;
        RemoteConfigControl.rateLevels.Clear();
        char[] val_1 = new char[1];
        val_1[0] = 124;
        int val_6 = val_2.Length;
        val_7 = RemoteConfigControl.levelRateData.Split(separator:  val_1);
        if(val_6 < 1)
        {
                return;
        }
        
        var val_7 = 0;
        val_6 = val_6 & 4294967295;
        label_14:
        if((System.Int32.TryParse(s:  null, result: out  0)) == false)
        {
            goto label_10;
        }
        
        val_8 = null;
        val_8 = null;
        RemoteConfigControl.rateLevels.Add(item:  0);
        val_7 = val_7 + 1;
        if(val_7 < (val_2.Length << ))
        {
            goto label_14;
        }
        
        return;
        label_10:
        System.Collections.Generic.List<System.Int32> val_5 = null;
        val_7 = val_5;
        val_5 = new System.Collections.Generic.List<System.Int32>();
        val_5.Add(item:  3);
        val_5.Add(item:  10);
        val_5.Add(item:  20);
        val_9 = null;
        val_9 = null;
        RemoteConfigControl.rateLevels = val_7;
    }
    public RemoteConfigControl()
    {
    
    }
    private static RemoteConfigControl()
    {
        RemoteConfigControl.interstitialAds_Interval = 30;
        RemoteConfigControl.interstitialAds_MinLevel = 1;
        RemoteConfigControl.levelRateData = "3|10|20";
        RemoteConfigControl.taichi_Threshold = 0.01f;
        RemoteConfigControl.rateLevels = new System.Collections.Generic.List<System.Int32>();
    }

}
