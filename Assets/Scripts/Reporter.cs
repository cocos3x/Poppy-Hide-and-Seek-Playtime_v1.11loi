using UnityEngine;
public class Reporter : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<Reporter.Sample> samples;
    private System.Collections.Generic.List<Reporter.Log> logs;
    private System.Collections.Generic.List<Reporter.Log> collapsedLogs;
    private System.Collections.Generic.List<Reporter.Log> currentLog;
    private MultiKeyDictionary<string, string, Reporter.Log> logsDic;
    private System.Collections.Generic.Dictionary<string, string> cachedString;
    public bool show;
    private bool collapse;
    private bool clearOnNewSceneLoaded;
    private bool showTime;
    private bool showScene;
    private bool showMemory;
    private bool showFps;
    private bool showGraph;
    private bool showLog;
    private bool showWarning;
    private bool showError;
    private int numOfLogs;
    private int numOfLogsWarning;
    private int numOfLogsError;
    private int numOfCollapsedLogs;
    private int numOfCollapsedLogsWarning;
    private int numOfCollapsedLogsError;
    private bool showClearOnNewSceneLoadedButton;
    private bool showTimeButton;
    private bool showSceneButton;
    private bool showMemButton;
    private bool showFpsButton;
    private bool showSearchText;
    private bool showCopyButton;
    private bool showSaveButton;
    private string buildDate;
    private string logDate;
    private float logsMemUsage;
    private float graphMemUsage;
    private float gcTotalMemory;
    public string UserData;
    public float fps;
    public string fpsText;
    private Reporter.ReportView currentView;
    private static bool created;
    public Images images;
    private UnityEngine.GUIContent clearContent;
    private UnityEngine.GUIContent collapseContent;
    private UnityEngine.GUIContent clearOnNewSceneContent;
    private UnityEngine.GUIContent showTimeContent;
    private UnityEngine.GUIContent showSceneContent;
    private UnityEngine.GUIContent userContent;
    private UnityEngine.GUIContent showMemoryContent;
    private UnityEngine.GUIContent softwareContent;
    private UnityEngine.GUIContent dateContent;
    private UnityEngine.GUIContent showFpsContent;
    private UnityEngine.GUIContent infoContent;
    private UnityEngine.GUIContent saveLogsContent;
    private UnityEngine.GUIContent searchContent;
    private UnityEngine.GUIContent copyContent;
    private UnityEngine.GUIContent closeContent;
    private UnityEngine.GUIContent buildFromContent;
    private UnityEngine.GUIContent systemInfoContent;
    private UnityEngine.GUIContent graphicsInfoContent;
    private UnityEngine.GUIContent backContent;
    private UnityEngine.GUIContent logContent;
    private UnityEngine.GUIContent warningContent;
    private UnityEngine.GUIContent errorContent;
    private UnityEngine.GUIStyle barStyle;
    private UnityEngine.GUIStyle buttonActiveStyle;
    private UnityEngine.GUIStyle nonStyle;
    private UnityEngine.GUIStyle lowerLeftFontStyle;
    private UnityEngine.GUIStyle backStyle;
    private UnityEngine.GUIStyle evenLogStyle;
    private UnityEngine.GUIStyle oddLogStyle;
    private UnityEngine.GUIStyle logButtonStyle;
    private UnityEngine.GUIStyle selectedLogStyle;
    private UnityEngine.GUIStyle selectedLogFontStyle;
    private UnityEngine.GUIStyle stackLabelStyle;
    private UnityEngine.GUIStyle scrollerStyle;
    private UnityEngine.GUIStyle searchStyle;
    private UnityEngine.GUIStyle sliderBackStyle;
    private UnityEngine.GUIStyle sliderThumbStyle;
    private UnityEngine.GUISkin toolbarScrollerSkin;
    private UnityEngine.GUISkin logScrollerSkin;
    private UnityEngine.GUISkin graphScrollerSkin;
    public UnityEngine.Vector2 size;
    public float maxSize;
    public int numOfCircleToShow;
    private static string[] scenes;
    private string currentScene;
    private string filterText;
    private string deviceModel;
    private string deviceType;
    private string deviceName;
    private string graphicsMemorySize;
    private string maxTextureSize;
    private string systemMemorySize;
    public bool Initialized;
    private UnityEngine.Rect screenRect;
    private UnityEngine.Rect toolBarRect;
    private UnityEngine.Rect logsRect;
    private UnityEngine.Rect stackRect;
    private UnityEngine.Rect graphRect;
    private UnityEngine.Rect graphMinRect;
    private UnityEngine.Rect graphMaxRect;
    private UnityEngine.Rect buttomRect;
    private UnityEngine.Vector2 stackRectTopLeft;
    private UnityEngine.Rect detailRect;
    private UnityEngine.Vector2 scrollPosition;
    private UnityEngine.Vector2 scrollPosition2;
    private UnityEngine.Vector2 toolbarScrollPosition;
    private Reporter.Log selectedLog;
    private float toolbarOldDrag;
    private float oldDrag;
    private float oldDrag2;
    private float oldDrag3;
    private int startIndex;
    private UnityEngine.Rect countRect;
    private UnityEngine.Rect timeRect;
    private UnityEngine.Rect timeLabelRect;
    private UnityEngine.Rect sceneRect;
    private UnityEngine.Rect sceneLabelRect;
    private UnityEngine.Rect memoryRect;
    private UnityEngine.Rect memoryLabelRect;
    private UnityEngine.Rect fpsRect;
    private UnityEngine.Rect fpsLabelRect;
    private UnityEngine.GUIContent tempContent;
    private UnityEngine.Vector2 infoScrollPosition;
    private UnityEngine.Vector2 oldInfoDrag;
    private UnityEngine.Rect tempRect;
    private float graphSize;
    private int startFrame;
    private int currentFrame;
    private UnityEngine.Vector3 tempVector1;
    private UnityEngine.Vector3 tempVector2;
    private UnityEngine.Vector2 graphScrollerPos;
    private float maxFpsValue;
    private float minFpsValue;
    private float maxMemoryValue;
    private float minMemoryValue;
    private System.Collections.Generic.List<UnityEngine.Vector2> gestureDetector;
    private UnityEngine.Vector2 gestureSum;
    private float gestureLength;
    private int gestureCount;
    private float lastClickTime;
    private UnityEngine.Vector2 startPos;
    private UnityEngine.Vector2 downPos;
    private UnityEngine.Vector2 mousePosition;
    private int frames;
    private bool firstTime;
    private float lastUpdate;
    private const int requiredFrames = 10;
    private const float updateInterval = 0.25;
    private System.Collections.Generic.List<Reporter.Log> threadedLogs;
    
    // Properties
    public float TotalMemUsage { get; }
    
    // Methods
    public float get_TotalMemUsage()
    {
        float val_1 = this.logsMemUsage;
        val_1 = val_1 + this.graphMemUsage;
        return (float)val_1;
    }
    private void Awake()
    {
        if(this.Initialized != true)
        {
                this.Initialize();
        }
        
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Reporter::_OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)));
    }
    private void OnDestroy()
    {
        UnityEngine.SceneManagement.SceneManager.remove_sceneLoaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  this, method:  System.Void Reporter::_OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)));
    }
    private void OnEnable()
    {
        if(this.logs != null)
        {
                return;
        }
        
        this.clear();
    }
    private void OnDisable()
    {
    
    }
    private void addSample()
    {
        .fps = this.fps;
        .fpsText = this.fpsText;
        UnityEngine.SceneManagement.Scene val_2 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        .loadedScene = val_2.m_Handle.buildIndex;
        float val_4 = UnityEngine.Time.realtimeSinceStartup;
        .time = val_4;
        .memory = this.gcTotalMemory;
        this.samples.Add(item:  new Reporter.Sample());
        float val_5 = val_4;
        val_5 = val_5 * 13f;
        val_5 = val_5 * 0.0009765625f;
        val_5 = val_5 * 0.0009765625f;
        this.graphMemUsage = val_5;
    }
    public void Initialize()
    {
        UnityEngine.Object val_82;
        var val_83;
        var val_84;
        LogCallback val_85;
        string val_86;
        val_82 = this;
        val_83 = null;
        val_83 = null;
        if(Reporter.updateInterval != 0)
        {
                UnityEngine.Debug.LogWarning(message:  "tow manager is exists delete the second");
            val_82 = this.gameObject;
            UnityEngine.Object.DestroyImmediate(obj:  val_82, allowDestroyingAssets:  true);
            return;
        }
        
        this.gameObject.SendMessage(methodName:  "OnPreStart");
        int val_3 = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
        val_84 = null;
        val_84 = null;
        Reporter.scenes = new string[0];
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.currentScene = val_5.m_Handle.name;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        Application.LogCallback val_8 = new Application.LogCallback(object:  this, method:  System.Void Reporter::CaptureLogThread(string condition, string stacktrace, UnityEngine.LogType type));
        val_85 = val_8;
        val_86 = 0;
        UnityEngine.Application.add_logMessageReceivedThreaded(value:  val_8);
        Reporter.updateInterval = 1.401298E-45f;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_9 = null;
        val_86 = "";
        val_9 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.clearImage, tooltip:  "Clear logs");
        this.clearContent = val_9;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_10 = null;
        val_86 = "";
        val_10 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.collapseImage, tooltip:  "Collapse logs");
        this.collapseContent = val_10;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_11 = null;
        val_86 = "";
        val_11 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.clearOnNewSceneImage, tooltip:  "Clear logs on new scene loaded");
        this.clearOnNewSceneContent = val_11;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_12 = null;
        val_86 = "";
        val_12 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.showTimeImage, tooltip:  "Show Hide Time");
        this.showTimeContent = val_12;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_13 = null;
        val_86 = "";
        val_13 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.showSceneImage, tooltip:  "Show Hide Scene");
        this.showSceneContent = val_13;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_14 = null;
        val_86 = "";
        val_14 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.showMemoryImage, tooltip:  "Show Hide Memory");
        this.showMemoryContent = val_14;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_15 = null;
        val_86 = "";
        val_15 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.softwareImage, tooltip:  "Software");
        this.softwareContent = val_15;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_16 = null;
        val_86 = "";
        val_16 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.dateImage, tooltip:  "Date");
        this.dateContent = val_16;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_17 = null;
        val_86 = "";
        val_17 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.showFpsImage, tooltip:  "Show Hide fps");
        this.showFpsContent = val_17;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_18 = null;
        val_86 = "";
        val_18 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.infoImage, tooltip:  11143856);
        this.infoContent = val_18;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_19 = null;
        val_86 = "";
        val_19 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.saveLogsImage, tooltip:  "Save logs to device");
        this.saveLogsContent = val_19;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_20 = null;
        val_86 = "";
        val_20 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.searchImage, tooltip:  "Search for logs");
        this.searchContent = val_20;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_21 = null;
        val_86 = "";
        val_21 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.copyImage, tooltip:  "Copy log to clipboard");
        this.copyContent = val_21;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_22 = null;
        val_86 = "";
        val_22 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.closeImage, tooltip:  "Hide logs");
        this.closeContent = val_22;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_23 = null;
        val_86 = "";
        val_23 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.userImage, tooltip:  "User");
        this.userContent = val_23;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_24 = null;
        val_86 = "";
        val_24 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.buildFromImage, tooltip:  "Build From");
        this.buildFromContent = val_24;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_25 = null;
        val_86 = "";
        val_25 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.systemInfoImage, tooltip:  "System Info");
        this.systemInfoContent = val_25;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_26 = null;
        val_86 = "";
        val_26 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.graphicsInfoImage, tooltip:  "Graphics Info");
        this.graphicsInfoContent = val_26;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_27 = null;
        val_86 = "";
        val_27 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.backImage, tooltip:  "Back");
        this.backContent = val_27;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_28 = null;
        val_86 = "";
        val_28 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.logImage, tooltip:  "show or hide logs");
        this.logContent = val_28;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        UnityEngine.GUIContent val_29 = null;
        val_86 = "";
        val_29 = new UnityEngine.GUIContent(text:  val_86, image:  this.images.warningImage, tooltip:  "show or hide warnings");
        this.warningContent = val_29;
        if(this.images == null)
        {
                throw new NullReferenceException();
        }
        
        this.errorContent = new UnityEngine.GUIContent(text:  "", image:  this.images.errorImage, tooltip:  "show or hide errors");
        this.currentView = UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_currentView", defaultValue:  1);
        this.show = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_show")) == 1) ? 1 : 0;
        this.collapse = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_collapse")) == 1) ? 1 : 0;
        this.clearOnNewSceneLoaded = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_clearOnNewSceneLoaded")) == 1) ? 1 : 0;
        this.showTime = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showTime")) == 1) ? 1 : 0;
        this.showScene = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showScene")) == 1) ? 1 : 0;
        this.showMemory = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showMemory")) == 1) ? 1 : 0;
        this.showFps = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showFps")) == 1) ? 1 : 0;
        this.showGraph = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showGraph")) == 1) ? 1 : 0;
        this.showLog = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showLog", defaultValue:  1)) == 1) ? 1 : 0;
        this.showWarning = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showWarning", defaultValue:  1)) == 1) ? 1 : 0;
        this.showError = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showError", defaultValue:  1)) == 1) ? 1 : 0;
        this.filterText = UnityEngine.PlayerPrefs.GetString(key:  "Reporter_filterText");
        float val_55 = UnityEngine.PlayerPrefs.GetFloat(key:  "Reporter_size", defaultValue:  32f);
        mem[1152921507196938564] = val_55;
        this.size = val_55;
        this.showClearOnNewSceneLoadedButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showClearOnNewSceneLoadedButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showTimeButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showTimeButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showSceneButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSceneButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showMemButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showMemButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showFpsButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showFpsButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.showSearchText = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSearchText", defaultValue:  1)) == 1) ? 1 : 0;
        this.showCopyButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showCopyButton", defaultValue:  1)) == 1) ? 1 : 0;
        val_86 = 1;
        this.showSaveButton = ((UnityEngine.PlayerPrefs.GetInt(key:  "Reporter_showSaveButton", defaultValue:  1)) == 1) ? 1 : 0;
        this.initializeStyle();
        this.Initialized = true;
        if(this.show != false)
        {
                this.doShow();
        }
        
        string val_72 = UnityEngine.SystemInfo.deviceModel;
        if(val_72 == null)
        {
                throw new NullReferenceException();
        }
        
        this.deviceModel = val_72;
        UnityEngine.DeviceType val_73 = UnityEngine.SystemInfo.deviceType;
        if(val_73 == 0)
        {
                throw new NullReferenceException();
        }
        
        val_86 = public System.String System.Enum::ToString();
        val_73.Add(driver:  val_86, rectTransform:  0, drivenProperties:  "show or hide errors");
        this.deviceType = val_73.ToString();
        string val_75 = UnityEngine.SystemInfo.deviceName;
        if(val_75 == null)
        {
                throw new NullReferenceException();
        }
        
        this.deviceName = val_75;
        this.graphicsMemorySize = UnityEngine.SystemInfo.graphicsMemorySize.ToString();
        this.maxTextureSize = UnityEngine.SystemInfo.maxTextureSize.ToString();
        this.systemMemorySize = UnityEngine.SystemInfo.systemMemorySize.ToString();
    }
    private void initializeStyle()
    {
        UnityEngine.GUIStyle val_1 = new UnityEngine.GUIStyle();
        this.nonStyle = val_1;
        val_1.clipping = 1;
        this.nonStyle.border = new UnityEngine.RectOffset(left:  0, right:  0, top:  0, bottom:  0);
        this.nonStyle.normal.background = 0;
        float val_4 = S0 * 0.5f;
        this.nonStyle.fontSize = (int)val_4;
        this.nonStyle.alignment = 4;
        UnityEngine.GUIStyle val_5 = new UnityEngine.GUIStyle();
        this.lowerLeftFontStyle = val_5;
        val_5.clipping = 1;
        this.lowerLeftFontStyle.border = new UnityEngine.RectOffset(left:  0, right:  0, top:  0, bottom:  0);
        this.lowerLeftFontStyle.normal.background = 0;
        val_4 = val_4 * 0.5f;
        this.lowerLeftFontStyle.fontSize = (int)val_4;
        this.lowerLeftFontStyle.fontStyle = 1;
        this.lowerLeftFontStyle.alignment = 6;
        UnityEngine.GUIStyle val_8 = new UnityEngine.GUIStyle();
        this.barStyle = val_8;
        val_8.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.barStyle.normal.background = this.images.barImage;
        this.barStyle.active.background = this.images.button_activeImage;
        this.barStyle.alignment = 4;
        this.barStyle.margin = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.barStyle.clipping = 1;
        val_4 = val_4 * 0.5f;
        this.barStyle.fontSize = (int)val_4;
        UnityEngine.GUIStyle val_13 = new UnityEngine.GUIStyle();
        this.buttonActiveStyle = val_13;
        val_13.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        this.buttonActiveStyle.normal.background = this.images.button_activeImage;
        this.buttonActiveStyle.alignment = 4;
        this.buttonActiveStyle.margin = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        val_4 = val_4 * 0.5f;
        this.buttonActiveStyle.fontSize = (int)val_4;
        UnityEngine.GUIStyle val_17 = new UnityEngine.GUIStyle();
        this.backStyle = val_17;
        val_17.normal.background = this.images.even_logImage;
        this.backStyle.clipping = 1;
        val_4 = val_4 * 0.5f;
        this.backStyle.fontSize = (int)val_4;
        UnityEngine.GUIStyle val_19 = new UnityEngine.GUIStyle();
        this.evenLogStyle = val_19;
        val_19.normal.background = this.images.even_logImage;
        this.evenLogStyle.fixedHeight = val_4;
        this.evenLogStyle.clipping = 1;
        this.evenLogStyle.alignment = 0;
        this.evenLogStyle.imagePosition = 0;
        val_4 = val_4 * 0.5f;
        this.evenLogStyle.fontSize = (int)val_4;
        UnityEngine.GUIStyle val_21 = new UnityEngine.GUIStyle();
        this.oddLogStyle = val_21;
        val_21.normal.background = this.images.odd_logImage;
        this.oddLogStyle.fixedHeight = val_4;
        this.oddLogStyle.clipping = 1;
        this.oddLogStyle.alignment = 0;
        this.oddLogStyle.imagePosition = 0;
        val_4 = val_4 * 0.5f;
        this.oddLogStyle.fontSize = (int)val_4;
        UnityEngine.GUIStyle val_23 = new UnityEngine.GUIStyle();
        this.logButtonStyle = val_23;
        val_23.fixedHeight = val_4;
        this.logButtonStyle.clipping = 1;
        this.logButtonStyle.alignment = 0;
        float val_60 = 0.2f;
        val_4 = val_4 * 0.5f;
        val_60 = S10 * val_60;
        this.logButtonStyle.fontSize = (int)val_4;
        this.logButtonStyle.padding = new UnityEngine.RectOffset(left:  (int)this.size * val_60, right:  (int)this.size * val_60, top:  (int)val_60, bottom:  (int)val_60);
        UnityEngine.GUIStyle val_26 = new UnityEngine.GUIStyle();
        this.selectedLogStyle = val_26;
        val_26.normal.background = this.images.selectedImage;
        this.selectedLogStyle.fixedHeight = val_4;
        this.selectedLogStyle.clipping = 1;
        this.selectedLogStyle.alignment = 0;
        UnityEngine.Color val_29 = UnityEngine.Color.white;
        this.selectedLogStyle.normal.textColor = new UnityEngine.Color() {r = val_29.r, g = val_29.g, b = val_29.b, a = val_29.a};
        val_29.r = val_29.r * 0.5f;
        this.selectedLogStyle.fontSize = (int)val_29.r;
        UnityEngine.GUIStyle val_30 = new UnityEngine.GUIStyle();
        this.selectedLogFontStyle = val_30;
        val_30.normal.background = this.images.selectedImage;
        this.selectedLogFontStyle.fixedHeight = val_29.r;
        this.selectedLogFontStyle.clipping = 1;
        this.selectedLogFontStyle.alignment = 0;
        UnityEngine.Color val_33 = UnityEngine.Color.white;
        this.selectedLogFontStyle.normal.textColor = new UnityEngine.Color() {r = val_33.r, g = val_33.g, b = val_33.b, a = val_33.a};
        val_33.r = val_33.r * 0.5f;
        this.selectedLogFontStyle.fontSize = (int)val_33.r;
        this.selectedLogFontStyle.padding = new UnityEngine.RectOffset(left:  (int)this.size * val_60, right:  (int)this.size * val_60, top:  (int)val_60, bottom:  (int)val_60);
        UnityEngine.GUIStyle val_35 = new UnityEngine.GUIStyle();
        this.stackLabelStyle = val_35;
        val_35.wordWrap = true;
        val_33.r = val_33.r * 0.5f;
        this.stackLabelStyle.fontSize = (int)val_33.r;
        this.stackLabelStyle.padding = new UnityEngine.RectOffset(left:  (int)this.size * val_60, right:  (int)this.size * val_60, top:  (int)val_60, bottom:  (int)val_60);
        UnityEngine.GUIStyle val_37 = new UnityEngine.GUIStyle();
        this.scrollerStyle = val_37;
        val_37.normal.background = this.images.barImage;
        UnityEngine.GUIStyle val_39 = new UnityEngine.GUIStyle();
        this.searchStyle = val_39;
        val_39.clipping = 1;
        this.searchStyle.alignment = 7;
        val_33.r = val_33.r * 0.5f;
        this.searchStyle.fontSize = (int)val_33.r;
        this.searchStyle.wordWrap = true;
        UnityEngine.GUIStyle val_40 = new UnityEngine.GUIStyle();
        this.sliderBackStyle = val_40;
        val_40.normal.background = this.images.barImage;
        this.sliderBackStyle.fixedHeight = val_33.r;
        this.sliderBackStyle.border = new UnityEngine.RectOffset(left:  1, right:  1, top:  1, bottom:  1);
        UnityEngine.GUIStyle val_43 = new UnityEngine.GUIStyle();
        this.sliderThumbStyle = val_43;
        val_43.normal.background = this.images.selectedImage;
        this.sliderThumbStyle.fixedWidth = this.size;
        UnityEngine.GUISkin val_45 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.toolbarScrollerSkin = val_45;
        val_45.verticalScrollbar.fixedWidth = 0f;
        this.toolbarScrollerSkin.horizontalScrollbar.fixedHeight = 0f;
        this.toolbarScrollerSkin.verticalScrollbarThumb.fixedWidth = 0f;
        this.toolbarScrollerSkin.horizontalScrollbarThumb.fixedHeight = 0f;
        UnityEngine.GUISkin val_50 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.logScrollerSkin = val_50;
        UnityEngine.Vector2 val_61 = this.size;
        val_61 = val_61 + val_61;
        val_50.verticalScrollbar.fixedWidth = val_61;
        this.logScrollerSkin.horizontalScrollbar.fixedHeight = 0f;
        UnityEngine.Vector2 val_62 = this.size;
        val_62 = val_62 + val_62;
        this.logScrollerSkin.verticalScrollbarThumb.fixedWidth = val_62;
        this.logScrollerSkin.horizontalScrollbarThumb.fixedHeight = 0f;
        UnityEngine.GUISkin val_55 = UnityEngine.Object.Instantiate<UnityEngine.GUISkin>(original:  this.images.reporterScrollerSkin);
        this.graphScrollerSkin = val_55;
        val_55.verticalScrollbar.fixedWidth = 0f;
        UnityEngine.Vector2 val_63 = this.size;
        val_63 = val_63 + val_63;
        this.graphScrollerSkin.horizontalScrollbar.fixedHeight = val_63;
        this.graphScrollerSkin.verticalScrollbarThumb.fixedWidth = 0f;
        UnityEngine.Vector2 val_64 = this.size;
        val_64 = val_64 + val_64;
        this.graphScrollerSkin.horizontalScrollbarThumb.fixedHeight = val_64;
    }
    private void Start()
    {
        System.DateTime val_1 = System.DateTime.Now;
        this.logDate = val_1.dateData;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(methodName:  "readInfo");
    }
    private void clear()
    {
        this.logs.Clear();
        this.collapsedLogs.Clear();
        this.currentLog.Clear();
        this.logsDic.Clear();
        this.selectedLog = 0;
        this.logsMemUsage = 0f;
        this.graphMemUsage = 0f;
        this.numOfCollapsedLogsWarning = 0;
        this.numOfCollapsedLogsError = 0;
        this.numOfLogsError = 0;
        this.numOfCollapsedLogs = 0;
        this.numOfLogs = 0;
        this.numOfLogsWarning = 0;
        this.samples.Clear();
        System.GC.Collect();
        this.selectedLog = 0;
    }
    private void calculateCurrentLog()
    {
        string val_12;
        var val_13;
        System.Collections.Generic.List<Log> val_14;
        bool val_1 = System.String.IsNullOrEmpty(value:  this.filterText);
        if(val_1 != false)
        {
                val_12 = "";
        }
        else
        {
                val_12 = this.filterText.ToLower();
        }
        
        this.currentLog.Clear();
        bool val_12 = this.collapse;
        if(val_12 == false)
        {
            goto label_5;
        }
        
        val_13 = 0;
        label_17:
        if(val_13 >= val_12)
        {
            goto label_24;
        }
        
        if(val_12 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 0;
        if(((this.collapse + 0) + 32 + 20) > 4)
        {
            goto label_21;
        }
        
        var val_13 = 11346928 + ((this.collapse + 0) + 32 + 20) << 2;
        val_13 = val_13 + 11346928;
        goto (11346928 + ((this.collapse + 0) + 32 + 20) << 2 + 11346928);
        label_21:
        if(val_1 != true)
        {
                if(((this.collapse + 0) + 32 + 24.ToLower().Contains(value:  val_12)) == false)
        {
            goto label_22;
        }
        
        }
        
        this.currentLog.Add(item:  (this.collapse + 0) + 32);
        label_22:
        val_13 = val_13 + 1;
        if(this.collapsedLogs != null)
        {
            goto label_17;
        }
        
        if(this.showWarning == true)
        {
            goto label_21;
        }
        
        goto label_22;
        label_5:
        val_13 = 0;
        label_34:
        if(val_13 >= val_12)
        {
            goto label_24;
        }
        
        if(val_12 <= val_13)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_12 = val_12 + 0;
        if(((this.collapse + 0) + 32 + 20) > 4)
        {
            goto label_38;
        }
        
        var val_14 = 11346948 + ((this.collapse + 0) + 32 + 20) << 2;
        val_14 = val_14 + 11346948;
        goto (11346948 + ((this.collapse + 0) + 32 + 20) << 2 + 11346948);
        label_38:
        if(val_1 != true)
        {
                if(((this.collapse + 0) + 32 + 24.ToLower().Contains(value:  val_12)) == false)
        {
            goto label_39;
        }
        
        }
        
        this.currentLog.Add(item:  (this.collapse + 0) + 32);
        label_39:
        val_13 = val_13 + 1;
        if(this.logs != null)
        {
            goto label_34;
        }
        
        if(this.showWarning == true)
        {
            goto label_38;
        }
        
        goto label_39;
        label_24:
        if(this.selectedLog == null)
        {
                return;
        }
        
        val_14 = this.currentLog;
        if((val_14.IndexOf(item:  this.selectedLog)) == 1)
        {
                val_14 = this.currentLog;
            int val_10 = val_14.IndexOf(item:  this.logsDic.Item[this.selectedLog.condition].Item[this.selectedLog.stacktrace]);
            if(val_10 == 1)
        {
                return;
        }
        
        }
        
        mem[1152921507199029392] = S0 * (float)val_10;
    }
    private void DrawInfo()
    {
        UnityEngine.Vector2 val_109;
        var val_110;
        var val_111;
        var val_112;
        var val_113;
        var val_114;
        var val_115;
        var val_116;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.screenRect}, style:  this.backStyle);
        UnityEngine.Vector2 val_1 = this.getDrag();
        if(val_1.x != 0f)
        {
                val_109 = this.downPos;
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_109, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) != false)
        {
                UnityEngine.Vector2 val_109 = this.oldInfoDrag;
            val_109 = val_1.x - val_109;
            val_109 = this.infoScrollPosition - val_109;
            this.infoScrollPosition = val_109;
        }
        
        }
        
        if(val_1.y != 0f)
        {
                val_109 = this.downPos;
            UnityEngine.Vector2 val_4 = UnityEngine.Vector2.zero;
            float val_110 = val_109;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_110, y = V11.16B}, rhs:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y})) != false)
        {
                val_110 = val_1.y - val_110;
            val_110 = V11.16B + val_110;
            mem[1152921507199877412] = val_110;
        }
        
        }
        
        this.oldInfoDrag = val_1;
        mem[1152921507199877420] = val_1.y;
        UnityEngine.GUI.skin = this.toolbarScrollerSkin;
        UnityEngine.Vector2 val_6 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.infoScrollPosition, y = val_1.y}, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        this.infoScrollPosition = val_6;
        mem[1152921507199877412] = val_6.y;
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_7 = new UnityEngine.GUILayoutOption[2];
        val_7[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_7[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.buildFromContent, style:  this.nonStyle, options:  val_7);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_10 = new UnityEngine.GUILayoutOption[1];
        val_10[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.buildDate, style:  this.nonStyle, options:  val_10);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_12 = new UnityEngine.GUILayoutOption[2];
        val_12[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_12[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.systemInfoContent, style:  this.nonStyle, options:  val_12);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_15 = new UnityEngine.GUILayoutOption[1];
        val_15[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceModel, style:  this.nonStyle, options:  val_15);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[1];
        val_17[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceType, style:  this.nonStyle, options:  val_17);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_19 = new UnityEngine.GUILayoutOption[1];
        val_19[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.deviceName, style:  this.nonStyle, options:  val_19);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_21 = new UnityEngine.GUILayoutOption[2];
        val_21[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_21[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.graphicsInfoContent, style:  this.nonStyle, options:  val_21);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_25 = new UnityEngine.GUILayoutOption[1];
        val_25[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  UnityEngine.SystemInfo.graphicsDeviceName, style:  this.nonStyle, options:  val_25);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_27 = new UnityEngine.GUILayoutOption[1];
        val_27[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.graphicsMemorySize, style:  this.nonStyle, options:  val_27);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_29 = new UnityEngine.GUILayoutOption[1];
        val_29[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.maxTextureSize, style:  this.nonStyle, options:  val_29);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_33 = new UnityEngine.GUILayoutOption[1];
        val_33[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Screen Width " + UnityEngine.Screen.width, style:  this.nonStyle, options:  val_33);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_37 = new UnityEngine.GUILayoutOption[1];
        val_37[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Screen Height " + UnityEngine.Screen.height, style:  this.nonStyle, options:  val_37);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_39 = new UnityEngine.GUILayoutOption[2];
        val_39[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_39[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_39);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_43 = new UnityEngine.GUILayoutOption[1];
        val_43[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.systemMemorySize + " mb", style:  this.nonStyle, options:  val_43);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_47 = new UnityEngine.GUILayoutOption[1];
        val_47[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Mem Usage Of Logs " + this.logsMemUsage.ToString(format:  "0.000")(this.logsMemUsage.ToString(format:  "0.000")) + " mb", style:  this.nonStyle, options:  val_47);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_51 = new UnityEngine.GUILayoutOption[1];
        val_51[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "GC Memory " + this.gcTotalMemory.ToString(format:  "0.000")(this.gcTotalMemory.ToString(format:  "0.000")) + " mb", style:  this.nonStyle, options:  val_51);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_53 = new UnityEngine.GUILayoutOption[2];
        val_53[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_53[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.softwareContent, style:  this.nonStyle, options:  val_53);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_57 = new UnityEngine.GUILayoutOption[1];
        val_57[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  UnityEngine.SystemInfo.operatingSystem, style:  this.nonStyle, options:  val_57);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_59 = new UnityEngine.GUILayoutOption[2];
        val_59[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_59[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.dateContent, style:  this.nonStyle, options:  val_59);
        UnityEngine.GUILayout.Space(pixels:  this.size.x);
        System.DateTime val_62 = System.DateTime.Now;
        UnityEngine.GUILayoutOption[] val_63 = new UnityEngine.GUILayoutOption[1];
        val_63[0] = UnityEngine.GUILayout.Height(height:  this.size.x);
        UnityEngine.GUILayout.Label(text:  val_62.dateData, style:  this.nonStyle, options:  val_63);
        UnityEngine.GUILayoutOption[] val_66 = new UnityEngine.GUILayoutOption[1];
        val_66[0] = UnityEngine.GUILayout.Height(height:  this.size.x);
        UnityEngine.GUILayout.Label(text:  " - Application Started At "(" - Application Started At ") + this.logDate, style:  this.nonStyle, options:  val_66);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_110 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_110 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_110 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_110 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_68 = new UnityEngine.GUILayoutOption[2];
        val_68[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_68[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showTimeContent, style:  this.nonStyle, options:  val_68);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        float val_71 = UnityEngine.Time.realtimeSinceStartup;
        UnityEngine.GUILayoutOption[] val_73 = new UnityEngine.GUILayoutOption[1];
        val_73[0] = UnityEngine.GUILayout.Height(height:  val_71);
        UnityEngine.GUILayout.Label(text:  val_71.ToString(format:  "000"), style:  this.nonStyle, options:  val_73);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_111 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_111 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_111 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_111 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_75 = new UnityEngine.GUILayoutOption[2];
        val_75[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_75[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_75);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_78 = new UnityEngine.GUILayoutOption[1];
        val_78[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.fpsText, style:  this.nonStyle, options:  val_78);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_112 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_112 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_112 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_112 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_80 = new UnityEngine.GUILayoutOption[2];
        val_80[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_80[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.userContent, style:  this.nonStyle, options:  val_80);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_83 = new UnityEngine.GUILayoutOption[1];
        val_83[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.UserData, style:  this.nonStyle, options:  val_83);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_113 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_113 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_113 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_113 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_85 = new UnityEngine.GUILayoutOption[2];
        val_85[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_85[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_85);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_88 = new UnityEngine.GUILayoutOption[1];
        val_88[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  this.currentScene, style:  this.nonStyle, options:  val_88);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_114 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_114 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_114 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_114 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_90 = new UnityEngine.GUILayoutOption[2];
        val_90[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_90[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_90);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_95 = new UnityEngine.GUILayoutOption[1];
        val_95[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Unity Version = "("Unity Version = ") + UnityEngine.Application.unityVersion, style:  this.nonStyle, options:  val_95);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        this.drawInfo_enableDisableToolBarButtons();
        UnityEngine.GUILayout.FlexibleSpace();
        val_115 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_115 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_115 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_115 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_99 = new UnityEngine.GUILayoutOption[1];
        val_99[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Size = "("Size = ") + this.size.ToString(format:  "0.0")(this.size.ToString(format:  "0.0")), style:  this.nonStyle, options:  val_99);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_101 = new UnityEngine.GUILayoutOption[1];
        float val_111 = (float)UnityEngine.Screen.width;
        val_111 = val_111 * 0.5f;
        val_101[0] = UnityEngine.GUILayout.Width(width:  val_111);
        float val_104 = UnityEngine.GUILayout.HorizontalSlider(value:  this.size, leftValue:  16f, rightValue:  64f, slider:  this.sliderBackStyle, thumb:  this.sliderThumbStyle, options:  val_101);
        if(this.size.x != val_104)
        {
                mem[1152921507199876964] = val_104;
            this.size = val_104;
            this.initializeStyle();
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_116 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_116 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_116 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_116 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_105 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_112 = this.size;
        val_112 = val_112 + val_112;
        val_105[0] = UnityEngine.GUILayout.Width(width:  val_112);
        val_112 = val_112 + val_112;
        val_105[1] = UnityEngine.GUILayout.Height(height:  val_112);
        if((UnityEngine.GUILayout.Button(content:  this.backContent, style:  this.barStyle, options:  val_105)) != false)
        {
                this.currentView = 1;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawInfo_enableDisableToolBarButtons()
    {
        var val_52;
        var val_53;
        val_52 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_52 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_52 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_52 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayoutOption[] val_1 = new UnityEngine.GUILayoutOption[1];
        val_1[0] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Label(text:  "Hide or Show tool bar buttons", style:  this.nonStyle, options:  val_1);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_53 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_53 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_53 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_53 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.Space(pixels:  this.size);
        var val_3 = (this.showClearOnNewSceneLoadedButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_4 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_52 = this.size;
        val_52 = val_52 + val_52;
        val_4[0] = UnityEngine.GUILayout.Width(width:  val_52);
        val_52 = val_52 + val_52;
        val_4[1] = UnityEngine.GUILayout.Height(height:  val_52);
        if((UnityEngine.GUILayout.Button(content:  this.clearOnNewSceneContent, style:  1152921504768933888, options:  val_4)) != false)
        {
                bool val_53 = this.showClearOnNewSceneLoadedButton;
            val_53 = val_53 ^ 1;
            this.showClearOnNewSceneLoadedButton = val_53;
        }
        
        var val_8 = (this.showTimeButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_54 = this.size;
        val_54 = val_54 + val_54;
        val_9[0] = UnityEngine.GUILayout.Width(width:  val_54);
        val_54 = val_54 + val_54;
        val_9[1] = UnityEngine.GUILayout.Height(height:  val_54);
        if((UnityEngine.GUILayout.Button(content:  this.showTimeContent, style:  1152921504768933888, options:  val_9)) != false)
        {
                bool val_55 = this.showTimeButton;
            val_55 = val_55 ^ 1;
            this.showTimeButton = val_55;
        }
        
        UnityEngine.Rect val_13 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_13;
        mem[1152921507200821732] = val_13.m_YMin;
        mem[1152921507200821736] = val_13.m_Width;
        mem[1152921507200821740] = val_13.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_13.m_XMin, m_YMin = val_13.m_YMin, m_Width = val_13.m_Width, m_Height = val_13.m_Height}, text:  UnityEngine.Time.realtimeSinceStartup.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        var val_16 = (this.showSceneButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_56 = this.size;
        val_56 = val_56 + val_56;
        val_17[0] = UnityEngine.GUILayout.Width(width:  val_56);
        val_56 = val_56 + val_56;
        val_17[1] = UnityEngine.GUILayout.Height(height:  val_56);
        if((UnityEngine.GUILayout.Button(content:  this.showSceneContent, style:  1152921504768933888, options:  val_17)) != false)
        {
                bool val_57 = this.showSceneButton;
            val_57 = val_57 ^ 1;
            this.showSceneButton = val_57;
        }
        
        UnityEngine.Rect val_21 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_21;
        mem[1152921507200821732] = val_21.m_YMin;
        mem[1152921507200821736] = val_21.m_Width;
        mem[1152921507200821740] = val_21.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_21.m_XMin, m_YMin = val_21.m_YMin, m_Width = val_21.m_Width, m_Height = val_21.m_Height}, text:  this.currentScene, style:  this.lowerLeftFontStyle);
        var val_22 = (this.showMemButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_23 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_58 = this.size;
        val_58 = val_58 + val_58;
        val_23[0] = UnityEngine.GUILayout.Width(width:  val_58);
        val_58 = val_58 + val_58;
        val_23[1] = UnityEngine.GUILayout.Height(height:  val_58);
        if((UnityEngine.GUILayout.Button(content:  this.showMemoryContent, style:  1152921504768933888, options:  val_23)) != false)
        {
                bool val_59 = this.showMemButton;
            val_59 = val_59 ^ 1;
            this.showMemButton = val_59;
        }
        
        UnityEngine.Rect val_27 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_27;
        mem[1152921507200821732] = val_27.m_YMin;
        mem[1152921507200821736] = val_27.m_Width;
        mem[1152921507200821740] = val_27.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_27.m_XMin, m_YMin = val_27.m_YMin, m_Width = val_27.m_Width, m_Height = val_27.m_Height}, text:  this.gcTotalMemory.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        var val_29 = (this.showFpsButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_30 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_60 = this.size;
        val_60 = val_60 + val_60;
        val_30[0] = UnityEngine.GUILayout.Width(width:  val_60);
        val_60 = val_60 + val_60;
        val_30[1] = UnityEngine.GUILayout.Height(height:  val_60);
        if((UnityEngine.GUILayout.Button(content:  this.showFpsContent, style:  1152921504768933888, options:  val_30)) != false)
        {
                bool val_61 = this.showFpsButton;
            val_61 = val_61 ^ 1;
            this.showFpsButton = val_61;
        }
        
        UnityEngine.Rect val_34 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_34;
        mem[1152921507200821732] = val_34.m_YMin;
        mem[1152921507200821736] = val_34.m_Width;
        mem[1152921507200821740] = val_34.m_Height;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_34.m_XMin, m_YMin = val_34.m_YMin, m_Width = val_34.m_Width, m_Height = val_34.m_Height}, text:  this.fpsText, style:  this.lowerLeftFontStyle);
        var val_35 = (this.showSearchText == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_36 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_62 = this.size;
        val_62 = val_62 + val_62;
        val_36[0] = UnityEngine.GUILayout.Width(width:  val_62);
        val_62 = val_62 + val_62;
        val_36[1] = UnityEngine.GUILayout.Height(height:  val_62);
        if((UnityEngine.GUILayout.Button(content:  this.searchContent, style:  1152921504768933888, options:  val_36)) != false)
        {
                bool val_63 = this.showSearchText;
            val_63 = val_63 ^ 1;
            this.showSearchText = val_63;
        }
        
        var val_40 = (this.showCopyButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_41 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_64 = this.size;
        val_64 = val_64 + val_64;
        val_41[0] = UnityEngine.GUILayout.Width(width:  val_64);
        val_64 = val_64 + val_64;
        val_41[1] = UnityEngine.GUILayout.Height(height:  val_64);
        if((UnityEngine.GUILayout.Button(content:  this.copyContent, style:  1152921504768933888, options:  val_41)) != false)
        {
                bool val_65 = this.showCopyButton;
            val_65 = val_65 ^ 1;
            this.showCopyButton = val_65;
        }
        
        var val_45 = (this.showSaveButton == false) ? 368 : 376;
        UnityEngine.GUILayoutOption[] val_46 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_66 = this.size;
        val_66 = val_66 + val_66;
        val_46[0] = UnityEngine.GUILayout.Width(width:  val_66);
        val_66 = val_66 + val_66;
        val_46[1] = UnityEngine.GUILayout.Height(height:  val_66);
        if((UnityEngine.GUILayout.Button(content:  this.saveLogsContent, style:  1152921504768933888, options:  val_46)) != false)
        {
                bool val_67 = this.showSaveButton;
            val_67 = val_67 ^ 1;
            this.showSaveButton = val_67;
        }
        
        UnityEngine.Rect val_50 = UnityEngine.GUILayoutUtility.GetLastRect();
        this.tempRect = val_50;
        mem[1152921507200821732] = val_50.m_YMin;
        mem[1152921507200821736] = val_50.m_Width;
        mem[1152921507200821740] = val_50.m_Height;
        string val_51 = UnityEngine.GUI.TextField(position:  new UnityEngine.Rect() {m_XMin = val_50.m_XMin, m_YMin = val_50.m_YMin, m_Width = val_50.m_Width, m_Height = val_50.m_Height}, text:  this.filterText, style:  this.searchStyle);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
    }
    private void DrawReport()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        this.screenRect.x = 0f;
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.screenRect}, style:  this.backStyle);
        val_11 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_11 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_11 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_11 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginVertical(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.FlexibleSpace();
        val_12 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_12 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_12 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_12 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayoutOption[] val_3 = new UnityEngine.GUILayoutOption[1];
        val_3[0] = UnityEngine.GUILayout.Height(height:  this.screenRect);
        UnityEngine.GUILayout.Label(text:  "Select Photo", style:  this.nonStyle, options:  val_3);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        val_13 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_13 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_13 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_13 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_5 = new UnityEngine.GUILayoutOption[1];
        val_5[0] = UnityEngine.GUILayout.Height(height:  this.screenRect);
        UnityEngine.GUILayout.Label(text:  "Coming Soon", style:  this.nonStyle, options:  val_5);
        UnityEngine.GUILayout.EndHorizontal();
        val_14 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_14 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_14 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayoutOption[] val_7 = new UnityEngine.GUILayoutOption[2];
        val_7[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_7[1] = UnityEngine.GUILayout.Height(height:  this.size);
        if((UnityEngine.GUILayout.Button(content:  this.backContent, style:  this.barStyle, options:  val_7)) != false)
        {
                this.currentView = 1;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndVertical();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawToolBar()
    {
        float val_106;
        UnityEngine.Vector2 val_107;
        UnityEngine.GUIStyle val_109;
        string val_111;
        int val_112;
        int val_113;
        int val_114;
        var val_115;
        var val_116;
        var val_117;
        this.toolBarRect.x = 0f;
        float val_106 = (float)UnityEngine.Screen.width;
        val_106 = val_106 + val_106;
        UnityEngine.GUI.skin = this.toolbarScrollerSkin;
        UnityEngine.Vector2 val_2 = this.getDrag();
        if(val_2.x != 0f)
        {
                UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            UnityEngine.Vector2 val_107 = this.downPos;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_107, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y})) != false)
        {
                val_107 = val_107 + val_107;
            val_107 = (float)UnityEngine.Screen.height - val_107;
            if(this.downPos > val_107)
        {
                float val_108 = this.toolbarOldDrag;
            val_108 = val_2.x - val_108;
            val_108 = this.toolbarScrollPosition - val_108;
            this.toolbarScrollPosition = val_108;
        }
        
        }
        
        }
        
        this.toolbarOldDrag = val_2.x;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.toolBarRect, m_YMin = this.toolbarScrollPosition, m_Width = val_3.x, m_Height = val_3.y});
        val_107 = this.toolbarScrollPosition;
        UnityEngine.Vector2 val_6 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = val_107, y = this.downPos}, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        this.toolbarScrollPosition = val_6;
        mem[1152921507201788848] = val_6.y;
        UnityEngine.GUILayout.BeginHorizontal(style:  this.barStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_7 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_109 = this.size;
        val_109 = val_109 + val_109;
        if(val_7 == null)
        {
                throw new NullReferenceException();
        }
        
        val_7[0] = UnityEngine.GUILayout.Width(width:  val_109);
        val_109 = val_109 + val_109;
        val_7[1] = UnityEngine.GUILayout.Height(height:  val_109);
        if((UnityEngine.GUILayout.Button(content:  this.clearContent, style:  this.barStyle, options:  val_7)) != false)
        {
                this.clear();
        }
        
        var val_11 = (this.collapse == false) ? 368 : 376;
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_12 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_110 = this.size;
        val_110 = val_110 + val_110;
        if(val_12 == null)
        {
                throw new NullReferenceException();
        }
        
        val_12[0] = UnityEngine.GUILayout.Width(width:  val_110);
        val_110 = val_110 + val_110;
        val_12[1] = UnityEngine.GUILayout.Height(height:  val_110);
        if((UnityEngine.GUILayout.Button(content:  this.collapseContent, style:  1152921504768933888, options:  val_12)) != false)
        {
                bool val_111 = this.collapse;
            val_111 = val_111 ^ 1;
            this.collapse = val_111;
            this.calculateCurrentLog();
        }
        
        if(this.showClearOnNewSceneLoadedButton != false)
        {
                var val_16 = (this.clearOnNewSceneLoaded == false) ? 368 : 376;
            val_109 = 2;
            UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_112 = this.size;
            val_112 = val_112 + val_112;
            if(val_17 == null)
        {
                throw new NullReferenceException();
        }
        
            val_17[0] = UnityEngine.GUILayout.Width(width:  val_112);
            val_112 = val_112 + val_112;
            val_17[1] = UnityEngine.GUILayout.Height(height:  val_112);
            if((UnityEngine.GUILayout.Button(content:  this.clearOnNewSceneContent, style:  1152921504768933888, options:  val_17)) != false)
        {
                bool val_113 = this.clearOnNewSceneLoaded;
            val_113 = val_113 ^ 1;
            this.clearOnNewSceneLoaded = val_113;
        }
        
        }
        
        if(this.showTimeButton != false)
        {
                var val_21 = (this.showTime == false) ? 368 : 376;
            val_109 = 2;
            UnityEngine.GUILayoutOption[] val_22 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_114 = this.size;
            val_114 = val_114 + val_114;
            if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
            val_22[0] = UnityEngine.GUILayout.Width(width:  val_114);
            val_114 = val_114 + val_114;
            val_22[1] = UnityEngine.GUILayout.Height(height:  val_114);
            if((UnityEngine.GUILayout.Button(content:  this.showTimeContent, style:  1152921504768933888, options:  val_22)) != false)
        {
                bool val_115 = this.showTime;
            val_115 = val_115 ^ 1;
            this.showTime = val_115;
        }
        
        }
        
        if(this.showSceneButton != false)
        {
                UnityEngine.Rect val_26 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_26;
            mem[1152921507201789060] = val_26.m_YMin;
            mem[1152921507201789064] = val_26.m_Width;
            mem[1152921507201789068] = val_26.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_26.m_XMin, m_YMin = val_26.m_YMin, m_Width = val_26.m_Width, m_Height = val_26.m_Height}, text:  UnityEngine.Time.realtimeSinceStartup.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
            var val_29 = (this.showScene == false) ? 368 : 376;
            val_109 = 2;
            UnityEngine.GUILayoutOption[] val_30 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_116 = this.size;
            val_116 = val_116 + val_116;
            if(val_30 == null)
        {
                throw new NullReferenceException();
        }
        
            val_30[0] = UnityEngine.GUILayout.Width(width:  val_116);
            val_116 = val_116 + val_116;
            val_30[1] = UnityEngine.GUILayout.Height(height:  val_116);
            if((UnityEngine.GUILayout.Button(content:  this.showSceneContent, style:  1152921504768933888, options:  val_30)) != false)
        {
                bool val_117 = this.showScene;
            val_117 = val_117 ^ 1;
            this.showScene = val_117;
        }
        
            UnityEngine.Rect val_34 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_34;
            mem[1152921507201789060] = val_34.m_YMin;
            mem[1152921507201789064] = val_34.m_Width;
            mem[1152921507201789068] = val_34.m_Height;
            val_106 = val_34.m_YMin;
            val_107 = val_34.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_34.m_XMin, m_YMin = val_106, m_Width = val_34.m_Width, m_Height = val_107}, text:  this.currentScene, style:  this.lowerLeftFontStyle);
        }
        
        if(this.showMemButton != false)
        {
                var val_35 = (this.showMemory == false) ? 368 : 376;
            val_109 = 2;
            UnityEngine.GUILayoutOption[] val_36 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_118 = this.size;
            val_118 = val_118 + val_118;
            if(val_36 == null)
        {
                throw new NullReferenceException();
        }
        
            val_36[0] = UnityEngine.GUILayout.Width(width:  val_118);
            val_118 = val_118 + val_118;
            val_36[1] = UnityEngine.GUILayout.Height(height:  val_118);
            if((UnityEngine.GUILayout.Button(content:  this.showMemoryContent, style:  1152921504768933888, options:  val_36)) != false)
        {
                bool val_119 = this.showMemory;
            val_119 = val_119 ^ 1;
            this.showMemory = val_119;
        }
        
            UnityEngine.Rect val_40 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_40;
            mem[1152921507201789060] = val_40.m_YMin;
            mem[1152921507201789064] = val_40.m_Width;
            mem[1152921507201789068] = val_40.m_Height;
            val_106 = val_40.m_YMin;
            val_107 = val_40.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_40.m_XMin, m_YMin = val_106, m_Width = val_40.m_Width, m_Height = val_107}, text:  this.gcTotalMemory.ToString(format:  "0.0"), style:  this.lowerLeftFontStyle);
        }
        
        if(this.showFpsButton != false)
        {
                var val_42 = (this.showFps == false) ? 368 : 376;
            val_109 = 2;
            UnityEngine.GUILayoutOption[] val_43 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_120 = this.size;
            val_120 = val_120 + val_120;
            if(val_43 == null)
        {
                throw new NullReferenceException();
        }
        
            val_43[0] = UnityEngine.GUILayout.Width(width:  val_120);
            val_120 = val_120 + val_120;
            val_43[1] = UnityEngine.GUILayout.Height(height:  val_120);
            if((UnityEngine.GUILayout.Button(content:  this.showFpsContent, style:  1152921504768933888, options:  val_43)) != false)
        {
                bool val_121 = this.showFps;
            val_121 = val_121 ^ 1;
            this.showFps = val_121;
        }
        
            UnityEngine.Rect val_47 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_47;
            mem[1152921507201789060] = val_47.m_YMin;
            mem[1152921507201789064] = val_47.m_Width;
            mem[1152921507201789068] = val_47.m_Height;
            val_106 = val_47.m_YMin;
            val_107 = val_47.m_Height;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_47.m_XMin, m_YMin = val_106, m_Width = val_47.m_Width, m_Height = val_107}, text:  this.fpsText, style:  this.lowerLeftFontStyle);
        }
        
        if(this.showSearchText != false)
        {
                val_109 = 2;
            UnityEngine.GUILayoutOption[] val_48 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_122 = this.size;
            val_122 = val_122 + val_122;
            if(val_48 == null)
        {
                throw new NullReferenceException();
        }
        
            val_48[0] = UnityEngine.GUILayout.Width(width:  val_122);
            val_122 = val_122 + val_122;
            val_48[1] = UnityEngine.GUILayout.Height(height:  val_122);
            UnityEngine.GUILayout.Box(content:  this.searchContent, style:  this.barStyle, options:  val_48);
            UnityEngine.Rect val_51 = UnityEngine.GUILayoutUtility.GetLastRect();
            this.tempRect = val_51;
            mem[1152921507201789060] = val_51.m_YMin;
            mem[1152921507201789064] = val_51.m_Width;
            mem[1152921507201789068] = val_51.m_Height;
            val_106 = val_51.m_YMin;
            val_107 = val_51.m_Height;
            string val_52 = UnityEngine.GUI.TextField(position:  new UnityEngine.Rect() {m_XMin = val_51.m_XMin, m_YMin = val_106, m_Width = val_51.m_Width, m_Height = val_107}, text:  this.filterText, style:  this.searchStyle);
            if((System.String.op_Inequality(a:  val_52, b:  this.filterText)) != false)
        {
                this.filterText = val_52;
            this.calculateCurrentLog();
        }
        
        }
        
        if(this.showCopyButton != false)
        {
                val_109 = 2;
            UnityEngine.GUILayoutOption[] val_54 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_123 = this.size;
            val_123 = val_123 + val_123;
            if(val_54 == null)
        {
                throw new NullReferenceException();
        }
        
            val_54[0] = UnityEngine.GUILayout.Width(width:  val_123);
            val_123 = val_123 + val_123;
            val_109 = this.barStyle;
            val_54[1] = UnityEngine.GUILayout.Height(height:  val_123);
            if((UnityEngine.GUILayout.Button(content:  this.copyContent, style:  val_109, options:  val_54)) != false)
        {
                if(this.selectedLog != null)
        {
                if(this.selectedLog == null)
        {
                throw new NullReferenceException();
        }
        
            string val_60 = this.selectedLog.condition + System.Environment.NewLine + System.Environment.NewLine + this.selectedLog.stacktrace;
        }
        else
        {
                val_111 = "No log selected";
        }
        
            UnityEngine.GUIUtility.systemCopyBuffer = val_111;
        }
        
        }
        
        if(this.showSaveButton != false)
        {
                val_109 = 2;
            UnityEngine.GUILayoutOption[] val_61 = new UnityEngine.GUILayoutOption[2];
            UnityEngine.Vector2 val_124 = this.size;
            val_124 = val_124 + val_124;
            if(val_61 == null)
        {
                throw new NullReferenceException();
        }
        
            val_61[0] = UnityEngine.GUILayout.Width(width:  val_124);
            val_124 = val_124 + val_124;
            val_61[1] = UnityEngine.GUILayout.Height(height:  val_124);
            if((UnityEngine.GUILayout.Button(content:  this.saveLogsContent, style:  this.barStyle, options:  val_61)) != false)
        {
                this.SaveLogsToDevice();
        }
        
        }
        
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_65 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_125 = this.size;
        val_125 = val_125 + val_125;
        if(val_65 == null)
        {
                throw new NullReferenceException();
        }
        
        val_65[0] = UnityEngine.GUILayout.Width(width:  val_125);
        val_125 = val_125 + val_125;
        val_65[1] = UnityEngine.GUILayout.Height(height:  val_125);
        if((UnityEngine.GUILayout.Button(content:  this.infoContent, style:  this.barStyle, options:  val_65)) != false)
        {
                this.currentView = 2;
        }
        
        UnityEngine.GUILayout.FlexibleSpace();
        if(this.collapse != false)
        {
                val_112 = this.numOfCollapsedLogs;
        }
        else
        {
                val_112 = this.numOfLogs;
        }
        
        if(this.collapse != false)
        {
                val_113 = this.numOfCollapsedLogsWarning;
        }
        else
        {
                val_113 = this.numOfLogsWarning;
        }
        
        if(this.collapse != false)
        {
                val_114 = this.numOfCollapsedLogsError;
        }
        else
        {
                val_114 = this.numOfLogsError;
        }
        
        var val_72 = (this.showLog == false) ? 368 : 376;
        val_115 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_115 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_115 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_115 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(style:  1152921504768933888, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_73 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_126 = this.size;
        val_126 = val_126 + val_126;
        if(val_73 == null)
        {
                throw new NullReferenceException();
        }
        
        val_73[0] = UnityEngine.GUILayout.Width(width:  val_126);
        val_126 = val_126 + val_126;
        val_73[1] = UnityEngine.GUILayout.Height(height:  val_126);
        if((UnityEngine.GUILayout.Button(content:  this.logContent, style:  this.nonStyle, options:  val_73)) != false)
        {
                bool val_127 = this.showLog;
            val_127 = val_127 ^ 1;
            this.showLog = val_127;
            this.calculateCurrentLog();
        }
        
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_77 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_128 = this.size;
        val_128 = val_128 + val_128;
        if(val_77 == null)
        {
                throw new NullReferenceException();
        }
        
        val_77[0] = UnityEngine.GUILayout.Width(width:  val_128);
        val_128 = val_128 + val_128;
        val_77[1] = UnityEngine.GUILayout.Height(height:  val_128);
        if((UnityEngine.GUILayout.Button(text:  " " + val_112, style:  this.nonStyle, options:  val_77)) != false)
        {
                bool val_129 = this.showLog;
            val_129 = val_129 ^ 1;
            this.showLog = val_129;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        var val_81 = (this.showWarning == false) ? 368 : 376;
        val_116 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_116 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_116 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_116 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(style:  1152921504768933888, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_82 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_130 = this.size;
        val_130 = val_130 + val_130;
        if(val_82 == null)
        {
                throw new NullReferenceException();
        }
        
        val_82[0] = UnityEngine.GUILayout.Width(width:  val_130);
        val_130 = val_130 + val_130;
        val_82[1] = UnityEngine.GUILayout.Height(height:  val_130);
        if((UnityEngine.GUILayout.Button(content:  this.warningContent, style:  this.nonStyle, options:  val_82)) != false)
        {
                bool val_131 = this.showWarning;
            val_131 = val_131 ^ 1;
            this.showWarning = val_131;
            this.calculateCurrentLog();
        }
        
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_86 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_132 = this.size;
        val_132 = val_132 + val_132;
        if(val_86 == null)
        {
                throw new NullReferenceException();
        }
        
        val_86[0] = UnityEngine.GUILayout.Width(width:  val_132);
        val_132 = val_132 + val_132;
        val_86[1] = UnityEngine.GUILayout.Height(height:  val_132);
        if((UnityEngine.GUILayout.Button(text:  " " + val_113, style:  this.nonStyle, options:  val_86)) != false)
        {
                bool val_133 = this.showWarning;
            val_133 = val_133 ^ 1;
            this.showWarning = val_133;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        var val_90 = (this.showError == false) ? 384 : 376;
        val_117 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_117 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_117 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_117 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(style:  1152921504768933888, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_91 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_134 = this.size;
        val_134 = val_134 + val_134;
        if(val_91 == null)
        {
                throw new NullReferenceException();
        }
        
        val_91[0] = UnityEngine.GUILayout.Width(width:  val_134);
        val_134 = val_134 + val_134;
        val_91[1] = UnityEngine.GUILayout.Height(height:  val_134);
        if((UnityEngine.GUILayout.Button(content:  this.errorContent, style:  this.nonStyle, options:  val_91)) != false)
        {
                bool val_135 = this.showError;
            val_135 = val_135 ^ 1;
            this.showError = val_135;
            this.calculateCurrentLog();
        }
        
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_95 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_136 = this.size;
        val_136 = val_136 + val_136;
        if(val_95 == null)
        {
                throw new NullReferenceException();
        }
        
        val_95[0] = UnityEngine.GUILayout.Width(width:  val_136);
        val_136 = val_136 + val_136;
        val_95[1] = UnityEngine.GUILayout.Height(height:  val_136);
        if((UnityEngine.GUILayout.Button(text:  " " + val_114, style:  this.nonStyle, options:  val_95)) != false)
        {
                bool val_137 = this.showError;
            val_137 = val_137 ^ 1;
            this.showError = val_137;
            this.calculateCurrentLog();
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        val_109 = 2;
        UnityEngine.GUILayoutOption[] val_99 = new UnityEngine.GUILayoutOption[2];
        UnityEngine.Vector2 val_138 = this.size;
        val_138 = val_138 + val_138;
        if(val_99 == null)
        {
                throw new NullReferenceException();
        }
        
        val_99[0] = UnityEngine.GUILayout.Width(width:  val_138);
        val_138 = val_138 + val_138;
        val_99[1] = UnityEngine.GUILayout.Height(height:  val_138);
        if((UnityEngine.GUILayout.Button(content:  this.closeContent, style:  this.barStyle, options:  val_99)) != false)
        {
                val_109 = 0;
            this.show = false;
            UnityEngine.GameObject val_103 = this.gameObject;
            if(val_103 == null)
        {
                throw new NullReferenceException();
        }
        
            UnityEngine.Object.DestroyImmediate(obj:  val_103.GetComponent<ReporterGUI>());
            this.gameObject.SendMessage(methodName:  "OnHideReporter");
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
    }
    private void DrawLogs()
    {
        float val_63;
        var val_67;
        int val_68;
        int val_69;
        var val_70;
        var val_71;
        int val_72;
        var val_73;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.logsRect}, style:  this.backStyle);
        UnityEngine.GUI.skin = this.logScrollerSkin;
        UnityEngine.Vector2 val_1 = this.getDrag();
        val_63 = val_1.y;
        if(val_1.y != 0f)
        {
                float val_58 = (float)UnityEngine.Screen.height;
            val_58 = val_58 - val_1.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.downPos, y:  val_58);
            if((this.logsRect & 1) != 0)
        {
                float val_59 = this.oldDrag;
            val_59 = val_63 - val_59;
            val_59 = val_3.y + val_59;
            mem[1152921507202527936] = val_59;
        }
        
        }
        
        UnityEngine.Vector2 val_4 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.scrollPosition, y = V10.16B}, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        this.scrollPosition = val_4;
        mem[1152921507202527936] = val_4.y;
        this.oldDrag = val_63;
        float val_60 = (float)UnityEngine.Screen.height;
        val_60 = val_60 * 0.75f;
        val_4.x = val_60 / val_4.x;
        val_68 = UnityEngine.Mathf.Min(a:  (int)val_4.x, b:  W24 - this.startIndex);
        val_4.x = val_4.x * (float)this.startIndex;
        if((int)val_4.x >= (1.401298E-45f))
        {
                UnityEngine.GUILayoutOption[] val_8 = new UnityEngine.GUILayoutOption[1];
            float val_70 = (float)(int)val_4.x;
            val_8[0] = UnityEngine.GUILayout.Height(height:  val_70);
            UnityEngine.GUILayout.BeginHorizontal(options:  val_8);
            UnityEngine.GUILayout.Label(text:  "---", options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.EndHorizontal();
        }
        
        int val_11 = UnityEngine.Mathf.Clamp(value:  this.startIndex + val_68, min:  0, max:  W24);
        val_69 = this.startIndex;
        if(val_69 >= val_11)
        {
            goto label_27;
        }
        
        var val_61 = (long)val_69;
        val_61 = val_61 << 3;
        val_70 = 0;
        var val_12 = val_61 + 32;
        label_112:
        if(val_69 >= val_61)
        {
            goto label_113;
        }
        
        if(val_61 <= val_69)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 20) != 3)
        {
            goto label_32;
        }
        
        if(this.showLog == true)
        {
            goto label_33;
        }
        
        goto label_114;
        label_32:
        if((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 20) > 4)
        {
            goto label_115;
        }
        
        var val_62 = 11346968 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 20) << 2;
        val_62 = val_62 + 11346968;
        goto (11346968 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 20) << 2 + 11346968);
        label_33:
        label_115:
        if(val_70 >= val_68)
        {
            goto label_113;
        }
        
        var val_13 = (0 != 0) ? 352 : 360;
        var val_14 = ((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 20) == 3) ? 344 : (val_13);
        var val_15 = (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32)) + 16;
        var val_18 = ((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32)) == this.selectedLog) ? 432 : ((((this.startIndex + val_70) & 1) != 0) ? 408 : 416);
        this.tempContent.text = val_15.ToString();
        if(this.collapse != false)
        {
                UnityEngine.Vector2 val_20 = this.barStyle.CalcSize(content:  this.tempContent);
            val_63 = val_20.x + 3f;
        }
        else
        {
                val_63 = 0f;
        }
        
        float val_63 = (float)UnityEngine.Screen.width;
        val_63 = val_63 - val_63;
        this.countRect.x = val_63;
        val_63 = val_63 * (float)val_69;
        if((int)val_4.x >= (1.401298E-45f))
        {
                val_63 = val_63 + 8f;
        }
        
        if(W24 > val_68)
        {
                float val_22 = this.countRect.x;
            UnityEngine.Vector2 val_64 = this.size;
            val_64 = val_64 + val_64;
            val_22 = val_22 - val_64;
            this.countRect.x = val_22;
        }
        
        if(this.collapse <= (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40))
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_23 = 352 + ((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3);
        this.fpsRect = this.countRect;
        mem[1152921507202528104] = 432;
        mem[1152921507202528108] = this.selectedLog;
        mem[1152921507202528112] = val_13;
        if(this.showFps != false)
        {
                this.tempContent.text = (352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32 + 32;
            UnityEngine.Vector2 val_24 = 1152921504768933888.CalcSize(content:  this.tempContent);
            val_63 = val_24.x + this.size;
            float val_25 = this.fpsRect.x;
            val_25 = val_25 - val_63;
            this.fpsRect.x = val_25;
            mem2[0] = this.timeRect + 96;
            float val_26 = this.fpsLabelRect.x;
            val_26 = val_26 + this.size;
            this.fpsLabelRect.x = val_26;
            UnityEngine.Vector2 val_65 = this.size;
            val_65 = val_63 - val_65;
        }
        
        this.memoryRect = this.countRect;
        mem[1152921507202528072] = 432;
        mem[1152921507202528076] = this.selectedLog;
        mem[1152921507202528080] = val_13;
        if(this.showMemory != false)
        {
                this.tempContent.text = ((352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32) + 24.ToString(format:  "0.000");
            UnityEngine.Vector2 val_29 = 1152921504768933888.CalcSize(content:  this.tempContent);
            val_63 = val_29.x + this.size;
            float val_30 = this.memoryRect.x;
            val_30 = val_30 - val_63;
            this.memoryRect.x = val_30;
            mem2[0] = this.timeRect + 64;
            float val_31 = this.memoryLabelRect.x;
            val_31 = val_31 + this.size;
            this.memoryLabelRect.x = val_31;
            UnityEngine.Vector2 val_66 = this.size;
            val_66 = val_63 - val_66;
        }
        
        this.sceneRect = this.memoryRect;
        mem[1152921507202528040] = 432;
        mem[1152921507202528044] = this.selectedLog;
        mem[1152921507202528048] = val_13;
        if(this.showScene != false)
        {
                this.tempContent.text = (352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32.GetSceneName();
            UnityEngine.Vector2 val_33 = 1152921504768933888.CalcSize(content:  this.tempContent);
            val_63 = val_33.x + this.size;
            float val_34 = this.sceneRect.x;
            val_34 = val_34 - val_63;
            this.sceneRect.x = val_34;
            mem2[0] = this.timeRect + 32;
            float val_35 = this.sceneLabelRect.x;
            val_35 = val_35 + this.size;
            this.sceneLabelRect.x = val_35;
            UnityEngine.Vector2 val_67 = this.size;
            val_67 = val_63 - val_67;
        }
        
        this.timeRect = this.sceneRect;
        mem[1152921507202528008] = 432;
        mem[1152921507202528012] = this.selectedLog;
        mem[1152921507202528016] = val_13;
        if(this.showTime != false)
        {
                this.tempContent.text = ((352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32) + 16.ToString(format:  "0.000");
            UnityEngine.Vector2 val_38 = 1152921504768933888.CalcSize(content:  this.tempContent);
            val_63 = val_38.x + this.size;
            float val_39 = this.timeRect.x;
            val_39 = val_39 - val_63;
            this.timeRect.x = val_39;
            mem2[0] = this.timeRect;
            float val_40 = this.timeLabelRect.x;
            val_40 = val_40 + this.size;
            this.timeLabelRect.x = val_40;
            UnityEngine.Vector2 val_68 = this.size;
            val_68 = val_63 - val_68;
        }
        
        UnityEngine.GUILayout.BeginHorizontal(style:  1152921504768933888, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_41 = new UnityEngine.GUILayoutOption[2];
        val_41[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_41[1] = UnityEngine.GUILayout.Height(height:  this.size);
        if((((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32)) == this.selectedLog)
        {
            goto label_76;
        }
        
        if((UnityEngine.GUILayout.Button(content:  null, style:  this.nonStyle, options:  val_41)) != false)
        {
                this.selectedLog = ((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32);
        }
        
        val_68 = val_68;
        if((UnityEngine.GUILayout.Button(text:  ((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 24, style:  this.logButtonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184)) != false)
        {
                this.selectedLog = ((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32);
        }
        
        val_71 = 1152921504716910592;
        val_67 = ???;
        if(this.showTime == true)
        {
            goto label_85;
        }
        
        goto label_93;
        label_76:
        UnityEngine.GUILayout.Box(content:  null, style:  this.nonStyle, options:  val_41);
        UnityEngine.GUILayout.Label(text:  ((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 24, style:  this.selectedLogFontStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        val_71 = 1152921504716910592;
        val_68 = val_68;
        val_67 = ???;
        if(this.showTime == false)
        {
            goto label_93;
        }
        
        label_85:
        UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.timeRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showTimeContent, style:  1152921504768933888);
        val_63 = this.timeLabelRect;
        UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  ((352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32) + 16.ToString(format:  "0.000"), style:  1152921504768933888);
        label_93:
        if(this.showScene != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.sceneRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showSceneContent, style:  1152921504768933888);
            val_63 = this.sceneLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  (352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32.GetSceneName(), style:  1152921504768933888);
        }
        
        if(this.showMemory != false)
        {
                UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.memoryRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showMemoryContent, style:  1152921504768933888);
            val_63 = this.memoryLabelRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  ((352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32) + 24.ToString(format:  "0.000")(((352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32) + 24.ToString(format:  "0.000")) + " mb", style:  1152921504768933888);
        }
        
        if(this.showFps != false)
        {
                val_63 = this.fpsRect;
            UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, content:  this.showFpsContent, style:  1152921504768933888);
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = this.fpsLabelRect, m_YMin = V11.16B, m_Width = V10.16B, m_Height = this.scrollPosition}, text:  (352 + (((long)(int)(this.startIndex) << 3) + (((long)(int)(this.startIndex) << 3) + 32) + 40) << 3) + 32 + 32, style:  1152921504768933888);
        }
        
        if(this.collapse != false)
        {
                val_63 = this.countRect;
            UnityEngine.GUI.Label(position:  new UnityEngine.Rect() {m_XMin = val_63, m_YMin = this.scrollPosition, m_Width = V10.16B, m_Height = V11.16B}, text:  val_15.ToString(), style:  this.barStyle);
        }
        
        UnityEngine.GUILayout.EndHorizontal();
        val_70 = 1;
        label_114:
        int val_69 = this.startIndex;
        val_69 = val_69 + 1;
        val_12 = val_12 + 8;
        val_69 = val_69 + val_70;
        if(val_69 < val_11)
        {
            goto label_112;
        }
        
        label_113:
        val_69 = this.startIndex;
        label_27:
        int val_53 = W24 - val_68;
        val_53 = val_53 - val_69;
        val_70 = val_70 * (float)val_53;
        val_72 = (int)val_70;
        if(val_72 >= (1.401298E-45f))
        {
                UnityEngine.GUILayoutOption[] val_54 = new UnityEngine.GUILayoutOption[1];
            val_54[0] = UnityEngine.GUILayout.Height(height:  (float)val_72);
            UnityEngine.GUILayout.BeginHorizontal(options:  val_54);
            val_72 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>();
            val_73 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_73 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_73 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_73 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  " ", options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.EndHorizontal();
        }
        
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
        float val_71 = 0f;
        this.buttomRect.x = val_71;
        val_71 = (float)UnityEngine.Screen.height - val_71;
        int val_57 = UnityEngine.Screen.width;
        if(this.showGraph != false)
        {
                this.drawGraph();
            return;
        }
        
        this.drawStack();
    }
    private void drawGraph()
    {
        float val_52;
        float val_53;
        var val_54;
        var val_55;
        float val_56;
        float val_57;
        var val_58;
        var val_59;
        var val_60;
        var val_61;
        var val_62;
        var val_63;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        mem2[0] = this.stackRect.m_XMin;
        float val_50 = (float)UnityEngine.Screen.height;
        val_50 = val_50 * 0.25f;
        UnityEngine.GUI.skin = this.graphScrollerSkin;
        UnityEngine.Vector2 val_2 = this.getDrag();
        float val_51 = (float)UnityEngine.Screen.height;
        val_51 = val_51 - val_2.x;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  this.downPos, y:  val_51);
        val_52 = val_4.x;
        val_53 = val_4.y;
        if((this.graphRect & 1) != 0)
        {
                if(val_2.x != 0f)
        {
                float val_52 = this.oldDrag3;
            val_52 = val_2.x - val_52;
            float val_5 = this.graphScrollerPos - val_52;
            this.graphScrollerPos = val_5;
            val_52 = 0f;
            val_53 = val_5;
            this.graphScrollerPos = UnityEngine.Mathf.Max(a:  val_52, b:  val_53);
        }
        
            UnityEngine.Vector2 val_7 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = this.downPos, y = V10.16B}, rhs:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y})) != false)
        {
                float val_53 = this.graphSize;
            int val_54 = this.startFrame;
            val_53 = this.downPos / val_53;
            val_54 = val_54 + (int)val_53;
            this.currentFrame = val_54;
        }
        
        }
        
        this.oldDrag3 = val_2.x;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphRect, m_YMin = V10.16B, m_Width = val_7.x, m_Height = val_7.y}, style:  this.backStyle);
        val_54 = 1152921507199214944;
        val_55 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_55 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_55 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_55 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.Vector2 val_9 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.graphScrollerPos, y = this.downPos}, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        this.graphScrollerPos = val_9;
        val_9.x = val_9.x / this.graphSize;
        mem[1152921507203074584] = val_9.y;
        this.startFrame = (int)val_9.x;
        float val_55 = (float)S10;
        val_55 = this.graphSize * val_55;
        val_55 = val_55 - (float)UnityEngine.Screen.width;
        if(val_9.x >= val_55)
        {
                UnityEngine.Vector2 val_56 = this.graphScrollerPos;
            val_56 = val_56 + this.graphSize;
            this.graphScrollerPos = val_56;
        }
        
        UnityEngine.GUILayoutOption[] val_11 = new UnityEngine.GUILayoutOption[1];
        float val_57 = (float)val_56;
        val_57 = this.graphSize * val_57;
        val_11[0] = UnityEngine.GUILayout.Width(width:  val_57);
        UnityEngine.GUILayout.Label(text:  " ", options:  val_11);
        UnityEngine.GUILayout.EndScrollView();
        UnityEngine.GUILayout.EndArea();
        mem2[0] = ;
        float val_58 = this.graphSize;
        val_58 = (float)UnityEngine.Screen.width / val_58;
        if(val_58 <= 0f)
        {
            goto label_25;
        }
        
        var val_60 = 1;
        label_32:
        int val_59 = this.startFrame;
        val_59 = val_60 + val_59;
        int val_14 = val_59 - 1;
        if(val_14 >= 11345920)
        {
            goto label_25;
        }
        
        if(11345920 <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        var val_15 = 11345920 + (val_14 << 3);
        var val_62 = (11345920 + (((1 + this.startFrame) - 1)) << 3) + 32;
        val_56 = mem[(11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 28];
        val_56 = (11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 28;
        if(this.maxFpsValue < 0)
        {
                mem2[0] = val_56;
            val_56 = mem[(11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 28];
            val_56 = (11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 28;
        }
        
        if(this.minFpsValue > val_56)
        {
                mem2[0] = val_56;
        }
        
        val_57 = mem[(11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 24];
        val_57 = (11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 24;
        if(this.maxMemoryValue < 0)
        {
                mem2[0] = val_57;
            val_57 = mem[(11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 24];
            val_57 = (11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + 24;
        }
        
        if(this.minMemoryValue > val_57)
        {
                mem2[0] = val_57;
        }
        
        float val_61 = this.graphSize;
        val_60 = val_60 + 1;
        val_61 = (float)UnityEngine.Screen.width / val_61;
        if(val_61 > 1f)
        {
            goto label_32;
        }
        
        label_25:
        if((this.currentFrame != 1) && (this.currentFrame < val_62))
        {
                if(val_62 <= this.currentFrame)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_62 = val_62 + ((this.currentFrame) << 3);
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y}, style:  this.backStyle);
            val_58 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_58 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_58 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_58 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayoutOption[] val_17 = new UnityEngine.GUILayoutOption[2];
            val_17[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_17[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showTimeContent, style:  this.nonStyle, options:  val_17);
            val_59 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_59 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_59 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_59 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  (((11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + (this.currentFrame) << 3) + 32) + 16.ToString(format:  "0.0"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_22 = new UnityEngine.GUILayoutOption[2];
            val_22[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_22[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_22);
            val_60 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_60 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_60 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_60 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  ((11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + (this.currentFrame) << 3) + 32.GetSceneName(), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_26 = new UnityEngine.GUILayoutOption[2];
            val_26[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_26[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_26);
            val_61 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_61 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_61 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_61 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  (((11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + (this.currentFrame) << 3) + 32) + 24.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_31 = new UnityEngine.GUILayoutOption[2];
            val_31[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_31[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_31);
            val_54 = 1152921507199214944;
            val_62 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_62 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_62 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_62 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  ((11345920 + (((1 + this.startFrame) - 1)) << 3) + 32 + (this.currentFrame) << 3) + 32 + 32, style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
        }
        
        mem2[0] = this.stackRect;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphMaxRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y});
        val_63 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_63 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_63 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_63 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_34 = new UnityEngine.GUILayoutOption[2];
        val_34[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_34[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_34);
        val_64 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_64 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_64 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_64 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.Label(text:  this.maxMemoryValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_38 = new UnityEngine.GUILayoutOption[2];
        val_38[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_38[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_38);
        val_65 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_65 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_65 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_65 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.Label(text:  this.maxFpsValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
        UnityEngine.Rect val_63 = this.stackRect;
        mem2[0] = val_63;
        val_63 = val_63 + val_63;
        val_63 = val_63 - 1f;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.graphMinRect, m_YMin = 1f, m_Width = (float)UnityEngine.Screen.width, m_Height = val_7.y});
        val_66 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_66 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_66 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_66 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_42 = new UnityEngine.GUILayoutOption[2];
        val_42[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_42[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_42);
        val_67 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_67 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_67 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_67 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.Label(text:  this.minMemoryValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayoutOption[] val_46 = new UnityEngine.GUILayoutOption[2];
        val_46[0] = UnityEngine.GUILayout.Width(width:  this.size);
        val_46[1] = UnityEngine.GUILayout.Height(height:  this.size);
        UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_46);
        val_68 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_68 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        val_68 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
        val_68 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
        UnityEngine.GUILayout.Label(text:  this.minFpsValue.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
        UnityEngine.GUILayout.FlexibleSpace();
        UnityEngine.GUILayout.EndHorizontal();
        UnityEngine.GUILayout.EndArea();
    }
    private void drawStack()
    {
        var val_21;
        var val_22;
        UnityEngine.GUILayoutOption[] val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        var val_30;
        var val_31;
        var val_32;
        if(this.selectedLog != null)
        {
                UnityEngine.Vector2 val_1 = this.getDrag();
            if(val_1.y != 0f)
        {
                float val_21 = (float)UnityEngine.Screen.height;
            val_21 = val_21 - val_1.x;
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  this.downPos, y:  val_21);
            if((this.stackRect & 1) != 0)
        {
                float val_22 = this.oldDrag2;
            val_22 = val_1.y - val_22;
            val_22 = val_3.y + val_22;
            mem[1152921507203616600] = val_22;
        }
        
        }
        
            this.oldDrag2 = val_1.y;
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.stackRect, m_YMin = val_3.y}, style:  this.backStyle);
            val_21 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_21 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_21 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_21 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_22 = 0;
            val_23 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184];
            val_23 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184;
            UnityEngine.Vector2 val_4 = UnityEngine.GUILayout.BeginScrollView(scrollPosition:  new UnityEngine.Vector2() {x = this.scrollPosition2, y = this.downPos}, options:  val_23);
            Log val_23 = this.selectedLog;
            this.scrollPosition2 = val_4;
            mem[1152921507203616600] = val_4.y;
            if(val_23 == null)
        {
                throw new NullReferenceException();
        }
        
            if(val_23 <= this.selectedLog.sampleId)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_23 = val_23 + ((this.selectedLog.sampleId) << 3);
            val_24 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_24 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_24 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184];
            val_23 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184;
            UnityEngine.GUILayout.BeginHorizontal(options:  val_23);
            if(this.selectedLog == null)
        {
                throw new NullReferenceException();
        }
        
            val_25 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_25 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_25 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_25 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  this.selectedLog.condition, style:  this.stackLabelStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.EndHorizontal();
            val_4.x = val_4.x * 0.25f;
            UnityEngine.GUILayout.Space(pixels:  val_4.x);
            val_26 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_26 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_26 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_23 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184];
            val_23 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184;
            UnityEngine.GUILayout.BeginHorizontal(options:  val_23);
            if(this.selectedLog == null)
        {
                throw new NullReferenceException();
        }
        
            val_27 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_27 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_27 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_27 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  this.selectedLog.stacktrace, style:  this.stackLabelStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.Space(pixels:  val_4.x);
            UnityEngine.GUILayout.EndScrollView();
            UnityEngine.GUILayout.EndArea();
            UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect, m_YMin = 0.25f}, style:  this.backStyle);
            val_28 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_28 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_28 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_28 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.BeginHorizontal(options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayoutOption[] val_5 = new UnityEngine.GUILayoutOption[2];
            if(val_5 == null)
        {
                throw new NullReferenceException();
        }
        
            val_5[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_23 = this.showTimeContent;
            val_5[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  val_23, style:  this.nonStyle, options:  val_5);
            if(((this.selectedLog + (this.selectedLog.sampleId) << 3).stacktrace) == null)
        {
                throw new NullReferenceException();
        }
        
            val_29 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_29 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_29 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_29 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  (this.selectedLog + (this.selectedLog.sampleId) << 3).stacktrace.m_stringLength.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_9 = new UnityEngine.GUILayoutOption[2];
            if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
            val_9[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_9[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showSceneContent, style:  this.nonStyle, options:  val_9);
            val_30 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_30 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_30 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_30 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  (this.selectedLog + (this.selectedLog.sampleId) << 3).stacktrace.GetSceneName(), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_13 = new UnityEngine.GUILayoutOption[2];
            if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
            val_13[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_13[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showMemoryContent, style:  this.nonStyle, options:  val_13);
            val_31 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_31 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_31 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_31 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  ((this.selectedLog + (this.selectedLog.sampleId) << 3).stacktrace) + 24.ToString(format:  "0.000"), style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.Space(pixels:  this.size);
            UnityEngine.GUILayoutOption[] val_18 = new UnityEngine.GUILayoutOption[2];
            if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
            val_18[0] = UnityEngine.GUILayout.Width(width:  this.size);
            val_18[1] = UnityEngine.GUILayout.Height(height:  this.size);
            UnityEngine.GUILayout.Box(content:  this.showFpsContent, style:  this.nonStyle, options:  val_18);
            val_32 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_32 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            val_32 = mem[public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302];
            val_32 = public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 302;
            UnityEngine.GUILayout.Label(text:  (this.selectedLog + (this.selectedLog.sampleId) << 3).stacktrace, style:  this.nonStyle, options:  public static T[] System.Array::Empty<UnityEngine.GUILayoutOption>().__il2cppRuntimeField_30 + 184);
            UnityEngine.GUILayout.FlexibleSpace();
            UnityEngine.GUILayout.EndHorizontal();
            UnityEngine.GUILayout.EndArea();
            return;
        }
        
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.stackRect}, style:  this.backStyle);
        UnityEngine.GUILayout.EndArea();
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.buttomRect}, style:  this.backStyle);
        UnityEngine.GUILayout.EndArea();
    }
    public void OnGUIDraw()
    {
        if(this.show == false)
        {
                return;
        }
        
        this.screenRect.x = 0f;
        int val_1 = UnityEngine.Screen.width;
        int val_2 = UnityEngine.Screen.height;
        UnityEngine.Vector2 val_3 = this.getDownPos();
        float val_12 = 0f;
        this.logsRect.x = val_12;
        val_12 = val_12 + val_12;
        float val_14 = (float)UnityEngine.Screen.width;
        float val_13 = (float)UnityEngine.Screen.height;
        val_13 = val_13 * 0.75f;
        val_14 = val_14 + val_14;
        val_14 = val_13 - val_14;
        this.stackRectTopLeft = 0;
        this.stackRect.x = 0f;
        float val_15 = (float)UnityEngine.Screen.height;
        val_15 = val_15 * 0.75f;
        mem[1152921507203900664] = val_15;
        float val_16 = (float)UnityEngine.Screen.height;
        val_16 = val_16 * 0.75f;
        float val_18 = (float)UnityEngine.Screen.width;
        float val_17 = (float)UnityEngine.Screen.height;
        val_17 = val_17 * 0.25f;
        val_18 = val_17 - val_18;
        float val_19 = 0f;
        this.detailRect.x = val_19;
        val_19 = val_19 * 3f;
        val_19 = (float)UnityEngine.Screen.height - val_19;
        float val_20 = (float)UnityEngine.Screen.width;
        val_20 = val_20 * 3f;
        if(this.currentView != 1)
        {
                if(this.currentView != 2)
        {
                return;
        }
        
            this.DrawInfo();
            return;
        }
        
        this.drawToolBar();
        this.DrawLogs();
    }
    private bool isGestureDone()
    {
        System.Collections.Generic.List<UnityEngine.Vector2> val_32;
        float val_33;
        var val_34;
        var val_35;
        System.Collections.Generic.List<UnityEngine.Vector2> val_36;
        var val_37;
        var val_40;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_4;
        }
        
        if(UnityEngine.Input.touches[32].status_internet == 4)
        {
            goto label_7;
        }
        
        if(UnityEngine.Input.touches[32].status_internet != 3)
        {
            goto label_10;
        }
        
        label_7:
        this.gestureDetector.Clear();
        goto label_53;
        label_2:
        if((UnityEngine.Input.GetMouseButtonUp(button:  0)) == false)
        {
            goto label_13;
        }
        
        label_4:
        this.gestureDetector.Clear();
        this.gestureCount = 0;
        label_53:
        if(this.gestureDetector < 10)
        {
            goto label_29;
        }
        
        UnityEngine.Vector2 val_9 = UnityEngine.Vector2.zero;
        this.gestureSum = val_9;
        mem[1152921507204273100] = val_9.y;
        this.gestureLength = 0f;
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        val_32 = this.gestureDetector;
        val_33 = val_10.x;
        val_34 = 0;
        var val_34 = 0;
        val_35 = 4294967296;
        label_27:
        if(val_34 >= ((W9 - 2) << ))
        {
            goto label_20;
        }
        
        var val_12 = val_34 + 1;
        val_36 = val_32;
        if(val_12 >= X9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            val_36 = this.gestureDetector;
        }
        
        val_12 = val_12 - 1;
        val_34 = val_34 + 8;
        if(val_12 >= X9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_34 = val_34 + val_34;
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = (0 + 8) + 32, y = (0 + 8) + 32 + 4}, b:  new UnityEngine.Vector2() {x = ((0 + 8) + val_34) + 32, y = ((0 + 8) + val_34) + 32 + 4});
        UnityEngine.Vector2 val_14 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = this.gestureSum, y = val_13.y}, b:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y});
        this.gestureSum = val_14;
        mem[1152921507204273100] = val_14.y;
        this.gestureLength = val_13.x + this.gestureLength;
        if((UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, rhs:  new UnityEngine.Vector2() {x = val_33, y = val_10.y})) < 0)
        {
            goto label_26;
        }
        
        val_33 = val_13.x;
        val_32 = this.gestureDetector;
        val_34 = val_34 + 8;
        val_35 = val_35 + 4294967296;
        var val_17 = val_12 + 1;
        if(val_32 != null)
        {
            goto label_27;
        }
        
        throw new NullReferenceException();
        label_20:
        var val_35 = UnityEngine.Screen.width;
        val_35 = UnityEngine.Screen.height + val_35;
        var val_21 = (val_35 < 0) ? (val_35 + 3) : (val_35);
        val_21 = val_21 >> 2;
        if(this.gestureLength > (float)val_21)
        {
                var val_23 = (val_35 < 0) ? (val_35 + 7) : (val_35);
            val_23 = val_23 >> 3;
            if(this.gestureLength < 0)
        {
                this.gestureDetector.Clear();
            int val_36 = this.gestureCount;
            val_36 = val_36 + 1;
            this.gestureCount = val_36;
            if(val_36 >= this.numOfCircleToShow)
        {
                return (bool)val_37;
        }
        
        }
        
        }
        
        label_29:
        val_37 = 0;
        return (bool)val_37;
        label_26:
        this.gestureDetector.Clear();
        val_37 = 0;
        this.gestureCount = 0;
        return (bool)val_37;
        label_13:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
            goto label_53;
        }
        
        UnityEngine.Vector3 val_25 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector3 val_26 = UnityEngine.Input.mousePosition;
        UnityEngine.Vector2 val_27 = new UnityEngine.Vector2(x:  val_25.x, y:  val_26.y);
        if(true == 0)
        {
            goto label_36;
        }
        
        var val_28 = X9 + 0;
        UnityEngine.Vector2 val_29 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_27.x, y = val_27.y}, b:  new UnityEngine.Vector2() {x = (X9 + 0) + 32, y = (X9 + 0) + 32 + 4});
        if(val_29.x <= 10f)
        {
            goto label_53;
        }
        
        label_36:
        val_40 = 1152921507204160992;
        goto label_41;
        label_10:
        if(UnityEngine.Input.touches[32].status_internet != 1)
        {
            goto label_53;
        }
        
        int val_37 = val_32.Length;
        if(val_37 == 0)
        {
            goto label_48;
        }
        
        val_37 = val_37 - 1;
        val_37 = X9 + (val_37 << 3);
        UnityEngine.Vector2 val_33 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B}, b:  new UnityEngine.Vector2() {x = (X9 + ((val_32.Length - 1)) << 3) + 32, y = (X9 + ((val_32.Length - 1)) << 3) + 32 + 4});
        if(val_33.x <= 10f)
        {
            goto label_53;
        }
        
        label_48:
        val_40 = 1152921507204160992;
        label_41:
        this.gestureDetector.Add(item:  new UnityEngine.Vector2() {x = V0.16B, y = V1.16B});
        goto label_53;
    }
    private bool isDoubleClickDone()
    {
        var val_9;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_1;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_3;
        }
        
        if(UnityEngine.Input.touches[32].status_internet == 0)
        {
            goto label_6;
        }
        
        val_9 = 0;
        return (bool)val_9;
        label_3:
        val_9 = 0;
        this.lastClickTime = -1f;
        return (bool)val_9;
        label_1:
        val_9 = 0;
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
                return (bool)val_9;
        }
        
        label_6:
        float val_7 = UnityEngine.Time.realtimeSinceStartup;
        if(this.lastClickTime != (-1f))
        {
                val_7 = val_7 - this.lastClickTime;
            if(val_7 < 0)
        {
                this.lastClickTime = -1f;
            val_9 = 1;
            return (bool)val_9;
        }
        
        }
        
        val_9 = 0;
        this.lastClickTime = UnityEngine.Time.realtimeSinceStartup;
        return (bool)val_9;
    }
    private UnityEngine.Vector2 getDownPos()
    {
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
            goto label_11;
        }
        
        if(UnityEngine.Input.touches[32].status_internet != 0)
        {
            goto label_11;
        }
        
        this.downPos = new UnityEngine.Vector2();
        goto label_10;
        label_2:
        if((UnityEngine.Input.GetMouseButtonDown(button:  0)) == false)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_8 = UnityEngine.Input.mousePosition;
        this.downPos = val_8.x;
        UnityEngine.Vector3 val_9 = UnityEngine.Input.mousePosition;
        label_10:
        mem[1152921507205045992] = val_9.y;
        return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
        label_11:
        UnityEngine.Vector2 val_10 = UnityEngine.Vector2.zero;
        return new UnityEngine.Vector2() {x = val_10.x, y = val_10.y};
    }
    private UnityEngine.Vector2 getDrag()
    {
        UnityEngine.Vector2 val_8;
        float val_9;
        if(UnityEngine.Application.platform != 11)
        {
                if(UnityEngine.Application.platform != 8)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Touch[] val_3 = UnityEngine.Input.touches;
        if(val_3.Length != 1)
        {
                return UnityEngine.Vector2.zero;
        }
        
        val_8 = this.downPos;
        val_9 = V0.16B;
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = this.downPos});
        label_2:
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return UnityEngine.Vector2.zero;
        }
        
        UnityEngine.Vector3 val_6 = UnityEngine.Input.mousePosition;
        val_9 = val_6.x;
        val_8 = val_6.z;
        UnityEngine.Vector2 val_7 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector3() {x = val_9, y = val_6.y, z = val_8});
        this.mousePosition = val_7;
        mem[1152921507205362800] = val_7.y;
        return UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_7.x, y = val_7.y}, b:  new UnityEngine.Vector2() {x = this.downPos});
    }
    private void calculateStartIndex()
    {
        this.startIndex = (int)S0 / S1;
        this.startIndex = UnityEngine.Mathf.Clamp(value:  (int)S0 / S1, min:  0, max:  W21);
    }
    private void doShow()
    {
        this.show = true;
        this.currentView = true;
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        ReporterGUI val_2 = val_1.AddComponent<ReporterGUI>();
        this.gameObject.SendMessage(methodName:  "OnShowReporter");
    }
    private void Update()
    {
        string val_15;
        var val_16;
        var val_17;
        System.Collections.Generic.List<Log> val_18;
        System.Collections.Generic.List<Log> val_19;
        var val_20;
        this.fpsText = this.fps.ToString(format:  "0.000");
        float val_16 = 0.0009765625f;
        float val_15 = (float)System.GC.GetTotalMemory(forceFullCollection:  false);
        val_15 = val_15 * val_16;
        val_16 = val_15 * val_16;
        this.gcTotalMemory = val_16;
        val_15 = 1152921504700137472;
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        int val_4 = val_3.m_Handle.buildIndex;
        if(val_4 != 1)
        {
                val_16 = null;
            val_16 = null;
            System.String[] val_17 = Reporter.scenes;
            val_17 = val_17 + (val_4 << 3);
            if((System.String.IsNullOrEmpty(value:  (Reporter.scenes + (val_4) << 3) + 32)) != false)
        {
                val_17 = null;
            val_17 = null;
            UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            UnityEngine.SceneManagement.Scene val_8 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_15 = val_8.m_Handle.name;
            System.String[] val_10 = Reporter.scenes + (val_6.m_Handle.buildIndex << 3);
            (Reporter.scenes + (val_7) << 3).__unknownFiledOffset_20 = val_15;
        }
        
        }
        
        this.calculateStartIndex();
        bool val_18 = this.show;
        if(val_18 != true)
        {
                if(this.isGestureDone() != false)
        {
                this.doShow();
        }
        
        }
        
        if(val_18 < true)
        {
            goto label_22;
        }
        
        bool val_12 = false;
        System.Threading.Monitor.Enter(obj:  this.threadedLogs, lockTaken: ref  val_12);
        val_18 = this.threadedLogs;
        if(val_18 == null)
        {
                throw new NullReferenceException();
        }
        
        var val_19 = 0;
        label_27:
        if(val_19 >= val_18)
        {
            goto label_24;
        }
        
        if(val_18 <= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_18 = val_18 + 0;
        if(((this.show + 0) + 32) == 0)
        {
                throw new NullReferenceException();
        }
        
        this.AddLog(condition:  (this.show + 0) + 32 + 24, stacktrace:  (this.show + 0) + 32 + 24 + 8, type:  (this.show + 0) + 32 + 20);
        val_19 = this.threadedLogs;
        val_19 = val_19 + 1;
        if(val_19 != null)
        {
            goto label_27;
        }
        
        throw new NullReferenceException();
        label_24:
        val_19.Clear();
        val_20 = 0;
        if(val_12 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.threadedLogs);
        }
        
        if(val_20 != 0)
        {
                throw val_18;
        }
        
        label_22:
        if(this.firstTime == false)
        {
            goto label_30;
        }
        
        this.firstTime = false;
        label_34:
        this.lastUpdate = UnityEngine.Time.realtimeSinceStartup;
        this.frames = 0;
        return;
        label_30:
        int val_20 = this.frames;
        val_20 = val_20 + 1;
        this.frames = val_20;
        float val_14 = UnityEngine.Time.realtimeSinceStartup;
        val_14 = val_14 - this.lastUpdate;
        if(val_14 <= 0.25f)
        {
                return;
        }
        
        if(this.frames < 11)
        {
                return;
        }
        
        val_14 = (float)this.frames / val_14;
        this.fps = val_14;
        goto label_34;
    }
    private void CaptureLog(string condition, string stacktrace, UnityEngine.LogType type)
    {
        this.AddLog(condition:  condition, stacktrace:  stacktrace, type:  type);
    }
    private void AddLog(string condition, string stacktrace, UnityEngine.LogType type)
    {
        Reporter._LogType val_22;
        string val_23;
        object val_24;
        string val_25;
        float val_26;
        var val_27;
        float val_28;
        string val_29;
        var val_30;
        int val_31;
        val_22 = type;
        val_23 = condition;
        val_24 = this;
        if(this.cachedString == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_23;
        if(this.cachedString == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.cachedString.ContainsKey(key:  val_25)) != false)
        {
                val_25 = val_23;
            val_23 = this.cachedString.Item[val_25];
            val_26 = 0f;
        }
        else
        {
                this.cachedString.Add(key:  val_23, value:  val_23);
            val_25 = 0;
            if((System.String.IsNullOrEmpty(value:  val_23)) != false)
        {
                val_27 = 0;
        }
        else
        {
                if(val_23 == null)
        {
                throw new NullReferenceException();
        }
        
            val_27 = condition.m_stringLength << 1;
        }
        
            val_28 = (float)System.IntPtr.Size;
            val_26 = (float)val_27 + val_28;
        }
        
        if(this.cachedString == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = stacktrace;
        if(this.cachedString == null)
        {
                throw new NullReferenceException();
        }
        
        if((this.cachedString.ContainsKey(key:  val_25)) != false)
        {
                val_29 = this.cachedString.Item[stacktrace];
        }
        else
        {
                this.cachedString.Add(key:  stacktrace, value:  stacktrace);
            if((System.String.IsNullOrEmpty(value:  stacktrace)) != false)
        {
                val_30 = 0;
        }
        else
        {
                if(stacktrace == null)
        {
                throw new NullReferenceException();
        }
        
            val_30 = stacktrace.m_stringLength << 1;
        }
        
            val_26 = val_26 + (float)val_30;
            val_28 = (float)System.IntPtr.Size;
            val_26 = val_26 + val_28;
            val_29 = stacktrace;
        }
        
        this.addSample();
        Reporter.Log val_9 = null;
        val_25 = 0;
        .count = 1;
        val_9 = new Reporter.Log();
        if(val_9 == null)
        {
                throw new NullReferenceException();
        }
        
        .logType = val_22;
        .condition = val_23;
        .stacktrace = val_29;
        System.Collections.Generic.List<Sample> val_22 = this.samples;
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_22 = val_22 - 1;
        .sampleId = val_22;
        float val_10 = val_9.GetMemoryUsage();
        float val_23 = 0.0009765625f;
        val_10 = val_26 + val_10;
        val_10 = val_10 * val_23;
        val_10 = val_10 * val_23;
        val_10 = this.logsMemUsage + val_10;
        val_23 = this.graphMemUsage + val_10;
        this.logsMemUsage = val_10;
        if(val_23 > this.maxSize)
        {
                this.clear();
            val_24 = "Memory Usage Reach" + this.maxSize + " mb So It is Cleared";
            UnityEngine.Debug.Log(message:  val_24);
            return;
        }
        
        if(this.logsDic == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_23;
        if((this.logsDic.ContainsKey(key1:  val_25, key2:  stacktrace)) == false)
        {
            goto label_22;
        }
        
        if(this.logsDic == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_23;
        System.Collections.Generic.Dictionary<T2, T3> val_13 = this.logsDic.Item[val_25];
        if(val_13 == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = stacktrace;
        if(val_13.Item[val_25] == null)
        {
                throw new NullReferenceException();
        }
        
        val_23 = 0;
        val_31 = val_14.count;
        goto label_26;
        label_22:
        if(this.collapsedLogs == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_9;
        this.collapsedLogs.Add(item:  val_9);
        if(this.logsDic == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_23;
        System.Collections.Generic.Dictionary<T2, T3> val_15 = this.logsDic.Item[val_25];
        if(val_15 == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = stacktrace;
        val_15.set_Item(key:  val_25, value:  val_9);
        if(val_22 == 2)
        {
            goto label_30;
        }
        
        if(val_22 != 3)
        {
            goto label_31;
        }
        
        int val_24 = this.numOfCollapsedLogs;
        val_23 = 1;
        val_24 = val_24 + 1;
        this.numOfCollapsedLogs = val_24;
        goto label_32;
        label_30:
        int val_25 = this.numOfCollapsedLogsWarning;
        val_23 = 1;
        val_25 = val_25 + 1;
        this.numOfCollapsedLogsWarning = val_25;
        goto label_34;
        label_31:
        val_31 = this.numOfCollapsedLogsError;
        val_23 = 1;
        label_26:
        int val_26 = val_31;
        val_26 = val_26 + 1;
        mem2[0] = val_26;
        if(val_22 == 2)
        {
            goto label_34;
        }
        
        if(val_22 != 3)
        {
            goto label_35;
        }
        
        label_32:
        int val_27 = this.numOfLogs;
        val_27 = val_27 + 1;
        this.numOfLogs = val_27;
        goto label_37;
        label_34:
        int val_28 = this.numOfLogsWarning;
        val_28 = val_28 + 1;
        this.numOfLogsWarning = val_28;
        goto label_37;
        label_35:
        int val_29 = this.numOfLogsError;
        val_29 = val_29 + 1;
        this.numOfLogsError = val_29;
        label_37:
        if(this.logs == null)
        {
                throw new NullReferenceException();
        }
        
        this.logs.Add(item:  val_9);
        bool val_30 = this.collapse;
        val_30 = val_30 ^ 1;
        val_30 = val_23 | val_30;
        if(val_30 == false)
        {
            goto label_53;
        }
        
        if((Reporter.Log)[1152921507206297136].logType > 4)
        {
            goto label_43;
        }
        
        var val_31 = 11347008 + ((Reporter.Log)[1152921507206297136].logType) << 2;
        val_31 = val_31 + 11347008;
        goto (11347008 + ((Reporter.Log)[1152921507206297136].logType) << 2 + 11347008);
        label_43:
        val_25 = 0;
        if((System.String.IsNullOrEmpty(value:  this.filterText)) == true)
        {
            goto label_46;
        }
        
        if((Reporter.Log)[1152921507206297136].condition == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = 0;
        if(this.filterText == null)
        {
                throw new NullReferenceException();
        }
        
        val_22 = (Reporter.Log)[1152921507206297136].condition.ToLower();
        val_25 = 0;
        if(val_22 == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = this.filterText.ToLower();
        if((val_22.Contains(value:  val_25)) == false)
        {
            goto label_53;
        }
        
        label_46:
        if(this.currentLog == null)
        {
                throw new NullReferenceException();
        }
        
        val_25 = val_9;
        this.currentLog.Add(item:  val_9);
        this.calculateStartIndex();
        if(this.currentLog == null)
        {
                throw new NullReferenceException();
        }
        
        float val_32 = (float)UnityEngine.Screen.height;
        val_32 = val_32 * 0.75f;
        val_32 = val_32 / val_10;
        int val_33 = (int)val_32;
        val_33 = val_22 - val_33;
        if(this.startIndex >= val_33)
        {
                val_10 = val_10 + val_32;
            mem[1152921507206229024] = val_10;
        }
        
        label_53:
        this.gameObject.SendMessage(methodName:  "OnLog", value:  val_9);
    }
    private void CaptureLogThread(string condition, string stacktrace, UnityEngine.LogType type)
    {
        var val_3 = this;
        Reporter.Log val_1 = null;
        .count = 1;
        val_1 = new Reporter.Log();
        if(val_1 == null)
        {
                throw new NullReferenceException();
        }
        
        .condition = condition;
        .stacktrace = stacktrace;
        .logType = type;
        bool val_2 = false;
        System.Threading.Monitor.Enter(obj:  this.threadedLogs, lockTaken: ref  val_2);
        this.threadedLogs.Add(item:  val_1);
        val_3 = 0;
        if(val_2 != 0)
        {
                System.Threading.Monitor.Exit(obj:  this.threadedLogs);
        }
        
        if(val_3 != 0)
        {
                throw val_3 = this;
        }
    
    }
    private void _OnLevelWasLoaded(UnityEngine.SceneManagement.Scene _null1, UnityEngine.SceneManagement.LoadSceneMode _null2)
    {
        if(this.clearOnNewSceneLoaded != false)
        {
                this.clear();
        }
        
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        this.currentScene = val_1.m_Handle.name;
        UnityEngine.SceneManagement.Scene val_3 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        UnityEngine.Debug.Log(message:  "Scene " + val_3.m_Handle.name + " is loaded");
    }
    private void OnApplicationQuit()
    {
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_currentView", value:  this.currentView);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_show", value:  this.show);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_collapse", value:  this.collapse);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_clearOnNewSceneLoaded", value:  this.clearOnNewSceneLoaded);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showTime", value:  this.showTime);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showScene", value:  this.showScene);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showMemory", value:  this.showMemory);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showFps", value:  this.showFps);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showGraph", value:  this.showGraph);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showLog", value:  this.showLog);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showWarning", value:  this.showWarning);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showError", value:  this.showError);
        UnityEngine.PlayerPrefs.SetString(key:  "Reporter_filterText", value:  this.filterText);
        UnityEngine.PlayerPrefs.SetFloat(key:  11165912, value:  this.size);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showClearOnNewSceneLoadedButton", value:  this.showClearOnNewSceneLoadedButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showTimeButton", value:  this.showTimeButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showSceneButton", value:  this.showSceneButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showMemButton", value:  this.showMemButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showFpsButton", value:  this.showFpsButton);
        UnityEngine.PlayerPrefs.SetInt(key:  "Reporter_showSearchText", value:  this.showSearchText);
        UnityEngine.PlayerPrefs.Save();
    }
    private System.Collections.IEnumerator readInfo()
    {
        .<>1__state = 0;
        .<>4__this = this;
        return (System.Collections.IEnumerator)new Reporter.<readInfo>d__188();
    }
    private void SaveLogsToDevice()
    {
        int val_8;
        int val_9;
        string val_2 = UnityEngine.Application.persistentDataPath + "/logs.txt"("/logs.txt");
        System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
        UnityEngine.Debug.Log(message:  "Saving logs to " + val_2);
        System.IO.File.Delete(path:  val_2);
        var val_9 = 4;
        label_31:
        var val_5 = val_9 - 4;
        if(val_5 >= this.logs)
        {
            goto label_4;
        }
        
        object[] val_6 = new object[5];
        if(this.logs <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_6.Length;
        val_6[0] = this.logs;
        val_8 = val_6.Length;
        val_6[1] = "\n";
        if("\n" <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_9 = val_6.Length;
        val_6[2] = "\n".__il2cppRuntimeField_20 + 24;
        val_9 = val_6.Length;
        val_6[3] = "\n";
        if("\n" <= val_5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6[4] = "\n".__il2cppRuntimeField_20 + 32;
        val_3.Add(item:  +val_6);
        val_9 = val_9 + 1;
        if(this.logs != null)
        {
            goto label_31;
        }
        
        label_4:
        System.IO.File.WriteAllLines(path:  val_2, contents:  val_3.ToArray());
    }
    public Reporter()
    {
        this.samples = new System.Collections.Generic.List<Sample>();
        this.logs = new System.Collections.Generic.List<Log>();
        this.collapsedLogs = new System.Collections.Generic.List<Log>();
        this.currentLog = new System.Collections.Generic.List<Log>();
        this.logsDic = new MultiKeyDictionary<System.String, System.String, Log>();
        this.cachedString = new System.Collections.Generic.Dictionary<System.String, System.String>();
        this.showLog = true;
        this.showWarning = true;
        this.showError = true;
        this.showClearOnNewSceneLoadedButton = true;
        this.showTimeButton = true;
        this.showSceneButton = true;
        this.showMemButton = true;
        this.showFpsButton = true;
        this.showSearchText = true;
        this.showCopyButton = true;
        this.showSaveButton = true;
        this.currentView = true;
        this.UserData = "";
        UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  32f, y:  32f);
        this.maxSize = 20f;
        this.numOfCircleToShow = 1;
        this.size = val_7.x;
        this.filterText = "";
        UnityEngine.Rect val_8 = UnityEngine.Rect.zero;
        this.screenRect = val_8;
        mem[1152921507207343720] = val_8.m_YMin;
        mem[1152921507207343724] = val_8.m_Width;
        mem[1152921507207343728] = val_8.m_Height;
        UnityEngine.Rect val_9 = UnityEngine.Rect.zero;
        this.toolBarRect = val_9;
        mem[1152921507207343736] = val_9.m_YMin;
        mem[1152921507207343740] = val_9.m_Width;
        mem[1152921507207343744] = val_9.m_Height;
        UnityEngine.Rect val_10 = UnityEngine.Rect.zero;
        this.logsRect = val_10;
        mem[1152921507207343752] = val_10.m_YMin;
        mem[1152921507207343756] = val_10.m_Width;
        mem[1152921507207343760] = val_10.m_Height;
        UnityEngine.Rect val_11 = UnityEngine.Rect.zero;
        this.stackRect = val_11;
        mem[1152921507207343768] = val_11.m_YMin;
        mem[1152921507207343772] = val_11.m_Width;
        mem[1152921507207343776] = val_11.m_Height;
        UnityEngine.Rect val_12 = UnityEngine.Rect.zero;
        this.graphRect = val_12;
        mem[1152921507207343784] = val_12.m_YMin;
        mem[1152921507207343788] = val_12.m_Width;
        mem[1152921507207343792] = val_12.m_Height;
        UnityEngine.Rect val_13 = UnityEngine.Rect.zero;
        this.graphMinRect = val_13;
        mem[1152921507207343800] = val_13.m_YMin;
        mem[1152921507207343804] = val_13.m_Width;
        mem[1152921507207343808] = val_13.m_Height;
        UnityEngine.Rect val_14 = UnityEngine.Rect.zero;
        this.graphMaxRect = val_14;
        mem[1152921507207343816] = val_14.m_YMin;
        mem[1152921507207343820] = val_14.m_Width;
        mem[1152921507207343824] = val_14.m_Height;
        UnityEngine.Rect val_15 = UnityEngine.Rect.zero;
        this.buttomRect = val_15;
        mem[1152921507207343832] = val_15.m_YMin;
        mem[1152921507207343836] = val_15.m_Width;
        mem[1152921507207343840] = val_15.m_Height;
        UnityEngine.Rect val_16 = UnityEngine.Rect.zero;
        this.detailRect = val_16;
        mem[1152921507207343856] = val_16.m_YMin;
        mem[1152921507207343860] = val_16.m_Width;
        mem[1152921507207343864] = val_16.m_Height;
        UnityEngine.Rect val_17 = UnityEngine.Rect.zero;
        this.countRect = val_17;
        mem[1152921507207343928] = val_17.m_YMin;
        mem[1152921507207343932] = val_17.m_Width;
        mem[1152921507207343936] = val_17.m_Height;
        UnityEngine.Rect val_18 = UnityEngine.Rect.zero;
        this.timeRect = val_18;
        mem[1152921507207343944] = val_18.m_YMin;
        mem[1152921507207343948] = val_18.m_Width;
        mem[1152921507207343952] = val_18.m_Height;
        UnityEngine.Rect val_19 = UnityEngine.Rect.zero;
        this.timeLabelRect = val_19;
        mem[1152921507207343960] = val_19.m_YMin;
        mem[1152921507207343964] = val_19.m_Width;
        mem[1152921507207343968] = val_19.m_Height;
        UnityEngine.Rect val_20 = UnityEngine.Rect.zero;
        this.sceneRect = val_20;
        mem[1152921507207343976] = val_20.m_YMin;
        mem[1152921507207343980] = val_20.m_Width;
        mem[1152921507207343984] = val_20.m_Height;
        UnityEngine.Rect val_21 = UnityEngine.Rect.zero;
        this.sceneLabelRect = val_21;
        mem[1152921507207343992] = val_21.m_YMin;
        mem[1152921507207343996] = val_21.m_Width;
        mem[1152921507207344000] = val_21.m_Height;
        UnityEngine.Rect val_22 = UnityEngine.Rect.zero;
        this.memoryRect = val_22;
        mem[1152921507207344008] = val_22.m_YMin;
        mem[1152921507207344012] = val_22.m_Width;
        mem[1152921507207344016] = val_22.m_Height;
        UnityEngine.Rect val_23 = UnityEngine.Rect.zero;
        this.memoryLabelRect = val_23;
        mem[1152921507207344024] = val_23.m_YMin;
        mem[1152921507207344028] = val_23.m_Width;
        mem[1152921507207344032] = val_23.m_Height;
        UnityEngine.Rect val_24 = UnityEngine.Rect.zero;
        this.fpsRect = val_24;
        mem[1152921507207344040] = val_24.m_YMin;
        mem[1152921507207344044] = val_24.m_Width;
        mem[1152921507207344048] = val_24.m_Height;
        UnityEngine.Rect val_25 = UnityEngine.Rect.zero;
        this.fpsLabelRect = val_25;
        mem[1152921507207344056] = val_25.m_YMin;
        mem[1152921507207344060] = val_25.m_Width;
        mem[1152921507207344064] = val_25.m_Height;
        this.tempContent = new UnityEngine.GUIContent();
        this.graphSize = 4f;
        this.gestureDetector = new System.Collections.Generic.List<UnityEngine.Vector2>();
        UnityEngine.Vector2 val_28 = UnityEngine.Vector2.zero;
        this.gestureSum = val_28;
        mem[1152921507207344188] = val_28.y;
        this.lastClickTime = -1f;
        this.firstTime = true;
        this.threadedLogs = new System.Collections.Generic.List<Log>();
    }
    private static Reporter()
    {
    
    }

}
