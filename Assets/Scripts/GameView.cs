using UnityEngine;
public sealed class GameView : MonoBehaviour
{
    // Fields
    public Game.UI.MenuHud MenuHud;
    public GameHud GameHud;
    public Game.UI.UnitsHolderHud UnitsHolderHud;
    public Game.UI.EndGameHud EndGameHud;
    public Game.Camera.CameraFollower CameraFollower;
    public Game.UI.Pool.ComponentPoolFactory CagesPool;
    public UnityEngine.Material[] OutlineMaterials;
    public Game.UI.Pool.ComponentPoolFactory SparksEffectPool;
    public Game.UI.Pool.ComponentPoolFactory StepsEffectPool;
    
    // Methods
    public GameView()
    {
    
    }

}
