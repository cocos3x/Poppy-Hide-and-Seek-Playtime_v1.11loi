using UnityEngine;
private sealed class GameFlow.<>c__DisplayClass61_1
{
    // Fields
    public UnityEngine.Transform cameraTransform;
    public Character playerCharacter;
    public CameraFollowPlayer cameraFollowPlayer;
    public GameFlow <>4__this;
    public DG.Tweening.TweenCallback <>9__3;
    
    // Methods
    public GameFlow.<>c__DisplayClass61_1()
    {
    
    }
    internal void <OnGameStart>b__2()
    {
        GameFlow val_14;
        DG.Tweening.TweenCallback val_15;
        this.<>4__this.isCountdownPlayingTime = true;
        this.<>4__this.characterManager.seeker.StartGame();
        val_14 = this.<>4__this;
        var val_14 = 0;
        label_23:
        if(val_14 >= (this.<>4__this.characterManager))
        {
            goto label_8;
        }
        
        if((this.<>4__this.characterManager) <= val_14)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        GameFlow.__il2cppRuntimeField_byval_arg.SetVisibleToSeeker(flag:  false);
        UnityEngine.Vector3 val_2 = this.playerCharacter.transform.position;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.cameraFollowPlayer.offset, y = V12.16B, z = V13.16B});
        val_15 = this.<>9__3;
        if(val_15 == null)
        {
                DG.Tweening.TweenCallback val_5 = null;
            val_15 = val_5;
            val_5 = new DG.Tweening.TweenCallback(object:  this, method:  System.Void GameFlow.<>c__DisplayClass61_1::<OnGameStart>b__3());
            this.<>9__3 = val_15;
        }
        
        DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.OnComplete<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOMove(target:  this.cameraTransform, endValue:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, duration:  0.75f, snapping:  false), action:  val_5);
        this.<>4__this.radarForward.SetTarget(target:  this.playerCharacter.transform);
        this.<>4__this.radarForward.gameObject.SetActive(value:  true);
        val_14 = val_14 + 1;
        if((this.<>4__this) != null)
        {
            goto label_23;
        }
        
        label_8:
        if((this.<>4__this.useIgnoreWall) != false)
        {
                this.<>4__this.useIgnoreWall = false;
            IgnoreWall val_9 = SingletonMonoBehaviour<IgnoreWall>.Instance;
            UnityEngine.Coroutine val_11 = val_9.StartCoroutine(routine:  val_9.MakeHiderInvisibleForSeconds(seeker:  this.<>4__this.characterManager.seeker, duration:  val_9.duration));
            val_14 = this.<>4__this;
        }
        
        if((this.<>4__this.useSpeedBoost) != false)
        {
                this.<>4__this.useSpeedBoost = false;
            SingletonMonoBehaviour<SpeedBooster>.Instance.SetTarget(seekerPlayerControler:  this.playerCharacter.GetComponent<SeekerPlayerControler>());
            val_14 = this.<>4__this;
        }
        
        this.<>4__this.tutorialView.Open();
    }
    internal void <OnGameStart>b__3()
    {
        if(this.cameraFollowPlayer != null)
        {
                this.cameraFollowPlayer.enabled = true;
            return;
        }
        
        throw new NullReferenceException();
    }

}
