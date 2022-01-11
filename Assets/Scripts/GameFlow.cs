using UnityEngine;
public class GameFlow : MonoBehaviour
{
    // Fields
    public LevelController[] levelPrefabs;
    public UnityEngine.Audio.AudioMixer audioMixer;
    public UnityEngine.Camera gameCamera;
    public UnityEngine.AudioSource audioSourceWin;
    public UnityEngine.AudioSource audioSourceLose;
    public RadarVisualizer radarForward;
    public UnityEngine.Transform[] envBlocks;
    public LoadingView loadingView;
    public TextMeshCountdown textMeshCountdown;
    public UnityEngine.GameObject blocker;
    public StartView startView;
    public PlayView playView;
    public WinView winView;
    public LoseView loseView;
    public RateView rateView;
    public TutorialView tutorialView;
    public ShopView shopView;
    public UnityEngine.Material materialHiddenWall;
    public UnityEngine.Material materialOutline;
    public UnityEngine.Material materialBackground;
    public float cameraStartDistance;
    public float cameraStartAngle;
    public float cameraPlayDistance;
    public float cameraPlayAngle;
    public float cameraStartDistancceSeek;
    private GameMode mode;
    private float time;
    private float duration;
    private bool isPlaying;
    private bool isCountdownPlayingTime;
    private int caughtHiderCount;
    private int rescuedHiderCount;
    private int collectedCoin;
    private bool gameEnd;
    private int minCaughtHiderCount;
    private int rewardPerRescue;
    private int rewardPerCatch;
    private UnityEngine.AI.NavMeshDataInstance currentNavMeshDataInstance;
    private LevelController levelInstance;
    private LevelController levelInstancePrevious;
    private bool levelExist;
    private CharacterManager characterManager;
    public bool useSpeedBoost;
    public bool useInvisibility;
    public bool useIgnoreWall;
    private bool isReplay;
    private UnityEngine.Vector3 levelPosition;
    private bool isFirstLoaded;
    private int loadNewMapTimeCount;
    private int loseThisLevelTimeCount;
    
    // Methods
    public void LoadLevel()
    {
        var val_40;
        DG.Tweening.TweenCallback val_41;
        bool val_42;
        var val_43;
        CharacterManager val_44;
        DG.Tweening.TweenCallback val_45;
        var val_46;
        UserData val_47;
        if((this.isReplay != true) && (this.isFirstLoaded != true))
        {
                float val_2 = S0 + 40f;
            mem[1152921507126737628] = val_2;
            this.loadNewMapTimeCount = this.loadNewMapTimeCount + 1;
        }
        
        val_40 = null;
        val_40 = null;
        int val_40 = UserData.current.level;
        val_40 = val_40 - 1;
        val_40 = val_40 - ((val_40 / this.levelPrefabs.Length) * this.levelPrefabs.Length);
        float val_4 = val_2 + (this.levelPrefabs[(UserData.current.level - 1) - (((UserData.current.level - 1) / this.levelPrefabs.Length) * this.levelPrefabs.Length)][0].offsetY);
        mem[1152921507126737624] = val_4;
        val_41 = 1152921504693055488;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_42 = this.isReplay;
        this.levelInstance = UnityEngine.Object.Instantiate<LevelController>(original:  this.levelPrefabs[val_40], position:  new UnityEngine.Vector3() {x = this.levelPosition, y = val_4, z = V9.16B}, rotation:  new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w});
        if(val_42 != false)
        {
                val_42 = this.loseThisLevelTimeCount + 1;
        }
        
