using UnityEngine;
public class MovingEffect : MonoBehaviour
{
    // Fields
    public UnityEngine.ParticleSystem particleWave;
    public UnityEngine.ParticleSystem particleSmoke;
    
    // Methods
    public void OnStartMove(bool onLand)
    {
        if(onLand == false)
        {
            goto label_0;
        }
        
        if(this.particleSmoke != null)
        {
            goto label_1;
        }
        
        throw new NullReferenceException();
        label_0:
        label_1:
        this.particleSmoke.Play();
    }
    public MovingEffect()
    {
    
    }

}
