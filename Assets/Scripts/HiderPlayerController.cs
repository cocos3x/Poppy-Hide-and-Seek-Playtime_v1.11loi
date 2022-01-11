using UnityEngine;
public class HiderPlayerController : MonoBehaviour
{
    // Fields
    public Hider hider;
    public UnityEngine.CharacterController characterController;
    public TPSShooter.Joystick joystick;
    public float speedMultiplier;
    private UnityEngine.Vector3 moveDirection;
    private float moveSpeed;
    private bool isMoving;
    private bool isPlaying;
    
    // Methods
    public void SetUp(Hider hider, UnityEngine.CharacterController cc)
    {
        this.hider = hider;
        this.characterController = cc;
        cc.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.characterController.radius = 0.25f;
        this.characterController.height = 0.8f;
        cc.slopeLimit = 60f;
        System.Delegate val_2 = System.Delegate.Combine(a:  hider.OnStartGame, b:  new System.Action(object:  this, method:  public System.Void HiderPlayerController::OnStartGame()));
        if(val_2 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        hider.OnStartGame = val_2;
        System.Delegate val_4 = System.Delegate.Combine(a:  hider.OnStopGame, b:  new System.Action(object:  this, method:  public System.Void HiderPlayerController::OnStopGame()));
        if(val_4 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        hider.OnStopGame = val_4;
        hider.ToIdleState();
        return;
        label_8:
    }
    private void Start()
    {
    
    }
    private void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.hider)) == false)
        {
                return;
        }
        
        System.Delegate val_3 = System.Delegate.Remove(source:  this.hider.OnStartGame, value:  new System.Action(object:  this, method:  public System.Void HiderPlayerController::OnStartGame()));
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_9;
        }
        
        }
        
        this.hider.OnStartGame = val_3;
        System.Delegate val_5 = System.Delegate.Remove(source:  this.hider.OnStopGame, value:  new System.Action(object:  this, method:  public System.Void HiderPlayerController::OnStopGame()));
        if(val_5 != null)
        {
                if(null != null)
        {
            goto label_9;
        }
        
        }
        
        this.hider.OnStopGame = val_5;
        return;
        label_9:
    }
    public void OnStartGame()
    {
        this.isPlaying = true;
    }
    public void OnStopGame()
    {
        this.isPlaying = false;
    }
    public void Update()
    {
        float val_17;
        if(this.isPlaying == false)
        {
                return;
        }
        
        if((this.joystick.IsTouched != false) && (this.hider.state != 2))
        {
                val_17 = this.joystick.Horizontal;
            float val_1 = val_17 * val_17;
            val_1 = val_1 + (this.joystick.Vertical * this.joystick.Vertical);
            float val_3 = UnityEngine.Mathf.Min(a:  3.5f, b:  val_1);
            if(val_3 > 0.25f)
        {
                float val_18 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.up;
            float val_17 = -57.29578f;
            val_17 = this.joystick.Vertical * val_17;
            val_17 = val_17 + 90f;
            UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.AngleAxis(angle:  val_17, axis:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
            val_17 = val_6.x;
            UnityEngine.Quaternion val_9 = this.transform.localRotation;
            val_18 = val_18 * 20f;
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w}, b:  new UnityEngine.Quaternion() {x = val_17, y = val_6.y, z = val_6.z, w = val_6.w}, t:  val_18);
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w};
            float val_19 = this.speedMultiplier;
            val_19 = val_19 * 3.25f;
            val_19 = val_3 * val_19;
            this.moveSpeed = UnityEngine.Mathf.Lerp(a:  this.moveSpeed, b:  UnityEngine.Mathf.Min(a:  val_19, b:  8f), t:  val_18);
            UnityEngine.Vector3 val_14 = this.transform.forward;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.moveSpeed);
            this.moveDirection = val_15;
            mem[1152921507144601528] = val_15.y;
            mem[1152921507144601532] = val_15.z;
            bool val_16 = this.characterController.SimpleMove(speed:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            if(this.isMoving == true)
        {
                return;
        }
        
            this.hider.ToMoveState();
            this.isMoving = true;
            return;
        }
        
        }
        
        if(this.isMoving != false)
        {
                if(this.hider.state != 2)
        {
                this.hider.ToIdleState();
        }
        
            this.isMoving = false;
        }
        
        this.moveSpeed = 0f;
    }
    public void SetSpeedMultiplier(float value)
    {
        if(this.speedMultiplier == value)
        {
                return;
        }
        
        this.speedMultiplier = value;
        this.hider.animator.speed = value;
    }
    public HiderPlayerController()
    {
        this.speedMultiplier = 1f;
    }

}
