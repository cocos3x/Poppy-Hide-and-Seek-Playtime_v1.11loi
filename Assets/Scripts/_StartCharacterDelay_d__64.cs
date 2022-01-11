using UnityEngine;
private sealed class GameFlow.<StartCharacterDelay>d__64 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int <>1__state;
    private object <>2__current;
    public float delay;
    public GameFlow <>4__this;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameFlow.<StartCharacterDelay>d__64(int <>1__state)
    {
        this.<>1__state = <>1__state;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_40;
        int val_41;
        var val_42;
        var val_43;
        var val_44;
        UnityEngine.CharacterController val_45;
        Hider val_46;
        if((this.<>1__state) == 1)
        {
            goto label_1;
        }
        
        if((this.<>1__state) != 0)
        {
            goto label_33;
        }
        
        this.<>1__state = 0;
        UnityEngine.WaitForSeconds val_1 = null;
        val_40 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.delay);
        val_41 = 1;
        this.<>2__current = val_40;
        this.<>1__state = val_41;
        return (bool)val_41;
        label_1:
        val_40 = this.<>4__this;
        this.<>1__state = 0;
        if((this.<>4__this.mode) == 0)
        {
            goto label_5;
        }
        
        val_42 = 1152921504611426304;
        val_43 = 1152921507136268912;
        val_44 = 0;
        label_18:
        if(val_44 >= (this.<>4__this.mode))
        {
            goto label_8;
        }
        
        if((this.<>4__this.mode) <= val_44)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Delegate val_3 = System.Delegate.Combine(a:  CharacterManager.__il2cppRuntimeField_byval_arg + 112, b:  new System.Action<Hider>(object:  val_40, method:  System.Void GameFlow::OnHiderGetCaught(Hider hider)));
        if(val_3 != null)
        {
                if(null != null)
        {
                throw new IndexOutOfRangeException();
        }
        
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_70 = val_3;
        System.Delegate val_5 = System.Delegate.Combine(a:  CharacterManager.__il2cppRuntimeField_byval_arg + 120, b:  new System.Action<Hider, Hider>(object:  val_40, method:  System.Void GameFlow::OnHiderGetReleased(Hider subject, Hider hider)));
        if(val_5 != null)
        {
                if(null != null)
        {
                throw new IndexOutOfRangeException();
        }
        
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_78 = val_5;
        CharacterManager.__il2cppRuntimeField_byval_arg.gameObject.AddComponent<HiderAIController>().Setup(hider:  CharacterManager.__il2cppRuntimeField_byval_arg, mna:  CharacterManager.__il2cppRuntimeField_byval_arg.gameObject.AddComponent<UnityEngine.AI.NavMeshAgent>());
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_3C = 0;
        CharacterManager.__il2cppRuntimeField_byval_arg.SetLayerAsAI();
        val_44 = val_44 + 1;
        if((this.<>4__this.characterManager) != null)
        {
            goto label_18;
        }
        
        label_8:
        val_45 = this.<>4__this.characterManager.seeker.gameObject.AddComponent<UnityEngine.CharacterController>();
        val_13.joystick = this.<>4__this.playView.joystick;
        this.<>4__this.characterManager.seeker.gameObject.AddComponent<SeekerPlayerControler>().Setup(seeker:  this.<>4__this.characterManager.seeker, cc:  val_45);
        mem2[0] = 1;
        this.<>4__this.characterManager.seeker.SetLayerAsPlayer();
        goto label_33;
        label_5:
        val_45 = this.<>4__this.characterManager.seeker.gameObject.AddComponent<UnityEngine.AI.NavMeshAgent>();
        this.<>4__this.characterManager.seeker.gameObject.AddComponent<SeekerAIController>().Setup(seeker:  this.<>4__this.characterManager.seeker, agent:  val_45);
        this.<>4__this.characterManager.seeker.SetLayerAsAI();
        val_43 = 1152921504611319808;
        val_44 = 1152921507136290416;
        var val_40 = 0;
        val_42 = 1;
        label_59:
        if(val_40 >= (this.<>4__this.characterManager))
        {
            goto label_33;
        }
        
        if((this.<>4__this.characterManager) <= val_40)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        System.Delegate val_19 = System.Delegate.Combine(a:  CharacterManager.__il2cppRuntimeField_byval_arg + 112, b:  new System.Action<Hider>(object:  val_40, method:  System.Void GameFlow::OnHiderGetCaught(Hider hider)));
        if(val_19 != null)
        {
                if(null != null)
        {
                throw new IndexOutOfRangeException();
        }
        
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_70 = val_19;
        System.Delegate val_21 = System.Delegate.Combine(a:  CharacterManager.__il2cppRuntimeField_byval_arg + 120, b:  new System.Action<Hider, Hider>(object:  val_40, method:  System.Void GameFlow::OnHiderGetReleased(Hider subject, Hider hider)));
        if(val_21 != null)
        {
                if(null != null)
        {
                throw new IndexOutOfRangeException();
        }
        
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_78 = val_21;
        UnityEngine.GameObject val_22 = CharacterManager.__il2cppRuntimeField_byval_arg.gameObject;
        if(val_40 != 0)
        {
                val_45 = val_22.AddComponent<UnityEngine.AI.NavMeshAgent>();
            val_46 = CharacterManager.__il2cppRuntimeField_byval_arg;
            CharacterManager.__il2cppRuntimeField_byval_arg.gameObject.AddComponent<HiderAIController>().Setup(hider:  val_46, mna:  val_45);
            CharacterManager.__il2cppRuntimeField_byval_arg.SetLayerAsAI();
        }
        else
        {
                HiderPlayerController val_28 = CharacterManager.__il2cppRuntimeField_byval_arg.gameObject.AddComponent<HiderPlayerController>();
            val_28.joystick = this.<>4__this.playView.joystick;
            val_28.SetUp(hider:  CharacterManager.__il2cppRuntimeField_byval_arg, cc:  val_22.AddComponent<UnityEngine.CharacterController>());
            CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_18 = val_42;
            CharacterManager.__il2cppRuntimeField_byval_arg.SetLayerAsPlayer();
            if((this.<>4__this.useSpeedBoost) != false)
        {
                this.<>4__this.useSpeedBoost = false;
            SingletonMonoBehaviour<SpeedBooster>.Instance.SetTarget(hiderPlayerController:  val_28);
        }
        
            if((this.<>4__this.useIgnoreWall) != false)
        {
                this.<>4__this.useIgnoreWall = false;
            IgnoreWall val_30 = SingletonMonoBehaviour<IgnoreWall>.Instance;
            UnityEngine.Coroutine val_32 = val_30.StartCoroutine(routine:  val_30.MakeHiderInvisibleForSeconds(hider:  CharacterManager.__il2cppRuntimeField_byval_arg, duration:  val_30.duration));
        }
        
            if((this.<>4__this.useInvisibility) != false)
        {
                this.<>4__this.useInvisibility = false;
            Invisibility val_33 = SingletonMonoBehaviour<Invisibility>.Instance;
            UnityEngine.Coroutine val_35 = val_33.StartCoroutine(routine:  val_33.MakeHiderInvisibleForSeconds(hider:  CharacterManager.__il2cppRuntimeField_byval_arg, duration:  val_33.duration));
        }
        
            val_45 = CharacterManager.__il2cppRuntimeField_byval_arg + 192 + 32.GetComponent<UnityEngine.Renderer>();
            System.Collections.Generic.List<UnityEngine.Material> val_37 = new System.Collections.Generic.List<UnityEngine.Material>();
            val_37.AddRange(collection:  val_45.sharedMaterials);
            val_37.Add(item:  this.<>4__this.materialOutline);
            val_46 = val_37.ToArray();
            val_45.sharedMaterials = val_46;
        }
        
        CharacterManager.__il2cppRuntimeField_byval_arg.__unknownFiledOffset_3C = val_42;
        val_40 = val_40 + 1;
        if((this.<>4__this.characterManager) != null)
        {
            goto label_59;
        }
        
        throw new NullReferenceException();
        label_33:
        val_41 = 0;
        return (bool)val_41;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.<>2__current;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        throw new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.<>2__current;
    }

}
