using UnityEngine;

namespace Game
{
    public sealed class CircleRadarView : MonoBehaviour
    {
        // Fields
        private UnityEngine.MeshFilter _meshFilter;
        private UnityEngine.MeshRenderer _meshRenderer;
        private float _radius;
        private int _segments;
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
            float val_29;
            int val_30;
            var val_32;
            var val_33;
            UnityEngine.Vector3[] val_34;
            if(this._vertices != null)
            {
                    return;
            }
            
            int val_1 = this._segments + 1;
            this._vertices = new UnityEngine.Vector3[0];
            int val_3 = this._segments + 1;
            UnityEngine.Vector2[] val_4 = new UnityEngine.Vector2[0];
            this._uvs = val_4;
            val_29 = 0.5f;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_29, y:  0.5f);
            val_4[0] = val_5.x;
            val_30 = this._segments;
            if(val_30 >= 1)
            {
                    var val_35 = 1;
                do
            {
                float val_34 = 1f;
                val_34 = val_34 + (-1f);
                float val_6 = val_34 / (float)val_30;
                float val_7 = UnityEngine.Mathf.Lerp(a:  0f, b:  6.283185f, t:  val_6);
                float val_8 = val_7 * this._radius;
                val_6 = val_7 * this._radius;
                var val_9 = this._vertices + (1 * 12);
                mem2[0] = 0;
                mem2[0] = 0;
                val_29 = (val_7 * 0.5f) + 0.5f;
                UnityEngine.Vector2 val_13 = new UnityEngine.Vector2(x:  val_29, y:  (val_7 * 0.5f) + 0.5f);
                val_35 = val_35 + 1;
                this._uvs[1] = val_13.x;
                val_30 = this._segments;
            }
            while(val_35 <= val_30);
            
            }
            
            this._distances = new float[0];
            this._tempDistances = new float[0];
            if(this._vertices.Clone() != null)
            {
                    if(X0 == false)
            {
                goto label_16;
            }
            
            }
            
            this._tempVertices = null;
            this._tempUvs = new UnityEngine.Vector2[0];
            this._linecastDistances = new float[0];
            this._layerMask = Utils.LayerUtils.GetRadarAllLayerMask();
            this._victimLayerMask = Utils.LayerUtils.GetVictimLayerMask();
            this._isEven = Utilities.MathUtil.RandomBool;
            int val_23 = this._segments + (this._segments << 1);
            int[] val_24 = new int[0];
            val_32 = 0;
            val_33 = 44;
            label_31:
            int val_25 = 9 - 8;
            val_24[0] = 0;
            val_34 = val_32 + 2;
            if(val_25 >= (((-4294967296) + ((this._vertices.Length) << 32)) >> 32))
            {
                goto label_24;
            }
            
            val_24[(val_32 + 1) << 2] = val_25;
            val_25 = val_25 + 1;
            val_24[val_34 << 2] = val_25;
            var val_28 = val_25 - 1;
            val_30 = this._distances;
            val_30[1] = val_29;
            val_34 = this._vertices;
            val_32 = val_32 + 3;
            var val_29 = 9 + 1;
            val_33 = 44 + 12;
            if(val_34 != null)
            {
                goto label_31;
            }
            
