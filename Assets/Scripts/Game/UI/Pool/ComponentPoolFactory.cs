using UnityEngine;

namespace Game.UI.Pool
{
    public class ComponentPoolFactory : MonoBehaviour, IComponentPoolFactory
    {
        // Fields
        private UnityEngine.GameObject _prefab;
        private int _count;
        private UnityEngine.Transform _content;
        private UnityEngine.Transform _poolStorage;
        private readonly System.Collections.Generic.HashSet<UnityEngine.GameObject> _instances;
        private System.Collections.Generic.Queue<UnityEngine.GameObject> _pool;
        
        // Properties
        public UnityEngine.Transform Content { get; }
        public int CountInstances { get; }
        
        // Methods
        public UnityEngine.Transform get_Content()
        {
            return (UnityEngine.Transform)this._content;
        }
        public ComponentPoolFactory()
        {
            this._instances = new System.Collections.Generic.HashSet<UnityEngine.GameObject>();
            this._pool = new System.Collections.Generic.Queue<UnityEngine.GameObject>();
        }
        public int get_CountInstances()
        {
            return 2375;
        }
        private void Awake()
        {
            if(this._instances > 0)
            {
                    return;
            }
            
            if(this._count >= 1)
            {
                    var val_2 = 0;
                do
            {
                UnityEngine.Transform val_1 = this.Get<UnityEngine.Transform>();
                val_2 = val_2 + 1;
            }
            while(val_2 < this._count);
            
            }
            
            this.ReleaseAllInstances();
        }
        public T Get<T>()
        {
            goto __RuntimeMethodHiddenParam + 48;
        }
        public T Get<T>(int sublingIndex)
        {
            var val_12;
            UnityEngine.Object val_13;
            UnityEngine.Object val_14;
            if(true != 0)
            {
                    val_12 = 0;
            }
            else
            {
                    val_13 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._prefab);
                val_14 = 0;
                if(0 == val_13)
            {
                    return (object)val_14;
            }
            
                this._pool.Enqueue(item:  val_13);
                val_12 = 1;
            }
            
            val_14 = this._pool.Dequeue();
            if(0 == val_14)
            {
                    return (object)val_14;
            }
            
            val_13 = val_14.gameObject;
            UnityEngine.Transform val_6 = val_14.transform;
            if((val_12 & 1) == 0)
            {
                    if((this._poolStorage == 0) || (this._poolStorage == this._content))
            {
                goto label_20;
            }
            
            }
            
            val_6.SetParent(parent:  this._content, worldPositionStays:  false);
            label_20:
            bool val_9 = this._instances.Add(item:  val_13);
            if(val_13.activeSelf != true)
            {
                    val_13.SetActive(value:  true);
            }
            
            if(val_6.GetSiblingIndex() == sublingIndex)
            {
                    return (object)val_14;
            }
            
            val_6.SetSiblingIndex(index:  sublingIndex);
            return (object)val_14;
        }
        public void Release<T>(T component)
        {
            UnityEngine.GameObject val_1 = component.gameObject;
            if((this._instances.Contains(item:  val_1)) == false)
            {
                    return;
            }
            
            val_1.SetActive(value:  false);
            if((UnityEngine.Object.op_Implicit(exists:  this._poolStorage)) != false)
            {
                    val_1.transform.SetParent(parent:  this._poolStorage, worldPositionStays:  false);
            }
            
            this._pool.Enqueue(item:  val_1);
            bool val_5 = this._instances.Remove(item:  val_1);
        }
        public void ReleaseAllInstances()
        {
            UnityEngine.GameObject val_2;
            var val_3;
            UnityEngine.Transform val_6;
            System.Collections.Generic.Queue<UnityEngine.GameObject> val_7;
            var val_8;
            HashSet.Enumerator<T> val_1 = this._instances.GetEnumerator();
            label_9:
            val_6 = public System.Boolean HashSet.Enumerator<UnityEngine.GameObject>::MoveNext();
            if(((-1606715712) & 1) == 0)
            {
                goto label_2;
            }
            
            if(val_2 == 0)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = 0;
            val_2.SetActive(value:  false);
            val_6 = 0;
            if((UnityEngine.Object.op_Implicit(exists:  this._poolStorage)) != false)
            {
                    val_6 = 0;
                UnityEngine.Transform val_5 = val_2.transform;
                if(val_5 == null)
            {
                    throw new NullReferenceException();
            }
            
                val_6 = this._poolStorage;
                val_8 = 0;
                val_5.SetParent(parent:  val_6, worldPositionStays:  false);
            }
            
            val_7 = this._pool;
            if(val_7 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7.Enqueue(item:  val_2);
            goto label_9;
            label_2:
            val_3.Add(driver:  public System.Void HashSet.Enumerator<UnityEngine.GameObject>::Dispose(), rectTransform:  null, drivenProperties:  null);
            this._instances.Clear();
        }
        public void PutInstancesToPool()
        {
            this._pool = new System.Collections.Generic.Queue<UnityEngine.GameObject>(collection:  System.Linq.Enumerable.Union<UnityEngine.GameObject>(first:  this._instances, second:  this._pool));
            this._instances.Clear();
        }
        public void HideUnusedInstances()
        {
            Queue.Enumerator<T> val_1 = this._pool.GetEnumerator();
            label_4:
            if(((-1606415896) & 1) == 0)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.SetActive(value:  false);
            goto label_4;
        }
        public void Dispose()
        {
            this.ReleaseAllInstances();
            Queue.Enumerator<T> val_1 = this._pool.GetEnumerator();
            label_5:
            if(((-1606290616) & 1) == 0)
            {
                goto label_2;
            }
            
            UnityEngine.Object.Destroy(obj:  0);
            goto label_5;
            label_2:
            this._pool.Clear();
        }
    
    }

}
