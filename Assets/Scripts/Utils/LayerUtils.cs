using UnityEngine;

namespace Utils
{
    public static class LayerUtils
    {
        // Methods
        public static int GetDoorsLayerMask()
        {
            int val_2;
            string[] val_1 = new string[2];
            val_2 = val_1.Length;
            val_1[0] = "Default";
            val_2 = val_1.Length;
            val_1[1] = "Victim";
            return UnityEngine.LayerMask.GetMask(layerNames:  val_1);
        }
        public static int GetRadarAllLayerMask()
        {
            string[] val_1 = new string[1];
            val_1[0] = "Victim";
            return (int)~(UnityEngine.LayerMask.GetMask(layerNames:  val_1));
        }
        public static int GetVictimLayerMask()
        {
            string[] val_1 = new string[1];
            val_1[0] = "Victim";
            return UnityEngine.LayerMask.GetMask(layerNames:  val_1);
        }
        public static int GetVictimLayer(bool isVictim)
        {
            return UnityEngine.LayerMask.NameToLayer(layerName:  (isVictim != true) ? "Victim" : "Default");
        }
    
    }

}
