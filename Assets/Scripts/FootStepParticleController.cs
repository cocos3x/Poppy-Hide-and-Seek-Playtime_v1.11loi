using UnityEngine;
public class FootStepParticleController : MonoBehaviour
{
    // Fields
    public Hider hider;
    public FootStepParticleController.PredicateVoid CheckOnGround;
    public static float spawnFootStepDistanceThreshold;
    public UnityEngine.ParticleSystem particleSystemFootStep;
    public UnityEngine.ParticleSystem particleSystemFootSplat;
    private UnityEngine.Vector3 previousPosition;
    private float stickDuration;
    private float fadeDuration;
    private UnityEngine.Color color;
    private float time;
    private float totalDuration;
    private bool canSpawn;
    
    // Methods
    public void Show(UnityEngine.Color color, float stickDuration, float fadeDuration)
    {
        this.enabled = true;
        this.canSpawn = true;
        UnityEngine.Vector3 val_2 = this.transform.position;
        this.previousPosition = val_2;
        mem[1152921507125042604] = val_2.y;
        float val_3 = stickDuration + fadeDuration;
        val_3 = val_3 + 0.25f;
        this.fadeDuration = fadeDuration;
        this.color = color;
        mem[1152921507125042624] = color.g;
        mem[1152921507125042628] = color.b;
        mem[1152921507125042632] = color.a;
        mem[1152921507125042608] = val_2.z;
        this.stickDuration = stickDuration;
        this.time = 0f;
        this.totalDuration = val_3;
        this.particleSystemFootStep.gameObject.SetActive(value:  true);
        this.particleSystemFootStep.Play();
        this.particleSystemFootSplat.gameObject.SetActive(value:  true);
        this.particleSystemFootSplat.Play();
    }
    public void Update()
    {
        float val_13;
        float val_14;
        var val_15;
        float val_16;
        if(this.canSpawn != false)
        {
                UnityEngine.Vector3 val_2 = this.transform.position;
            if(this.hider.isOnLand != false)
        {
                val_14 = val_2.y;
            val_15 = null;
            val_15 = null;
            val_16 = FootStepParticleController.spawnFootStepDistanceThreshold;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.previousPosition, y = V8.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_14, z = val_2.z})) > val_16)
        {
                val_13 = 1f;
            float val_5 = UnityEngine.Mathf.Min(a:  val_13, b:  this.time / this.stickDuration);
            this.previousPosition = val_2;
            mem[1152921507125207852] = val_14;
            mem[1152921507125207856] = val_2.z;
            UnityEngine.Vector3 val_7 = this.transform.eulerAngles;
            float val_8 = 360f - val_7.y;
            float val_9 = val_13 - val_5;
            UnityEngine.Color32 val_10 = UnityEngine.Color32.op_Implicit(c:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            byte val_11 = val_10.r & 4294967295;
            this.particleSystemFootStep.Emit(emitParams:  new EmitParams() {m_Particle = new ParticleSystem.Particle() {m_Position = new UnityEngine.Vector3(), m_Velocity = new UnityEngine.Vector3(), m_AnimatedVelocity = new UnityEngine.Vector3(), m_InitialVelocity = new UnityEngine.Vector3(), m_AxisOfRotation = new UnityEngine.Vector3(), m_Rotation = new UnityEngine.Vector3(), m_AngularVelocity = new UnityEngine.Vector3(), m_StartSize = new UnityEngine.Vector3(), m_StartColor = new UnityEngine.Color32()}, m_PositionSet = false, m_VelocitySet = false, m_AxisOfRotationSet = false, m_RotationSet = false, m_AngularVelocitySet = false, m_StartSizeSet = false, m_StartColorSet = false, m_RandomSeedSet = false, m_StartLifetimeSet = false, m_MeshIndexSet = false, m_ApplyShapeToPosition = false}, count:  1);
            val_16 = 0.5f;
            if(val_5 < 0)
        {
                this.particleSystemFootSplat.Emit(emitParams:  new EmitParams() {m_Particle = new ParticleSystem.Particle() {m_Position = new UnityEngine.Vector3(), m_Velocity = new UnityEngine.Vector3(), m_AnimatedVelocity = new UnityEngine.Vector3(), m_InitialVelocity = new UnityEngine.Vector3(), m_AxisOfRotation = new UnityEngine.Vector3(), m_Rotation = new UnityEngine.Vector3(), m_AngularVelocity = new UnityEngine.Vector3(), m_StartSize = new UnityEngine.Vector3(), m_StartColor = new UnityEngine.Color32()}, m_PositionSet = false, m_VelocitySet = false, m_AxisOfRotationSet = false, m_RotationSet = false, m_AngularVelocitySet = false, m_StartSizeSet = false, m_StartColorSet = false, m_RandomSeedSet = false, m_StartLifetimeSet = false, m_MeshIndexSet = false, m_ApplyShapeToPosition = false}, count:  1);
        }
        
        }
        
        }
        
        }
        
        float val_12 = UnityEngine.Time.deltaTime;
        val_12 = this.time + val_12;
        this.time = val_12;
        if(val_12 <= this.totalDuration)
        {
                if(this.hider.isOnLand == true)
        {
                return;
        }
        
        }
        
        this.Hide();
    }
    private void Hide()
    {
        this.enabled = false;
        this.particleSystemFootStep.Stop();
        this.particleSystemFootStep.gameObject.SetActive(value:  false);
        this.particleSystemFootSplat.Stop();
        this.particleSystemFootSplat.gameObject.SetActive(value:  false);
    }
    public void StopSpawning()
    {
        this.canSpawn = false;
    }
    public FootStepParticleController()
    {
    
    }
    private static FootStepParticleController()
    {
        FootStepParticleController.spawnFootStepDistanceThreshold = 0.8f;
    }

}
