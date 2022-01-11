using UnityEngine;

namespace Game
{
    public abstract class BaseUnitView : MonoBehaviour
    {
        // Properties
        public UnityEngine.Vector2 Position { get; set; }
        public float Rotation { get; set; }
        
        // Methods
        public UnityEngine.Vector2 get_Position()
        {
            UnityEngine.Vector3 val_2 = this.transform.position;
            UnityEngine.Vector3 val_4 = this.transform.position;
            UnityEngine.Vector2 val_5 = new UnityEngine.Vector2(x:  val_2.x, y:  val_4.z);
            return new UnityEngine.Vector2() {x = val_5.x, y = val_5.y};
        }
        public void set_Position(UnityEngine.Vector2 value)
        {
            this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        public float get_Rotation()
        {
            UnityEngine.Vector3 val_2 = this.transform.localEulerAngles;
            return (float)val_2.y;
        }
        public void set_Rotation(float value)
        {
            this.transform.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected BaseUnitView()
        {
        
        }
    
    }

}
