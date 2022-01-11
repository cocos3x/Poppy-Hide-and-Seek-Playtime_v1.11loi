using UnityEngine;
public class LevelController : MonoBehaviour
{
    // Fields
    public float duration;
    public float minHiderSeekCount;
    public float offsetY;
    public CharacterPoints characterPoints;
    public UnityEngine.AI.NavMeshData navMeshData;
    public UnityEngine.Material materialWall;
    public UnityEngine.Material materialFloor;
    
    // Methods
    public LevelController()
    {
        this.duration = 30f;
        this.minHiderSeekCount = 6f;
    }

}
