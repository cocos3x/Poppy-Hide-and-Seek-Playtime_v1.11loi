using UnityEngine;
public class CageEffect : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject cageMeshObject;
    public UnityEngine.ParticleSystem particleSmoke;
    public UnityEngine.ParticleSystem particleText;
    public UnityEngine.ParticleSystem particleRecure;
    public UnityEngine.AudioSource audioSourceCaught;
    public UnityEngine.AudioSource audioSourceRescued;
    private UnityEngine.Coroutine particleTextPlayCoroutine;
    
    // Methods
    public void Play()
    {
        this.cageMeshObject.gameObject.SetActive(value:  true);
        this.particleText.gameObject.SetActive(value:  true);
        this.particleSmoke.Play();
        this.audioSourceCaught.Play();
        this.particleTextPlayCoroutine = this.StartCoroutine(routine:  this.audioSourceCaught.PlayParticleDelay(particle:  this.particleText, delay:  3f));
    }
    public void Stop()
    {
        this.cageMeshObject.gameObject.SetActive(value:  false);
        this.particleText.gameObject.SetActive(value:  false);
        this.particleRecure.Play();
        this.audioSourceRescued.Play();
        if(this.particleTextPlayCoroutine == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.particleTextPlayCoroutine);
    }
    private System.Collections.IEnumerator PlayParticleDelay(UnityEngine.ParticleSystem particle, float delay)
    {
        .<>1__state = 0;
        .particle = particle;
        .delay = delay;
        return (System.Collections.IEnumerator)new CageEffect.<PlayParticleDelay>d__9();
    }
    public CageEffect()
    {
    
    }

}
