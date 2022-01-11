using UnityEngine;

namespace Game.Config
{
    [Serializable]
    public sealed class GameConfig
    {
        // Fields
        public const string Name = "config";
        public readonly System.Collections.Generic.Dictionary<Game.Config.GameParam, object> ParamsMap;
        
        // Methods
        public GameConfig()
        {
            System.Collections.Generic.Dictionary<Game.Config.GameParam, System.Object> val_1 = new System.Collections.Generic.Dictionary<Game.Config.GameParam, System.Object>();
            this.ParamsMap = val_1;
            val_1.set_Item(key:  0, value:  1);
            this.ParamsMap.set_Item(key:  1, value:  10);
            this.ParamsMap.set_Item(key:  2, value:  300);
            this.ParamsMap.set_Item(key:  3, value:  5f);
            this.ParamsMap.set_Item(key:  5, value:  1f);
            this.ParamsMap.set_Item(key:  9, value:  10f);
            this.ParamsMap.set_Item(key:  10, value:  10f);
            this.ParamsMap.set_Item(key:  11, value:  5);
            this.ParamsMap.set_Item(key:  12, value:  3);
            this.ParamsMap.set_Item(key:  4, value:  3);
            this.ParamsMap.set_Item(key:  6, value:  60);
            this.ParamsMap.set_Item(key:  7, value:  88);
            this.ParamsMap.set_Item(key:  8, value:  15);
        }
        public float GetValue(Game.Config.GameParam param)
        {
            object val_1 = 0;
            if((this.ParamsMap.TryGetValue(key:  param, value: out  val_1)) != false)
            {
                    return (float)System.Convert.ToSingle(value:  val_1);
            }
            
            mem2[0] = null;
            throw new System.Collections.Generic.KeyNotFoundException(message:  (???) - 20.ToString());
        }
        public UnityEngine.Vector3 GetV3Value(Game.Config.GameParam param)
        {
            object val_7;
            UnityEngine.DrivenTransformProperties val_8;
            object val_1 = 0;
            val_8 = public System.Boolean System.Collections.Generic.Dictionary<Game.Config.GameParam, System.Object>::TryGetValue(Game.Config.GameParam key, out System.Object value);
            if((this.ParamsMap.TryGetValue(key:  param, value: out  val_1)) != false)
            {
                    if(1179403647 != null)
            {
                    if((this.TryParseVector3(value:  val_1, vector: out  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) != false)
            {
                    val_7 = 0;
                val_8 = public System.Void System.Collections.Generic.Dictionary<Game.Config.GameParam, System.Object>::set_Item(Game.Config.GameParam key, System.Object value);
                this.ParamsMap.set_Item(key:  param, value:  0);
            }
            
            }
            
                0.Add(driver:  null, rectTransform:  0, drivenProperties:  val_8);
                return new UnityEngine.Vector3() {x = -8.826844E-19f, y = 2.524355E-29f, z = mem[1152921507316515560]};
            }
            
            mem2[0] = null;
            throw new System.Collections.Generic.KeyNotFoundException(message:  (???) - 20.ToString());
        }
        public bool TryParseVector3(string value, out UnityEngine.Vector3 vector)
        {
            var val_20;
            string val_21;
            var val_22;
            val_20 = value;
            if((val_20.Contains(value:  "(")) != false)
            {
                    val_20 = val_20.Replace(oldValue:  "(", newValue:  ":").Replace(oldValue:  ",", newValue:  ",:").Replace(oldValue:  ")", newValue:  System.String.alignConst).Replace(oldValue:  " ", newValue:  System.String.alignConst);
            }
            
            val_21 = 1152921504618881024;
            System.String[] val_10 = Utilities.StringUtil.Split(strValue:  val_20.Replace(oldValue:  "\r", newValue:  System.String.alignConst).Replace(oldValue:  "\n", newValue:  System.String.alignConst).Replace(oldValue:  "}", newValue:  System.String.alignConst).Replace(oldValue:  "\"", newValue:  System.String.alignConst), splitValue:  ",");
            if((System.Single.TryParse(s:  Utilities.StringUtil.Split(strValue:  val_10[0], splitValue:  ":")[1], result: out  float val_12 = -9.138869E-19f)) == false)
            {
                goto label_22;
            }
            
            val_21 = val_10[1];
            if((System.Single.TryParse(s:  Utilities.StringUtil.Split(strValue:  val_21, splitValue:  ":")[1], result: out  float val_15 = -9.138865E-19f)) == false)
            {
                goto label_22;
            }
            
            val_22 = System.Single.TryParse(s:  Utilities.StringUtil.Split(strValue:  val_10[2], splitValue:  ":")[1], result: out  float val_18 = -9.138853E-19f);
            goto label_28;
            label_22:
            val_22 = 0;
            label_28:
            vector.z = 0f;
            vector.x = 0f;
            vector.y = 0f;
            return (bool)val_22 & 1;
        }
    
    }

}
