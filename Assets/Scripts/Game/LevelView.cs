using UnityEngine;

namespace Game
{
    public sealed class LevelView : MonoBehaviour
    {
        // Fields
        public Game.UnitView[] Units;
        public Game.CoinView[] Coins;
        public Game.DoorView[] Doors;
        public float Duration;
        
        // Methods
        private void Awake()
        {
        
        }
        public LevelView()
        {
        
        }
    
    }

}
