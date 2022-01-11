using UnityEngine;
public class CharacterPoints : MonoBehaviour
{
    // Fields
    public string startAnimation;
    public float radius;
    private static int count;
    
    // Methods
    public UnityEngine.Vector3 GetPosition(int idx = -1)
    {
        var val_8;
        if(idx != 1)
        {
                val_8 = null;
            val_8 = null;
            float val_8 = 360f;
            val_8 = val_8 / (float)CharacterPoints.count;
            val_8 = val_8 * (float)idx;
            float val_2 = val_8 * 0.01745329f;
            UnityEngine.Vector3 val_3 = this.transform.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, d:  this.radius);
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
            return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
        }
        
        UnityEngine.Vector3 val_7 = this.transform.position;
        return new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public CharacterPoints()
    {
        this.radius = 1.6f;
        this.startAnimation = "Idle";
    }
    private static CharacterPoints()
    {
        CharacterPoints.count = 6;
    }

}
