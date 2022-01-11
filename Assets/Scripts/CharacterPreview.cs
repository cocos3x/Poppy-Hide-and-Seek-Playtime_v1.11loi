using UnityEngine;
public class CharacterPreview : MonoBehaviour
{
    // Fields
    public CharacterManager characterManager;
    public UnityEngine.Camera camera;
    public UnityEngine.Transform spawnTransformation;
    public UnityEngine.GameObject currentCharacter;
    
    // Methods
    public void SpawnCharacter(string id)
    {
        var val_17;
        if((UnityEngine.Object.op_Implicit(exists:  this.currentCharacter)) != false)
        {
                UnityEngine.Object.Destroy(obj:  this.currentCharacter);
        }
        
        if((id.Contains(value:  "seeker")) == false)
        {
            goto label_8;
        }
        
        Seeker val_3 = this.characterManager.GetSeekerPrefab(id:  id);
        if(val_3.animator != null)
        {
            goto label_10;
        }
        
        label_8:
        Hider val_4 = this.characterManager.GetHiderPrefab(id:  id);
        label_10:
        this.currentCharacter = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_4.animator.gameObject);
        UnityEngine.Transform val_7 = this.spawnTransformation.Find(n:  id);
        UnityEngine.Vector3 val_9 = val_7.position;
        this.currentCharacter.transform.position = new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z};
        val_17 = this.currentCharacter.transform;
        UnityEngine.Quaternion val_11 = val_7.rotation;
        val_17.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        UnityEngine.Animator val_12 = this.currentCharacter.GetComponent<UnityEngine.Animator>();
        val_12.Play(stateName:  "Idle");
        val_12.SetBool(name:  "ground", value:  true);
        if(val_15.Length < 1)
        {
                return;
        }
        
        do
        {
            this.currentCharacter.GetComponentsInChildren<UnityEngine.Renderer>()[0].gameObject.layer = this.gameObject.layer;
            val_17 = 0 + 1;
        }
        while(val_17 < val_15.Length);
    
    }
    public CharacterPreview()
    {
    
    }

}
