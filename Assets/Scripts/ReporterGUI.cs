using UnityEngine;
public class ReporterGUI : MonoBehaviour
{
    // Fields
    private Reporter reporter;
    
    // Methods
    private void Awake()
    {
        this.reporter = this.gameObject.GetComponent<Reporter>();
    }
    private void OnGUI()
    {
        if(this.reporter != null)
        {
                this.reporter.OnGUIDraw();
            return;
        }
        
        throw new NullReferenceException();
    }
    public ReporterGUI()
    {
    
    }

}
