using UnityEngine;
public class DepthTest : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera camera;
    public UnityEngine.RenderTexture depthTexture;
    public int textureWith;
    public int textureHeight;
    public float fov;
    public UnityEngine.Shader depthReplacementShader;
    public UnityEngine.Material materialView;
    public UnityEngine.UI.RawImage rawImage;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  this.textureWith, height:  this.textureHeight, depth:  16, format:  14);
        this.depthTexture = val_1;
        val_1.filterMode = 1;
        bool val_2 = this.depthTexture.Create();
        this.rawImage.texture = this.depthTexture;
        this.camera.targetTexture = this.depthTexture;
        if((UnityEngine.Object.op_Implicit(exists:  this.depthReplacementShader)) != false)
        {
                this.camera.SetReplacementShader(shader:  this.depthReplacementShader, replacementTag:  "");
        }
        
        this.materialView.SetTexture(name:  "_DepthTex", value:  this.depthTexture);
    }
    private void OnDestroy()
    {
        if(this.depthTexture.IsCreated() == false)
        {
                return;
        }
        
        this.depthTexture.Release();
    }
    private void Start()
    {
    
    }
    private void Update()
    {
        float val_7;
        float val_8;
        float val_9;
        float val_10;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_20;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        UnityEngine.RenderTexture.active = this.depthTexture;
        UnityEngine.Vector3 val_3 = this.camera.transform.position;
        UnityEngine.Vector3 val_5 = this.camera.transform.forward;
        this.materialView.SetVector(name:  "_CamPos", value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_26 = 0.01745329f;
        val_26 = this.fov * val_26;
        this.materialView.SetFloat(name:  "_FovCosine", value:  val_26);
        UnityEngine.Matrix4x4 val_6 = this.camera.worldToCameraMatrix;
        this.materialView.SetMatrix(name:  "_V_Mat", value:  new UnityEngine.Matrix4x4() {m00 = val_9, m10 = val_9, m20 = val_9, m30 = val_9, m01 = val_10, m11 = val_10, m21 = val_10, m31 = val_10, m02 = val_7, m12 = val_7, m22 = val_7, m32 = val_7, m03 = val_8, m13 = val_8, m23 = val_8, m33 = val_8});
        UnityEngine.Matrix4x4 val_11 = this.camera.projectionMatrix;
        UnityEngine.Matrix4x4 val_12 = this.camera.worldToCameraMatrix;
        UnityEngine.Matrix4x4 val_21 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_15, m10 = val_15, m20 = val_15, m30 = val_15, m01 = val_16, m11 = val_16, m21 = val_16, m31 = val_16, m02 = val_13, m12 = val_13, m22 = val_13, m32 = val_13, m03 = val_14, m13 = val_14, m23 = val_14, m33 = val_14}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_19, m10 = val_19, m20 = val_19, m30 = val_19, m01 = val_20, m11 = val_20, m21 = val_20, m31 = val_20, m02 = val_17, m12 = val_17, m22 = val_17, m32 = val_17, m03 = val_18, m13 = val_18, m23 = val_18, m33 = val_18});
        this.materialView.SetMatrix(name:  "_VP_Mat", value:  new UnityEngine.Matrix4x4() {m00 = val_24, m10 = val_24, m20 = val_24, m30 = val_24, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_22, m12 = val_22, m22 = val_22, m32 = val_22, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23});
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
    }
    public DepthTest()
    {
        this.fov = 60f;
        this.textureWith = 512;
        this.textureHeight = 256;
    }

}
