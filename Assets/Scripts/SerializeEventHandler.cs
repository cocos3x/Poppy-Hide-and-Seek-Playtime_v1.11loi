using UnityEngine;
public class SerializeEventHandler : MonoBehaviour
{
    // Fields
    public bool saveData;
    public UserData userData;
    
    // Methods
    private void Awake()
    {
        if((UnityEngine.Object.FindObjectOfType<SerializeEventHandler>()) != this)
        {
                UnityEngine.Object.Destroy(obj:  this.gameObject);
            return;
        }
        
        bool val_4 = UserData.Load(forceReload:  false);
        this.userData = UserData.current;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void OnApplicationQuit()
    {
        this.SaveData();
    }
    public void OnApplicationPause(bool pause)
    {
        if(pause == false)
        {
                return;
        }
        
        this.SaveData();
    }
    public void SaveData()
    {
        this.saveData = true;
        UserData.Save();
        UnityEngine.PlayerPrefs.Save();
    }
    public SerializeEventHandler()
    {
        this.saveData = true;
    }

}
