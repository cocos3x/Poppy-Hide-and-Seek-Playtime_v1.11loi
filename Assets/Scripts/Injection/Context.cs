using UnityEngine;

namespace Injection
{
    public sealed class Context
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type, object> _objectsMap;
        
        // Methods
        public Context()
        {
            System.Collections.Generic.Dictionary<System.Type, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Object>(capacity:  100);
            this._objectsMap = val_1;
            val_1.set_Item(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  this);
        }
        public Context(Injection.Context parent)
        {
            System.Collections.Generic.Dictionary<System.Type, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.Type, System.Object>(dictionary:  parent._objectsMap);
            this._objectsMap = val_1;
            val_1.set_Item(key:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), value:  this);
        }
        public void Install(object[] objects)
        {
            object val_2;
            if(objects.Length < 1)
            {
                    return;
            }
            
            var val_2 = 0;
            do
            {
                val_2 = objects[val_2];
                this._objectsMap.set_Item(key:  val_2.GetType(), value:  val_2);
                val_2 = val_2 + 1;
            }
            while(val_2 < objects.Length);
        
        }
        public void ApplyInstall()
        {
            Injection.Injector val_1 = this.Get<Injection.Injector>();
            Dictionary.ValueCollection.Enumerator<TKey, TValue> val_3 = this._objectsMap.Values.GetEnumerator();
            label_5:
            if(((-1633504472) & 1) == 0)
            {
                goto label_3;
            }
            
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_1.Inject(value:  0);
            goto label_5;
            label_3:
            0.Add(driver:  public System.Void Dictionary.ValueCollection.Enumerator<System.Type, System.Object>::Dispose(), rectTransform:  null, drivenProperties:  null);
        }
        public void Uninstall(object[] objects)
        {
            System.Collections.Generic.Dictionary<System.Type, System.Object> val_3;
            if(objects.Length < 1)
            {
                    return;
            }
            
            var val_4 = 0;
            do
            {
                val_3 = this._objectsMap;
                bool val_2 = val_3.Remove(key:  objects[val_4].GetType());
                val_4 = val_4 + 1;
            }
            while(val_4 < objects.Length);
        
        }
        public T Get<T>()
        {
            var val_3;
            if((this._objectsMap.Item[System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 48})]) != null)
            {
                    if(X0 == true)
            {
                    return (Game.GameModel)val_3;
            }
            
            }
            
            val_3 = 0;
            return (Game.GameModel)val_3;
        }
        public object Get(System.Type type)
        {
            return this._objectsMap.Item[type];
        }
    
    }

}
