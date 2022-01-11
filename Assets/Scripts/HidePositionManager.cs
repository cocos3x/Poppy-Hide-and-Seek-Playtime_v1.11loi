using UnityEngine;
public class HidePositionManager : MonoBehaviour
{
    // Fields
    public static HidePositionManager current;
    private UnityEngine.Vector3[] positions;
    
    // Methods
    private void Awake()
    {
        var val_9;
        HidePositionManager.current = this;
        val_9 = this.transform.childCount;
        var val_9 = null;
        UnityEngine.Vector3[] val_3 = new UnityEngine.Vector3[0];
        int val_4 = val_9 - 1;
        this.positions = val_3;
        if(<0)
        {
                return;
        }
        
        val_9 = val_9 + (val_4 << );
        val_4 = val_9 << 2;
        do
        {
            UnityEngine.Vector3 val_7 = this.transform.GetChild(index:  (long)val_4).position;
            val_9 = (long)val_4 - 1;
            val_3[val_4] = val_7;
            val_3[val_4] = val_7.y;
            val_3[val_4] = val_7.z;
            if((val_9 & 2147483648) != 0)
        {
                return;
        }
        
            val_4 = val_4 - 12;
        }
        while(this.transform != null);
        
        throw new NullReferenceException();
    }
    public UnityEngine.Vector3 GetRandomPoint(out int resultIndex, int excludeIndex = -1)
    {
        do
        {
            int val_2 = UnityEngine.Random.Range(min:  0, max:  this.positions.Length - 1);
        }
        while(val_2 == excludeIndex);
        
        resultIndex = val_2;
        UnityEngine.Vector3[] val_3 = this.positions;
        val_3 = val_3 + ((long)val_2 * 12);
        return new UnityEngine.Vector3() {x = ((long)(int)(val_2) * 12) + this.positions + 32, y = ((long)(int)(val_2) * 12) + this.positions + 32 + 4, z = ((long)(int)(val_2) * 12) + this.positions + 40};
    }
    public HidePositionManager()
    {
    
    }

}
