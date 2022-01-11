using UnityEngine;

namespace Analytics
{
    public class TrackerController : MonoBehaviour
    {
        // Fields
        private static Analytics.TrackerController _instance;
        public bool enableLog;
        private System.Reflection.PropertyInfo[] propertyInfo;
        private System.Collections.Generic.List<string> parameterName;
        private System.Collections.Generic.List<string> parameterValue;
        private object stringCache;
        public bool firebaseIsReady;
        private string _null;
        
        // Properties
        public static Analytics.TrackerController Instance { get; }
        
        // Methods
        public static Analytics.TrackerController get_Instance()
        {
            if(Analytics.TrackerController._instance != 0)
            {
                    return (Analytics.TrackerController)Analytics.TrackerController._instance;
            }
            
            Analytics.TrackerController._instance = UnityEngine.Object.FindObjectOfType<Analytics.TrackerController>();
            return (Analytics.TrackerController)Analytics.TrackerController._instance;
        }
        private void Awake()
        {
            if(Analytics.TrackerController._instance != 0)
            {
                    if(Analytics.TrackerController._instance != this)
            {
                    UnityEngine.Object.Destroy(obj:  this.gameObject);
                return;
            }
            
            }
            
            Analytics.TrackerController._instance = this;
            this.parameterName = new System.Collections.Generic.List<System.String>();
            this.parameterValue = new System.Collections.Generic.List<System.String>();
            Firebase.Analytics.FirebaseAnalytics.SetUserId(userId:  UnityEngine.SystemInfo.deviceUniqueIdentifier);
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        }
        private void Start()
        {
            System.Threading.Tasks.Task val_3 = Firebase.Extensions.TaskExtension.ContinueWithOnMainThread<Firebase.DependencyStatus>(task:  Firebase.FirebaseApp.CheckAndFixDependenciesAsync(), continuation:  new System.Action<System.Threading.Tasks.Task<Firebase.DependencyStatus>>(object:  this, method:  System.Void Analytics.TrackerController::<Start>b__11_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)));
        }
        public void LogEvent(object eventType)
        {
            string val_8;
            System.Collections.Generic.List<System.String> val_9;
            if(this.firebaseIsReady == false)
            {
                    return;
            }
            
            this.propertyInfo = eventType.GetType().GetProperties();
            this.parameterName.Clear();
            this.parameterValue.Clear();
            val_8 = 1152921506647980224;
            var val_13 = 4;
            label_19:
            if((val_13 - 4) >= this.propertyInfo.Length)
            {
                goto label_7;
            }
            
            object val_4 = this.propertyInfo[0].GetValue(obj:  eventType);
            this.stringCache = val_4;
            if(val_4 != null)
            {
                    if((val_4.Equals(value:  this._null)) != true)
            {
                    this.parameterName.Add(item:  this.propertyInfo[0]);
                this.parameterValue.Add(item:  this.stringCache);
            }
            
            }
            
            val_13 = val_13 + 1;
            if(this.propertyInfo != null)
            {
                goto label_19;
            }
            
            label_7:
            System.Collections.Generic.List<System.String> val_14 = this.parameterName;
            System.Collections.Generic.List<System.String> val_6 = val_14 - 1;
            Firebase.Analytics.Parameter[] val_7 = new Firebase.Analytics.Parameter[0];
            val_9 = this.parameterName;
            var val_15 = 0;
            label_31:
            var val_8 = val_15 + 1;
            if(val_8 >= val_14)
            {
                goto label_23;
            }
            
            val_14 = val_14 & 4294967295;
            if(val_8 >= val_14)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            if(val_8 >= 1152921505689689456)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_8 = mem[typeof(System.Collections.Generic.List<T>).SyncRoot + 40];
            var val_10 = val_8 - 1;
            mem2[0] = new Firebase.Analytics.Parameter(parameterName:  typeof(System.Collections.Generic.List<T>).__il2cppRuntimeField_28, parameterValue:  val_8);
            val_9 = this.parameterName;
            val_15 = val_15 + 1;
            if(val_9 != null)
            {
                goto label_31;
            }
            
            throw new NullReferenceException();
            label_23:
            if(val_7.Length == 0)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  "Unrecognized control character.", parameters:  val_7);
        }
        public void LogEventML(string eventName)
        {
            Firebase.Analytics.FirebaseAnalytics.LogEvent(name:  eventName);
        }
        public void SetUserProperties(object eventType)
        {
            if(this.firebaseIsReady == false)
            {
                    return;
            }
            
            System.Reflection.PropertyInfo[] val_2 = eventType.GetType().GetProperties();
            this.propertyInfo = val_2;
            Firebase.Analytics.FirebaseAnalytics.SetUserProperty(name:  val_2[0].GetValue(obj:  eventType), property:  this.propertyInfo[1].GetValue(obj:  eventType));
        }
        public TrackerController()
        {
            this.enableLog = true;
            this._null = "NONE";
        }
        private void <Start>b__11_0(System.Threading.Tasks.Task<Firebase.DependencyStatus> task)
        {
            Firebase.DependencyStatus val_1 = task.Result;
            if(val_1 != 0)
            {
                    UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Could not resolve all Firebase dependencies: {0}", arg0:  val_1));
                UnityEngine.MonoBehaviour.print(message:  "google rc failed");
                return;
            }
            
            this.firebaseIsReady = true;
            Analytics.Tracker.NotifyFirebaseReadyEvent();
        }
    
    }

}
