using UnityEngine;
public class CharacterManager : SingletonMonoBehaviour<CharacterManager>
{
    // Fields
    public System.Collections.Generic.List<Seeker> seekerPrefabs;
    public System.Collections.Generic.List<Hider> hiderPrefabs;
    public System.Collections.Generic.List<Hider> hiders;
    public Seeker seeker;
    
    // Methods
    public Seeker GetSeekerPrefab(string id)
    {
        .id = id;
        return this.seekerPrefabs.Find(match:  new System.Predicate<Seeker>(object:  new CharacterManager.<>c__DisplayClass4_0(), method:  System.Boolean CharacterManager.<>c__DisplayClass4_0::<GetSeekerPrefab>b__0(Seeker x)));
    }
    public Hider GetHiderPrefab(string id)
    {
        .id = id;
        return this.hiderPrefabs.Find(match:  new System.Predicate<Hider>(object:  new CharacterManager.<>c__DisplayClass5_0(), method:  System.Boolean CharacterManager.<>c__DisplayClass5_0::<GetHiderPrefab>b__0(Hider x)));
    }
    public void Spawn()
    {
        var val_5;
        var val_6;
        val_5 = null;
        val_5 = null;
        var val_5 = 0;
        do
        {
            this.hiders.Add(item:  UnityEngine.Object.Instantiate<Hider>(original:  this.GetHiderPrefab(id:  UserData.current.currentHiderId)));
            val_5 = val_5 + 1;
        }
        while(val_5 < 5);
        
        val_6 = null;
        val_6 = null;
        this.seeker = UnityEngine.Object.Instantiate<Seeker>(original:  this.GetSeekerPrefab(id:  UserData.current.currentSeekerId));
    }
    public void ReplaceHider(int index, Hider newHiderPrefab)
    {
        bool val_13 = true;
        if(val_13 <= index)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_13 = val_13 + (index << 3);
        UnityEngine.Vector3 val_2 = (true + (index) << 3) + 32.transform.localPosition;
        UnityEngine.Quaternion val_4 = (true + (index) << 3) + 32.transform.localRotation;
        UnityEngine.AnimatorStateInfo val_5 = (true + (index) << 3) + 32 + 88.GetCurrentAnimatorStateInfo(layerIndex:  0);
        Hider val_9 = UnityEngine.Object.Instantiate<Hider>(original:  newHiderPrefab);
        val_9.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        val_9.transform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        val_9.animator.Play(stateNameHash:  -1779634768, layer:  0);
        val_9.canBeCaught = (true + (index) << 3) + 32 + 62;
        val_9.canBeRescued = (true + (index) << 3) + 32 + 61;
        val_9.canRescueOthers = (true + (index) << 3) + 32 + 60;
        val_9.SetOnLand(flag:  (true + (index) << 3) + 32 + 152);
        UnityEngine.Object.Destroy(obj:  (true + (index) << 3) + 32.gameObject);
        this.hiders.set_Item(index:  index, value:  val_9);
    }
    public void ReplaceSeeker(Seeker newSeekerPrefab)
    {
        UnityEngine.Vector3 val_2 = this.seeker.transform.localPosition;
        UnityEngine.Quaternion val_4 = this.seeker.transform.localRotation;
        UnityEngine.AnimatorStateInfo val_5 = this.seeker.animator.GetCurrentAnimatorStateInfo(layerIndex:  0);
        Seeker val_9 = UnityEngine.Object.Instantiate<Seeker>(original:  newSeekerPrefab);
        val_9.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        val_9.transform.localRotation = new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w};
        val_9.catchDistance = this.seeker.catchDistance;
        val_9.SetOnLand(flag:  this.seeker.isOnLand);
        val_9.animator.Play(stateNameHash:  -1779432688, layer:  0);
        UnityEngine.Object.Destroy(obj:  this.seeker.gameObject);
        this.seeker = val_9;
    }
    public void Clear()
    {
        bool val_3 = true;
        var val_4 = 0;
        label_7:
        if(val_4 >= val_3)
        {
            goto label_2;
        }
        
        if(val_3 <= val_4)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        val_3 = val_3 + 0;
        UnityEngine.Object.Destroy(obj:  (true + 0) + 32.gameObject);
        val_4 = val_4 + 1;
        if(this.hiders != null)
        {
            goto label_7;
        }
        
        label_2:
        UnityEngine.Object.Destroy(obj:  this.seeker.gameObject);
        this.hiders.Clear();
    }
    public void GetRefs()
    {
        this.hiders = new System.Collections.Generic.List<Hider>(collection:  UnityEngine.Object.FindObjectsOfType<Hider>());
        this.seeker = UnityEngine.Object.FindObjectOfType<Seeker>();
    }
    public CharacterManager()
    {
    
    }

}
