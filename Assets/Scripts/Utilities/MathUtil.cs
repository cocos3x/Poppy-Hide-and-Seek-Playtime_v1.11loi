using UnityEngine;

namespace Utilities
{
    public static class MathUtil
    {
        // Fields
        private static float secPerYear;
        private static System.Random _random;
        
        // Properties
        public static bool RandomBool { get; }
        public static int RandomSign { get; }
        
        // Methods
        public static void SetSecPerYear(float value)
        {
            null = null;
            Utilities.MathUtil.secPerYear = value;
        }
        public static float YearsToSec(float years)
        {
            null = null;
            float val_1 = Utilities.MathUtil.secPerYear;
            val_1 = val_1 * years;
            return (float)val_1;
        }
        public static float SecToYears(float value)
        {
            null = null;
            float val_1 = Utilities.MathUtil.secPerYear;
            val_1 = value / val_1;
            return (float)val_1;
        }
        public static string FloatToString(float value, int decim)
        {
            return (string)value.ToString(format:  "F" + decim);
        }
        public static float SecToMos(float value)
        {
            null = null;
            float val_1 = Utilities.MathUtil.secPerYear;
            val_1 = value / val_1;
            val_1 = val_1 * 12f;
            return (float)val_1;
        }
        public static string LongToString(long cash, string prefix = "", string suffixTimeUnit = "")
        {
            int val_8;
            float val_9;
            int val_11;
            string val_12;
            string[] val_1 = new string[4];
            val_8 = val_1.Length;
            val_1[0] = "";
            val_8 = val_1.Length;
            val_1[1] = "k";
            val_8 = val_1.Length;
            val_1[2] = "m";
            val_8 = val_1.Length;
            val_1[3] = "b";
            if(cash == 0)
            {
                goto label_14;
            }
            
            if(cash < 1)
            {
                goto label_15;
            }
            
            val_9 = (float)cash;
            goto label_18;
            label_14:
            string val_2 = cash.ToString();
            val_11 = 0;
            goto label_20;
            label_15:
            val_9 = (float)-cash;
            label_18:
            string val_3 = -cash.ToString();
            float val_8 = 3f;
            val_8 = val_9 / val_8;
            val_11 = (int)val_8;
            label_20:
            float val_4 = val_11 + (val_11 << 1);
            float val_9 = 10f;
            if(val_3.m_stringLength <= 3)
            {
                goto label_28;
            }
            
            val_9 = (float)cash / val_9;
            if(val_3.m_stringLength <= 6)
            {
                goto label_29;
            }
            
            val_12 = "F3";
            goto label_30;
            label_28:
            val_9 = (float)cash / val_9;
            string val_5 = val_9.ToString();
            goto label_31;
            label_29:
            val_12 = "F2";
            label_30:
            label_31:
            return (string)prefix + val_9.ToString(format:  val_12)(val_9.ToString(format:  val_12)) + val_1[val_11] + suffixTimeUnit;
        }
        public static long IntToLong(int value)
        {
            return System.Convert.ToInt64(value:  value);
        }
        public static float HoursToSeconds(float value)
        {
            value = value * 3600f;
            return (float)value;
        }
        public static string SecondsToHours(float value)
        {
            System.Object[] val_13;
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)value);
            if(val_1._ticks.Days != 0)
            {
                    object[] val_3 = new object[4];
                val_13 = val_3;
                val_13[0] = val_1._ticks.Days;
                val_13[1] = val_1._ticks.Hours;
                val_13[2] = val_1._ticks.Minutes;
                val_13[3] = val_1._ticks.Seconds;
                string val_8 = System.String.Format(format:  "{0:D1}d {1:D1}h {2:D1}m {3:D1}s", args:  val_3);
                return (string)System.String.Format(format:  "{0:D1}h {1:D1}m {2:D1}s", arg0:  int val_9 = val_1._ticks.Hours, arg1:  val_1._ticks.Minutes, arg2:  val_1._ticks.Seconds);
            }
            
