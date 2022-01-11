using UnityEngine;
public class RadarVisualizer : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 offset;
    public UnityEngine.Camera depthRenderCamera;
    public UnityEngine.RenderTexture depthTexture;
    public int textureWith;
    public int textureHeight;
    public float fov;
    public UnityEngine.Shader depthReplacementShader;
    public UnityEngine.Material materialView;
    public UnityEngine.Renderer renderer1;
    public UnityEngine.Renderer renderer2;
    private static int shaderId_CamPos;
    private static int shaderId_DepthTex;
    private static int shaderId_FovCosine;
    private static int shaderId_V_Mat;
    private static int shaderId_VP_Mat;
    private bool isTargetAvailable;
    private UnityEngine.Transform target;
    
    // Methods
    public void SetTarget(UnityEngine.Transform target)
    {
        if((UnityEngine.Object.op_Implicit(exists:  target)) == false)
        {
                return;
        }
        
        this.target = target;
        this.isTargetAvailable = true;
    }
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  this.textureWith, height:  this.textureHeight, depth:  16, format:  14);
        this.depthTexture = val_1;
        val_1.filterMode = 1;
        bool val_2 = this.depthTexture.Create();
        this.depthRenderCamera.targetTexture = this.depthTexture;
        if((UnityEngine.Object.op_Implicit(exists:  this.depthReplacementShader)) != false)
        {
                this.depthRenderCamera.SetReplacementShader(shader:  this.depthReplacementShader, replacementTag:  "");
        }
        
        this.materialView.SetTexture(nameID:  RadarVisualizer.shaderId_DepthTex, value:  this.depthTexture);
        this.materialView.SetMaterialProperty(renderer:  this.renderer1, property:  "_Visible", value:  1f);
        this.materialView.SetMaterialProperty(renderer:  this.renderer2, property:  "_Visible", value:  0f);
    }
    public void SetMaterialProperty(UnityEngine.Renderer renderer, string property, float value)
    {
        UnityEngine.MaterialPropertyBlock val_1 = new UnityEngine.MaterialPropertyBlock();
        renderer.GetPropertyBlock(properties:  val_1);
        val_1.SetFloat(name:  property, value:  value);
        renderer.SetPropertyBlock(properties:  val_1);
    }
    private void OnDestroy()
    {
        if(this.depthTexture.IsCreated() == false)
        {
                return;
        }
        
        this.depthTexture.Release();
    }
    private void Update()
    {
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        var val_31;
        if(this.isTargetAvailable != false)
        {
                UnityEngine.Vector3 val_2 = this.target.localPosition;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, b:  new UnityEngine.Vector3() {x = this.offset, y = V11.16B, z = V10.16B});
            this.transform.localPosition = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            UnityEngine.Quaternion val_5 = this.target.localRotation;
            this.transform.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        }
        
        UnityEngine.RenderTexture.active = this.depthTexture;
        UnityEngine.Vector3 val_8 = this.depthRenderCamera.transform.position;
        UnityEngine.Vector3 val_10 = this.depthRenderCamera.transform.forward;
        val_31 = null;
        val_31 = null;
        this.materialView.SetVector(nameID:  RadarVisualizer.shaderId_CamPos, value:  new UnityEngine.Vector4() {x = 0f, y = 0f, z = 0f, w = 0f});
        float val_31 = 0.01745329f;
        val_31 = this.fov * val_31;
        this.materialView.SetFloat(nameID:  RadarVisualizer.shaderId_FovCosine, value:  val_31);
        UnityEngine.Matrix4x4 val_11 = this.depthRenderCamera.worldToCameraMatrix;
        this.materialView.SetMatrix(nameID:  RadarVisualizer.shaderId_V_Mat, value:  new UnityEngine.Matrix4x4() {m00 = val_14, m10 = val_14, m20 = val_14, m30 = val_14, m01 = val_15, m11 = val_15, m21 = val_15, m31 = val_15, m02 = val_12, m12 = val_12, m22 = val_12, m32 = val_12, m03 = val_13, m13 = val_13, m23 = val_13, m33 = val_13});
        UnityEngine.Matrix4x4 val_16 = this.depthRenderCamera.projectionMatrix;
        UnityEngine.Matrix4x4 val_17 = this.depthRenderCamera.worldToCameraMatrix;
        UnityEngine.Matrix4x4 val_26 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_20, m10 = val_20, m20 = val_20, m30 = val_20, m01 = val_21, m11 = val_21, m21 = val_21, m31 = val_21, m02 = val_18, m12 = val_18, m22 = val_18, m32 = val_18, m03 = val_19, m13 = val_19, m23 = val_19, m33 = val_19}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_24, m10 = val_24, m20 = val_24, m30 = val_24, m01 = val_25, m11 = val_25, m21 = val_25, m31 = val_25, m02 = val_22, m12 = val_22, m22 = val_22, m32 = val_22, m03 = val_23, m13 = val_23, m23 = val_23, m33 = val_23});
        this.materialView.SetMatrix(nameID:  RadarVisualizer.shaderId_VP_Mat, value:  new UnityEngine.Matrix4x4() {m00 = val_29, m10 = val_29, m20 = val_29, m30 = val_29, m01 = val_30, m11 = val_30, m21 = val_30, m31 = val_30, m02 = val_27, m12 = val_27, m22 = val_27, m32 = val_27, m03 = val_28, m13 = val_28, m23 = val_28, m33 = val_28});
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
    }
    public RadarVisualizer()
    {
        this.fov = 60f;
        this.textureWith = 512;
        this.textureHeight = 256;
    }
    private static RadarVisualizer()
    {
        RadarVisualizer.shaderId_CamPos = UnityEngine.Shader.PropertyToID(name:  "_CamPos");
        RadarVisualizer.shaderId_DepthTex = UnityEngine.Shader.PropertyToID(name:  "_DepthTex");
        RadarVisualizer.shaderId_FovCosine = UnityEngine.Shader.PropertyToID(name:  "_FovCosine");
        RadarVisualizer.shaderId_V_Mat = UnityEngine.Shader.PropertyToID(name:  "_V_Mat");
        RadarVisualizer.shaderId_VP_Mat = UnityEngine.Shader.PropertyToID(name:  "_VP_Mat");
    }

}
