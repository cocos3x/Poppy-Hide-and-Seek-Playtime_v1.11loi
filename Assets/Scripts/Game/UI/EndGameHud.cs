using UnityEngine;

namespace Game.UI
{
    public sealed class EndGameHud : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button BtnRestart;
        public TMPro.TextMeshProUGUI TxtRestartLabel;
        
        // Properties
        set; }
        
        // Methods
        public void set_RestartLabel(string value)
        {
            if(this.TxtRestartLabel != null)
            {
                    this.TxtRestartLabel.text = value;
                return;
            }
            
            throw new NullReferenceException();
        }
        public EndGameHud()
        {
        
        }
    
    }

}
