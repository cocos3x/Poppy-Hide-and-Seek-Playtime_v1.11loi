using UnityEngine;
public class Hider : Character
{
    // Fields
    public string id;
    public float rescueDistance;
    public bool canRescueOthers;
    public bool canBeRescued;
    public bool canBeCaught;
    public CageEffect cageEffect;
    public MovingEffect movingEffect;
    public UnityEngine.ParticleSystem particleRewardRescue;
    public UnityEngine.Animator animator;
    public UnityEngine.Collider mainCollider;
    public UnityEngine.SkinnedMeshRenderer[] skinnedMeshRenderers;
    public System.Action<Hider> OnGetCaught;
    public System.Action<Hider, Hider> OnGetReleased;
    public System.Action OnStartGame;
    public System.Action OnStopGame;
    private int layerInvisible;
    private int layerDefault;
    public bool isOnLand;
    private int layerMaskGround;
    private int fixedUpdateFrameCount;
    private int waterLayer;
    public Hider.State state;
    protected Seeker seeker;
    protected System.Collections.Generic.List<Hider> hiders;
    public UnityEngine.GameObject[] seekerInvisibleObjects;
    private UnityEngine.Transform cachedTransform;
    
    // Methods
    private void Awake()
    {
        int val_7;
        this.cachedTransform = this.transform;
        this.waterLayer = UnityEngine.LayerMask.NameToLayer(layerName:  "Water");
        string[] val_3 = new string[3];
        val_7 = val_3.Length;
        val_3[0] = "Floor";
        val_7 = val_3.Length;
        val_3[1] = "Water";
        val_7 = val_3.Length;
        val_3[2] = "Wall";
        this.layerMaskGround = UnityEngine.LayerMask.GetMask(layerNames:  val_3);
        this.layerInvisible = UnityEngine.LayerMask.NameToLayer(layerName:  "Invisible");
        this.layerDefault = UnityEngine.LayerMask.NameToLayer(layerName:  "Default");
    }
    public void SetLayerAsPlayer()
    {
        this.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "Player");
        this.mainCollider.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "PlayerTrigger");
    }
    public void SetLayerAsAI()
    {
        this.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "AI");
        this.mainCollider.gameObject.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "AITrigger");
    }
    public virtual void StartGame()
    {
        mem[1152921507140188665] = 1;
        CharacterManager val_1 = SingletonMonoBehaviour<CharacterManager>.Instance;
        this.seeker = val_1.seeker;
        CharacterManager val_2 = SingletonMonoBehaviour<CharacterManager>.Instance;
        this.hiders = val_2.hiders;
        if(this.OnStartGame == null)
        {
                return;
        }
        
        this.OnStartGame.Invoke();
    }
    public virtual void StopGame()
    {
        mem[1152921507140325241] = 0;
        if(this.OnStopGame == null)
        {
                return;
        }
        
        this.OnStopGame.Invoke();
    }
    private void Update()
    {
        if(W8 == 0)
        {
                return;
        }
        
        if(this.state == 2)
        {
                return;
        }
        
        if(this.canRescueOthers == false)
        {
                return;
        }
        
        this.CheckRescueHiders();
    }
    private void FixedUpdate()
    {
        var val_9;
        if(this.fixedUpdateFrameCount != 3)
        {
            goto label_11;
        }
        
        UnityEngine.Vector3 val_2 = this.transform.localPosition;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, direction:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1.5f, layerMask:  this.layerMaskGround)) == false)
        {
            goto label_11;
        }
        
        if(0.gameObject.layer != this.waterLayer)
        {
            goto label_8;
        }
        
        if(this.isOnLand == false)
        {
            goto label_11;
        }
        
        val_9 = 0;
        goto label_10;
        label_8:
        if(this.isOnLand == true)
        {
            goto label_11;
        }
        
        val_9 = 1;
        label_10:
        this.SetOnLand(flag:  true);
        label_11:
        int val_9 = this.fixedUpdateFrameCount;
        val_9 = val_9 + 1;
        this.fixedUpdateFrameCount = val_9;
    }
    public void SetOnLand(bool flag)
    {
        bool val_1 = flag;
        this.isOnLand = val_1;
        this.animator.SetBool(name:  "ground", value:  val_1);
    }
    public void ToIdleState()
    {
        this.state = 0;
        this.animator.SetBool(name:  "move", value:  false);
    }
    public void ToMoveState()
    {
        this.state = 1;
        this.animator.SetBool(name:  "move", value:  true);
        this.movingEffect.OnStartMove(onLand:  this.isOnLand);
    }
    public void ToWinState()
    {
        this.state = 3;
        this.animator.SetBool(name:  "win", value:  true);
    }
    public virtual void GetCaught()
    {
        this.state = 2;
        this.animator.CrossFade(stateName:  "Caught", normalizedTransitionDuration:  0.25f);
        this.cageEffect.Play();
        if(this.OnGetCaught == null)
        {
                return;
        }
        
        this.OnGetCaught.Invoke(obj:  this);
    }
    public virtual void GetReleased(Hider subject)
    {
        this.state = 0;
        this.animator.CrossFade(stateName:  "Idle", normalizedTransitionDuration:  0.25f);
        this.cageEffect.Stop();
        if(this.OnGetReleased == null)
        {
                return;
        }
        
        this.OnGetReleased.Invoke(arg1:  subject, arg2:  this);
    }
    public void CheckRescueHiders()
    {
        var val_7 = 4;
        do
        {
            var val_1 = val_7 - 4;
            if(val_1 >= true)
        {
                return;
        }
        
            if(true <= val_1)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((((mem[-3458764513820540760]) == 2) && ((mem[-3458764513820540867]) != false)) && (0 != this))
        {
                UnityEngine.Vector3 val_4 = this.transform.localPosition;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            UnityEngine.Vector3 val_6 = UnityEngine.Object.__il2cppRuntimeField_cctor_finished + 32.transform.localPosition;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) < 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
            this.particleRewardRescue.Play();
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(this.hiders != null);
        
        throw new NullReferenceException();
    }
    public void SetVisibleToSeeker(bool flag)
    {
        var val_1 = (flag != true) ? 148 : 144;
        var val_3 = 0;
        do
        {
            if(val_3 >= this.seekerInvisibleObjects.Length)
        {
                return;
        }
        
            this.seekerInvisibleObjects[val_3].layer = 158412800;
            val_3 = val_3 + 1;
        }
        while(this.seekerInvisibleObjects != null);
        
        throw new NullReferenceException();
    }
    public void SetAnimationSpeed(float speed)
    {
        if(this.animator != null)
        {
                this.animator.speed = speed;
            return;
        }
        
        throw new NullReferenceException();
    }
    public Hider()
    {
        this.rescueDistance = 0.3f;
        this.canRescueOthers = true;
        this.canBeRescued = true;
        this.canBeCaught = true;
    }

}
