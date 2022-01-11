using UnityEngine;
public class PaintedSubject : MonoBehaviour
{
    // Fields
    public UnityEngine.RenderTexture mainTexture;
    public int textureSize;
    private UnityEngine.Mesh mesh;
    public UnityEngine.RenderTexture targetTexture1;
    public UnityEngine.RenderTexture targetTexture2;
    
    // Methods
    private void Awake()
    {
        UnityEngine.RenderTexture val_1 = new UnityEngine.RenderTexture(width:  this.textureSize, height:  this.textureSize, depth:  0, format:  0);
        this.mainTexture = val_1;
        val_1.wrapMode = 0;
        bool val_2 = this.mainTexture.Create();
        UnityEngine.RenderTexture val_3 = new UnityEngine.RenderTexture(width:  this.textureSize, height:  this.textureSize, depth:  0, format:  0);
        this.targetTexture1 = val_3;
        val_3.wrapMode = 0;
        bool val_4 = this.targetTexture1.Create();
        UnityEngine.RenderTexture val_5 = new UnityEngine.RenderTexture(width:  this.textureSize, height:  this.textureSize, depth:  0, format:  0);
        this.targetTexture2 = val_5;
        val_5.wrapMode = 0;
        bool val_6 = this.targetTexture2.Create();
    }
    private void OnDestroy()
    {
        if(this.mainTexture.IsCreated() != false)
        {
                this.mainTexture.Release();
        }
        
        if(this.targetTexture1.IsCreated() != false)
        {
                this.targetTexture1.Release();
        }
        
        if(this.targetTexture2.IsCreated() == false)
        {
                return;
        }
        
        this.targetTexture2.Release();
    }
    private void Start()
    {
        this.mesh = this.GetComponent<UnityEngine.MeshFilter>().mesh;
        this.GetComponent<UnityEngine.MeshRenderer>().material.SetTexture(name:  "_MainTex", value:  this.mainTexture);
    }
    public void RenderUVSpace(UnityEngine.Material fixUVIslandMaterial)
    {
        float val_3;
        float val_4;
        float val_5;
        float val_6;
        UnityEngine.RenderTexture.active = this.targetTexture1;
        UnityEngine.Matrix4x4 val_2 = UnityEngine.Matrix4x4.identity;
        UnityEngine.Graphics.DrawMeshNow(mesh:  this.mesh, matrix:  new UnityEngine.Matrix4x4() {m00 = val_5, m10 = val_5, m20 = val_5, m30 = val_5, m01 = val_6, m11 = val_6, m21 = val_6, m31 = val_6, m02 = val_3, m12 = val_3, m22 = val_3, m32 = val_3, m03 = val_4, m13 = val_4, m23 = val_4, m33 = val_4});
        UnityEngine.RenderTexture.active = UnityEngine.RenderTexture.active;
        UnityEngine.Graphics.CopyTexture(src:  this.targetTexture1, dst:  this.mainTexture);
    }
    public PaintedSubject()
    {
        this.textureSize = 512;
    }

}
