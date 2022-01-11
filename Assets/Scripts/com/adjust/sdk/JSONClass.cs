using UnityEngine;

namespace com.adjust.sdk
{
    public class JSONClass : JSONNode, IEnumerable
    {
        // Fields
        private System.Collections.Generic.Dictionary<string, com.adjust.sdk.JSONNode> m_Dict;
        
        // Properties
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override com.adjust.sdk.JSONNode Item { get; set; }
        public override int Count { get; }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> Childs { get; }
        
        // Methods
        public override com.adjust.sdk.JSONNode get_Item(string aKey)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    return this.m_Dict.Item[aKey];
            }
            
            .m_Node = this;
            .m_Key = aKey;
            return (com.adjust.sdk.JSONNode)new com.adjust.sdk.JSONLazyCreator();
        }
        public override void set_Item(string aKey, com.adjust.sdk.JSONNode value)
        {
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  value);
                return;
            }
            
            this.m_Dict.Add(key:  aKey, value:  value);
        }
        public override com.adjust.sdk.JSONNode get_Item(int aIndex)
        {
            var val_3;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_3 = aIndex;
                return (com.adjust.sdk.JSONNode)val_3;
            }
            
            }
            
            val_3 = 0;
            return (com.adjust.sdk.JSONNode)val_3;
        }
        public override void set_Item(int aIndex, com.adjust.sdk.JSONNode value)
        {
            if((aIndex & 2147483648) != 0)
            {
                    return;
            }
            
            if(this.m_Dict.Count <= aIndex)
            {
                    return;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  aIndex);
            this.m_Dict.set_Item(key:  val_2.Value, value:  value);
        }
        public override int get_Count()
        {
            return this.m_Dict.Count;
        }
        public override void Add(string aKey, com.adjust.sdk.JSONNode aItem)
        {
            string val_4;
            var val_5;
            if((System.String.IsNullOrEmpty(value:  aKey)) != false)
            {
                    System.Guid val_2 = System.Guid.NewGuid();
                val_4 = ;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>::Add(System.String key, com.adjust.sdk.JSONNode value);
            }
            else
            {
                    if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    this.m_Dict.set_Item(key:  aKey, value:  aItem);
                return;
            }
            
                val_4 = aKey;
                val_5 = public System.Void System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>::Add(System.String key, com.adjust.sdk.JSONNode value);
            }
            
            this.m_Dict.Add(key:  val_4, value:  aItem);
        }
        public override com.adjust.sdk.JSONNode Remove(string aKey)
        {
            var val_4;
            if((this.m_Dict.ContainsKey(key:  aKey)) != false)
            {
                    val_4 = this.m_Dict.Item[aKey];
                bool val_3 = this.m_Dict.Remove(key:  aKey);
                return (com.adjust.sdk.JSONNode)val_4;
            }
            
            val_4 = 0;
            return (com.adjust.sdk.JSONNode)val_4;
        }
        public override com.adjust.sdk.JSONNode Remove(int aIndex)
        {
            var val_4;
            if((aIndex & 2147483648) == 0)
            {
                    if(this.m_Dict.Count > aIndex)
            {
                    System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_2 = System.Linq.Enumerable.ElementAt<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, index:  aIndex);
                val_4 = aIndex;
                bool val_3 = this.m_Dict.Remove(key:  val_2.Value);
                return (com.adjust.sdk.JSONNode)val_4;
            }
            
            }
            
            val_4 = 0;
            return (com.adjust.sdk.JSONNode)val_4;
        }
        public override com.adjust.sdk.JSONNode Remove(com.adjust.sdk.JSONNode aNode)
        {
            JSONClass.<>c__DisplayClass12_0 val_1 = new JSONClass.<>c__DisplayClass12_0();
            if(val_1 == null)
            {
                    throw new NullReferenceException();
            }
            
            .aNode = aNode;
            System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode> val_4 = System.Linq.Enumerable.First<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  System.Linq.Enumerable.Where<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>>(source:  this.m_Dict, predicate:  new System.Func<System.Collections.Generic.KeyValuePair<System.String, com.adjust.sdk.JSONNode>, System.Boolean>(object:  val_1, method:  System.Boolean JSONClass.<>c__DisplayClass12_0::<Remove>b__0(System.Collections.Generic.KeyValuePair<string, com.adjust.sdk.JSONNode> k))));
            bool val_5 = this.m_Dict.Remove(key:  val_4.Value);
            return (com.adjust.sdk.JSONNode)(JSONClass.<>c__DisplayClass12_0)[1152921507330961552].aNode;
        }
        public override System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode> get_Childs()
        {
            .<>1__state = -2;
            .<>l__initialThreadId = System.Environment.CurrentManagedThreadId;
            .<>4__this = this;
            return (System.Collections.Generic.IEnumerable<com.adjust.sdk.JSONNode>)new JSONClass.<get_Childs>d__14();
        }
        public System.Collections.IEnumerator GetEnumerator()
        {
            .<>1__state = 0;
            .<>4__this = this;
            return (System.Collections.IEnumerator)new JSONClass.<GetEnumerator>d__15();
        }
        public override string ToString()
        {
            string val_3;
            var val_4;
            string val_10;
            string val_11;
            var val_12;
            int val_13;
            int val_14;
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_23:
            if(((-1570492048) & 1) == 0)
            {
                goto label_2;
            }
            
            val_11 = "{";
            val_12 = 5;
            string[] val_6 = new string[5];
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_13 = val_6.Length;
            if(val_13 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[0] = ;
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_13 = val_6.Length;
            val_6[1] = "\"";
            string val_7 = com.adjust.sdk.JSONNode.Escape(aText:  val_3);
            if(val_7 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_14 = val_6.Length;
            if(val_14 <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[2] = val_7;
            val_10 = "\":";
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_14 = val_6.Length;
            if(val_14 <= 3)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[3] = "\":";
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_10 = val_3;
            if(val_10 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_6.Length <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_6[4] = val_10;
            string val_8 = +val_6;
            goto label_23;
            label_2:
            val_4.Add(driver:  public System.Void Dictionary.Enumerator<System.String, com.adjust.sdk.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (string)"{" + "}";
        }
        public override string ToString(string aPrefix)
        {
            string val_3;
            var val_4;
            string val_12;
            string val_13;
            string val_14;
            int val_15;
            int val_16;
            val_12 = "{ ";
            Dictionary.Enumerator<TKey, TValue> val_1 = this.m_Dict.GetEnumerator();
            label_22:
            if(((-1570318352) & 1) == 0)
            {
                goto label_2;
            }
            
            val_12 = val_12 + ", ";
            val_14 = aPrefix;
            string[] val_7 = new string[5];
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_15 = val_7.Length;
            if(val_15 == 0)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[0] = val_12 + "\n" + val_14 + "   ";
            val_13 = "\"";
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_15 = val_7.Length;
            if(val_15 <= 1)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[1] = "\"";
            string val_8 = com.adjust.sdk.JSONNode.Escape(aText:  val_3);
            if(val_8 != null)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            val_16 = val_7.Length;
            if(val_16 <= 2)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[2] = val_8;
            if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            val_16 = val_7.Length;
            val_7[3] = "\" : ";
            val_14 = 0;
            string val_9 = aPrefix + "   ";
            if(val_3 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_14 = mem[val_3 + 584];
            val_14 = val_3 + 584;
            val_13 = val_3;
            if(val_13 != 0)
            {
                    if(X0 == false)
            {
                    throw new ArrayTypeMismatchException();
            }
            
            }
            
            if(val_7.Length <= 4)
            {
                    throw new IndexOutOfRangeException();
            }
            
            val_7[4] = val_13;
            string val_10 = +val_7;
            goto label_22;
            label_2:
            val_4.Add(driver:  public System.Void Dictionary.Enumerator<System.String, com.adjust.sdk.JSONNode>::Dispose(), rectTransform:  null, drivenProperties:  null);
            return (string)val_12 + "\n" + aPrefix + "}";
        }
        public override void Serialize(System.IO.BinaryWriter aWriter)
        {
            var val_5;
            string val_6;
            System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode> val_7;
            int val_1 = this.m_Dict.Count;
            Dictionary.KeyCollection.Enumerator<TKey, TValue> val_3 = this.m_Dict.Keys.GetEnumerator();
            label_8:
            if(((-1570140712) & 1) == 0)
            {
                goto label_5;
            }
            
            val_6 = 0;
            val_7 = this.m_Dict;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_5 = public com.adjust.sdk.JSONNode System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>::get_Item(System.String key);
            val_6 = 0;
            if(val_7.Item[val_6] == null)
            {
                    throw new NullReferenceException();
            }
            
            goto label_8;
            label_5:
            0.Add(driver:  public System.Void Dictionary.KeyCollection.Enumerator<System.String, com.adjust.sdk.JSONNode>::Dispose(), rectTransform:  typeof(System.IO.BinaryWriter).__il2cppRuntimeField_238, drivenProperties:  null);
        }
        public JSONClass()
        {
            this.m_Dict = new System.Collections.Generic.Dictionary<System.String, com.adjust.sdk.JSONNode>();
            this = new System.Object();
        }
    
    }

}
