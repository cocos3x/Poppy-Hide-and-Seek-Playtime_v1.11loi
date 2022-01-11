using UnityEngine;

namespace Game.Utilities
{
    public static class ArrayUtils
    {
        // Methods
        public static void RemoveAt<T>(ref T[] values, int index)
        {
            T[] val_11;
            int val_12;
            System.Array val_13;
            var val_14;
            val_11 = values;
            val_12 = index;
            val_13 = 1152921507288897712;
            val_14 = values.Length - 1;
            if(val_14 == val_12)
            {
                    val_14 = val_12;
                val_12 = ???;
                val_13 = ???;
                val_11 = ???;
            }
            else
            {
                    if(((__RuntimeMethodHiddenParam + 48 + 48 + 8 + 302) & 1) == 0)
            {
                    val_14 = (val_11 + 24) - 1;
            }
            
                if(val_12 != 0)
            {
                    System.Array.Copy(sourceArray:  val_13, sourceIndex:  0, destinationArray:  __RuntimeMethodHiddenParam + 48 + 48 + 8, destinationIndex:  0, length:  val_12);
            }
            
                System.Array.Copy(sourceArray:  val_13, sourceIndex:  val_12 + 1, destinationArray:  __RuntimeMethodHiddenParam + 48 + 48 + 8, destinationIndex:  val_12, length:  (val_13 + 24) + (~val_12));
                mem2[0] = __RuntimeMethodHiddenParam + 48 + 48 + 8;
            }
        
        }
        public static void Remove<T>(ref T[] values, T value)
        {
            goto __RuntimeMethodHiddenParam + 48 + 8;
        }
        public static void Add<T>(ref T[] values, T value)
        {
            int val_1 = values.Length + 1;
            T[] val_3 = values;
            val_3 = val_3 + (((-4294967296) + ((values.Length) << 32)) >> 29);
            mem2[0] = value;
        }
        public static void AddRange<T>(ref T[] array, int count, System.Collections.Generic.IEnumerable<T> values)
        {
            var val_5;
            System.Collections.Generic.IEnumerable<T> val_6;
            int val_7;
            var val_8;
            val_5 = __RuntimeMethodHiddenParam;
            val_6 = values;
            if(array == null)
            {
                    throw new NullReferenceException();
            }
            
            val_7 = mem[array + 24];
            val_7 = array.Length;
            val_8 = val_7 + count;
            if(val_6 == null)
            {
                    throw new NullReferenceException();
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_8 = __RuntimeMethodHiddenParam + 48 + 8;
            val_6 = val_6;
            goto label_9;
            label_21:
            var val_7 = 0;
            val_7 = val_7 + 1;
            T[] val_8 = array;
            if(val_8 == null)
            {
                    throw new NullReferenceException();
            }
            
            val_8 = val_8 + (val_7 << 3);
            val_7 = val_7 + 1;
            mem2[0] = val_6;
            label_9:
            var val_9 = 0;
            val_9 = val_9 + 1;
            if(val_6.MoveNext() == true)
            {
                goto label_21;
            }
            
            val_5 = 0;
            if(val_6 != null)
            {
                    var val_10 = 0;
                val_10 = val_10 + 1;
                val_6.Dispose();
            }
            
            if(val_5 != 0)
            {
                    throw val_5;
            }
        
        }
    
    }

}
