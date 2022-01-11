using UnityEngine;
public class RadarController : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform target;
    public UnityEngine.Vector3 offset;
    public UnityEngine.MeshFilter meshFilter;
    public float radius;
    public float offsetAngle;
    public float fov;
    public int resolution;
    private int blockLayermask;
    private float deltaAngle;
    private UnityEngine.Mesh mesh;
    private UnityEngine.Vector3[] vertices;
    private UnityEngine.Vector2[] texCoords;
    private int[] indices;
    private int frameCount;
    
    // Methods
    private void Start()
    {
        int val_10;
        string[] val_1 = new string[2];
        val_10 = val_1.Length;
        val_1[0] = "Wall";
        val_10 = val_1.Length;
        val_1[1] = "Door";
        this.blockLayermask = UnityEngine.LayerMask.GetMask(layerNames:  val_1);
        float val_13 = (float)this.resolution;
        val_13 = this.fov / val_13;
        this.deltaAngle = val_13;
        UnityEngine.Mesh val_3 = new UnityEngine.Mesh();
        this.mesh = val_3;
        val_3.MarkDynamic();
        this.meshFilter.sharedMesh = this.mesh;
        int val_4 = this.resolution + 2;
        this.vertices = new UnityEngine.Vector3[0];
        int val_6 = this.resolution + 2;
        this.texCoords = new UnityEngine.Vector2[0];
        int val_8 = this.resolution + (this.resolution << 1);
        int[] val_9 = new int[0];
        this.indices = val_9;
        if(this.resolution < 1)
        {
                return;
        }
        
        int val_14 = this.vertices.Length;
        int val_15 = 1;
        var val_16 = 2;
        val_14 = val_14 - 1;
        do
        {
            var val_10 = val_16 - 2;
            val_9[val_10 << 2] = val_14;
            val_10 = val_10 + 1;
            this.indices[val_16 - 1] = val_15;
            val_10 = val_10 + 1;
            this.indices[val_16] = val_15 - 1;
            if(val_15 >= this.resolution)
        {
                return;
        }
        
            val_15 = val_15 + 1;
            val_16 = val_16 + 3;
        }
        while(this.indices != null);
        
        throw new NullReferenceException();
    }
    private void Update()
    {
        UnityEngine.Vector3 val_13;
        UnityEngine.Vector3[] val_14;
        float val_15;
        float val_16;
        int val_12 = this.frameCount;
        val_12 = val_12 + 1;
        this.frameCount = val_12;
        if((val_12 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_1 = this.target.localPosition;
        val_13 = this.offset;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_13, y = V11.16B, z = V10.16B});
        UnityEngine.Vector3[] val_13 = this.vertices;
        var val_3 = (-4294967296) + ((this.vertices.Length) << 32);
        val_3 = val_3 >> 32;
        val_13 = val_13 + (val_3 * 12);
        mem2[0] = val_2.x;
        mem2[0] = val_2.y;
        mem2[0] = val_2.z;
        val_14 = this.vertices;
        UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0.5f, y:  0.5f);
        int val_14 = this.vertices.Length;
        val_14 = val_14 - 1;
        this.texCoords[val_14] = val_4.x;
        this.mesh.Clear();
        UnityEngine.Vector3 val_5 = this.target.localEulerAngles;
        if((this.resolution & 2147483648) == 0)
        {
                float val_15 = this.fov;
            val_14 = 1152921504693108736;
            val_15 = val_15 * (-0.5f);
            val_5.y = 90f - val_5.y;
            val_5.y = val_5.y + val_15;
            var val_19 = 0;
            do
        {
            float val_16 = this.deltaAngle;
            val_16 = val_16 * 0f;
            val_16 = (this.offsetAngle + val_5.y) + val_16;
            float val_7 = val_16 * 0.01745329f;
            val_13 = val_7 * this.radius;
            val_7 = val_7 * this.radius;
            val_15 = val_2.x;
            val_16 = val_2.z;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_15, y = val_2.y, z = val_16}, direction:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  this.radius, layerMask:  this.blockLayermask)) != false)
        {
            
        }
        else
        {
                float val_9 = val_2.x + val_13;
            float val_10 = val_2.z + val_7;
            val_15 = val_15;
            val_16 = val_16;
        }
        
            float val_17 = this.radius;
            val_15 = val_15 - val_2.x;
            val_16 = val_16 - val_2.z;
            val_15 = val_15 / val_17;
            val_17 = val_16 / val_17;
            val_15 = val_15 * 0.5f;
            val_17 = val_17 * 0.5f;
            val_15 = val_15 + 0.5f;
            val_17 = val_17 + 0.5f;
            UnityEngine.Vector2 val_11 = new UnityEngine.Vector2(x:  val_15, y:  val_17);
            long val_18 = 0;
            this.texCoords[val_18] = val_11.x;
            val_18 = this.vertices + (val_18 * 12);
            val_19 = val_19 + 1;
            mem2[0] = val_15;
            mem2[0] = val_16;
        }
        while(val_19 <= this.resolution);
        
        }
        
        this.mesh.SetVertices(inVertices:  this.vertices);
        this.mesh.SetUVs(channel:  0, uvs:  this.texCoords);
        this.mesh.SetIndices(indices:  this.indices, topology:  0, submesh:  0);
    }
    public RadarController()
    {
        this.radius = 1f;
        this.fov = 90f;
        this.resolution = 1;
    }

}
