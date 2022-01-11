using UnityEngine;
public class CameraDumping : MonoBehaviour
{
    // Fields
    public UnityEngine.Shader replacementShader;
    public UnityEngine.RenderTexture renderTexture;
    public UnityEngine.Mesh mesh;
    public UnityEngine.Material material;
    private UnityEngine.Camera camera;
    public bool drawNow;
    
    // Methods
    private void Start()
    {
        UnityEngine.Camera val_1 = this.GetComponent<UnityEngine.Camera>();
        this.camera = val_1;
        val_1.nearClipPlane = 0.01f;
        this.camera.enabled = false;
        UnityEngine.RenderTexture val_2 = new UnityEngine.RenderTexture(width:  1024, height:  1024, depth:  0, format:  0);
        this.renderTexture = val_2;
        bool val_3 = val_2.Create();
    }
    private void OnDestroy()
    {
        if(this.renderTexture != null)
        {
                this.renderTexture.Release();
            return;
        }
        
        throw new NullReferenceException();
    }
    private void Update()
    {
        float val_10;
        float val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        float val_20;
        float val_21;
        float val_22;
        float val_23;
        float val_24;
        float val_25;
        float val_26;
        float val_27;
        float val_29;
        float val_30;
        float val_31;
        float val_32;
        if((UnityEngine.Input.GetKeyDown(key:  116)) != false)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.replacementShader)) != false)
        {
                this.GetComponent<UnityEngine.Camera>().SetReplacementShader(shader:  this.replacementShader, replacementTag:  "RenderType");
        }
        
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  115)) != false)
        {
                this.SaveRenderTextureToFile(filePath:  "F:/save.png");
        }
        
        UnityEngine.RenderTexture.active = this.renderTexture;
        UnityEngine.Color val_6 = UnityEngine.Color.blue;
        UnityEngine.GL.Clear(clearDepth:  true, clearColor:  true, backgroundColor:  new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a});
        bool val_7 = this.material.SetPass(pass:  0);
        UnityEngine.Matrix4x4 val_8 = this.camera.projectionMatrix;
        UnityEngine.Matrix4x4 val_9 = this.camera.cameraToWorldMatrix;
        UnityEngine.Matrix4x4 val_18 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_12, m10 = val_12, m20 = val_12, m30 = val_12, m01 = val_13, m11 = val_13, m21 = val_13, m31 = val_13, m02 = val_10, m12 = val_10, m22 = val_10, m32 = val_10, m03 = val_11, m13 = val_11, m23 = val_11, m33 = val_11}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_16, m10 = val_16, m20 = val_16, m30 = val_16, m01 = val_17, m11 = val_17, m21 = val_17, m31 = val_17, m02 = val_14, m12 = val_14, m22 = val_14, m32 = val_14, m03 = val_15, m13 = val_15, m23 = val_15, m33 = val_15});
        UnityEngine.Matrix4x4 val_19 = UnityEngine.Matrix4x4.identity;
        UnityEngine.Matrix4x4 val_28 = UnityEngine.Matrix4x4.op_Multiply(lhs:  new UnityEngine.Matrix4x4() {m00 = val_22, m10 = val_22, m20 = val_22, m30 = val_22, m01 = val_23, m11 = val_23, m21 = val_23, m31 = val_23, m02 = val_20, m12 = val_20, m22 = val_20, m32 = val_20, m03 = val_21, m13 = val_21, m23 = val_21, m33 = val_21}, rhs:  new UnityEngine.Matrix4x4() {m00 = val_26, m10 = val_26, m20 = val_26, m30 = val_26, m01 = val_27, m11 = val_27, m21 = val_27, m31 = val_27, m02 = val_24, m12 = val_24, m22 = val_24, m32 = val_24, m03 = val_25, m13 = val_25, m23 = val_25, m33 = val_25});
        UnityEngine.Graphics.DrawMeshNow(mesh:  this.mesh, matrix:  new UnityEngine.Matrix4x4() {m00 = val_31, m10 = val_31, m20 = val_31, m30 = val_31, m01 = val_32, m11 = val_32, m21 = val_32, m31 = val_32, m02 = val_29, m12 = val_29, m22 = val_29, m32 = val_29, m03 = val_30, m13 = val_30, m23 = val_30, m33 = val_30});
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
    }
    private void SaveRenderTextureToFile(string filePath)
    {
        UnityEngine.RenderTexture.active = this.renderTexture;
        UnityEngine.Texture2D val_2 = new UnityEngine.Texture2D(width:  this.renderTexture, height:  this.renderTexture);
        val_2.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        val_2.Apply();
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
        System.IO.File.WriteAllBytes(path:  filePath, bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  val_2));
    }
    public CameraDumping()
    {
    
    }

}
