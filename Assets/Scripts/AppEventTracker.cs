using UnityEngine;
public static class AppEventTracker
{
    // Methods
    public static void PushEventRemove_Ads()
    {
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "remove_ads");
    }
    public static void PushEvent_Force_Ads(string position, int level, bool succeeded)
    {
        var val_1 = (succeeded != true) ? (1 + 1) : 1;
        var val_3 = (UnityEngine.Application.internetReachability == 0) ? (1 + 1) : 1;
        Analytics.Tracker.LogEvent(eventType:  0);
    }
    public static void PushEvent_Rewarded_Ads(string position, bool succeeded)
    {
        var val_1 = (succeeded != true) ? (1 + 1) : 1;
        var val_3 = (UnityEngine.Application.internetReachability == 0) ? (1 + 1) : 1;
        Analytics.Tracker.LogEvent(eventType:  0);
    }
    public static void PushEvent_Level(int level, bool start, bool isReplay)
    {
        string val_1 = level.ToString();
        var val_2 = ((start & true) != 0) ? (1 + 1) : 1;
        var val_3 = ((isReplay & true) != 0) ? (1 + 1) : 1;
        Analytics.Tracker.LogEvent(eventType:  0);
    }
    public static void PushEvent_PurchaseRemoveAds()
    {
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "remove_ads");
    }
    public static void PushEvent_Iap(string productId)
    {
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  productId);
    }
    public static void PushEventProperty_Level(int value)
    {
        string val_1 = value.ToString();
        Analytics.Tracker.SetUserProperties(eventType:  0);
    }
    public static void PushEventProperty_RemoveAds(bool value)
    {
        var val_1 = (value != true) ? "true" : "false";
        Analytics.Tracker.SetUserProperties(eventType:  2);
    }
    public static void PushEvent_FullAds_Session(int session, int adsCount)
    {
        int val_4;
        int val_5;
        int val_6;
        val_4 = adsCount;
        val_5 = session;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        object[] val_2 = new object[4];
        val_2[0] = "session";
        val_6 = val_2.Length;
        val_2[1] = val_5;
        val_5 = "_fullads_";
        val_6 = val_2.Length;
        val_2[2] = "_fullads_";
        val_2[3] = val_4;
        val_4 = +val_2;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_4);
    }
    public static void PushEvent_FullAds_DayActive(int day, int adsCount)
    {
        int val_4;
        int val_5;
        int val_6;
        val_4 = adsCount;
        val_5 = day;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        object[] val_2 = new object[4];
        val_2[0] = "day";
        val_6 = val_2.Length;
        val_2[1] = val_5;
        val_5 = "_fullads_";
        val_6 = val_2.Length;
        val_2[2] = "_fullads_";
        val_2[3] = val_4;
        val_4 = +val_2;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_4);
    }
    public static void PushEvent_RewardedAds_Session(int session, int adsCount)
    {
        int val_4;
        int val_5;
        int val_6;
        val_4 = adsCount;
        val_5 = session;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        object[] val_2 = new object[4];
        val_2[0] = "session";
        val_6 = val_2.Length;
        val_2[1] = val_5;
        val_5 = "_rewardads_";
        val_6 = val_2.Length;
        val_2[2] = "_rewardads_";
        val_2[3] = val_4;
        val_4 = +val_2;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_4);
    }
    public static void PushEvent_RewardedAds_DayActive(int day, int adsCount)
    {
        int val_4;
        int val_5;
        int val_6;
        val_4 = adsCount;
        val_5 = day;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        object[] val_2 = new object[4];
        val_2[0] = "day";
        val_6 = val_2.Length;
        val_2[1] = val_5;
        val_5 = "_rewardads_";
        val_6 = val_2.Length;
        val_2[2] = "_rewardads_";
        val_2[3] = val_4;
        val_4 = +val_2;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_4);
    }
    public static void PushEvent_DayActive(int day)
    {
        int val_3 = day;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        val_3 = "day_active_" + val_3;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_3);
    }
    public static void PushEvent_LevelCompleted_Feature(int level)
    {
        int val_3 = level;
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        val_3 = "level_completed_" + val_3;
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  val_3);
    }
    public static void SetUserPropertyLevel(int value)
    {
        string val_1 = value.ToString();
        Analytics.Tracker.SetUserProperties(eventType:  0);
    }
    public static void PushEvent_LevelDay0_Start(int level, string result, string mode)
    {
        if((level <= 10) && (Analytics.Tracker.IsReady != true))
        {
                return;
        }
        
        Firebase.Analytics.Parameter[] val_2 = new Firebase.Analytics.Parameter[3];
        val_2[0] = new Firebase.Analytics.Parameter(parameterName:  "level", parameterValue:  (long)level);
        val_2[1] = new Firebase.Analytics.Parameter(parameterName:  "result", parameterValue:  result);
        val_2[2] = new Firebase.Analytics.Parameter(parameterName:  "mode", parameterValue:  mode);
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "level_status_day0", parameters:  val_2);
    }
    public static void PushEvent(string name)
    {
        if(Analytics.Tracker.IsReady == false)
        {
                return;
        }
        
        Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  name);
    }

}
