using UnityEngine;

namespace Analytics
{
    public struct Feature_AD_STATUS
    {
        // Fields
        private Analytics.Feature_AD_STATUS.EVENT_NAME <eventName>k__BackingField;
        private Analytics.Feature_AD_STATUS.ACTION_NAME <action_name>k__BackingField;
        private string <status_Ad_position>k__BackingField;
        private Analytics.Feature_AD_STATUS.STATUS_RESULT <status_result>k__BackingField;
        private Analytics.Feature_AD_STATUS.STATUS_INTERNET <status_internet>k__BackingField;
        
        // Properties
        public Analytics.Feature_AD_STATUS.EVENT_NAME eventName { get; set; }
        public Analytics.Feature_AD_STATUS.ACTION_NAME action_name { get; set; }
        public string status_Ad_position { get; set; }
        public Analytics.Feature_AD_STATUS.STATUS_RESULT status_result { get; set; }
        public Analytics.Feature_AD_STATUS.STATUS_INTERNET status_internet { get; set; }
        
        // Methods
        public Analytics.Feature_AD_STATUS.EVENT_NAME get_eventName()
        {
            return (EVENT_NAME)this.<status_result>k__BackingField;
        }
        public void set_eventName(Analytics.Feature_AD_STATUS.EVENT_NAME value)
        {
            this.<status_result>k__BackingField = value;
        }
        public Analytics.Feature_AD_STATUS.ACTION_NAME get_action_name()
        {
            return (ACTION_NAME)this.<status_internet>k__BackingField;
        }
        public void set_action_name(Analytics.Feature_AD_STATUS.ACTION_NAME value)
        {
            this.<status_internet>k__BackingField = value;
        }
        public string get_status_Ad_position()
        {
            return (string)this;
        }
        public void set_status_Ad_position(string value)
        {
            mem[1152921507212027000] = value;
        }
        public Analytics.Feature_AD_STATUS.STATUS_RESULT get_status_result()
        {
            return (STATUS_RESULT)this;
        }
        public void set_status_result(Analytics.Feature_AD_STATUS.STATUS_RESULT value)
        {
            mem[1152921507212259200] = value;
        }
        public Analytics.Feature_AD_STATUS.STATUS_INTERNET get_status_internet()
        {
            return (STATUS_INTERNET)this;
        }
        public void set_status_internet(Analytics.Feature_AD_STATUS.STATUS_INTERNET value)
        {
            mem[1152921507212491396] = value;
        }
    
    }

}
