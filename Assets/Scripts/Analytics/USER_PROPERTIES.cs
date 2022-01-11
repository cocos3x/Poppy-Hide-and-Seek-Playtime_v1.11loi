using UnityEngine;

namespace Analytics
{
    public struct USER_PROPERTIES
    {
        // Fields
        private Analytics.USER_PROPERTIES_TYPE <user_properties>k__BackingField;
        private string <value>k__BackingField;
        
        // Properties
        public Analytics.USER_PROPERTIES_TYPE user_properties { get; set; }
        public string value { get; set; }
        
        // Methods
        public Analytics.USER_PROPERTIES_TYPE get_user_properties()
        {
            return (Analytics.USER_PROPERTIES_TYPE)this;
        }
        public void set_user_properties(Analytics.USER_PROPERTIES_TYPE value)
        {
            mem[1152921507214597488] = value;
        }
        public string get_value()
        {
            return (string)this;
        }
        public void set_value(string value)
        {
            mem[1152921507214829688] = value;
        }
    
    }

}
