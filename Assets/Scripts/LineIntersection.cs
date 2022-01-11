using UnityEngine;
public static class LineIntersection
{
    // Fields
    public const float kTolerance = 0.01;
    
    // Methods
    public static bool FindIntersection(UnityEngine.Vector2 point1, UnityEngine.Vector2 point2, float x3, float y3, float x4, float y4, bool checkOnInside, out UnityEngine.Vector2 point, float tolerance = 0.01)
    {
        return LineIntersection.FindIntersection(x1:  point1.x, y1:  point1.y, x2:  point2.x, y2:  point2.y, x3:  x3, y3:  y3, x4:  x4, y4:  y4, checkOnInside:  checkOnInside, point: out  new UnityEngine.Vector2() {x = point.x, y = point.y}, tolerance:  tolerance);
    }
    public static bool FindIntersection(float x1, float y1, float x2, float y2, float x3, float y3, float x4, float y4, bool checkOnInside, out UnityEngine.Vector2 point, float tolerance = 0.01)
    {
        float val_30;
        float val_31;
        float val_32;
        float val_33;
        float val_34;
        var val_35;
        float val_36;
        float val_37;
        val_30 = y4;
        float val_24 = y3;
        float val_18 = x2;
        val_18 = x1 ?? val_18;
        if((val_18 >= 0) || ((x3 ?? x4) >= 0))
        {
            goto label_6;
        }
        
        val_31 = x1 ?? x3;
        if(val_31 < 0)
        {
            goto label_59;
        }
        
        label_6:
        float val_2 = y1 ?? y2;
        if((val_2 >= 0) || ((val_24 ?? val_30) >= 0))
        {
            goto label_15;
        }
        
        val_31 = y1 ?? val_24;
        if(val_31 < 0)
        {
            goto label_59;
        }
        
        label_15:
        if(val_18 >= 0)
        {
            goto label_21;
        }
        
        val_31 = x3 ?? x4;
        if(val_31 < 0)
        {
            goto label_59;
        }
        
        label_21:
        float val_25 = x4;
        if(val_2 >= 0)
        {
            goto label_27;
        }
        
        val_31 = val_24 ?? val_30;
        if(val_31 < 0)
        {
            goto label_59;
        }
        
        label_27:
        if(val_18 >= 0)
        {
            goto label_33;
        }
        
        float val_4 = val_30 - val_24;
        float val_5 = val_25 - x3;
        val_4 = val_4 / val_5;
        val_5 = val_4 * x3;
        val_5 = val_24 - val_5;
        val_4 = val_4 * x1;
        val_32 = val_4 + val_5;
        val_33 = x1;
        if(checkOnInside == true)
        {
            goto label_34;
        }
        
        goto label_53;
        label_33:
        float val_19 = y2;
        float val_20 = val_18;
        val_19 = val_19 - y1;
        val_20 = val_20 - x1;
        val_19 = val_19 / val_20;
        val_20 = val_19 * x1;
        val_30 = y1 - val_20;
        if((x3 ?? val_25) >= 0)
        {
            goto label_38;
        }
        
        val_19 = val_19 * x3;
        val_32 = val_19 + val_30;
        val_30 = val_30;
        val_33 = x3;
        label_62:
        if(checkOnInside == false)
        {
            goto label_53;
        }
        
        label_34:
        val_34 = val_18;
        if((x1 - tolerance) <= val_33)
        {
                if((val_34 + tolerance) >= val_33)
        {
            goto label_41;
        }
        
        }
        
        val_31 = val_34 - tolerance;
        if(val_31 > val_33)
        {
            goto label_59;
        }
        
        val_31 = x1 + tolerance;
        if(val_31 < val_33)
        {
            goto label_59;
        }
        
        label_41:
        if((y1 - tolerance) > val_32)
        {
            goto label_44;
        }
        
        float val_21 = y2;
        val_21 = val_21 + tolerance;
        if(val_21 >= val_32)
        {
            goto label_45;
        }
        
        label_44:
        val_31 = y2 - tolerance;
        if(val_31 > val_32)
        {
            goto label_59;
        }
        
        val_31 = y1 + tolerance;
        if(val_31 < val_32)
        {
            goto label_59;
        }
        
        label_45:
        if((x3 - tolerance) > val_33)
        {
            goto label_48;
        }
        
        float val_22 = x4;
        val_22 = val_22 + tolerance;
        if(val_22 >= val_33)
        {
            goto label_49;
        }
        
        label_48:
        val_31 = x4 - tolerance;
        if(val_31 > val_33)
        {
            goto label_59;
        }
        
        val_31 = x3 + tolerance;
        if(val_31 < val_33)
        {
            goto label_59;
        }
        
        label_49:
        val_34 = val_24;
        if((val_34 - tolerance) <= val_32)
        {
                if((val_30 + tolerance) >= val_32)
        {
            goto label_53;
        }
        
        }
        
        val_31 = val_30 - tolerance;
        if(val_31 > val_32)
        {
            goto label_59;
        }
        
        val_31 = val_34 + tolerance;
        if(val_31 < val_32)
        {
            goto label_59;
        }
        
        label_53:
        val_35 = 1;
        goto label_56;
        label_38:
        float val_23 = val_30;
        val_23 = val_23 - val_24;
        val_24 = val_23 / (val_25 - x3);
        val_23 = val_24 * x3;
        val_36 = val_24 - val_23;
        val_37 = -val_19;
        val_34 = val_30 - val_36;
        val_19 = val_24 - val_19;
        val_25 = val_34 / val_19;
        val_19 = val_24 * val_25;
        float val_14 = val_36 + val_19;
        val_37 = val_37;
        val_36 = val_36;
        float val_15 = val_25 * val_37;
        val_15 = val_15 + val_14;
        val_31 = val_15 ?? val_30;
        if(val_31 >= 0)
        {
            goto label_59;
        }
        
        val_36 = val_36;
        float val_16 = val_25 * (-val_24);
        val_30 = val_30;
        val_16 = val_16 + val_14;
        val_31 = val_16 ?? val_36;
        if(val_31 < 0)
        {
            goto label_62;
        }
        
        label_59:
        UnityEngine.Vector2 val_17 = UnityEngine.Vector2.zero;
        val_33 = val_17.x;
        val_32 = val_17.y;
        val_35 = 0;
        label_56:
        point.x = val_33;
        point.y = val_32;
        return (bool)val_35;
    }
    private static bool IsInsideLine(float x1, float y1, float x2, float y2, float x, float y, float t)
    {
        var val_8;
        if((x1 - t) <= x)
        {
                if((x2 + t) >= x)
        {
            goto label_1;
        }
        
        }
        
        x2 = x2 - t;
        val_8 = 0;
        if(x2 > x)
        {
                return (bool)((y1 + t) >= y) ? 1 : 0;
        }
        
        x1 = x1 + t;
        if(x1 < x)
        {
                return (bool)((y1 + t) >= y) ? 1 : 0;
        }
        
        label_1:
        if((y1 - t) <= y)
        {
                if((y2 + t) >= y)
        {
                return true;
        }
        
        }
        
        if((y2 - t) <= y)
        {
                return (bool)((y1 + t) >= y) ? 1 : 0;
        }
        
        return false;
    }

}
