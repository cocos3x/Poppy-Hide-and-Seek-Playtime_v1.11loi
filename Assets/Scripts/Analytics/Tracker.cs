using UnityEngine;

namespace Analytics
{
    public static class Tracker
    {
        // Fields
        private static System.Action OnFirebaseReady;
        
        // Properties
        public static bool IsReady { get; }
        
        // Methods
        public static bool get_IsReady()
        {
            Analytics.TrackerController val_1 = Analytics.TrackerController.Instance;
            return (bool)val_1.firebaseIsReady;
        }
        public static void LogEvent(object eventType)
        {
            Analytics.TrackerController.Instance.LogEvent(eventType:  eventType);
        }
        public static void SetUserProperties(object eventType)
        {
            Analytics.TrackerController.Instance.SetUserProperties(eventType:  eventType);
        }
        public static void LogEventML(Analytics.ML_EVENT_TYPE eventName)
        {
            Analytics.TrackerController val_1 = Analytics.TrackerController.Instance;
            eventName.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            eventName.LogEventML(eventName:  eventName.ToString());
        }
        public static void add_OnFirebaseReady(System.Action value)
        {
            if((System.Delegate.Combine(a:  Analytics.Tracker.OnFirebaseReady, b:  value)) == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        public static void remove_OnFirebaseReady(System.Action value)
        {
            if((System.Delegate.Remove(source:  Analytics.Tracker.OnFirebaseReady, value:  value)) == null)
            {
                    return;
            }
            
            if(null == null)
            {
                    return;
            }
        
        }
        internal static void NotifyFirebaseReadyEvent()
        {
            if(Analytics.Tracker.OnFirebaseReady != null)
            {
                    Analytics.Tracker.OnFirebaseReady.Invoke();
            }
            
            Analytics.Tracker.OnFirebaseReady = 0;
        }
    
    }

}