        this.loseThisLevelTimeCount = val_42;
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
        UnityEngine.AI.NavMeshDataInstance val_8 = UnityEngine.AI.NavMesh.AddNavMeshData(navMeshData:  val_6.navMeshData, position:  new UnityEngine.Vector3() {x = this.levelPosition, y = val_4, z = V9.16B}, rotation:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w});
        this.currentNavMeshDataInstance = val_8;
        this.isPlaying = false;
        float val_42 = 0.25f;
        this.minCaughtHiderCount = (int)this.levelInstance.minHiderSeekCount;
        this.isCountdownPlayingTime = false;
        mem[1152921507126737553] = 0;
        this.caughtHiderCount = 0;
        this.rescuedHiderCount = 0;
        val_42 = this.levelInstance.duration + val_42;
        this.time = val_42;
        this.duration = this.levelInstance.duration;
        this.playView.SetCount(count:  0, flag:  true);
        this.startView.Open();
        val_43 = null;
        val_43 = null;
        this.startView.SetLevel(level:  UserData.current.level);
        this.startView.SetCoin(coin:  UserData.current.coin);
        this.characterManager.Spawn();
        bool val_9 = this.levelInstance.characterPoints.startAnimation.Equals(value:  "Idle");
        this.characterManager.seeker.animator.Play(stateName:  this.levelInstance.characterPoints.startAnimation);
        this.characterManager.seeker.animator.SetBool(name:  "ground", value:  val_9);
        val_44 = this.characterManager;
        val_45 = 0;
        label_48:
        if(val_45 >= this.levelInstance.characterPoints)
        {
            goto label_41;
        }
        
        if(this.levelInstance.characterPoints <= val_45)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg + 88.Play(stateName:  this.levelInstance.characterPoints.startAnimation);
        CharacterManager.__il2cppRuntimeField_byval_arg + 88.SetBool(name:  "ground", value:  val_9);
        val_44 = this.characterManager;
        val_45 = val_45 + 1;
        if(val_44 != null)
        {
            goto label_48;
        }
        
        throw new NullReferenceException();
        label_41:
        UnityEngine.Vector3 val_12 = this.levelInstance.characterPoints.GetPosition(idx:  0);
        this.levelInstance.characterPoints.SetTransform(character:  this.characterManager.seeker, position:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        if(this.characterManager == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_13 = this.levelInstance.characterPoints.GetPosition(idx:  3);
        this.levelInstance.characterPoints.SetTransform(character:  this.levelInstance.offsetY, position:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z});
        if(this.characterManager <= 1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_14 = this.levelInstance.characterPoints.GetPosition(idx:  5);
        this.levelInstance.characterPoints.SetTransform(character:  this.levelInstance.characterPoints, position:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z});
        if(this.characterManager <= 2)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_15 = this.levelInstance.characterPoints.GetPosition(idx:  1);
        this.levelInstance.characterPoints.SetTransform(character:  this.levelInstance.navMeshData, position:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
        if(this.characterManager <= 3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_16 = this.levelInstance.characterPoints.GetPosition(idx:  2);
        this.levelInstance.characterPoints.SetTransform(character:  this.levelInstance.materialWall, position:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z});
        if(this.characterManager <= 4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_17 = this.levelInstance.characterPoints.GetPosition(idx:  4);
        this.levelInstance.characterPoints.SetTransform(character:  this.levelInstance.materialFloor, position:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
        if(this.characterManager <= 5)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Vector3 val_18 = this.levelInstance.characterPoints.GetPosition(idx:  0);
        this.levelInstance.characterPoints.SetTransform(character:  this.characterManager.hiders, position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
        UnityEngine.Transform val_19 = this.gameCamera.transform;
        UnityEngine.Quaternion val_20 = UnityEngine.Quaternion.Euler(x:  this.cameraStartAngle, y:  0f, z:  0f);
        UnityEngine.Vector3 val_21 = this.levelInstance.characterPoints.GetPosition(idx:  0);
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_23 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, point:  new UnityEngine.Vector3() {x = val_22.x, y = val_22.y, z = val_22.z});
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, d:  this.cameraStartDistance);
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z});
        if(this.isFirstLoaded != false)
        {
                this.isFirstLoaded = false;
            val_19.position = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
            val_19.rotation = new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w};
            UnityEngine.Color val_26 = this.levelInstance.materialWall.color;
            this.materialBackground.color = new UnityEngine.Color() {r = val_26.r, g = val_26.g, b = val_26.b, a = val_26.a};
            UnityEngine.Color val_27 = this.levelInstance.materialFloor.color;
            UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = val_27.r, g = val_27.g, b = val_27.b, a = val_27.a};
        }
        else
        {
                GameFlow.<>c__DisplayClass50_0 val_28 = new GameFlow.<>c__DisplayClass50_0();
            .<>4__this = this;
            UnityEngine.Color val_29 = this.materialBackground.color;
            .colorStartBackground = val_29;
            mem[1152921507127117512] = val_29.g;
            mem[1152921507127117516] = val_29.b;
            mem[1152921507127117520] = val_29.a;
            UnityEngine.Color val_30 = this.levelInstance.materialWall.color;
            .colorEndBackGround = val_30;
            mem[1152921507127117528] = val_30.g;
            mem[1152921507127117532] = val_30.b;
            mem[1152921507127117536] = val_30.a;
            UnityEngine.Color val_31 = UnityEngine.RenderSettings.fogColor;
            .colorStartFog = val_31;
            mem[1152921507127117544] = val_31.g;
            mem[1152921507127117548] = val_31.b;
            mem[1152921507127117552] = val_31.a;
            UnityEngine.Color val_32 = this.levelInstance.materialFloor.color;
            .colorEndFog = val_32;
            mem[1152921507127117560] = val_32.g;
            mem[1152921507127117564] = val_32.b;
            mem[1152921507127117568] = val_32.a;
            .colorTweenTime = 0f;
            DG.Tweening.TweenCallback val_36 = null;
            val_45 = val_36;
            val_36 = new DG.Tweening.TweenCallback(object:  val_28, method:  System.Void GameFlow.<>c__DisplayClass50_0::<LoadLevel>b__2());
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_37 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_28, method:  System.Single GameFlow.<>c__DisplayClass50_0::<LoadLevel>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_28, method:  System.Void GameFlow.<>c__DisplayClass50_0::<LoadLevel>b__1(float value)), endValue:  1f, duration:  1.5f), action:  val_36);
            DG.Tweening.TweenCallback val_38 = null;
            val_41 = val_38;
            val_38 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameFlow::<LoadLevel>b__50_3());
            val_38.CameraDOTransformation(cameraTransform:  val_19, position:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, rotation:  new UnityEngine.Quaternion() {x = val_20.x, y = val_20.y, z = val_20.z, w = val_20.w}, duration:  1.5f, OnCompleted:  val_38);
        }
        
        val_46 = null;
        val_46 = null;
        AppEventTracker.PushEvent_Level(level:  UserData.current.level, start:  true, isReplay:  this.isReplay);
        val_47 = UserData.current;
        if(UserData.current.dayActive != 1)
        {
                return;
        }
        
        val_47 = UserData.current;
        AppEventTracker.PushEvent_LevelDay0_Start(level:  UserData.current.level, result:  "start", mode:  (this.mode == 0) ? "hide" : "seek");
    }
    private void CameraDOTransformation(UnityEngine.Transform cameraTransform, UnityEngine.Vector3 position, UnityEngine.Quaternion rotation, float duration, DG.Tweening.TweenCallback OnCompleted)
    {
        DG.Tweening.Tweener val_1 = DG.Tweening.ShortcutExtensions.DOMove(target:  cameraTransform, endValue:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z}, duration:  duration, snapping:  false);
        DG.Tweening.Tweener val_3 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotateQuaternion(target:  cameraTransform, endValue:  new UnityEngine.Quaternion() {x = rotation.x, y = rotation.y, z = rotation.z, w = rotation.w}, duration:  duration), action:  OnCompleted);
    }
    public void ClearLevel()
    {
        this.radarForward.gameObject.SetActive(value:  false);
        this.characterManager.Clear();
        bool val_2 = this.currentNavMeshDataInstance.valid;
        if((UnityEngine.Object.op_Implicit(exists:  this.levelInstance)) != false)
        {
                if(this.isReplay != false)
        {
                UnityEngine.Object.Destroy(obj:  this.levelInstance.gameObject);
        }
        else
        {
                this.levelInstancePrevious = this.levelInstance;
        }
        
        }
        
        this.levelInstance = 0;
        this.levelExist = false;
        SingletonMonoBehaviour<SpeedBooster>.Instance.Stop();
        SingletonMonoBehaviour<Invisibility>.Instance.StopAllCoroutines();
        SingletonMonoBehaviour<IgnoreWall>.Instance.StopAllCoroutines();
    }
    private void SetupAdManagerForIOS()
    {
        AdManager val_1 = SingletonMonoBehaviour<AdManager>.Instance;
        val_1.AudioPauseAction = new System.Action(object:  this, method:  System.Void GameFlow::<SetupAdManagerForIOS>b__53_0());
        AdManager val_3 = SingletonMonoBehaviour<AdManager>.Instance;
        val_3.AudioResumeAction = new System.Action(object:  this, method:  System.Void GameFlow::<SetupAdManagerForIOS>b__53_1());
    }
    public void Start()
    {
        UnityEngine.Application.targetFrameRate = 60;
        bool val_1 = UserData.Load(forceReload:  false);
        this.characterManager = SingletonMonoBehaviour<CharacterManager>.Instance;
        bool val_6 = this.audioMixer.SetFloat(name:  "MusicVolume", value:  ((UnityEngine.PlayerPrefs.GetInt(key:  "music", defaultValue:  1)) == 1) ? 0f : -80f);
        bool val_8 = this.audioMixer.SetFloat(name:  "EffectVolume", value:  ((UnityEngine.PlayerPrefs.GetInt(key:  "sound", defaultValue:  1)) == 1) ? 0f : -80f);
        CoinController.add_CoinCollectedEvent(value:  new System.Action<Character, CoinController>(object:  this, method:  System.Void GameFlow::OnCoinCollected(Character character, CoinController coin)));
        this.loseView.OnReplay = new System.Action(object:  this, method:  System.Void GameFlow::OnReplay());
        this.loseView.OnSkip = new System.Action(object:  this, method:  System.Void GameFlow::OnSkip());
        this.loseView.OnSpeedUp = new System.Action(object:  this, method:  System.Void GameFlow::<Start>b__54_0());
        this.loseView.OnInvisible = new System.Action(object:  this, method:  System.Void GameFlow::<Start>b__54_1());
        this.loseView.OnIgnoreWall = new System.Action(object:  this, method:  System.Void GameFlow::<Start>b__54_2());
        this.winView.OnReplay = new System.Action(object:  this, method:  System.Void GameFlow::OnReplay());
        this.winView.OnNext = new System.Action(object:  this, method:  System.Void GameFlow::OnNext());
        bool val_17 = Analytics.Tracker.IsReady;
        if(val_17 != false)
        {
                val_17.OnFirebaseReady();
        }
        else
        {
                Analytics.Tracker.add_OnFirebaseReady(value:  new System.Action(object:  this, method:  System.Void GameFlow::OnFirebaseReady()));
        }
        
        this.loadingView.Open();
        this.loadingView.OnClose = new System.Action(object:  this, method:  public System.Void GameFlow::LoadLevel());
        this.shopView.OnHiderIdChange = new System.Action(object:  this, method:  System.Void GameFlow::<Start>b__54_3());
        this.shopView.OnSeekerIdChange = new System.Action(object:  this, method:  System.Void GameFlow::<Start>b__54_4());
    }
    private void OnFirebaseReady()
    {
        var val_2;
        SingletonMonoBehaviour<RemoteConfigControl>.Instance.InitializeFirebase();
        val_2 = null;
        val_2 = null;
        AppEventTracker.SetUserPropertyLevel(value:  UserData.current.level);
    }
    public void OnDestroy()
    {
        if(this.currentNavMeshDataInstance.valid == false)
        {
                return;
        }
    
    }
    private void SetTransform(Character character, UnityEngine.Vector3 position)
    {
        character.transform.position = new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.up;
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.AngleAxis(angle:  UnityEngine.Random.Range(min:  0f, max:  360f), axis:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        character.transform.rotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
    }
    private void OnCoinCollected(Character character, CoinController coin)
    {
        var val_1;
        if(character.isPlayer == false)
        {
                return;
        }
        
        int val_1 = this.collectedCoin;
        val_1 = coin.value + val_1;
        this.collectedCoin = val_1;
        val_1 = null;
        val_1 = null;
        int val_2 = UserData.current.coin;
        val_2 = coin.value + val_2;
        UserData.current.coin = val_2;
        this.startView.SetCoin(coin:  UserData.current.coin);
    }
    private void OnHiderGetCaught(Hider hider)
    {
        var val_2;
        if(this.mode == 1)
        {
                hider.SetVisibleToSeeker(flag:  true);
            val_2 = null;
            val_2 = null;
            int val_2 = UserData.current.coin;
            val_2 = this.rewardPerCatch + val_2;
            UserData.current.coin = val_2;
            this.startView.SetCoin(coin:  UserData.current.coin);
        }
        
        int val_1 = this.caughtHiderCount + 1;
        this.caughtHiderCount = val_1;
        this.playView.SetCount(count:  val_1, flag:  true);
        if(this.caughtHiderCount != 0)
        {
                this.OnHiderPlayerCaught();
            return;
        }
        
        if(this.caughtHiderCount != 6)
        {
                return;
        }
        
        this.OnAllHidersCaught();
    }
    private void OnHiderGetReleased(Hider subject, Hider hider)
    {
        var val_1;
        if(this.mode == 1)
        {
                hider.SetVisibleToSeeker(flag:  false);
        }
        
        this.playView.SetCount(count:  this.caughtHiderCount, flag:  false);
        int val_1 = this.caughtHiderCount;
        val_1 = val_1 - 1;
        this.caughtHiderCount = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        int val_2 = this.rescuedHiderCount;
        val_2 = val_2 + 1;
        this.rescuedHiderCount = val_2;
        val_1 = null;
        val_1 = null;
        int val_3 = UserData.current.coin;
        val_3 = this.rewardPerRescue + val_3;
        UserData.current.coin = val_3;
        this.startView.SetCoin(coin:  UserData.current.coin);
    }
    private void OnGameStart()
    {
        this.isPlaying = true;
        this.gameEnd = false;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.StartCharacterDelay(delay:  0.5f));
        this.startView.Close();
        this.playView.seeker = this.characterManager.seeker;
        float val_43 = 0.25f;
        val_43 = this.levelInstance.duration + val_43;
        this.time = val_43;
        this.duration = this.levelInstance.duration;
        this.playView.OnGameStart(mode:  this.mode, dur:  this.levelInstance.duration);
        if(this.mode != 0)
        {
                .<>4__this = this;
            this.playView.SetMinCaught(count:  this.minCaughtHiderCount);
            CharacterManager val_4 = SingletonMonoBehaviour<CharacterManager>.Instance;
            .playerCharacter = val_4.seeker;
            .cameraTransform = this.gameCamera.transform;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(x:  this.cameraPlayAngle, y:  0f, z:  0f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_8 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, point:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this.cameraPlayDistance);
            CameraFollowPlayer val_11 = (GameFlow.<>c__DisplayClass61_1)[1152921507129170064].cameraTransform.GetComponent<CameraFollowPlayer>();
            .cameraFollowPlayer = val_11;
            val_11.SetTarget(target:  (GameFlow.<>c__DisplayClass61_1)[1152921507129170064].playerCharacter.transform, offset:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
            UnityEngine.Vector3 val_14 = (GameFlow.<>c__DisplayClass61_1)[1152921507129170064].playerCharacter.transform.position;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, d:  this.cameraStartDistancceSeek);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            DG.Tweening.Tweener val_18 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  (GameFlow.<>c__DisplayClass61_1)[1152921507129170064].cameraTransform, endValue:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, duration:  2f, snapping:  false), ease:  6);
            DG.Tweening.Tweener val_19 = DG.Tweening.ShortcutExtensions.DORotateQuaternion(target:  (GameFlow.<>c__DisplayClass61_1)[1152921507129170064].cameraTransform, endValue:  new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w}, duration:  2f);
            UnityEngine.Coroutine val_22 = this.StartCoroutine(routine:  this.Countdown(OnCompleted:  new System.Action(object:  new GameFlow.<>c__DisplayClass61_1(), method:  System.Void GameFlow.<>c__DisplayClass61_1::<OnGameStart>b__2())));
            return;
        }
        
        this.playView.SetMinCaught(count:  6);
        if(this.characterManager == null)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        UnityEngine.Transform val_24 = this.gameCamera.transform;
        UnityEngine.Quaternion val_25 = UnityEngine.Quaternion.Euler(x:  this.cameraPlayAngle, y:  0f, z:  0f);
        UnityEngine.Vector3 val_26 = UnityEngine.Vector3.forward;
        UnityEngine.Vector3 val_27 = UnityEngine.Quaternion.op_Multiply(rotation:  new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w}, point:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
        UnityEngine.Vector3 val_28 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z}, d:  this.cameraPlayDistance);
        CameraFollowPlayer val_30 = val_24.GetComponent<CameraFollowPlayer>();
        .cameraFollowPlayer = val_30;
        val_30.SetTarget(target:  this.characterManager.seekerPrefabs.transform, offset:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        UnityEngine.Vector3 val_33 = this.characterManager.seekerPrefabs.transform.position;
        UnityEngine.Vector3 val_34 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_29.x, y = val_29.y, z = val_29.z});
        DG.Tweening.Tweener val_36 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  val_24, endValue:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, duration:  0.75f, snapping:  false), ease:  6);
        DG.Tweening.Tweener val_39 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DORotateQuaternion(target:  val_24, endValue:  new UnityEngine.Quaternion() {x = val_25.x, y = val_25.y, z = val_25.z, w = val_25.w}, duration:  0.75f), action:  new DG.Tweening.TweenCallback(object:  new GameFlow.<>c__DisplayClass61_0(), method:  System.Void GameFlow.<>c__DisplayClass61_0::<OnGameStart>b__0()));
        UnityEngine.Coroutine val_42 = this.StartCoroutine(routine:  this.Countdown(OnCompleted:  new System.Action(object:  this, method:  System.Void GameFlow::<OnGameStart>b__61_1())));
        this.tutorialView.Open();
    }
    public void OnGameEnd()
    {
        this.isPlaying = false;
        this.gameCamera.GetComponent<CameraFollowPlayer>().enabled = false;
    }
    private System.Collections.IEnumerator Countdown(System.Action OnCompleted)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .OnCompleted = OnCompleted;
        return (System.Collections.IEnumerator)new GameFlow.<Countdown>d__63();
    }
    private System.Collections.IEnumerator StartCharacterDelay(float delay)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .delay = delay;
        return (System.Collections.IEnumerator)new GameFlow.<StartCharacterDelay>d__64();
    }
    private void Update()
    {
        if(this.isPlaying != false)
        {
                if(this.gameEnd == false)
        {
            goto label_2;
        }
        
        }
        
        label_13:
        if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
        {
                return;
        }
        
        var val_6 = public static CharacterManager SingletonMonoBehaviour<CharacterManager>::get_Instance();
        CharacterManager val_3 = SingletonMonoBehaviour<CharacterManager>.Instance;
        int val_4 = UnityEngine.Random.Range(min:  0, max:  5);
        if(val_6 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_6 = val_6 + (val_4 << 3);
        SingletonMonoBehaviour<CharacterManager>.Instance.ReplaceHider(index:  0, newHiderPrefab:  (public static CharacterManager SingletonMonoBehaviour<CharacterManager>::get_Instance() + (val_4) << 3) + 32);
        return;
        label_2:
        if(this.isCountdownPlayingTime == false)
        {
            goto label_13;
        }
        
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = this.time - val_5;
        this.time = val_5;
        if(val_5 >= 0)
        {
            goto label_9;
        }
        
        this.isPlaying = false;
        this.playView.SetTime(time:  0f);
        this.OnTimeOut();
        goto label_13;
        label_9:
        this.playView.SetTime(time:  val_5);
        goto label_13;
    }
    public void OnTimeOut()
    {
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        UserData val_11;
        int val_12;
        GameMode val_13;
        string val_14;
        var val_15;
        UserData val_16;
        var val_17;
        if(this.gameEnd != false)
        {
                return;
        }
        
        this.gameEnd = true;
        if(this.mode == 0)
        {
            goto label_2;
        }
        
        if(this.caughtHiderCount >= this.minCaughtHiderCount)
        {
            goto label_3;
        }
        
        this.audioSourceLose.Play();
        if(this.loseThisLevelTimeCount < 1)
        {
            goto label_5;
        }
        
        val_7 = null;
        val_7 = null;
        var val_1 = (UserData.current.level == 1) ? 1 : 0;
        if(this.loseView != null)
        {
            goto label_9;
        }
        
        label_2:
        this.audioSourceWin.Play();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.OpenWinViewDelay(delay:  3f));
        var val_7 = 4;
        label_26:
        val_9 = val_7 - 4;
        if(val_9 >= this.characterManager)
        {
            goto label_14;
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager.seekerPrefabs != 2)
        {
                if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.characterManager.seekerPrefabs.ToWinState();
        }
        
        val_7 = val_7 + 1;
        if(this.characterManager != null)
        {
            goto label_26;
        }
        
        label_14:
        this.playView.OnGameEnd();
        this.characterManager.seeker.StopGame();
        this.characterManager.seeker.ToLoseState();
        goto label_33;
        label_3:
        this.characterManager.seeker.StopGame();
        this.characterManager.seeker.ToWinState();
        var val_8 = 4;
        label_52:
        val_9 = val_8 - 4;
        if(val_9 >= this.characterManager)
        {
            goto label_40;
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager.seekerPrefabs != 2)
        {
                if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.characterManager.seekerPrefabs.ToIdleState();
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_8 = val_8 + 1;
        if(this.characterManager != null)
        {
            goto label_52;
        }
        
        label_40:
        this.playView.OnGameEnd();
        this.audioSourceWin.Play();
        UnityEngine.Coroutine val_5 = this.characterManager.StartCoroutine(routine:  this.OpenWinViewDelay(delay:  3f));
        label_33:
        val_10 = null;
        val_10 = null;
        val_11 = UserData.current;
        if(UserData.current.dayActive != 1)
        {
            goto label_90;
        }
        
        val_11 = UserData.current;
        val_12 = mem[UserData.current + 40];
        val_12 = UserData.current.level;
        val_13 = this.mode;
        val_14 = "win";
        goto label_63;
        label_5:
        val_8 = 0;
        label_9:
        this.loseView.SetMode(gameMode:  1, canNext:  false);
        this.loseView.Open();
        var val_9 = 4;
        label_80:
        val_9 = val_9 - 4;
        if(val_9 >= this.characterManager)
        {
            goto label_68;
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager.seekerPrefabs != 2)
        {
                if(this.characterManager <= val_9)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.characterManager.seekerPrefabs.ToWinState();
        }
        
        val_9 = val_9 + 1;
        if(this.characterManager != null)
        {
            goto label_80;
        }
        
        label_68:
        this.playView.OnGameEnd();
        this.characterManager.seeker.StopGame();
        this.characterManager.seeker.ToLoseState();
        val_15 = null;
        val_15 = null;
        val_16 = UserData.current;
        if(UserData.current.dayActive != 1)
        {
            goto label_90;
        }
        
        val_16 = UserData.current;
        val_12 = mem[UserData.current + 40];
        val_12 = UserData.current.level;
        val_13 = this.mode;
        val_14 = "lose";
        label_63:
        AppEventTracker.PushEvent_LevelDay0_Start(level:  val_12, result:  val_14, mode:  (val_13 == 0) ? "hide" : "seek");
        label_90:
        val_17 = null;
        val_17 = null;
        AppEventTracker.PushEvent_Level(level:  UserData.current.level, start:  false, isReplay:  this.isReplay);
    }
    public void OnAllHidersCaught()
    {
        var val_4;
        UserData val_5;
        this.characterManager.seeker.StopGame();
        this.characterManager.seeker.ToWinState();
        if(this.gameEnd != false)
        {
                return;
        }
        
        this.gameEnd = true;
        var val_4 = 0;
        label_11:
        if(val_4 >= this.characterManager)
        {
            goto label_8;
        }
        
        if(this.characterManager <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_4 = val_4 + 1;
        if(this.characterManager != null)
        {
            goto label_11;
        }
        
        label_8:
        this.playView.OnGameEnd();
        this.audioSourceWin.Play();
        UnityEngine.Coroutine val_2 = this.characterManager.StartCoroutine(routine:  this.OpenWinViewDelay(delay:  3f));
        val_4 = null;
        val_4 = null;
        val_5 = UserData.current;
        if(UserData.current.dayActive == 1)
        {
                val_5 = UserData.current;
            AppEventTracker.PushEvent_LevelDay0_Start(level:  UserData.current.level, result:  "win", mode:  (this.mode == 0) ? "hide" : "seek");
            val_4 = null;
        }
        
        val_4 = null;
        AppEventTracker.PushEvent_Level(level:  UserData.current.level, start:  false, isReplay:  this.isReplay);
    }
    public void OnHiderPlayerCaught()
    {
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        UserData val_7;
        if(this.gameEnd != false)
        {
                return;
        }
        
        this.gameEnd = true;
        var val_3 = 4;
        label_12:
        val_3 = val_3 - 4;
        if(val_3 >= this.characterManager)
        {
            goto label_4;
        }
        
        if(this.characterManager <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if(this.characterManager.seekerPrefabs != null)
        {
                if(this.characterManager <= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            mem2[0] = 0;
        }
        
        val_3 = val_3 + 1;
        if(this.characterManager != null)
        {
            goto label_12;
        }
        
        label_4:
        this.playView.OnGameEnd();
        this.audioSourceLose.Play();
        if(this.loseThisLevelTimeCount < 1)
        {
            goto label_16;
        }
        
        val_3 = 1152921504768454656;
        val_4 = null;
        val_4 = null;
        var val_1 = (UserData.current.level == 1) ? 1 : 0;
        if(this.loseView != null)
        {
            goto label_20;
        }
        
        label_16:
        val_5 = 0;
        label_20:
        this.loseView.SetMode(gameMode:  0, canNext:  false);
        this.loseView.Open();
        val_6 = null;
        val_6 = null;
        val_7 = UserData.current;
        if(UserData.current.dayActive == 1)
        {
                val_7 = UserData.current;
            AppEventTracker.PushEvent_LevelDay0_Start(level:  UserData.current.level, result:  "lose", mode:  (this.mode == 0) ? "hide" : "seek");
            val_6 = null;
        }
        
        val_6 = null;
        AppEventTracker.PushEvent_Level(level:  UserData.current.level, start:  false, isReplay:  this.isReplay);
    }
    private System.Collections.IEnumerator OpenWinViewDelay(float delay)
    {
        .<>1__state = 0;
        .<>4__this = this;
        .delay = delay;
        return (System.Collections.IEnumerator)new GameFlow.<OpenWinViewDelay>d__69();
    }
    private void OnReplayLevelWithBooster()
    {
        this.OnGameEnd();
        this.ClearLevel();
        this.LoadLevel();
        this.OnGameStart();
    }
    private void OnReplay()
    {
        var val_5;
        var val_6;
        var val_7;
        System.Action val_9;
        System.Action val_11;
        this.OnGameEnd();
        val_5 = null;
        val_5 = null;
        val_6 = null;
        val_6 = null;
        if(UserData.current.level < RemoteConfigControl.interstitialAds_MinLevel)
        {
                this.isReplay = true;
            this.ClearLevel();
            this.LoadLevel();
            return;
        }
        
        val_7 = null;
        val_7 = null;
        val_9 = GameFlow.<>c.<>9__71_1;
        if(val_9 == null)
        {
                System.Action val_3 = null;
            val_9 = val_3;
            val_3 = new System.Action(object:  GameFlow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameFlow.<>c::<OnReplay>b__71_1());
            val_7 = null;
            GameFlow.<>c.<>9__71_1 = val_9;
        }
        
        val_7 = null;
        val_11 = GameFlow.<>c.<>9__71_2;
        if(val_11 == null)
        {
                System.Action val_4 = null;
            val_11 = val_4;
            val_4 = new System.Action(object:  GameFlow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameFlow.<>c::<OnReplay>b__71_2());
            GameFlow.<>c.<>9__71_2 = val_11;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowInterstitialAd(ClosedEvent:  new System.Action(object:  this, method:  System.Void GameFlow::<OnReplay>b__71_0()), SucceededEvent:  val_3, FailedEvent:  val_4);
    }
    private void OnNext()
    {
        object val_9;
        var val_10;
        System.Action val_11;
        var val_12;
        var val_13;
        var val_14;
        System.Action val_17;
        var val_18;
        val_9 = this;
        this.OnGameEnd();
        val_10 = null;
        val_10 = null;
        int val_9 = UserData.current.level;
        val_9 = val_9 + 1;
        UserData.current.level = val_9;
        if(IsLevelRate() != false)
        {
                this.rateView.Open();
            System.Action val_2 = null;
            val_11 = val_2;
            val_2 = new System.Action(object:  this, method:  System.Void GameFlow::<OnNext>b__72_0());
            this.rateView.CloseAction = val_11;
        }
        else
        {
                val_12 = null;
            val_12 = null;
            val_11 = mem[UserData.current + 40];
            val_11 = UserData.current.level;
            val_13 = null;
            val_13 = null;
            if((val_11 - 1) < RemoteConfigControl.interstitialAds_MinLevel)
        {
                this.isReplay = false;
            this.ClearLevel();
            this.LoadLevel();
        }
        else
        {
                val_11 = SingletonMonoBehaviour<AdManager>.Instance;
            val_14 = null;
            val_14 = null;
            val_9 = GameFlow.<>c.<>9__72_2;
            if(val_9 == null)
        {
                System.Action val_6 = null;
            val_9 = val_6;
            val_6 = new System.Action(object:  GameFlow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameFlow.<>c::<OnNext>b__72_2());
            val_14 = null;
            GameFlow.<>c.<>9__72_2 = val_9;
        }
        
            val_14 = null;
            val_17 = GameFlow.<>c.<>9__72_3;
            if(val_17 == null)
        {
                System.Action val_7 = null;
            val_17 = val_7;
            val_7 = new System.Action(object:  GameFlow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameFlow.<>c::<OnNext>b__72_3());
            GameFlow.<>c.<>9__72_3 = val_17;
        }
        
            val_11.ShowInterstitialAd(ClosedEvent:  new System.Action(object:  this, method:  System.Void GameFlow::<OnNext>b__72_1()), SucceededEvent:  val_6, FailedEvent:  val_7);
        }
        
        }
        
        val_18 = null;
        val_18 = null;
        SetAdjustEvent(level:  UserData.current.level - 1);
    }
    private void OnSkip()
    {
        var val_2;
        this.OnGameEnd();
        val_2 = null;
        val_2 = null;
        int val_2 = UserData.current.level;
        val_2 = val_2 + 1;
        UserData.current.level = val_2;
        this.isReplay = false;
        this.ClearLevel();
        this.LoadLevel();
        AppEventTracker.SetUserPropertyLevel(value:  UserData.current.level);
        UserData.current.level.SetAdjustEvent(level:  UserData.current.level - 1);
    }
    public void OnPlayModeHide()
    {
        this.mode = 0;
        this.OnGameStart();
    }
    public void OnPlayModeSeek()
    {
        this.mode = 1;
        this.OnGameStart();
    }
    public void OnPlayWithBooster(int type)
    {
        var val_5;
        System.Action val_7;
        .type = type;
        .<>4__this = this;
        val_5 = null;
        val_5 = null;
        val_7 = GameFlow.<>c.<>9__76_1;
        if(val_7 == null)
        {
                System.Action val_4 = null;
            val_7 = val_4;
            val_4 = new System.Action(object:  GameFlow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameFlow.<>c::<OnPlayWithBooster>b__76_1());
            GameFlow.<>c.<>9__76_1 = val_7;
        }
        
        SingletonMonoBehaviour<AdManager>.Instance.ShowRewardedAd(succeededEvent:  new System.Action(object:  new GameFlow.<>c__DisplayClass76_0(), method:  System.Void GameFlow.<>c__DisplayClass76_0::<OnPlayWithBooster>b__0()), failedEvent:  val_4);
    }
    private bool IsLevelRate()
    {
        var val_1;
        var val_2;
        val_1 = null;
        val_1 = null;
        if(UserData.current.rated != false)
        {
                return false;
        }
        
        val_2 = null;
        val_2 = null;
        val_1 = null;
        val_1 = null;
        return RemoteConfigControl.rateLevels.Contains(item:  UserData.current.level);
    }
    private void SetAdjustEvent(int level)
    {
        int val_4 = level;
        int val_1 = val_4 - 2;
        if(val_1 > 18)
        {
                return;
        }
        
        if(((271659 >> val_1) & 1) == 0)
        {
                return;
        }
        
        val_4 = mem[14764608 + ((level - 2)) << 3];
        val_4 = 14764608 + ((level - 2)) << 3;
        if(val_4 == 0)
        {
                return;
        }
        
        com.adjust.sdk.Adjust.trackEvent(adjustEvent:  new com.adjust.sdk.AdjustEvent(eventToken:  val_4));
    }
    public GameFlow()
    {
        this.cameraStartDistancceSeek = 7f;
        this.rewardPerRescue = 5;
        this.rewardPerCatch = 0;
        this.levelExist = true;
        this.cameraStartDistance = ;
        this.cameraStartAngle = ;
        this.cameraPlayDistance = 20f;
        this.cameraPlayAngle = 70f;
        this.isFirstLoaded = true;
    }
    private void <LoadLevel>b__50_3()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.levelInstancePrevious)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.levelInstancePrevious.gameObject);
        }
        
        int val_8 = this.loadNewMapTimeCount;
        this.levelInstancePrevious = 0;
        if(val_8 == 1)
        {
                return;
        }
        
        int val_3 = val_8 * 1431655766;
        int val_4 = val_3 >> 63;
        val_3 = val_3 >> 32;
        val_3 = val_3 + val_4;
        val_4 = val_3 + (val_3 << 1);
        val_8 = val_8 - val_4;
        if(val_8 != 1)
        {
                return;
        }
        
        val_3 = val_3 - 1;
        val_3 = val_3 - ((val_3 / this.envBlocks.Length) * this.envBlocks.Length);
        this = this.envBlocks[val_3];
        UnityEngine.Vector3 val_6 = this.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    private void <SetupAdManagerForIOS>b__53_0()
    {
        bool val_1 = this.audioMixer.SetFloat(name:  "EffectVolume", value:  -80f);
        bool val_2 = this.audioMixer.SetFloat(name:  "MusicVolume", value:  -80f);
    }
    private void <SetupAdManagerForIOS>b__53_1()
    {
        bool val_1 = this.audioMixer.SetFloat(name:  "EffectVolume", value:  0f);
        bool val_2 = this.audioMixer.SetFloat(name:  "MusicVolume", value:  0f);
    }
    private void <Start>b__54_0()
    {
        this.useSpeedBoost = true;
        this.OnReplayLevelWithBooster();
    }
    private void <Start>b__54_1()
    {
        this.useInvisibility = true;
        this.OnReplayLevelWithBooster();
    }
    private void <Start>b__54_2()
    {
        this.useIgnoreWall = true;
        this.OnReplayLevelWithBooster();
    }
    private void <Start>b__54_3()
    {
        null = null;
        Hider val_1 = this.characterManager.GetHiderPrefab(id:  UserData.current.currentHiderId);
        this.characterManager.ReplaceHider(index:  0, newHiderPrefab:  val_1);
        this.characterManager.ReplaceHider(index:  1, newHiderPrefab:  val_1);
        this.characterManager.ReplaceHider(index:  2, newHiderPrefab:  val_1);
        this.characterManager.ReplaceHider(index:  3, newHiderPrefab:  val_1);
        this.characterManager.ReplaceHider(index:  4, newHiderPrefab:  val_1);
        this.characterManager.ReplaceHider(index:  5, newHiderPrefab:  val_1);
    }
    private void <Start>b__54_4()
    {
        null = null;
        this.characterManager.ReplaceSeeker(newSeekerPrefab:  this.characterManager.GetSeekerPrefab(id:  UserData.current.currentSeekerId));
    }
    private void <OnGameStart>b__61_1()
    {
        this.isCountdownPlayingTime = true;
        this.characterManager.seeker.StartGame();
        this.radarForward.SetTarget(target:  this.characterManager.seeker.transform);
        this.radarForward.gameObject.SetActive(value:  true);
    }
    private void <OnReplay>b__71_0()
    {
        this.isReplay = true;
        this.ClearLevel();
        this.LoadLevel();
    }
    private void <OnNext>b__72_0()
    {
        var val_1;
        this.isReplay = false;
        this.ClearLevel();
        this.LoadLevel();
        val_1 = null;
        val_1 = null;
        AppEventTracker.SetUserPropertyLevel(value:  UserData.current.level);
    }
    private void <OnNext>b__72_1()
    {
        var val_1;
        this.isReplay = false;
        this.ClearLevel();
        this.LoadLevel();
        val_1 = null;
        val_1 = null;
        AppEventTracker.SetUserPropertyLevel(value:  UserData.current.level);
    }

}
