using UnityEngine;

namespace Game
{
    public static class Log
    {
        // Methods
        public static void Info(object message)
        {
            UnityEngine.Debug.Log(message:  message);
        }
        public static void Exception(System.Exception exception)
        {
            UnityEngine.Debug.LogException(exception:  exception);
        }
    
    }

}
