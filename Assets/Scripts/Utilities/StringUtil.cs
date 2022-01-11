using UnityEngine;

namespace Utilities
{
    public static class StringUtil
    {
        // Fields
        private static readonly System.Text.StringBuilder _stringBuilder;
        
        // Methods
        public static string[] Split(string strValue, string splitValue)
        {
            string[] val_1 = new string[1];
            val_1[0] = splitValue;
            return strValue.Split(separator:  val_1, options:  0);
        }
        public static string SplitStringByMaxChars(string strValue, int maxChars)
        {
            return strValue.Substring(startIndex:  0, length:  maxChars)(strValue.Substring(startIndex:  0, length:  maxChars)) + "...";
        }
        public static string SplitStringByStartEnd(string strValue, string start, string end)
        {
            string val_8;
            string val_9;
            val_8 = start;
            val_9 = strValue;
            if((val_9.Contains(value:  val_8)) != false)
            {
                    string[] val_2 = new string[1];
                val_2[0] = val_8;
                val_9 = val_9.Split(separator:  val_2, options:  0)[((-4294967296) + ((val_3.Length) << 32)) >> 29];
            }
            
            if((val_9.Contains(value:  end)) == false)
            {
                    return val_9;
            }
            
            string[] val_6 = new string[1];
            val_8 = val_6;
            val_8[0] = end;
            val_9 = val_9.Split(separator:  val_6, options:  0)[0];
            return val_9;
        }
        public static string UppercaseFirstLetter(string value)
        {
            if((System.String.IsNullOrEmpty(value:  value)) == true)
            {
                    return (string)value;
            }
            
            if(value.m_stringLength == 0)
            {
                    return (string)value;
            }
            
            if(value.m_stringLength != 1)
            {
                    return System.String.Format(format:  "{0}{1}", arg0:  value.Substring(startIndex:  0, length:  1).ToUpper(), arg1:  value.Substring(startIndex:  1, length:  value.m_stringLength - 1).ToLower());
            }
            
            return value.ToUpper();
        }
        public static string LowercaseFirstLetter(string value)
        {
            if((System.String.IsNullOrEmpty(value:  value)) == true)
            {
                    return (string)value;
            }
            
            if(value.m_stringLength == 0)
            {
                    return (string)value;
            }
            
            if(value.m_stringLength != 1)
            {
                    return System.String.Format(format:  "{0}{1}", arg0:  value.Substring(startIndex:  0, length:  1).ToLower(), arg1:  value.Substring(startIndex:  1, length:  value.m_stringLength - 1));
            }
            
            return value.ToLower();
        }
        public static string ReplaceHtmlTags(string value)
        {
            return value.Replace(oldValue:  "<", newValue:  "〈").Replace(oldValue:  ">", newValue:  "〉");
        }
        public static string PrepareTextForBubble(string text, int maxLines, int maxLineLength, string ellipsis)
        {
            var val_11;
            int val_12;
            var val_13;
            int val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            string val_21;
            var val_22;
            var val_23;
            char[] val_1 = new char[1];
            val_1[0] = 32;
            val_11 = text.Split(separator:  val_1);
            System.Collections.Generic.List<System.String> val_3 = new System.Collections.Generic.List<System.String>();
            val_12 = maxLines;
            if((val_12 & 2147483648) != 0)
            {
                goto label_38;
            }
            
            if(val_12 == 0)
            {
                goto label_5;
            }
            
            val_13 = 0;
            goto label_34;
            label_31:
            val_12 = maxLines;
            val_3.Add(item:  val_11[0].Substring(startIndex:  0, length:  System.Math.Max(val1:  1, val2:  maxLineLength - (ellipsis + 16))));
            val_3.Add(item:  ellipsis);
            val_14 = val_2.Length;
            val_13 = 1;
            val_15 = 1;
            goto label_13;
            label_34:
            if(0 >= 1)
            {
                    val_3.Add(item:  "\n");
            }
            
            val_14 = val_2.Length;
            if(val_13 >= val_14)
            {
                goto label_17;
            }
            
            val_16 = 0;
            label_28:
            if(val_16 >= 1)
            {
                    var val_7 = (val_2[0x0][0].m_stringLength > 0) ? 1 : 0;
                var val_8 = (val_2[0x0][0].m_stringLength < 1) ? 1 : 0;
            }
            else
            {
                    val_17 = 0;
                val_18 = 1;
            }
            
            val_17 = val_17 + val_16;
            val_17 = val_17 + val_2[0x0][0].m_stringLength;
            if(val_17 > maxLineLength)
            {
                goto label_23;
            }
            
            if((val_18 & 1) != 0)
            {
                    if(val_3 != null)
            {
                goto label_25;
            }
            
            }
            
            val_3.Add(item:  " ");
            val_19 = val_16 + 1;
            label_25:
            val_3.Add(item:  val_11[val_13]);
            val_14 = val_2.Length;
            val_13 = val_13 + 1;
            val_20 = val_2[0x0][0].m_stringLength + val_19;
            if(val_13 < val_14)
            {
                goto label_28;
            }
            
            goto label_30;
            label_17:
            val_20 = 0;
            goto label_30;
            label_23:
            if(val_16 == 0)
            {
                goto label_31;
            }
            
            label_30:
            val_15 = 0;
            label_13:
            if(val_13 == val_14)
            {
                goto label_38;
            }
            
            val_21 = 0 + 1;
            if(val_21 > val_12)
            {
                goto label_38;
            }
            
            if(val_21 != val_12)
            {
                goto label_34;
            }
            
            if((val_15 & 1) == 0)
            {
                goto label_35;
            }
            
            label_38:
            if(val_3 != null)
            {
                    return System.String.Join(separator:  "", value:  val_3.ToArray());
            }
            
            label_5:
            val_22 = 0;
            if((1 & 1) != 0)
            {
                goto label_38;
            }
            
            label_35:
            val_3.Add(item:  " ");
            val_21 = ellipsis;
            val_23 = val_22 + 1;
            if()
            {
                goto label_42;
            }
            
            val_11 = 1152921506979455568;
            label_45:
            var val_13 = ellipsis + 16;
            val_13 = val_13 + val_23;
            if(val_13 <= maxLineLength)
            {
                goto label_42;
            }
            
            if(val_13 <= 1)
            {
                    System.ThrowHelper.ThrowArgumentOutOfRangeException();
            }
            
            val_13 = val_13 + ((val_13 - 2) << 3);
            val_23 = val_23 + (~(((ellipsis + 16 + (val_22 + 1)) + (((ellipsis + 16 + (val_22 + 1)) - 2)) << 3) + 32 + 16));
            val_3.RemoveRange(index:  -1, count:  2);
            if(val_23 != 0)
            {
                goto label_45;
            }
            
            label_42:
            val_3.Add(item:  val_21);
            return System.String.Join(separator:  "", value:  val_3.ToArray());
        }
        public static string Concat(string[] texts)
        {
            var val_2;
            var val_3;
            var val_4;
            var val_5;
            int val_6;
            var val_7;
            var val_8;
            val_2 = null;
            val_2 = null;
            val_3 = 0;
            Utilities.StringUtil._stringBuilder.Length = 0;
            val_4 = null;
            val_5 = (uint)(((uint)((Utilities.StringUtil.__il2cppRuntimeField_12F>>1) & 0x1)) >> 1) & 1;
            if(texts.Length >= 1)
            {
                    var val_2 = 0;
                val_6 = texts.Length & 4294967295;
                do
            {
                val_7 = null;
                val_6 = texts.Length;
                System.Text.StringBuilder val_1 = Utilities.StringUtil._stringBuilder.Append(value:  null);
                val_8 = null;
                val_2 = val_2 + 1;
                val_5 = (uint)(((uint)((Utilities.StringUtil.__il2cppRuntimeField_12F>>1) & 0x1)) >> 1) & 1;
            }
            while(val_2 < (texts.Length << ));
            
            }
            
            val_8 = null;
            goto typeof(System.Text.StringBuilder).__il2cppRuntimeField_160;
        }
        private static StringUtil()
        {
            Utilities.StringUtil._stringBuilder = new System.Text.StringBuilder();
        }
    
    }

}
