using UnityEngine;

namespace Game
{
    public sealed class CoinView : MonoBehaviour
    {
        // Fields
        private float _shakeScaleDuration;
        private float _hideScaleDuration;
        public int Value;
        
        // Methods
        public void Collect()
        {
            this.enabled = false;
            DG.Tweening.Tweener val_2 = DG.Tweening.ShortcutExtensions.DOShakeScale(target:  this.transform, duration:  this._shakeScaleDuration, strength:  1f, vibrato:  10, randomness:  90f, fadeOut:  true);
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
            DG.Tweening.Tweener val_6 = DG.Tweening.TweenSettingsExtensions.SetDelay<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOScale(target:  this.transform, endValue:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  this._hideScaleDuration), delay:  this._shakeScaleDuration);
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            this.transform.Rotate(eulers:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        }
        public CoinView()
        {
            this.Value = 1;
            this._shakeScaleDuration = 1f;
            this._hideScaleDuration = 0.25f;
        }
    
    }

}
