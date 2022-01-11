using UnityEngine;
public class Reporter.Log
{
    // Fields
    public int count;
    public Reporter._LogType logType;
    public string condition;
    public string stacktrace;
    public int sampleId;
    
    // Methods
    public Reporter.Log CreateCopy()
    {
        object val_1 = this.MemberwiseClone();
        if(val_1 == null)
        {
                return (Log)val_1;
        }
        
        return (Log)val_1;
    }
    public float GetMemoryUsage()
    {
        int val_1 = this.condition.m_stringLength;
        val_1 = this.stacktrace.m_stringLength + val_1;
        val_1 = val_1 << 1;
        val_1 = val_1 + 12;
        return (float)(float)val_1;
    }
    public Reporter.Log()
    {
        this.count = 1;
    }

}
