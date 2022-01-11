using UnityEngine;
public class SeekerAIController : MonoBehaviour
{
    // Fields
    public Seeker seeker;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    private float lookTime;
    private float lookRotateSpeed;
    private float hearTime;
    private float hearRotateSpeed;
    private UnityEngine.Vector3 hearPosition;
    private bool isSeekingHearTarget;
    private Hider hearTarget;
    public UnityEngine.Transform seekTarget;
    private int hidePositionIndex;
    private bool isPlaying;
    private System.Collections.Generic.List<Hider> hiders;
    
    // Methods
    public void Setup(Seeker seeker, UnityEngine.AI.NavMeshAgent agent)
    {
        this.seeker = seeker;
        this.navMeshAgent = agent;
        agent.radius = 0.1f;
        this.navMeshAgent.updateRotation = false;
        float val_1 = this.navMeshAgent.speed;
        val_1 = val_1 * 1.2f;
        this.navMeshAgent.speed = val_1;
        System.Delegate val_3 = System.Delegate.Combine(a:  seeker.OnStartGame, b:  new System.Action(object:  this, method:  public System.Void SeekerAIController::OnStartGame()));
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        seeker.OnStartGame = val_3;
        System.Delegate val_5 = System.Delegate.Combine(a:  seeker.OnStopGame, b:  new System.Action(object:  this, method:  public System.Void SeekerAIController::OnStopGame()));
        if(val_5 != null)
        {
                if(null != null)
        {
            goto label_8;
        }
        
        }
        
        seeker.OnStopGame = val_5;
        return;
        label_8:
    }
    private void Start()
    {
    
    }
    public void OnStartGame()
    {
        this.isPlaying = true;
        this.isSeekingHearTarget = false;
        if(this.seeker != null)
        {
                this.hiders = this.seeker.hiders;
            this.Seek();
            return;
        }
        
        throw new NullReferenceException();
    }
    public void OnStopGame()
    {
        this.isPlaying = false;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.navMeshAgent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.navMeshAgent.isStopped = true;
    }
    private void Update()
    {
        State val_28;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        if(this.isPlaying == false)
        {
                return;
        }
        
        val_28 = this.seeker.state;
        val_29 = UnityEngine.Time.deltaTime;
        if(val_28 != 1)
        {
            goto label_3;
        }
        
        if(this.IsNavMeshAgentReachDestination() == false)
        {
            goto label_4;
        }
        
        this.ToLookState();
        goto label_26;
        label_3:
        if(val_28 == 3)
        {
            goto label_6;
        }
        
        if(val_28 != 2)
        {
            goto label_26;
        }
        
        float val_28 = this.lookTime;
        val_28 = val_28 - val_29;
        this.lookTime = val_28;
        float val_4 = val_29 * this.lookRotateSpeed;
        val_30 = 0f;
        val_31 = 0f;
        this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = val_30, z = val_31}, relativeTo:  1);
        val_32 = this.lookTime;
        if(val_32 >= 0)
        {
            goto label_26;
        }
        
        this.isSeekingHearTarget = false;
        this.Seek();
        goto label_26;
        label_4:
        UnityEngine.Vector3 val_5 = this.navMeshAgent.velocity;
        val_33 = val_5.z;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_32 = val_5.x;
        val_30 = val_5.y;
        val_31 = val_33;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_32, y = val_30, z = val_31}, rhs:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z})) == false)
        {
            goto label_26;
        }
        
        float val_29 = val_33;
        val_29 = val_29 * (-57.29578f);
        val_32 = 0f;
        val_31 = 0f;
        val_30 = val_29 + 90f;
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.Euler(x:  val_32, y:  val_30, z:  val_31);
        val_33 = val_9.y;
        val_34 = val_9.w;
        UnityEngine.Quaternion val_12 = this.transform.localRotation;
        float val_30 = 25f;
        val_30 = val_29 * val_30;
        UnityEngine.Quaternion val_13 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, b:  new UnityEngine.Quaternion() {x = val_9.x, y = val_33, z = val_9.z, w = val_34}, t:  val_30);
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_13.x, y = val_13.y, z = val_13.z, w = val_13.w};
        goto label_26;
        label_6:
        float val_31 = this.hearTime;
        val_31 = val_31 - val_29;
        this.hearTime = val_31;
        if((this.seeker.CanHear(hider:  this.hearTarget)) != false)
        {
                UnityEngine.Vector3 val_16 = this.hearTarget.transform.localPosition;
            this.hearPosition = val_16;
            mem[1152921507160107548] = val_16.y;
            mem[1152921507160107552] = val_16.z;
        }
        
        float val_18 = val_29 * this.hearRotateSpeed;
        val_30 = 0f;
        val_31 = 0f;
        this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = 0f, y = val_30, z = val_31}, relativeTo:  1);
        val_32 = this.hearTime;
        if(val_32 < 0)
        {
                val_29 = this.hearPosition;
            this.isSeekingHearTarget = true;
            UnityEngine.Vector2 val_19 = UnityEngine.Random.insideUnitCircle;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = val_19.x, y = val_19.y});
            val_34 = val_20.y;
            val_32 = val_29;
            val_30 = V9.16B;
            val_31 = V10.16B;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_32, y = val_30, z = val_31}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_34, z = val_20.z});
            this.Seek(position:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        }
        
        label_26:
        var val_32 = 4;
        do
        {
            var val_22 = val_32 - 4;
            System.ThrowHelper.ThrowArgumentOutOfRangeException();
            if((this.seeker.CanCatch(hider:  (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished & 4294967295) + 32)) != false)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            val_32 = val_32 + 1;
        }
        while(this.hiders != null);
        
        if(val_28 == 3)
        {
                return;
        }
        
        if(val_28 == 1)
        {
                if(this.isSeekingHearTarget == true)
        {
                return;
        }
        
            return;
        }
        
        val_28 = 0;
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        if((this.seeker.CanHear(hider:  (UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 0) + 32)) != true)
        {
                val_28 = val_28 + 1;
            return;
        }
        
        System.ThrowHelper.ThrowArgumentOutOfRangeException();
        this.hearTarget = ((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 0) + 0) + 32;
        UnityEngine.Vector3 val_27 = ((UnityEngine.Vector3.__il2cppRuntimeField_cctor_finished + 0) + 0) + 32.transform.localPosition;
        this.hearPosition = val_27;
        mem[1152921507160107548] = val_27.y;
        mem[1152921507160107552] = val_27.z;
        this.ToHearState();
    }
    private bool IsNavMeshAgentReachDestination()
    {
        if(this.navMeshAgent.pathPending == true)
        {
                return false;
        }
        
        float val_3 = this.navMeshAgent.stoppingDistance;
        val_3 = val_3 + 0.01f;
        if(this.navMeshAgent.remainingDistance > val_3)
        {
                return false;
        }
        
        if(this.navMeshAgent.hasPath == false)
        {
                return false;
        }
        
        UnityEngine.Vector3 val_5 = this.navMeshAgent.velocity;
        if(val_5.x > 0.01f)
        {
                return false;
        }
        
        return false;
    }
    private void ToLookState()
    {
        this.seeker.ToLookState();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.navMeshAgent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.navMeshAgent.isStopped = true;
        this.lookTime = UnityEngine.Random.Range(min:  0.5f, max:  0.75f);
        var val_4 = ((UnityEngine.Random.Range(min:  0, max:  2)) == 0) ? 1 : 0;
        this.lookRotateSpeed = 11346896 + val_3 == 0 ? 1 : 0;
    }
    private void ToHearState()
    {
        this.seeker.ToHearState();
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.navMeshAgent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.navMeshAgent.isStopped = true;
        UnityEngine.Vector3 val_3 = this.transform.localPosition;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.hearPosition, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        float val_12 = val_4.x;
        float val_10 = -val_12;
        float val_11 = 57.29578f;
        float val_13 = 360f;
        val_10 = val_10 * val_11;
        val_11 = val_10 + val_13;
        val_12 = (val_10 < 0) ? (val_11) : (val_10);
        UnityEngine.Vector3 val_6 = this.transform.localEulerAngles;
        float val_7 = val_13 - val_6.y;
        val_6.y = val_7 + val_13;
        val_13 = (val_7 < 0) ? (val_6.y) : (val_7);
        float val_14 = 1f;
        float val_9 = UnityEngine.Random.Range(min:  0.7f, max:  val_14);
        val_14 = (UnityEngine.Mathf.DeltaAngle(current:  val_12, target:  val_13)) / val_9;
        this.hearTime = val_9;
        this.hearRotateSpeed = val_14;
    }
    private void Seek()
    {
        UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
        int val_2 = this.hidePositionIndex;
        UnityEngine.Vector3 val_3 = HidePositionManager.current.GetRandomPoint(resultIndex: out  val_2, excludeIndex:  val_2);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.Seek(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private void Seek(UnityEngine.Vector3 position)
    {
        this.seeker.ToSeekState();
        bool val_1 = this.navMeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        this.navMeshAgent.isStopped = false;
    }
    public SeekerAIController()
    {
        this.hidePositionIndex = 0;
    }

}
