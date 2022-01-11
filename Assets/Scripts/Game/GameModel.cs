using UnityEngine;

namespace Game
{
    public sealed class GameModel
    {
        // Fields
        public System.Action Changed;
        public int Level;
        public bool IsTimeOut;
        public UnityEngine.Vector4 LevelBounds;
        
        // Methods
        public static Game.GameModel Load(Game.Config.GameConfig config)
        {
            return 0;
        }
        public GameModel()
        {
            this.IsTimeOut = false;
        }
        public GameModel(Game.Config.GameConfig config)
        {
            this.Level = 1;
            this.IsTimeOut = false;
        }
        public void SetChanged()
        {
            ActionExtentions.SafeInvoke(invocationTarget:  this.Changed);
        }
        public void Save()
        {
        
        }
        public void Remove()
        {
            UnityEngine.PlayerPrefs.DeleteKey(key:  "model");
            UnityEngine.PlayerPrefs.Save();
        }
    
    }

}