            val_13 = val_9;
            return (string)System.String.Format(format:  "{0:D1}h {1:D1}m {2:D1}s", arg0:  val_9, arg1:  val_1._ticks.Minutes, arg2:  val_1._ticks.Seconds);
        }
        public static string SecondsToMinutes(float value)
        {
            string val_13;
            System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)value);
            if(val_1._ticks.Minutes == 0)
            {
                goto label_3;
            }
            
            if(val_1._ticks.Seconds == 0)
            {
                goto label_4;
            }
            
            val_13 = "{0:D1}"("{0:D1}") + "min" + "{1:D1}"("{1:D1}") + "s";
            string val_7 = System.String.Format(format:  val_13, arg0:  val_1._ticks.Minutes, arg1:  val_1._ticks.Seconds);
            return (string)System.String.Format(format:  val_13 = "{0:D1}"("{0:D1}") + "min", arg0:  val_1._ticks.Minutes);
            label_3:
            val_13 = "{0:D1}"("{0:D1}") + "s";
            int val_9 = val_1._ticks.Seconds;
            return (string)System.String.Format(format:  val_13, arg0:  val_1._ticks.Minutes);
            label_4:
            return (string)System.String.Format(format:  val_13, arg0:  val_1._ticks.Minutes);
        }
        private static MathUtil()
        {
            Utilities.MathUtil._random = new System.Random();
        }
        public static void InitSeed(int seed)
        {
            var val_2 = null;
            Utilities.MathUtil._random = new System.Random(Seed:  seed);
        }
        public static float GetAngle(UnityEngine.Vector3 start, UnityEngine.Vector3 end)
        {
            float val_1 = start.z - end.z;
            float val_2 = start.x - end.x;
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public static float GetAngle(UnityEngine.Vector2 start, UnityEngine.Vector2 end)
        {
            float val_1 = start.y - end.y;
            float val_2 = start.x - end.x;
            val_1 = val_1 * 57.29578f;
            return (float)val_1;
        }
        public static long Lerp(double a, double b, float t)
        {
            b = b - a;
            double val_2 = (double)UnityEngine.Mathf.Clamp01(value:  t);
            val_2 = b * val_2;
            val_2 = val_2 + a;
            return (long)(long)val_2;
        }
        public static int Sign(double value)
        {
            return (int)(value < 0f) ? 0 : (0 + 1);
        }
        public static int RandomSystem(int min, int max)
        {
            null = null;
            int val_1 = max + 1;
            goto typeof(System.Random).__il2cppRuntimeField_180;
        }
        public static float RandomSystem(float min, float max)
        {
            null = null;
            float val_1 = 0.0001f;
            float val_2 = (float)min;
            val_1 = max + val_1;
            val_1 = val_1 - min;
            val_2 = val_1 * val_2;
            val_2 = val_2 + min;
            return (float)val_2;
        }
        public static int Random(int min, int max)
        {
            max = max + 1;
            return UnityEngine.Random.Range(min:  min, max:  max);
        }
        public static float Random(float min, float max)
        {
            max = max + 0.0001f;
            return UnityEngine.Random.Range(min:  min, max:  max);
        }
        public static string IntToHex(uint crc)
        {
            return (string)System.String.Format(format:  "{0:X}", arg0:  crc);
        }
        public static uint HexToInt(string crc)
        {
            return System.UInt32.Parse(s:  crc, style:  512);
        }
        public static bool get_RandomBool()
        {
            return (bool)(UnityEngine.Random.value > 0.5f) ? 1 : 0;
        }
        public static int get_RandomSign()
        {
            return (int)(UnityEngine.Random.value <= 0.5f) ? 0 : (0 + 1);
        }
        public static UnityEngine.Vector2 RotateAround(UnityEngine.Vector2 center, UnityEngine.Vector2 point, float angleInRadians)
        {
            float val_4 = angleInRadians;
            val_4 = val_4 * 0.01745329f;
            float val_5 = val_4;
            float val_1 = point.x - center.x;
            float val_2 = point.y - center.y;
            angleInRadians = val_2 * val_5;
            val_1 = val_1 * val_5;
            val_2 = val_2 * val_4;
            val_5 = (val_1 * val_4) - angleInRadians;
            val_1 = val_2 + val_1;
            return new UnityEngine.Vector2() {x = val_5, y = val_1};
        }
    
    }

}
