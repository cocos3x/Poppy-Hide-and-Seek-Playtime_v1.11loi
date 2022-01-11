using UnityEngine;
public class Painter : MonoBehaviour
{
    // Fields
    public UnityEngine.Material uvSpaceMaterial;
    public UnityEngine.Material fixUVIslandMaterial;
    public float brushSize;
    public UnityEngine.Color color;
    public System.Collections.Generic.List<PaintedSubject> subjects;
    public UnityEngine.RenderTexture depthTexture;
    public int textureSize;
    public UnityEngine.Texture2D brushTexture;
    public UnityEngine.Shader depthReplacementShader;
    private UnityEngine.Camera camera;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  this.textureSize, height:  this.textureSize, depth:  16, format:  14);
        this.depthTexture = val_1;
        bool val_2 = val_1.Create();
        UnityEngine.Camera val_3 = UnityEngine.Camera.main;
        UnityEngine.Camera val_5 = this.gameObject.AddComponent<UnityEngine.Camera>();
        this.camera = val_5;
        val_5.targetTexture = this.depthTexture;
        UnityEngine.Vector3 val_8 = val_3.transform.position;
        this.camera.transform.position = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_11 = val_3.transform.rotation;
        this.camera.transform.rotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        this.camera.nearClipPlane = val_3.nearClipPlane;
        this.camera.farClipPlane = val_3.farClipPlane;
        this.camera.fieldOfView = val_3.fieldOfView;
        this.camera.clearFlags = 2;
        UnityEngine.Color val_15 = UnityEngine.Color.blue;
        this.camera.backgroundColor = new UnityEngine.Color() {r = val_15.r, g = val_15.g, b = val_15.b, a = val_15.a};
        if((public UnityEngine.Camera UnityEngine.GameObject::AddComponent<UnityEngine.Camera>()) == 0)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
        this.camera.cullingMask = 1 << gameObject.layer;
        if((UnityEngine.Object.op_Implicit(exists:  this.depthReplacementShader)) != false)
        {
                this.camera.SetReplacementShader(shader:  this.depthReplacementShader, replacementTag:  "");
        }
        
        this.camera.enabled = false;
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
        if((UnityEngine.Input.GetMouseButton(button:  0)) == false)
        {
                return;
        }
        
        this.Paint();
    }
    private void RenderToDepthTexture()
    {
        UnityEngine.RenderTexture.active = this.depthTexture;
        this.camera.Render();
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
    }
    public void Paint()
    {
        float val_16;
        float val_17;
        float val_18;
        float val_19;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        var val_34;
        this.RenderToDepthTexture();
        UnityEngine.Vector3 val_1 = UnityEngine.Input.mousePosition;
        float val_34 = val_1.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Input.mousePosition;
        float val_35 = val_2.y;
        float val_4 = this.brushSize * 0.5f;
        val_4 = val_34 - val_4;
        val_34 = val_4 / (float)UnityEngine.Screen.width;
        float val_36 = this.brushSize;
        float val_6 = this.brushSize * 0.5f;
        val_6 = val_35 - val_6;
        val_35 = val_6 / (float)UnityEngine.Screen.height;
        float val_37 = this.brushSize;
        val_36 = val_36 / (float)UnityEngine.Screen.width;
        val_37 = val_37 / (float)UnityEngine.Screen.height;
        float val_10 = UnityEngine.Mathf.Max(a:  0f, b:  val_35);
        float val_12 = UnityEngine.Mathf.Min(a:  1f, b:  val_34 + val_36);
        float val_14 = UnityEngine.Mathf.Min(a:  1f, b:  val_35 + val_37);
        this.uvSpaceMaterial.SetTexture(name:  "_BrushTex", value:  this.brushTexture);
        this.uvSpaceMaterial.SetTexture(name:  "_DepthTex", value:  this.depthTexture);
        UnityEngine.Matrix4x4 val_15 = this.camera.projectionMatrix;
        this.uvSpaceMaterial.SetMatrix(name:  "_PMatrix", value:  new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17});
        this.uvSpaceMaterial.SetVector(name:  "_BrushUVRect", value:  new UnityEngine.Vector4() {x = val_34, y = val_35, z = val_36, w = val_37});
        this.uvSpaceMaterial.SetVector(name:  "_BrushUVClamp", value:  new UnityEngine.Vector4() {x = UnityEngine.Mathf.Max(a:  0f, b:  val_34), y = val_10, z = val_12, w = val_14});
        this.uvSpaceMaterial.SetColor(name:  "_BrushColor", value:  new UnityEngine.Color() {r = this.color, g = val_10, b = val_12, a = val_14});
        val_34 = 4;
        do
        {
            var val_20 = val_34 - 4;
            if(val_20 >= "_BrushColor")
        {
                return;
        }
        
            if("_BrushColor" <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            this.uvSpaceMaterial.SetTexture(name:  "_MainTex", value:  System.Boolean UnityEngine.Playables.PlayableHandle::IsPlayableOfType<UnityEngine.Animations.AnimationOffsetPlayable>().__il2cppRuntimeField_18);
            if(val_21 <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Matrix4x4 val_23 = this.camera.worldToCameraMatrix.m02.transform.localToWorldMatrix;
            this.uvSpaceMaterial.SetMatrix(name:  "_MVMatrix", value:  new UnityEngine.Matrix4x4() {m00 = val_31, m10 = val_31, m20 = val_31, m30 = val_31, m01 = val_32, m11 = val_32, m21 = val_32, m31 = val_32, m02 = val_29, m12 = val_29, m22 = val_29, m32 = val_29, m03 = val_30, m13 = val_30, m23 = val_30, m33 = val_30});
            bool val_33 = this.uvSpaceMaterial.SetPass(pass:  0);
            if(val_28 <= val_20)
        {
                System.ThrowHelper.ThrowArgumentOutOfRangeException();
        }
        
            UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_18, m10 = val_18, m20 = val_18, m30 = val_18, m01 = val_19, m11 = val_19, m21 = val_19, m31 = val_19, m02 = val_16, m12 = val_16, m22 = val_16, m32 = val_16, m03 = val_17, m13 = val_17, m23 = val_17, m33 = val_17}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_26, m10 = val_26, m20 = val_26, m30 = val_26, m01 = val_27, m11 = val_27, m21 = val_27, m31 = val_27, m02 = val_24, m12 = val_24, m22 = val_24, m32 = val_24, m03 = val_25, m13 = val_25, m23 = val_25, m33 = val_25}).m02.RenderUVSpace(fixUVIslandMaterial:  0);
            val_34 = val_34 + 1;
        }
        while(this.subjects != null);
        
        throw new NullReferenceException();
    }
    public Painter()
    {
        this.brushSize = 50f;
        this.textureSize = 1024;
    }

}
