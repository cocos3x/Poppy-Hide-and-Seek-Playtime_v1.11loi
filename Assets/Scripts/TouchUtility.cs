using UnityEngine;
public static class TouchUtility
{
    // Fields
    private static bool enabled;
    
    // Properties
    public static bool Enabled { get; set; }
    public static int TouchCount { get; }
    
    // Methods
    public static bool get_Enabled()
    {
        null = null;
        return (bool)TouchUtility.enabled;
    }
    public static void set_Enabled(bool value)
    {
        null = null;
        TouchUtility.enabled = value;
    }
    public static bool TouchedUI(int fingerId)
    {
        return UnityEngine.EventSystems.EventSystem.current.IsPointerOverGameObject(pointerId:  fingerId);
    }
    public static int get_TouchCount()
    {
        return UnityEngine.Input.touchCount;
    }
    public static UnityEngine.Touch GetTouch(int index)
    {
        return UnityEngine.Input.GetTouch(index:  index);
    }
    private static TouchUtility()
    {
        TouchUtility.enabled = true;
    }

}
