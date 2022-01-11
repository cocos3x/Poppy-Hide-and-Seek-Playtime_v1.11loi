using UnityEngine;

namespace Game
{
    public sealed class RadarView : MonoBehaviour
    {
        // Fields
        private UnityEngine.MeshFilter _meshFilter;
        private UnityEngine.MeshRenderer _meshRenderer;
        private UnityEngine.Vector2 _size;
        private UnityEngine.Vector3[] _vertices;
        private UnityEngine.Vector2[] _uvs;
        private float[] _distances;
        private float[] _tempDistances;
        private UnityEngine.Vector3[] _tempVertices;
        private UnityEngine.Vector2[] _tempUvs;
        private float[] _linecastDistances;
        private bool _isEven;
        private UnityEngine.Mesh _mesh;
        private int _layerMask;
        private int _victimLayerMask;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Vector3[] val_28;
            int val_29;
            int val_30;
            if(this._vertices != null)
            {
                    return;
            }
            
            UnityEngine.Vector3[] val_1 = new UnityEngine.Vector3[10];
            val_1[0] = 0;
            val_1[1] = 0;
            val_1[1] = 0;
            val_1[2] = 0;
            UnityEngine.Vector2 val_34 = this._size;
            val_34 = val_34 * (-0.75f);
            val_1[3] = 0;
            val_1[4] = 0;
            UnityEngine.Vector2 val_35 = this._size;
            val_35 = val_35 * (-0.5f);
            val_1[4] = 0;
            val_1[5] = 0;
            UnityEngine.Vector2 val_36 = this._size;
            val_36 = val_36 * (-0.25f);
            val_1[6] = 0;
            val_1[7] = 0;
            val_1[7] = 0;
            val_1[8] = 0;
            UnityEngine.Vector2 val_37 = this._size;
            val_37 = val_37 * 0.25f;
            val_1[9] = 0;
            val_1[10] = 0;
            UnityEngine.Vector2 val_38 = this._size;
            val_38 = val_38 * 0.5f;
            val_1[10] = 0;
            val_1[11] = 0;
            UnityEngine.Vector2 val_39 = this._size;
            val_39 = val_39 * 0.75f;
            val_1[12] = 0;
            val_1[13] = 0;
            val_1[13] = 0;
            val_1[14] = 0;
            this._vertices = val_1;
            UnityEngine.Vector2[] val_2 = new UnityEngine.Vector2[10];
            UnityEngine.Vector2 val_3 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            val_2[0] = val_3.x;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  1f);
            val_2[1] = val_4.x;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  0.125f, y:  1f);
            val_2[2] = val_5.x;
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0.25f, y:  1f);
            val_2[3] = val_6.x;
            UnityEngine.Vector2 val_7 = new UnityEngine.Vector2(x:  0.375f, y:  1f);
            val_2[4] = val_7.x;
            UnityEngine.Vector2 val_8 = new UnityEngine.Vector2(x:  0.5f, y:  1f);
            val_2[5] = val_8.x;
            UnityEngine.Vector2 val_9 = new UnityEngine.Vector2(x:  0.625f, y:  1f);
            val_2[6] = val_9.x;
            UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  0.75f, y:  1f);
            val_2[7] = val_10.x;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  0.875f, y:  1f);
            val_2[8] = val_11.x;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  1f, y:  1f);
            val_2[9] = val_12.x;
            this._uvs = val_2;
            this._distances = new float[0];
            this._tempDistances = new float[0];
            if(this._vertices.Clone() != null)
            {
                    if(X0 == false)
            {
                goto label_28;
            }
            
            }
            
            this._tempVertices = null;
            this._tempUvs = new UnityEngine.Vector2[0];
            this._linecastDistances = new float[0];
            this._layerMask = Utils.LayerUtils.GetRadarAllLayerMask();
            this._victimLayerMask = Utils.LayerUtils.GetVictimLayerMask();
            this._isEven = Utilities.MathUtil.RandomBool;
            int[] val_22 = new int[24];
            val_28 = this._vertices;
            var val_40 = 0;
            label_43:
            val_29 = this._vertices.Length;
            int val_23 = 9 - 8;
            val_30 = (-4294967296) + ((this._vertices.Length) << 32);
            if(val_23 >= (val_30 >> 32))
            {
                goto label_34;
            }
            
            val_22[0] = 0;
            val_22[(val_40 + 1) << 2] = val_23;
            val_29 = val_22.Length;
            val_40 = val_40 + 2;
            val_23 = val_23 + 1;
            val_22[val_40 << 2] = val_23;
            val_30 = this._vertices.Length;
            var val_27 = val_23 - 1;
            this._distances[1] = 1f;
            val_28 = this._vertices;
            var val_28 = 9 + 1;
            var val_29 = 44 + 12;
            var val_30 = ((val_40 + 1) + 1) + 1;
            if(val_28 != null)
            {
                goto label_43;
            }
            
            throw new NullReferenceException();
            label_34:
            int val_31 = val_30 >> 32;
            val_31 = val_28 + (val_31 * 12);
            int val_32 = val_31 + 32;
            int val_41 = this._vertices.Length;
            val_41 = val_41 - 1;
            this._distances[val_41] = 1f;
            int val_33 = new int();
            this._mesh = val_33;
            val_33.vertices = this._vertices;
            this._mesh.uv = this._uvs;
            this._mesh.triangles = val_22;
            this._meshFilter.mesh = this._mesh;
            return;
            label_28:
        }
        public UnityEngine.Collider GetSeenVictim()
        {
            float val_4;
            float val_17;
            float val_18;
            var val_19;
            var val_20;
            UnityEngine.Matrix4x4 val_2 = this.transform.localToWorldMatrix;
            float val_7 = val_4 * 0.5f;
            val_17 = 0f;
            val_18 = 0f;
            float val_8 = 0f * 0.5f;
            UnityEngine.Quaternion val_10 = this.transform.rotation;
            val_19 = 0;
            if((UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, orientation:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.z, z = 0f, w = 0f}, layerMask:  this._victimLayerMask)) == false)
            {
                    return -1617159440;
            }
            
            var val_20 = 0;
            val_20 = 3;
            label_9:
            if(val_20 >= (((-8589934592) + ((this._vertices.Length) << 32)) >> 32))
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_14 = this.transform.position;
            val_17 = val_14.x;
            val_18 = val_14.z;
            UnityEngine.Vector3 val_15 = this.Convert(v:  new UnityEngine.Vector3() {x = this._tempVertices[val_20], y = this._tempVertices[val_20], z = this._tempVertices[val_20]});
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_17, y = val_14.y, z = val_18}, end:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._victimLayerMask)) == true)
            {
                    return -1617159440;
            }
            
            val_20 = val_20 + 1;
            val_20 = val_20 + 12;
            if(this._vertices != null)
            {
                goto label_9;
            }
            
            throw new NullReferenceException();
            label_4:
            val_19 = 0;
            return -1617159440;
        }
        private void LateUpdate()
        {
            float val_6;
            var val_7;
            float val_28;
            var val_29;
            var val_32;
            var val_33;
            float val_35;
            int val_36;
            float val_37;
            if(this._isEven == false)
            {
                goto label_1;
            }
            
            if((UnityEngine.Time.frameCount & 1) == 0)
            {
                    return;
            }
            
            if(this._isEven == true)
            {
                goto label_3;
            }
            
            label_1:
            if((UnityEngine.Time.frameCount & 1) != 0)
            {
                    return;
            }
            
            label_3:
            UnityEngine.Matrix4x4 val_4 = this.transform.localToWorldMatrix;
            float val_9 = val_6 * 0.5f;
            val_28 = 0f;
            val_29 = 0f;
            float val_10 = 0f * 0.5f;
            UnityEngine.Quaternion val_12 = this.transform.rotation;
            if((UnityEngine.Physics.CheckBox(center:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, halfExtents:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, orientation:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.z, z = 0f, w = 0f}, layerMask:  this._layerMask)) != true)
            {
                    if((System.Linq.Enumerable.Sum(source:  this._linecastDistances)) <= 0f)
            {
                    return;
            }
            
            }
            
            var val_35 = 0;
            val_32 = 0;
            val_33 = 1;
            label_30:
            if((val_32 + 1) >= (this._vertices.Length << ))
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_17 = this.transform.position;
            UnityEngine.Vector3 val_18 = this.Convert(v:  new UnityEngine.Vector3() {x = this._vertices[val_35], y = this._vertices[val_35], z = this._vertices[val_35]});
            val_35 = val_17.x;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_35, y = val_17.y, z = val_17.z}, end:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._layerMask)) != false)
            {
                    float val_20 = 0.yAdvance;
                val_36 = this._linecastDistances.Length;
            }
            else
            {
                    val_36 = this._linecastDistances.Length;
                val_35 = 0f;
            }
            
            this._linecastDistances[val_32] = val_35;
            if((UnityEngine.Mathf.Approximately(a:  this._linecastDistances[val_32], b:  this._tempDistances[val_32])) != true)
            {
                    this._tempDistances[val_32] = this._linecastDistances[val_32];
            }
            
            val_32 = val_32 + 1;
            val_35 = val_35 + 12;
            if(this._vertices != null)
            {
                goto label_30;
            }
            
            label_10:
            if((val_33 & 1) != 0)
            {
                    return;
            }
            
            if(this._vertices.Length < 2)
            {
                goto label_33;
            }
            
            label_58:
            val_33 = 0 + 1;
            float val_36 = this._linecastDistances[0];
            if(val_36 <= 0f)
            {
                goto label_39;
            }
            
            if(val_36 >= 0)
            {
                goto label_39;
            }
            
            val_28 = val_36 / this._distances[0];
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0.07425845f, y = 0f, z = 0f}, d:  val_28);
            mem2[0] = val_22.x;
            mem2[0] = val_22.y;
            mem2[0] = val_22.z;
            float val_23 = null / this._size;
            val_23 = val_23 * 0.5f;
            val_23 = val_23 + 0.5f;
            val_7 = 0;
            UnityEngine.Vector2 val_25 = new UnityEngine.Vector2(x:  val_23, y:  val_28 / val_22.z);
            val_37 = val_25.x;
            goto label_49;
            label_39:
            mem2[0] = null;
            mem2[0] = this._vertices[44];
            val_37 = this._uvs[0];
            label_49:
            this._tempUvs[0] = val_37;
            val_32 = 0 + 1;
            var val_27 = 44 + 12;
            if((0 + 2) < (this._vertices.Length << ))
            {
                goto label_58;
            }
            
            label_33:
            val_7 = 0;
            UnityEngine.Vector2 val_28 = new UnityEngine.Vector2(x:  0.5f, y:  0f);
            this._tempUvs[0] = val_28.x;
            this._mesh.uv = this._tempUvs;
            this._mesh.vertices = this._tempVertices;
            this._meshFilter.mesh = this._mesh;
        }
        private UnityEngine.Vector3 Convert(UnityEngine.Vector3 v)
        {
            UnityEngine.Matrix4x4 val_2 = this.transform.localToWorldMatrix;
            return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
        }
        public RadarView()
        {
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  2.5f, y:  4.5f);
            this._size = val_1.x;
        }
    
    }

}
