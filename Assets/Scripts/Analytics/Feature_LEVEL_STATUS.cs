using UnityEngine;

namespace Analytics
{
    public struct Feature_LEVEL_STATUS
    {
        // Fields
        private Analytics.Feature_LEVEL_STATUS.EVENT_NAME <eventName>k__BackingField;
        private Analytics.Feature_LEVEL_STATUS.ACTION_NAME <action_name>k__BackingField;
        private string <level>k__BackingField;
        public Analytics.Feature_LEVEL_STATUS.USE_HELP use_help;
        
        // Properties
        public Analytics.Feature_LEVEL_STATUS.EVENT_NAME eventName { get; set; }
        public Analytics.Feature_LEVEL_STATUS.ACTION_NAME action_name { get; set; }
        public string level { get; set; }
        
        // Methods
        public Analytics.Feature_LEVEL_STATUS.EVENT_NAME get_eventName()
        {
            return (EVENT_NAME)this.use_help;
        }
        public void set_eventName(Analytics.Feature_LEVEL_STATUS.EVENT_NAME value)
        {
            this.use_help = value;
        }
        public Analytics.Feature_LEVEL_STATUS.ACTION_NAME get_action_name()
        {
            return (ACTION_NAME)this;
        }
        public void set_action_name(Analytics.Feature_LEVEL_STATUS.ACTION_NAME value)
        {
            mem[1152921507212963956] = value;
        }
        public string get_level()
        {
            return (string)this;
        }
        public void set_level(string value)
        {
            mem[1152921507213196152] = value;
        }
    
    }

}
