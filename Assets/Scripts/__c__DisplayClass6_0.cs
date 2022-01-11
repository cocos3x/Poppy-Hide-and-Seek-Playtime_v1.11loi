using UnityEngine;
private sealed class DOTweenModulePhysics.<>c__DisplayClass6_0
{
    // Fields
    public UnityEngine.Rigidbody target;
    public float startPosY;
    public bool offsetYSet;
    public float offsetY;
    public DG.Tweening.Sequence s;
    public UnityEngine.Vector3 endValue;
    public DG.Tweening.Tween yTween;
    
    // Methods
    public DOTweenModulePhysics.<>c__DisplayClass6_0()
    {
    
    }
    internal UnityEngine.Vector3 <DOJump>b__0()
    {
        if(this.target != null)
        {
                return this.target.position;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJump>b__1()
    {
        UnityEngine.Vector3 val_1 = this.target.position;
        this.startPosY = val_1.y;
    }
    internal UnityEngine.Vector3 <DOJump>b__2()
    {
        if(this.target != null)
        {
                return this.target.position;
        }
        
        throw new NullReferenceException();
    }
    internal UnityEngine.Vector3 <DOJump>b__3()
    {
        if(this.target != null)
        {
                return this.target.position;
        }
        
        throw new NullReferenceException();
    }
    internal void <DOJump>b__4()
    {
        float val_5;
        if(this.offsetYSet != true)
        {
                this.offsetYSet = true;
            if(this.s == null)
        {
                val_5 = S0 - this.startPosY;
        }
        
            this.offsetY = val_5;
        }
        
        UnityEngine.Vector3 val_1 = this.target.position;
        float val_4 = this.offsetY;
        val_4 = val_1.y + (DG.Tweening.DOVirtual.EasedValue(from:  0f, to:  val_4, lifetimePercentage:  DG.Tweening.TweenExtensions.ElapsedPercentage(t:  this.yTween, includeLoops:  true), easeType:  6));
        this.target.MovePosition(position:  new UnityEngine.Vector3() {x = val_1.x, y = val_4, z = val_1.z});
    }

}
