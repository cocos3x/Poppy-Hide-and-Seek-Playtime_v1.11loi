using UnityEngine;

namespace Game
{
    public sealed class DoorView : MonoBehaviour
    {
        // Fields
        public System.Action<UnityEngine.Collider> COLLISION;
        private const float kColliderRadius = 0.8;
        private UnityEngine.BoxCollider _box;
        private float _angleOffset;
        private float _lerpFactor;
        private float _speedFading;
        private float _speed;
        private float _angle;
        private float _startAngle;
        private UnityEngine.Transform _lastDetectedCollisionTarget;
        private int _layerMask;
        
        // Methods
        private void Awake()
        {
            UnityEngine.Vector3 val_2 = this.transform.eulerAngles;
            this._startAngle = val_2.y;
            this._layerMask = Utils.LayerUtils.GetDoorsLayerMask();
        }
        private void FixedUpdate()
        {
            var val_5;
            var val_35;
            float val_36;
            float val_39;
            float val_40;
            float val_41;
            float val_42;
            float val_43;
            float val_44;
            val_35 = this;
            UnityEngine.Matrix4x4 val_2 = this.transform.localToWorldMatrix;
            UnityEngine.Vector3 val_7 = this._box.center;
            UnityEngine.Vector3 val_8 = this._box.size;
            val_8.x = val_8.x * 0.5f;
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_36 = val_9.y;
            UnityEngine.Matrix4x4 val_11 = this.transform.localToWorldMatrix;
            UnityEngine.Vector3 val_16 = this._box.center;
            UnityEngine.Vector3 val_17 = this._box.size;
            val_17.x = val_17.x * 0.5f;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_39 = val_18.y;
            val_40 = val_9.x;
            val_41 = val_36;
            val_42 = val_9.z;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, end:  new UnityEngine.Vector3() {x = val_18.x, y = val_39, z = val_18.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._layerMask, queryTriggerInteraction:  1)) == true)
            {
                goto label_9;
            }
            
            val_40 = val_18.x;
            val_41 = val_39;
            val_42 = val_18.z;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_40, y = val_41, z = val_42}, end:  new UnityEngine.Vector3() {x = val_9.x, y = val_36, z = val_9.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._layerMask, queryTriggerInteraction:  1)) == false)
            {
                goto label_12;
            }
            
            label_9:
            label_12:
            if(0 != this._lastDetectedCollisionTarget)
            {
                    UnityEngine.Vector3 val_22 = this._lastDetectedCollisionTarget.position;
                val_36 = val_22.y;
                UnityEngine.Vector3 val_23 = this._lastDetectedCollisionTarget.position;
                val_39 = val_23.y;
                val_43 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_39, z = val_23.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_36, z = val_9.z});
                UnityEngine.Vector3 val_25 = this._box.size;
                val_41 = 0.8f;
                val_44 = val_25.x + val_41;
                if(val_43 <= val_44)
            {
                    return;
            }
            
            }
            
            float val_35 = this._angle;
            float val_26 = UnityEngine.Time.fixedDeltaTime;
            val_26 = this._lerpFactor * val_26;
            val_35 = val_35 + val_26;
            this._angle = val_35;
            float val_36 = val_35;
            float val_37 = this._speed;
            val_36 = val_36 * val_37;
            val_37 = val_37 * this._speedFading;
            val_43 = this._startAngle - val_36;
            this._speed = val_37;
            val_35 = this.transform;
            val_5 = 0;
            val_35.eulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private float DirectionPointByTheLine(UnityEngine.Vector3 position, UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            position.x = position.x - start.x;
            position.z = position.z - start.z;
            start.x = end.x - start.x;
            position.x = position.x * (end.y - start.z);
            position.x = position.x - (position.z * start.x);
            return (float)(float)Utilities.MathUtil.Sign(value:  (double)position.x);
        }
        public DoorView()
        {
        
        }
    
    }

}
