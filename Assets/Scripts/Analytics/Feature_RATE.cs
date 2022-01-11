using UnityEngine;

namespace Analytics
{
    public struct Feature_RATE
    {
        // Fields
        private Analytics.Feature_RATE.EVENT_NAME <eventName>k__BackingField;
        private string <star>k__BackingField;
        private string <level>k__BackingField;
        
        // Properties
        public Analytics.Feature_RATE.EVENT_NAME eventName { get; set; }
        public string star { get; set; }
        public string level { get; set; }
        
        // Methods
        public Analytics.Feature_RATE.EVENT_NAME get_eventName()
        {
            return (EVENT_NAME)this.<level>k__BackingField;
        }
        public void set_eventName(Analytics.Feature_RATE.EVENT_NAME value)
        {
            this.<level>k__BackingField = value;
        }
        public string get_star()
        {
            return (string)this;
        }
        public void set_star(string value)
        {
            mem[1152921507214133112] = value;
        }
        public string get_level()
        {
            return (string)this;
        }
        public void set_level(string value)
        {
            mem[1152921507214365312] = value;
        }
    
    }

}
