using UnityEngine;
public class SaveRenderTexture : MonoBehaviour
{
    // Fields
    public UnityEngine.Camera camera;
    public int width;
    public int height;
    private UnityEngine.RenderTexture renderTexture;
    
    // Methods
    public void Awake()
    {
        this.renderTexture = new UnityEngine.RenderTexture(width:  this.width, height:  this.height, depth:  32);
    }
    public void OnDestroy()
    {
        if(this.renderTexture != null)
        {
                this.renderTexture.Release();
            return;
        }
        
        throw new NullReferenceException();
    }
    public void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  32)) == false)
        {
                return;
        }
        
        this.SaveTexture();
    }
    public void SaveTexture()
    {
        this.camera.targetTexture = this.renderTexture;
        this.camera.Render();
        this.camera.targetTexture = 0;
        System.IO.File.WriteAllBytes(path:  "D:/SavedScreen.png", bytes:  UnityEngine.ImageConversion.EncodeToPNG(tex:  this.camera.toTexture2D(rTex:  this.renderTexture)));
    }
    private UnityEngine.Texture2D toTexture2D(UnityEngine.RenderTexture rTex)
    {
        UnityEngine.Texture2D val_1 = new UnityEngine.Texture2D(width:  rTex, height:  rTex, textureFormat:  3, mipChain:  false);
        UnityEngine.RenderTexture.active = rTex;
        val_1.ReadPixels(source:  new UnityEngine.Rect() {m_XMin = 0f, m_YMin = 0f, m_Width = 0f, m_Height = 0f}, destX:  0, destY:  0);
        val_1.Apply();
        return val_1;
    }
    public SaveRenderTexture()
    {
        this.width = 1080;
        this.height = 1920;
    }

}
