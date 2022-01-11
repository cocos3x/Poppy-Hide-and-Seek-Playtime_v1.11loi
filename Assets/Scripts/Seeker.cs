using UnityEngine;
public class Seeker : Character
{
    // Fields
    public string id;
    public float hearDistance;
    public float catchDistance;
    public UnityEngine.Animator animator;
    public UnityEngine.SkinnedMeshRenderer skinnedMeshRenderer;
    public UnityEngine.Collider mainCollider;
    public UnityEngine.ParticleSystem particleRewardCatch;
    private float catchDistanceSqr;
    public Seeker.State state;
    public System.Collections.Generic.List<Hider> hiders;
    private static int wallBitmask;
    public System.Action OnStartGame;
    public System.Action OnStopGame;
    private UnityEngine.Transform cachedTransform;
    public bool isOnLand;
    private int layerMaskGround;
    private int fixedUpdateFrameCount;
    private int waterLayer;
    
    // Methods
    private void Awake()
    {
        int val_5;
        this.cachedTransform = this.transform;
        this.waterLayer = UnityEngine.LayerMask.NameToLayer(layerName:  "Water");
        string[] val_3 = new string[3];
        val_5 = val_3.Length;
        val_3[0] = "Floor";
        val_5 = val_3.Length;
        val_3[1] = "Water";
        val_5 = val_3.Length;
        val_3[2] = "Wall";
        this.layerMaskGround = UnityEngine.LayerMask.GetMask(layerNames:  val_3);
    }
    private void FixedUpdate()
    {
        string val_8;
        var val_9;
        if(this.fixedUpdateFrameCount != 3)
        {
            goto label_12;
        }
        
        UnityEngine.Vector3 val_1 = this.cachedTransform.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  1.5f, layerMask:  this.layerMaskGround)) == false)
        {
            goto label_12;
        }
        
        if(0.gameObject.layer != this.waterLayer)
        {
            goto label_8;
        }
        
        if(this.isOnLand == false)
        {
            goto label_12;
        }
        
        this.isOnLand = false;
        val_8 = "ground";
        val_9 = 0;
        goto label_11;
        label_8:
        if(this.isOnLand == true)
        {
            goto label_12;
        }
        
        this.isOnLand = true;
        val_8 = "ground";
        val_9 = 1;
        label_11:
        this.animator.SetBool(name:  val_8, value:  true);
        label_12:
        int val_8 = this.fixedUpdateFrameCount;
        val_8 = val_8 + 1;
        this.fixedUpdateFrameCount = val_8;
    }
    public void SetOnLand(bool flag)
    {
        bool val_1 = flag;
        this.isOnLand = val_1;
        this.animator.SetBool(name:  "ground", value:  val_1);
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
    public void CheckCatchHiders()
    {
        System.Collections.Generic.List<Hider> val_2;
        bool val_3 = true;
        val_2 = this.hiders;
        var val_4 = 4;
        do
        {
            var val_1 = val_4 - 4;
            if(val_1 >= val_3)
        {
                return;
        }
        
            val_3 = val_3 & 4294967295;
            if(val_1 >= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            if((this.CanCatch(hider:  (true & 4294967295) + 32)) != false)
        {
                if(val_1 >= val_3)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        }
        
            val_2 = this.hiders;
            val_4 = val_4 + 1;
        }
        while(val_2 != null);
        
        throw new NullReferenceException();
    }
    public bool CanHear(Hider hider)
    {
        var val_6;
        UnityEngine.Vector3 val_2 = hider.transform.localPosition;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        if(((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) < 0) && (hider.state == 1))
        {
                val_6 = 1;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    public bool CanCatch(Hider hider)
    {
        float val_13;
        float val_14;
        float val_15;
        var val_16;
        UnityEngine.Vector3 val_2 = hider.transform.localPosition;
        val_13 = val_2.x;
        val_14 = val_2.z;
        UnityEngine.Vector3 val_4 = this.transform.localPosition;
        val_15 = val_4.y;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13, y = val_2.y, z = val_14}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_15, z = val_4.z});
        if((hider.canBeCaught == false) || (hider.state == 2))
        {
            goto label_15;
        }
        
        val_13 = val_5.x;
        if(val_13 >= 0)
        {
            goto label_15;
        }
        
        val_14 = val_5.y;
        UnityEngine.Vector3 val_7 = this.transform.forward;
        val_15 = val_7.x;
        if((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = this.catchDistanceSqr, y = val_14, z = val_5.z}, rhs:  new UnityEngine.Vector3() {x = val_15, y = val_7.y, z = val_7.z})) <= 0.7f)
        {
            goto label_15;
        }
        
        UnityEngine.Vector3 val_10 = this.transform.localPosition;
        val_14 = val_10.y;
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_10.x, y = val_14, z = val_10.z}, direction:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  this.catchDistance, layerMask:  Seeker.wallBitmask)) == false)
        {
            goto label_14;
        }
        
        float val_12 = 0.yAdvance;
        val_12 = val_12 * val_12;
        if(val_13 >= 0)
        {
            goto label_15;
        }
        
        label_14:
        this.particleRewardCatch.Play();
        val_16 = 1;
        return (bool)val_16;
        label_15:
        val_16 = 0;
        return (bool)val_16;
    }
    public void StartGame()
    {
        int val_4;
        float val_4 = this.catchDistance;
        mem[1152921507158271129] = 1;
        val_4 = val_4 * val_4;
        this.catchDistanceSqr = val_4;
        CharacterManager val_1 = SingletonMonoBehaviour<CharacterManager>.Instance;
        this.hiders = val_1.hiders;
        string[] val_2 = new string[2];
        val_4 = val_2.Length;
        val_2[0] = "Wall";
        val_4 = val_2.Length;
        val_2[1] = "Door";
        Seeker.wallBitmask = UnityEngine.LayerMask.GetMask(layerNames:  val_2);
        if(this.OnStartGame == null)
        {
                return;
        }
        
        this.OnStartGame.Invoke();
    }
    public void StopGame()
    {
        mem[1152921507158403625] = 0;
        if(this.OnStopGame == null)
        {
                return;
        }
        
        this.OnStopGame.Invoke();
    }
    public void ToLookState()
    {
        this.state = 2;
        this.animator.SetBool(name:  "move", value:  false);
    }
    public void ToSeekState()
    {
        this.state = 1;
        this.animator.SetBool(name:  "move", value:  true);
    }
    public void ToHearState()
    {
        this.state = 3;
        this.animator.SetBool(name:  "move", value:  false);
    }
    public void ToWinState()
    {
        this.state = 4;
        this.animator.SetBool(name:  "win", value:  true);
    }
    public void ToLoseState()
    {
        this.state = 5;
        this.animator.SetBool(name:  "sad", value:  true);
    }
    public void ToStartState()
    {
        this.state = 0;
        this.animator.SetBool(name:  "move", value:  false);
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
    public Seeker()
    {
        this.hearDistance = 5f;
        this.catchDistance = 2f;
    }

}
