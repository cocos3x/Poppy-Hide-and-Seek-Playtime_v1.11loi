using UnityEngine;
public class HiderAIController : MonoBehaviour
{
    // Fields
    public Hider hider;
    public UnityEngine.AI.NavMeshAgent navMeshAgent;
    private float idleTime;
    private float agentSpeed;
    private int hidePositionIndex;
    private bool isPlaying;
    
    // Methods
    public void Setup(Hider hider, UnityEngine.AI.NavMeshAgent mna)
    {
        this.hider = hider;
        this.navMeshAgent = mna;
        mna.updateRotation = false;
        this.navMeshAgent.radius = 0.1f;
        float val_1 = this.navMeshAgent.speed;
        val_1 = val_1 * 1.2f;
        this.navMeshAgent.speed = val_1;
        this.agentSpeed = this.navMeshAgent.speed;
        System.Delegate val_4 = System.Delegate.Combine(a:  hider.OnStartGame, b:  new System.Action(object:  this, method:  public System.Void HiderAIController::OnStartGame()));
        if(val_4 != null)
        {
                if(null != null)
        {
            goto label_13;
        }
        
        }
        
        hider.OnStartGame = val_4;
        System.Delegate val_6 = System.Delegate.Combine(a:  hider.OnStopGame, b:  new System.Action(object:  this, method:  public System.Void HiderAIController::OnStopGame()));
        if(val_6 != null)
        {
                if(null != null)
        {
            goto label_13;
        }
        
        }
        
        hider.OnStopGame = val_6;
        System.Delegate val_8 = System.Delegate.Combine(a:  hider.OnGetCaught, b:  new System.Action<Hider>(object:  this, method:  public System.Void HiderAIController::OnGetCaught(Hider hider)));
        if(val_8 != null)
        {
                if(null != null)
        {
            goto label_13;
        }
        
        }
        
        hider.OnGetCaught = val_8;
        System.Delegate val_10 = System.Delegate.Combine(a:  hider.OnGetReleased, b:  new System.Action<Hider, Hider>(object:  this, method:  public System.Void HiderAIController::OnGetReleased(Hider subject, Hider hider)));
        if(val_10 != null)
        {
                if(null != null)
        {
            goto label_13;
        }
        
        }
        
        hider.OnGetReleased = val_10;
        hider.ToIdleState();
        return;
        label_13:
    }
    private void OnDestroy()
    {
        if(this.hider == 0)
        {
                return;
        }
        
        System.Delegate val_3 = System.Delegate.Remove(source:  this.hider.OnStartGame, value:  new System.Action(object:  this, method:  public System.Void HiderAIController::OnStartGame()));
        if(val_3 != null)
        {
                if(null != null)
        {
            goto label_15;
        }
        
        }
        
        this.hider.OnStartGame = val_3;
        System.Delegate val_5 = System.Delegate.Remove(source:  this.hider.OnStopGame, value:  new System.Action(object:  this, method:  public System.Void HiderAIController::OnStopGame()));
        if(val_5 != null)
        {
                if(null != null)
        {
            goto label_15;
        }
        
        }
        
        this.hider.OnStopGame = val_5;
        System.Delegate val_7 = System.Delegate.Remove(source:  this.hider.OnGetCaught, value:  new System.Action<Hider>(object:  this, method:  public System.Void HiderAIController::OnGetCaught(Hider hider)));
        if(val_7 != null)
        {
                if(null != null)
        {
            goto label_15;
        }
        
        }
        
        this.hider.OnGetCaught = val_7;
        System.Delegate val_9 = System.Delegate.Remove(source:  this.hider.OnGetReleased, value:  new System.Action<Hider, Hider>(object:  this, method:  public System.Void HiderAIController::OnGetReleased(Hider subject, Hider hider)));
        if(val_9 != null)
        {
                if(null != null)
        {
            goto label_15;
        }
        
        }
        
        this.hider.OnGetReleased = val_9;
        return;
        label_15:
    }
    public void OnStartGame()
    {
        this.isPlaying = true;
        this.Hide();
    }
    public void OnStopGame()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.navMeshAgent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.navMeshAgent.speed = 0f;
        this.navMeshAgent.isStopped = true;
    }
    public void OnGetCaught(Hider hider)
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.navMeshAgent.velocity = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
        this.navMeshAgent.speed = 0f;
        this.navMeshAgent.isStopped = true;
    }
    public void OnGetReleased(Hider subject, Hider hider)
    {
        this.Hide();
        this.navMeshAgent.speed = this.agentSpeed;
        this.navMeshAgent.isStopped = false;
    }
    private void Update()
    {
        float val_12;
        if(this.isPlaying == false)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        if(this.hider.state != 1)
        {
                if(this.hider.state != 0)
        {
                return;
        }
        
            float val_12 = this.idleTime;
            val_12 = val_12 - val_1;
            this.idleTime = val_12;
            if(val_12 >= 0)
        {
                return;
        }
        
            this.Hide();
            return;
        }
        
        if(this.IsNavMeshAgentReachDestination() != false)
        {
                this.ToIdleState();
            return;
        }
        
        UnityEngine.Vector3 val_3 = this.navMeshAgent.velocity;
        val_12 = val_3.z;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_12}, rhs:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z})) == false)
        {
                return;
        }
        
        float val_13 = val_12;
        val_13 = val_13 * (-57.29578f);
        UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.Euler(x:  0f, y:  val_13 + 90f, z:  0f);
        val_12 = val_7.y;
        UnityEngine.Quaternion val_10 = this.transform.localRotation;
        float val_14 = 25f;
        val_14 = val_1 * val_14;
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.Slerp(a:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, b:  new UnityEngine.Quaternion() {x = val_7.x, y = val_12, z = val_7.z, w = val_7.w}, t:  val_14);
        this.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
    }
    private void ToIdleState()
    {
        this.hider.ToIdleState();
        this.idleTime = UnityEngine.Random.Range(min:  1f, max:  5f);
    }
    private void Hide()
    {
        this.hider.ToMoveState();
        UnityEngine.Vector2 val_1 = UnityEngine.Random.insideUnitCircle;
        int val_2 = this.hidePositionIndex;
        UnityEngine.Vector3 val_3 = HidePositionManager.current.GetRandomPoint(resultIndex: out  val_2, excludeIndex:  val_2);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        bool val_5 = this.navMeshAgent.SetDestination(target:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
    }
    private bool IsNavMeshAgentReachDestination()
    {
        if(this.navMeshAgent.pathPending != true)
        {
                if(this.navMeshAgent.remainingDistance <= this.navMeshAgent.stoppingDistance)
        {
            goto label_4;
        }
        
        }
        
        return false;
        label_4:
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
    public HiderAIController()
    {
        this.hidePositionIndex = 0;
    }

}
