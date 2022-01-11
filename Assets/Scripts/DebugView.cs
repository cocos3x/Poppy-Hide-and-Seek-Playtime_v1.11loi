using UnityEngine;
public class DebugView : MonoBehaviour
{
    // Fields
    public CharacterManager characterManager;
    public GameFlow gameFlow;
    public UnityEngine.UI.InputField inputField;
    public Hider[] hiderPrefabs;
    public Seeker[] seekerPrefabs;
    
    // Methods
    public void Open()
    {
        var val_3;
        this.gameObject.SetActive(value:  true);
        val_3 = null;
        val_3 = null;
        UserData.current.level
        this.inputField.text = UserData.current.level.ToString();
    }
    public void Close()
    {
        this.gameObject.SetActive(value:  false);
    }
    public void LoadMap()
    {
        null = null;
        if((System.Int32.TryParse(s:  this.inputField.m_Text, result: out  UserData.current.level)) == false)
        {
                return;
        }
        
        this.gameFlow.OnGameEnd();
        this.gameFlow.ClearLevel();
        this.gameFlow.LoadLevel();
    }
    public DebugView()
    {
    
    }

}
