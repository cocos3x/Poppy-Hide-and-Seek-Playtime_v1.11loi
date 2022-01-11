using UnityEngine;

namespace Injection
{
    public sealed class Injector
    {
        // Fields
        private readonly System.Collections.Generic.Dictionary<System.Type, System.Reflection.FieldInfo[]> _fieldsMap;
        private readonly Injection.Context _context;
        
        // Methods
        public Injector(Injection.Context context)
        {
            this._context = context;
            this._fieldsMap = new System.Collections.Generic.Dictionary<System.Type, System.Reflection.FieldInfo[]>(capacity:  100);
        }
        public void Inject(object value)
        {
            var val_4;
            if(value == null)
            {
                    return;
            }
            
            System.Type val_1 = value.GetType();
            this.TryToMapFields(type:  val_1);
            val_4 = this._fieldsMap.Item[val_1];
            if(val_2.Length < 1)
            {
                    return;
            }
            
            var val_5 = 0;
            do
            {
                System.Reflection.FieldInfo val_4 = val_4[val_5];
                val_4.SetValue(obj:  value, value:  this._context.Get(type:  val_4));
                val_5 = val_5 + 1;
            }
            while(val_5 < val_2.Length);
        
        }
        public T Get<T>()
        {
            if(this._context != null)
            {
                
            }
            else
            {
                    throw new NullReferenceException();
            }
        
        }
        private void TryToMapFields(System.Type type)
        {
            var val_5;
            System.Func<System.Reflection.FieldInfo, System.Boolean> val_7;
            if((this._fieldsMap.ContainsKey(key:  type)) != false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = Injector.<>c.<>9__5_0;
            if(val_7 == null)
            {
                    System.Func<System.Reflection.FieldInfo, System.Boolean> val_2 = null;
                val_7 = val_2;
                val_2 = new System.Func<System.Reflection.FieldInfo, System.Boolean>(object:  Injector.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean Injector.<>c::<TryToMapFields>b__5_0(System.Reflection.FieldInfo temp));
                Injector.<>c.<>9__5_0 = val_7;
            }
            
            this._fieldsMap.set_Item(key:  type, value:  System.Linq.Enumerable.ToArray<System.Reflection.FieldInfo>(source:  System.Linq.Enumerable.Where<System.Reflection.FieldInfo>(source:  type, predicate:  val_2)));
        }
    
    }

}
