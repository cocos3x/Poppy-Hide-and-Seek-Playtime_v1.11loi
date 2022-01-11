using UnityEngine;

namespace Game.Camera
{
    public sealed class CameraFollower : MonoBehaviour
    {
        // Fields
        public UnityEngine.GameObject player;
        public float lerpFactor;
        public float Radius;
        public float ZoomDuration;
        private UnityEngine.Vector3 difference;
        private UnityEngine.Vector3 startPos;
        private UnityEngine.Vector3 _clampedPosition;
        private UnityEngine.Transform _transform;
        private UnityEngine.Vector3 _defaultPosition;
        
        // Properties
        private float Zoom { get; set; }
        
        // Methods
        private float get_Zoom()
        {
            return UnityEngine.Camera.main.fieldOfView;
        }
        private void set_Zoom(float value)
        {
            UnityEngine.Camera.main.fieldOfView = value;
        }
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            this._defaultPosition = val_2;
            mem[1152921507311418204] = val_2.y;
            mem[1152921507311418208] = val_2.z;
        }
        public void ResetToDefaultPosition()
        {
            this.transform.position = new UnityEngine.Vector3() {x = this._defaultPosition};
        }
        public void SetTarget(UnityEngine.GameObject target)
        {
            UnityEngine.GameObject val_17 = target;
            val_17 = UnityEngine.Object.op_Inequality(x:  0, y:  val_17);
            this.enabled = val_17;
            if(0 == target)
            {
                    return;
            }
            
            this.transform.position = new UnityEngine.Vector3() {x = this._defaultPosition};
            this.player = target;
            UnityEngine.Transform val_4 = this.transform;
            this._transform = val_4;
            UnityEngine.Vector3 val_5 = val_4.position;
            this._clampedPosition = val_5;
            mem[1152921507311695432] = val_5.y;
            mem[1152921507311695436] = val_5.z;
            UnityEngine.Vector3 val_7 = this.transform.position;
            UnityEngine.Vector3 val_9 = this.player.transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z});
            this.startPos = val_10;
            mem[1152921507311695420] = val_10.y;
            mem[1152921507311695424] = val_10.z;
            this.transform.position = new UnityEngine.Vector3() {x = this.startPos, y = val_10.y, z = val_10.z};
            UnityEngine.Vector3 val_13 = this.player.transform.position;
            UnityEngine.Vector3 val_15 = this.transform.position;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z});
            this.difference = val_16;
            mem[1152921507311695408] = val_16.y;
            mem[1152921507311695412] = val_16.z;
        }
        private void Update()
        {
            UnityEngine.Vector3 val_2 = this.player.transform.position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.difference, y = V11.16B, z = V10.16B});
            UnityEngine.Vector3 val_4 = this._transform.position;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, t:  this.lerpFactor);
            this._transform.position = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = this._transform.position;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.ClampMagnitude(vector:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, maxLength:  this.Radius);
            this._clampedPosition = val_7;
            mem[1152921507311872968] = val_7.y;
            mem[1152921507311872972] = val_7.z;
            UnityEngine.Vector3 val_9 = this._transform.position;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = this._clampedPosition, y = val_3.y, z = val_3.z}, t:  this.lerpFactor);
            this.transform.position = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
        }
        public void ZoomTo(float zoom, float duration)
        {
            int val_1 = DG.Tweening.DOTween.Kill(targetOrId:  this, complete:  false);
            duration = this.ZoomDuration * duration;
            DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions> val_5 = DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  this, method:  System.Single Game.Camera.CameraFollower::<ZoomTo>b__16_0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  this, method:  System.Void Game.Camera.CameraFollower::<ZoomTo>b__16_1(float x)), endValue:  zoom, duration:  duration), target:  this);
            bool val_6 = UnityEngine.Mathf.Approximately(a:  duration, b:  0f);
            if(val_6 == false)
            {
                    return;
            }
            
            val_6.Zoom = zoom;
        }
        public CameraFollower()
        {
            this.Radius = 50f;
        }
        private float <ZoomTo>b__16_0()
        {
            return this.Zoom;
        }
        private void <ZoomTo>b__16_1(float x)
        {
            this.Zoom = x;
        }
    
    }

}
