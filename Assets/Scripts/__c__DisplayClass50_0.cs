using UnityEngine;
private sealed class GameFlow.<>c__DisplayClass50_0
{
    // Fields
    public float colorTweenTime;
    public UnityEngine.Color colorStartBackground;
    public UnityEngine.Color colorEndBackGround;
    public UnityEngine.Color colorStartFog;
    public UnityEngine.Color colorEndFog;
    public GameFlow <>4__this;
    
    // Methods
    public GameFlow.<>c__DisplayClass50_0()
    {
    
    }
    internal float <LoadLevel>b__0()
    {
        return (float)this.colorTweenTime;
    }
    internal void <LoadLevel>b__1(float value)
    {
        this.colorTweenTime = value;
    }
    internal void <LoadLevel>b__2()
    {
        float val_7 = this.colorTweenTime;
        val_7 = 1f - val_7;
        UnityEngine.Color val_1 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = this.colorStartBackground}, b:  val_7);
        UnityEngine.Color val_2 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = this.colorEndBackGround, g = val_1.g, b = val_1.b, a = V5.16B}, b:  this.colorTweenTime);
        UnityEngine.Color val_3 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = val_1.r, g = val_1.g, b = val_1.b, a = val_1.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
        this.<>4__this.materialBackground.color = new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a};
        float val_8 = this.colorTweenTime;
        val_8 = 1f - val_8;
        UnityEngine.Color val_4 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = this.colorStartFog, g = val_3.g, b = val_3.b, a = val_3.a}, b:  val_8);
        UnityEngine.Color val_5 = UnityEngine.Color.op_Multiply(a:  new UnityEngine.Color() {r = this.colorEndFog, g = val_4.g, b = val_4.b, a = val_2.g}, b:  this.colorTweenTime);
        UnityEngine.Color val_6 = UnityEngine.Color.op_Addition(a:  new UnityEngine.Color() {r = val_4.r, g = val_4.g, b = val_4.b, a = val_4.a}, b:  new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a});
        UnityEngine.RenderSettings.fogColor = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
    }

}
