using UnityEngine;

namespace Game.UI
{
    public sealed class UnitsHolderHud : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject[] _greenHolders;
        private UnityEngine.GameObject[] _yellowHolders;
        private TMPro.TextMeshProUGUI _txtOnlyOneLeft;
        private int _count;
        private int _maxCount;
        private bool _isGreen;
        
        // Properties
        public int Count { get; set; }
        
        // Methods
        public int get_Count()
        {
            return (int)this._count;
        }
        public void set_Count(int value)
        {
            var val_5;
            this._count = value;
            UnityEngine.GameObject val_1 = this._txtOnlyOneLeft.gameObject;
            int val_5 = this._count;
            val_5 = val_5 + 1;
            if(val_5 != this._maxCount)
            {
                goto label_1;
            }
            
            var val_2 = (this._isGreen == true) ? 1 : 0;
            if(val_1 != null)
            {
                goto label_2;
            }
            
            label_1:
            val_5 = 0;
            label_2:
            val_1.SetActive(value:  false);
            var val_3 = (this._isGreen == false) ? 32 : 24;
            var val_6 = 0;
            Game.UI.__il2cppRuntimeField_20.SetActive(value:  (val_6 < this._count) ? 1 : 0);
            val_6 = val_6 + 1;
        }
        public void SwitchToMode(bool isGreen, int maxCount)
        {
            this._isGreen = false;
            this.Count = 0;
            this._isGreen = true;
            this.Count = 0;
            this._isGreen = isGreen;
            this._maxCount = maxCount;
            var val_7 = 0;
            do
            {
                if(val_7 >= this._greenHolders.Length)
            {
                    return;
            }
            
                this._greenHolders[val_7].transform.parent.gameObject.SetActive(value:  (val_7 < maxCount) ? 1 : 0);
                val_7 = val_7 + 1;
            }
            while(this._greenHolders != null);
            
            throw new NullReferenceException();
        }
        public UnitsHolderHud()
        {
        
        }
    
    }

}
