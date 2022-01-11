using UnityEngine;
[Serializable]
public class UserData
{
    // Fields
    public static UserData current;
    public System.DateTime activeTime;
    public int activeCount;
    public string name;
    public int level;
    public int coin;
    public int dayActive;
    public int session;
    public int fullAdsCount;
    public int rewardAdsCount;
    public bool removedAds;
    public bool rated;
    public string lastActiveTime;
    public string currentHiderId;
    public string currentSeekerId;
    public System.Collections.Generic.List<string> unlockCharacterIds;
    public System.Collections.Generic.List<RewardedAdCounter> rewardedAdCounters;
    public TempData tempData;
    public bool isDifferentDayFromLastSession;
    private static bool isLoaded;
    
    // Methods
    public void OnBeforeSerialize()
    {
        System.DateTime val_1 = System.DateTime.UtcNow;
        this.lastActiveTime = val_1.dateData;
    }
    public void OnAfterDeserialize()
    {
        int val_8;
        int val_8 = this.session;
        this.isDifferentDayFromLastSession = false;
        val_8 = val_8 + 1;
        this.session = val_8;
        if((System.DateTime.TryParse(s:  this.lastActiveTime, result: out  new System.DateTime())) == false)
        {
            goto label_3;
        }
        
        System.DateTime val_2 = System.DateTime.UtcNow;
        System.DateTime val_3 = val_2.dateData.Date;
        System.DateTime val_4 = 0.Date;
        if((System.DateTime.op_Inequality(d1:  new System.DateTime() {dateData = val_3.dateData}, d2:  new System.DateTime() {dateData = val_4.dateData})) == false)
        {
            goto label_8;
        }
        
        this.isDifferentDayFromLastSession = true;
        val_8 = this.dayActive + 1;
        goto label_7;
        label_3:
        if(this.dayActive != 0)
        {
            goto label_8;
        }
        
        val_8 = 1;
        label_7:
        this.dayActive = val_8;
        label_8:
        if(this.unlockCharacterIds != null)
        {
                if((this.unlockCharacterIds.Contains(item:  "hider_worker")) != true)
        {
                this.currentHiderId = "hider_worker";
            this.unlockCharacterIds.Add(item:  "hider_worker");
        }
        
            if((this.unlockCharacterIds.Contains(item:  "seeker_huggy_blue")) == true)
        {
                return;
        }
        
            this.currentSeekerId = "seeker_huggy_blue";
            this.unlockCharacterIds.Add(item:  "seeker_huggy_blue");
            return;
        }
        
        this.currentHiderId = "hider_worker";
        throw new NullReferenceException();
    }
    public string EncryptData(string data, string key)
    {
        return 0;
    }
    public string DecryptData(string data, string key)
    {
        return 0;
    }
    public static void Save()
    {
        if(UserData.current == null)
        {
                return;
        }
        
        null = null;
        if(UserData.isLoaded == false)
        {
                return;
        }
        
        UserData.__il2cppRuntimeField_static_fields.OnBeforeSerialize();
        UnityEngine.PlayerPrefs.SetString(key:  "user_data", value:  UnityEngine.JsonUtility.ToJson(obj:  UserData.current));
        UnityEngine.PlayerPrefs.Save();
    }
    public static bool Load(bool forceReload = False)
    {
        UserData val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_5 = forceReload;
        val_6 = null;
        val_6 = null;
        if((UserData.isLoaded != false) && (val_5 != true))
        {
                val_7 = 0;
            return (bool)(UserData.isLoaded == true) ? 1 : 0;
        }
        
        val_8 = null;
        val_5 = UnityEngine.JsonUtility.FromJson<UserData>(json:  UnityEngine.PlayerPrefs.GetString(key:  "user_data", defaultValue:  0));
        val_8 = null;
        UserData.current = val_5;
        val_9 = null;
        if(UserData.current == null)
        {
                UserData val_3 = null;
            val_5 = val_3;
            val_3 = new UserData();
            val_10 = null;
            val_10 = null;
            UserData.current = val_5;
            val_9 = null;
        }
        
        val_9 = null;
        val_3.OnAfterDeserialize();
        UserData.isLoaded = true;
        return (bool)(UserData.isLoaded == true) ? 1 : 0;
    }
    public UserData()
    {
        this.level = 1;
        this.name = "Me";
        this.unlockCharacterIds = new System.Collections.Generic.List<System.String>();
        this.rewardedAdCounters = new System.Collections.Generic.List<RewardedAdCounter>();
        this.tempData = new TempData();
    }
    private static UserData()
    {
    
    }

}
