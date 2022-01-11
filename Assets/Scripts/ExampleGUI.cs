using UnityEngine;
public class ExampleGUI : MonoBehaviour
{
    // Fields
    private int numberOfButtons;
    private bool isEnabled;
    private bool showPopUp;
    private string txtSetEnabled;
    private string txtManualLaunch;
    private string txtSetOfflineMode;
    
    // Methods
    private void OnGUI()
    {
        var val_64;
        System.Action<System.String> val_66;
        string val_67;
        string val_68;
        if(this.showPopUp != false)
        {
                int val_1 = UnityEngine.Screen.width;
            int val_2 = UnityEngine.Screen.height;
            var val_3 = (val_1 < 0) ? (val_1 + 1) : (val_1);
            val_3 = val_3 >> 1;
            var val_4 = (val_2 < 0) ? (val_2 + 1) : (val_2);
            val_3 = val_3 - 150;
            val_4 = val_4 >> 1;
            var val_5 = val_4 - 65;
            UnityEngine.Rect val_7 = UnityEngine.GUI.Window(id:  0, clientRect:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, func:  new GUI.WindowFunction(object:  this, method:  System.Void ExampleGUI::ShowGUI(int windowID)), text:  "Is SDK enabled?");
        }
        
        int val_8 = UnityEngine.Screen.height;
        int val_9 = UnityEngine.Screen.width;
        int val_64 = this.numberOfButtons;
        val_64 = UnityEngine.Screen.height / val_64;
        if(((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtManualLaunch)) != false) && ((System.String.Equals(a:  this.txtManualLaunch, b:  "SDK Launched", comparisonType:  5)) != true))
        {
                com.adjust.sdk.AdjustConfig val_13 = new com.adjust.sdk.AdjustConfig(appToken:  "2fm9gkqubvpc", environment:  0);
            val_13.setLogLevel(logLevel:  1);
            val_64 = null;
            val_64 = null;
            val_66 = ExampleGUI.<>c.<>9__6_0;
            if(val_66 == null)
        {
                System.Action<System.String> val_14 = null;
            val_66 = val_14;
            val_14 = new System.Action<System.String>(object:  ExampleGUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ExampleGUI.<>c::<OnGUI>b__6_0(string msg));
            ExampleGUI.<>c.<>9__6_0 = val_66;
        }
        
            .logDelegate = val_66;
            val_13.setEventSuccessDelegate(eventSuccessDelegate:  new System.Action<com.adjust.sdk.AdjustEventSuccess>(object:  this, method:  public System.Void ExampleGUI::EventSuccessCallback(com.adjust.sdk.AdjustEventSuccess eventSuccessData)), sceneName:  "Adjust");
            val_13.setEventFailureDelegate(eventFailureDelegate:  new System.Action<com.adjust.sdk.AdjustEventFailure>(object:  this, method:  public System.Void ExampleGUI::EventFailureCallback(com.adjust.sdk.AdjustEventFailure eventFailureData)), sceneName:  "Adjust");
            val_13.setSessionSuccessDelegate(sessionSuccessDelegate:  new System.Action<com.adjust.sdk.AdjustSessionSuccess>(object:  this, method:  public System.Void ExampleGUI::SessionSuccessCallback(com.adjust.sdk.AdjustSessionSuccess sessionSuccessData)), sceneName:  "Adjust");
            val_13.setSessionFailureDelegate(sessionFailureDelegate:  new System.Action<com.adjust.sdk.AdjustSessionFailure>(object:  this, method:  public System.Void ExampleGUI::SessionFailureCallback(com.adjust.sdk.AdjustSessionFailure sessionFailureData)), sceneName:  "Adjust");
            val_13.setDeferredDeeplinkDelegate(deferredDeeplinkDelegate:  new System.Action<System.String>(object:  this, method:  System.Void ExampleGUI::DeferredDeeplinkCallback(string deeplinkURL)), sceneName:  "Adjust");
            val_13.setAttributionChangedDelegate(attributionChangedDelegate:  new System.Action<com.adjust.sdk.AdjustAttribution>(object:  this, method:  public System.Void ExampleGUI::AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attributionData)), sceneName:  "Adjust");
            com.adjust.sdk.Adjust.start(adjustConfig:  val_13);
            this.isEnabled = true;
            this.txtManualLaunch = "SDK Launched";
        }
        
        int val_22 = UnityEngine.Screen.width;
        int val_65 = this.numberOfButtons;
        int val_24 = UnityEngine.Screen.height / this.numberOfButtons;
        val_65 = UnityEngine.Screen.height / val_65;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Simple Event")) != false)
        {
                com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  "g3mfiw"));
        }
        
        int val_28 = UnityEngine.Screen.width;
        int val_66 = this.numberOfButtons;
        int val_30 = UnityEngine.Screen.height << 1;
        val_30 = val_30 / this.numberOfButtons;
        val_66 = UnityEngine.Screen.height / val_66;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Revenue Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_32 = new com.adjust.sdk.AdjustEvent(eventToken:  "a4fd35");
            val_32.setRevenue(amount:  0.25, currency:  "EUR");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_32);
        }
        
        int val_33 = UnityEngine.Screen.height;
        int val_34 = UnityEngine.Screen.width;
        int val_67 = this.numberOfButtons;
        int val_36 = val_33 + (val_33 << 1);
        val_36 = val_36 / this.numberOfButtons;
        val_67 = UnityEngine.Screen.height / val_67;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Callback Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_38 = new com.adjust.sdk.AdjustEvent(eventToken:  "34vgg9");
            val_38.addCallbackParameter(key:  "key", value:  "value");
            val_38.addCallbackParameter(key:  "foo", value:  "bar");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_38);
        }
        
        int val_40 = UnityEngine.Screen.width;
        int val_68 = this.numberOfButtons;
        int val_42 = UnityEngine.Screen.height << 2;
        val_42 = val_42 / this.numberOfButtons;
        val_68 = UnityEngine.Screen.height / val_68;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Track Partner Event")) != false)
        {
                com.adjust.sdk.AdjustEvent val_44 = new com.adjust.sdk.AdjustEvent(eventToken:  "w788qs");
            val_44.addPartnerParameter(key:  "key", value:  "value");
            val_44.addPartnerParameter(key:  "foo", value:  "bar");
            com.adjust.sdk.Adjust.trackEvent(adjustEvent:  val_44);
        }
        
        int val_45 = UnityEngine.Screen.height;
        int val_46 = UnityEngine.Screen.width;
        int val_69 = this.numberOfButtons;
        int val_48 = val_45 + (val_45 << 2);
        val_48 = val_48 / this.numberOfButtons;
        val_69 = UnityEngine.Screen.height / val_69;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtSetOfflineMode)) != false)
        {
                if((System.String.Equals(a:  this.txtSetOfflineMode, b:  "Turn Offline Mode ON", comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  true);
            val_67 = "Turn Offline Mode OFF";
        }
        else
        {
                com.adjust.sdk.Adjust.setOfflineMode(enabled:  false);
            val_67 = "Turn Offline Mode ON";
        }
        
            this.txtSetOfflineMode = val_67;
        }
        
        int val_51 = UnityEngine.Screen.height;
        int val_52 = UnityEngine.Screen.width;
        int val_70 = this.numberOfButtons;
        int val_54 = val_51 + (val_51 << 1);
        val_54 = val_54 << 1;
        val_54 = val_54 / this.numberOfButtons;
        val_70 = UnityEngine.Screen.height / val_70;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  this.txtSetEnabled)) != false)
        {
                if((System.String.Equals(a:  this.txtSetEnabled, b:  "Disable SDK", comparisonType:  5)) != false)
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  false);
            val_68 = "Enable SDK";
        }
        else
        {
                com.adjust.sdk.Adjust.setEnabled(enabled:  true);
            val_68 = "Disable SDK";
        }
        
            this.txtSetEnabled = val_68;
        }
        
        int val_57 = UnityEngine.Screen.height;
        int val_58 = UnityEngine.Screen.width;
        int val_71 = this.numberOfButtons;
        int val_60 = val_57 << 3;
        val_60 = val_60 - val_57;
        val_60 = val_60 / this.numberOfButtons;
        val_71 = UnityEngine.Screen.height / val_71;
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "Is SDK Enabled?")) == false)
        {
                return;
        }
        
        this.isEnabled = com.adjust.sdk.Adjust.isEnabled();
        this.showPopUp = true;
    }
    private void ShowGUI(int windowID)
    {
        string val_2;
        if(this.isEnabled != false)
        {
                val_2 = "Adjust SDK is ENABLED!";
        }
        else
        {
                val_2 = "Adjust SDK is DISABLED!";
        }
        
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  val_2);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, text:  "OK")) == false)
        {
                return;
        }
        
        this.showPopUp = false;
    }
    public void HandleGooglePlayId(string adId)
    {
        UnityEngine.Debug.Log(message:  "Google Play Ad ID = "("Google Play Ad ID = ") + adId);
    }
    public void AttributionChangedCallback(com.adjust.sdk.AdjustAttribution attributionData)
    {
        UnityEngine.Debug.Log(message:  "Attribution changed!");
        if((attributionData.<trackerName>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Tracker name: "("Tracker name: ") + attributionData.<trackerName>k__BackingField(attributionData.<trackerName>k__BackingField));
        }
        
        if((attributionData.<trackerToken>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Tracker token: "("Tracker token: ") + attributionData.<trackerToken>k__BackingField(attributionData.<trackerToken>k__BackingField));
        }
        
        if((attributionData.<network>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Network: "("Network: ") + attributionData.<network>k__BackingField(attributionData.<network>k__BackingField));
        }
        
        if((attributionData.<campaign>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Campaign: "("Campaign: ") + attributionData.<campaign>k__BackingField(attributionData.<campaign>k__BackingField));
        }
        
        if((attributionData.<adgroup>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Adgroup: "("Adgroup: ") + attributionData.<adgroup>k__BackingField(attributionData.<adgroup>k__BackingField));
        }
        
        if((attributionData.<creative>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Creative: "("Creative: ") + attributionData.<creative>k__BackingField(attributionData.<creative>k__BackingField));
        }
        
        if((attributionData.<clickLabel>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Click label: "("Click label: ") + attributionData.<clickLabel>k__BackingField(attributionData.<clickLabel>k__BackingField));
        }
        
        if((attributionData.<adid>k__BackingField) == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "ADID: "("ADID: ") + attributionData.<adid>k__BackingField(attributionData.<adid>k__BackingField));
    }
    public void EventSuccessCallback(com.adjust.sdk.AdjustEventSuccess eventSuccessData)
    {
        UnityEngine.Debug.Log(message:  "Event tracked successfully!");
        if((eventSuccessData.<Message>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + eventSuccessData.<Message>k__BackingField(eventSuccessData.<Message>k__BackingField));
        }
        
        if((eventSuccessData.<Timestamp>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + eventSuccessData.<Timestamp>k__BackingField(eventSuccessData.<Timestamp>k__BackingField));
        }
        
        if((eventSuccessData.<Adid>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + eventSuccessData.<Adid>k__BackingField(eventSuccessData.<Adid>k__BackingField));
        }
        
        if((eventSuccessData.<EventToken>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "EventToken: "("EventToken: ") + eventSuccessData.<EventToken>k__BackingField(eventSuccessData.<EventToken>k__BackingField));
        }
        
        if((eventSuccessData.<CallbackId>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "CallbackId: "("CallbackId: ") + eventSuccessData.<CallbackId>k__BackingField(eventSuccessData.<CallbackId>k__BackingField));
        }
        
        if((eventSuccessData.<JsonResponse>k__BackingField) == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + eventSuccessData.GetJsonResponse());
    }
    public void EventFailureCallback(com.adjust.sdk.AdjustEventFailure eventFailureData)
    {
        UnityEngine.Debug.Log(message:  "Event tracking failed!");
        if((eventFailureData.<Message>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + eventFailureData.<Message>k__BackingField(eventFailureData.<Message>k__BackingField));
        }
        
        if((eventFailureData.<Timestamp>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + eventFailureData.<Timestamp>k__BackingField(eventFailureData.<Timestamp>k__BackingField));
        }
        
        if((eventFailureData.<Adid>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + eventFailureData.<Adid>k__BackingField(eventFailureData.<Adid>k__BackingField));
        }
        
        if((eventFailureData.<EventToken>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "EventToken: "("EventToken: ") + eventFailureData.<EventToken>k__BackingField(eventFailureData.<EventToken>k__BackingField));
        }
        
        if((eventFailureData.<CallbackId>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "CallbackId: "("CallbackId: ") + eventFailureData.<CallbackId>k__BackingField(eventFailureData.<CallbackId>k__BackingField));
        }
        
        if((eventFailureData.<JsonResponse>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + eventFailureData.GetJsonResponse());
        }
        
        UnityEngine.Debug.Log(message:  "WillRetry: "("WillRetry: ") + eventFailureData.<WillRetry>k__BackingField.ToString()(eventFailureData.<WillRetry>k__BackingField.ToString()));
    }
    public void SessionSuccessCallback(com.adjust.sdk.AdjustSessionSuccess sessionSuccessData)
    {
        UnityEngine.Debug.Log(message:  "Session tracked successfully!");
        if((sessionSuccessData.<Message>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + sessionSuccessData.<Message>k__BackingField(sessionSuccessData.<Message>k__BackingField));
        }
        
        if((sessionSuccessData.<Timestamp>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + sessionSuccessData.<Timestamp>k__BackingField(sessionSuccessData.<Timestamp>k__BackingField));
        }
        
        if((sessionSuccessData.<Adid>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + sessionSuccessData.<Adid>k__BackingField(sessionSuccessData.<Adid>k__BackingField));
        }
        
        if((sessionSuccessData.<JsonResponse>k__BackingField) == null)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + sessionSuccessData.GetJsonResponse());
    }
    public void SessionFailureCallback(com.adjust.sdk.AdjustSessionFailure sessionFailureData)
    {
        UnityEngine.Debug.Log(message:  "Session tracking failed!");
        if((sessionFailureData.<Message>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Message: "("Message: ") + sessionFailureData.<Message>k__BackingField(sessionFailureData.<Message>k__BackingField));
        }
        
        if((sessionFailureData.<Timestamp>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Timestamp: "("Timestamp: ") + sessionFailureData.<Timestamp>k__BackingField(sessionFailureData.<Timestamp>k__BackingField));
        }
        
        if((sessionFailureData.<Adid>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "Adid: "("Adid: ") + sessionFailureData.<Adid>k__BackingField(sessionFailureData.<Adid>k__BackingField));
        }
        
        if((sessionFailureData.<JsonResponse>k__BackingField) != null)
        {
                UnityEngine.Debug.Log(message:  "JsonResponse: "("JsonResponse: ") + sessionFailureData.GetJsonResponse());
        }
        
        UnityEngine.Debug.Log(message:  "WillRetry: "("WillRetry: ") + sessionFailureData.<WillRetry>k__BackingField.ToString()(sessionFailureData.<WillRetry>k__BackingField.ToString()));
    }
    private void DeferredDeeplinkCallback(string deeplinkURL)
    {
        string val_2;
        object val_3;
        val_2 = deeplinkURL;
        UnityEngine.Debug.Log(message:  "Deferred deeplink reported!");
        if(val_2 != null)
        {
                val_2 = "Deeplink URL: "("Deeplink URL: ") + val_2;
            val_3 = val_2;
        }
        else
        {
                val_3 = "Deeplink URL is null!";
        }
        
        UnityEngine.Debug.Log(message:  val_3);
    }
    public ExampleGUI()
    {
        this.numberOfButtons = 8;
        this.txtSetEnabled = "Disable SDK";
        this.txtManualLaunch = "Manual Launch";
        this.txtSetOfflineMode = "Turn Offline Mode ON";
    }

}
