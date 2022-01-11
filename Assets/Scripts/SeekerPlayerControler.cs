using UnityEngine;
public class SeekerPlayerControler : MonoBehaviour
{
    // Fields
    public Seeker seeker;
    public UnityEngine.CharacterController characterController;
    public TPSShooter.Joystick joystick;
    public float speedMultiplier;
    private UnityEngine.Vector3 moveDirection;
    private float moveSpeed;
    private bool isMoving;
    private bool isPlaying;
    private System.Collections.Generic.List<Hider> hiders;
    
    // Methods
    public void Setup(Seeker seeker, UnityEngine.CharacterController cc)
    {
        this.seeker = seeker;
        this.characterController = cc;
        cc.center = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.characterController.radius = 0.4f;
        this.characterController.height = 0.8f;
        System.Delegate val_2 = System.Delegate.Combine(a:  seeker.OnStartGame, b:  new System.Action(object:  this, method:  public System.Void SeekerPlayerControler::OnStartGame()));
        if(val_2 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        seeker.OnStartGame = val_2;
        System.Delegate val_4 = System.Delegate.Combine(a:  seeker.OnStopGame, b:  new System.Action(object:  this, method:  public System.Void SeekerPlayerControler::OnStopGame()));
        if(val_4 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        seeker.OnStopGame = val_4;
        seeker.ToStartState();
        return;
        label_8:
    }
    private void Start()
    {
    
    }
    private void OnDestroy()
    {
        if((UnityEngine.Object.op_Implicit(exists:  this.seeker)) == false)
        {
                return;
        }
        
        System.Delegate val_3 = System.Delegate.Remove(source:  this.seeker.OnStartGame, value:  new System.Action(object:  this, method:  public System.Void SeekerPlayerControler::OnStartGame()));
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_6;
        }
        
        }
        
        this.seeker.OnStartGame = val_3;
        return;
        label_6:
    }
    public void OnStartGame()
    {
        this.isPlaying = true;
        if(this.seeker != null)
        {
                this.hiders = this.seeker.hiders;
            return;
        }
        
        throw new NullReferenceException();
    }
    public void OnStopGame()
    {
        this.isPlaying = false;
    }
    public void Update()
    {
        bool val_19 = this.isPlaying;
        if(val_19 == false)
        {
                return;
        }
        
        var val_20 = 4;
        label_10:
        var val_1 = val_20 - 4;
        if(val_1 >= val_19)
        {
            goto label_3;
        }
        
        val_19 = val_19 & 4294967295;
        if(val_1 >= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        if((this.seeker.CanCatch(hider:  (this.isPlaying & 4294967295) + 32)) != false)
        {
                if(val_1 >= val_19)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        }
        
        val_20 = val_20 + 1;
        if(this.hiders != null)
        {
            goto label_10;
        }
        
        label_3:
        if(this.joystick.IsTouched != false)
        {
                float val_3 = this.joystick.Horizontal * this.joystick.Horizontal;
            val_3 = val_3 + (this.joystick.Vertical * this.joystick.Vertical);
            float val_5 = UnityEngine.Mathf.Min(a:  3.5f, b:  val_3);
            if(val_5 > 0.25f)
        {
                if(this.isMoving != true)
        {
                this.seeker.ToSeekState();
            this.isMoving = true;
        }
        
            float val_22 = UnityEngine.Time.deltaTime;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.up;
            float val_21 = -57.29578f;
            val_21 = this.joystick.Vertical * val_21;
            val_21 = val_21 + 90f;
            UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.AngleAxis(angle:  val_21, axis:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            UnityEngine.Quaternion val_11 = this.transform.localRotation;
            val_22 = val_22 * 20f;
            UnityEngine.Quaternion val_12 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w}, b:  new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w}, t:  val_22);
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w};
            float val_23 = this.speedMultiplier;
            val_23 = val_23 * 3.25f;
            val_23 = val_5 * val_23;
            this.moveSpeed = UnityEngine.Mathf.Lerp(a:  this.moveSpeed, b:  UnityEngine.Mathf.Min(a:  val_23, b:  10f), t:  val_22);
            UnityEngine.Vector3 val_16 = this.transform.forward;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  this.moveSpeed);
            this.moveDirection = val_17;
            mem[1152921507161838616] = val_17.y;
            mem[1152921507161838620] = val_17.z;
            bool val_18 = this.characterController.SimpleMove(speed:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z});
            return;
        }
        
        }
        
        if(this.isMoving != false)
        {
                this.seeker.ToLookState();
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
        this.seeker.animator.speed = value;
    }
    public SeekerPlayerControler()
    {
        this.speedMultiplier = 1f;
    }

}
