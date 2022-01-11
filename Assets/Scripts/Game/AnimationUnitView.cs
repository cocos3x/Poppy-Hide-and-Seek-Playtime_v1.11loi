using UnityEngine;

namespace Game
{
    public abstract class AnimationUnitView : BaseUnitView
    {
        // Fields
        private UnityEngine.Animator _animator;
        private Game.AnimationType _animationType;
        
        // Properties
        public Game.AnimationType AnimationType { get; }
        
        // Methods
        public Game.AnimationType get_AnimationType()
        {
            return (Game.AnimationType)this._animationType;
        }
        public bool IsDied()
        {
            return (bool)(this._animationType == 2) ? 1 : 0;
        }
        public virtual void Idle()
        {
            this.PlayAnimation(animationType:  0);
        }
        public void Walk()
        {
            this.PlayAnimation(animationType:  1);
        }
        public virtual void Die()
        {
            this.PlayAnimation(animationType:  2);
        }
        private void PlayAnimation(Game.AnimationType animationType)
        {
            if(this._animationType == animationType)
            {
                    return;
            }
            
            this._animationType = animationType;
            this._animationType.Add(driver:  public System.String System.Enum::ToString(), rectTransform:  null, drivenProperties:  null);
            this._animationType = null;
            int val_2 = UnityEngine.Animator.StringToHash(name:  this._animationType.ToString());
            this._animator.Play(stateNameHash:  val_2);
            if((this._animator.HasState(layerIndex:  1, stateID:  val_2)) != false)
            {
                    this._animator.Play(stateNameHash:  val_2, layer:  1);
            }
            
            this._animator.Update(deltaTime:  0f);
        }
        protected AnimationUnitView()
        {
            val_1 = new UnityEngine.MonoBehaviour();
        }
    
    }

}
