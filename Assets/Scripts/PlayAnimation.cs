using UnityEngine;
public class PlayAnimation : MonoBehaviour
{
    // Fields
    public string name;
    
    // Methods
    public void PlayAnim()
    {
        this.GetComponent<UnityEngine.Animator>().Play(stateName:  this.name);
    }
    public PlayAnimation()
    {
        this.name = "Idle";
    }

}
