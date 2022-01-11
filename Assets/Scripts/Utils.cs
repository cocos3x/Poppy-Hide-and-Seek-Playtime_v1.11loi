using UnityEngine;
public static class DOTweenModuleUI.Utils
{
    // Methods
    public static UnityEngine.Vector2 SwitchToRectTransform(UnityEngine.RectTransform from, UnityEngine.RectTransform to)
    {
        UnityEngine.Rect val_1 = from.rect;
        UnityEngine.Rect val_2 = from.rect;
        UnityEngine.Rect val_4 = from.rect;
        UnityEngine.Rect val_5 = from.rect;
        UnityEngine.Vector2 val_10 = new UnityEngine.Vector2(x:  (val_1.m_XMin * 0.5f) + (val_2.m_XMin.System.IConvertible.ToSingle(provider:  0)), y:  (val_4.m_XMin * 0.5f) + val_5.m_XMin);
        UnityEngine.Vector3 val_11 = from.position;
        UnityEngine.Vector2 val_12 = UnityEngine.RectTransformUtility.WorldToScreenPoint(cam:  0, worldPoint:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        UnityEngine.Vector2 val_13 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_12.x, y = val_12.y}, b:  new UnityEngine.Vector2() {x = val_10.x, y = val_10.y});
        bool val_14 = UnityEngine.RectTransformUtility.ScreenPointToLocalPointInRectangle(rect:  to, screenPoint:  new UnityEngine.Vector2() {x = val_13.x, y = val_13.y}, cam:  0, localPoint: out  new UnityEngine.Vector2() {x = 0f, y = 0f});
        UnityEngine.Rect val_15 = to.rect;
        UnityEngine.Rect val_16 = to.rect;
        UnityEngine.Rect val_18 = to.rect;
        UnityEngine.Rect val_19 = to.rect;
        UnityEngine.Vector2 val_24 = new UnityEngine.Vector2(x:  (val_15.m_XMin * 0.5f) + (val_16.m_XMin.System.IConvertible.ToSingle(provider:  0)), y:  (val_18.m_XMin * 0.5f) + val_19.m_XMin);
        UnityEngine.Vector2 val_25 = to.anchoredPosition;
        UnityEngine.Vector2 val_26 = UnityEngine.Vector2.op_Addition(a:  new UnityEngine.Vector2() {x = val_25.x, y = val_25.y}, b:  new UnityEngine.Vector2() {x = 0f, y = 0f});
        UnityEngine.Vector2 val_27 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_26.x, y = val_26.y}, b:  new UnityEngine.Vector2() {x = val_24.x, y = val_24.y});
        return new UnityEngine.Vector2() {x = val_27.x, y = val_27.y};
    }

}