            throw new NullReferenceException();
            label_24:
            int val_36 = this._vertices.Length;
            val_36 = val_36 - 1;
            val_24[(val_32 + 1) << 2] = val_36;
            val_24[val_34 << 2] = 1;
            var val_31 = (-4294967296) + ((this._vertices.Length) << 32);
            val_31 = val_31 >> 32;
            val_31 = this._vertices + (val_31 * 12);
            var val_32 = val_31 + 32;
            int val_37 = this._vertices.Length;
            val_37 = val_37 - 1;
            this._distances[val_37] = val_29;
            UnityEngine.Mesh val_33 = new UnityEngine.Mesh();
            this._mesh = val_33;
            val_33.vertices = this._vertices;
            this._mesh.uv = this._uvs;
            this._mesh.triangles = val_24;
            this._meshFilter.mesh = this._mesh;
            return;
            label_16:
        }
        public UnityEngine.Collider GetSeenVictim()
        {
            var val_8;
            UnityEngine.Vector3 val_2 = this.transform.position;
            val_8 = 0;
            if((UnityEngine.Physics.CheckSphere(position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, radius:  this._radius, layerMask:  this._victimLayerMask)) == false)
            {
                    return (UnityEngine.Collider)val_8;
            }
            
            var val_12 = 0;
            var val_11 = 1;
            label_8:
            if(val_11 >= this._vertices.Length)
            {
                goto label_3;
            }
            
            UnityEngine.Vector3 val_5 = this.transform.position;
            UnityEngine.Vector3 val_6 = this.Convert(v:  new UnityEngine.Vector3() {x = this._tempVertices[val_12], y = this._tempVertices[val_12], z = this._tempVertices[val_12]});
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, end:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._victimLayerMask)) == true)
            {
                goto label_7;
            }
            
            val_11 = val_11 + 1;
            val_12 = val_12 + 12;
            if(this._vertices != null)
            {
                goto label_8;
            }
            
            throw new NullReferenceException();
            label_3:
            val_8 = 0;
            return (UnityEngine.Collider)val_8;
            label_7:
            val_8;
            return (UnityEngine.Collider)val_8;
        }
        private void LateUpdate()
        {
            float val_20;
            float val_21;
            var val_22;
            var val_23;
            float val_25;
            int val_26;
            float val_27;
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
            UnityEngine.Vector3 val_4 = this.transform.position;
            val_20 = val_4.x;
            val_21 = val_4.z;
            if((UnityEngine.Physics.CheckSphere(position:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, radius:  this._radius, layerMask:  this._layerMask)) != true)
            {
                    if((System.Linq.Enumerable.Sum(source:  this._linecastDistances)) <= 0f)
            {
                    return;
            }
            
            }
            
            var val_26 = 0;
            val_22 = 0;
            val_23 = 1;
            label_27:
            if((val_22 + 1) >= (this._vertices.Length << ))
            {
                goto label_9;
            }
            
            UnityEngine.Vector3 val_8 = this.Convert(v:  new UnityEngine.Vector3() {x = this._vertices[val_26], y = this._vertices[val_26], z = this._vertices[val_26]});
            val_25 = val_20;
            if((UnityEngine.Physics.Linecast(start:  new UnityEngine.Vector3() {x = val_25, y = val_4.y, z = val_21}, end:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, layerMask:  this._layerMask)) != false)
            {
                    float val_10 = 0.yAdvance;
                val_26 = this._linecastDistances.Length;
            }
            else
            {
                    val_26 = this._linecastDistances.Length;
                val_25 = 0f;
            }
            
            this._linecastDistances[val_22] = val_25;
            if((UnityEngine.Mathf.Approximately(a:  this._linecastDistances[val_22], b:  this._tempDistances[val_22])) != true)
            {
                    this._tempDistances[val_22] = this._linecastDistances[val_22];
            }
            
            val_22 = val_22 + 1;
            val_26 = val_26 + 12;
            if(this._vertices != null)
            {
                goto label_27;
            }
            
            label_9:
            if((val_23 & 1) != 0)
            {
                    return;
            }
            
            if(this._vertices.Length < 2)
            {
                goto label_30;
            }
            
            label_55:
            val_23 = 0 + 1;
            float val_27 = this._linecastDistances[0];
            if(val_27 <= 0f)
            {
                goto label_36;
            }
            
            if(val_27 >= 0)
            {
                goto label_36;
            }
            
            val_20 = val_27 / this._distances[0];
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0.07425845f, y = val_4.y, z = val_21}, d:  val_20);
            mem2[0] = val_12.x;
            mem2[0] = val_12.y;
            mem2[0] = val_12.z;
            float val_29 = this._radius;
            float val_13 = null / val_29;
            val_29 = val_12.z / val_29;
            val_13 = val_13 * 0.5f;
            val_12.z = val_29 * 0.5f;
            UnityEngine.Vector2 val_16 = new UnityEngine.Vector2(x:  val_13 + 0.5f, y:  val_12.z + 0.5f);
            val_27 = val_16.x;
            goto label_46;
            label_36:
            mem2[0] = null;
            mem2[0] = this._vertices[44];
            val_27 = this._uvs[0];
            label_46:
            this._tempUvs[0] = val_27;
            val_22 = 0 + 1;
            var val_18 = 44 + 12;
            if((0 + 2) < (this._vertices.Length << ))
            {
                goto label_55;
            }
            
            label_30:
            UnityEngine.Vector2 val_19 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
            this._tempUvs[0] = val_19.x;
            this._mesh.uv = this._tempUvs;
            this._mesh.vertices = this._tempVertices;
            this._meshFilter.mesh = this._mesh;
        }
        private UnityEngine.Vector3 Convert(UnityEngine.Vector3 v)
        {
            UnityEngine.Matrix4x4 val_2 = this.transform.localToWorldMatrix;
            return new UnityEngine.Vector3() {x = v.x, y = v.y, z = v.z};
        }
        public CircleRadarView()
        {
            this._radius = 3f;
            this._segments = 10;
        }
    
    }

}
