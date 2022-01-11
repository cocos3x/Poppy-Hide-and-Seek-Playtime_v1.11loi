using UnityEngine;
private sealed class GameFlow.<>c__DisplayClass61_0
{
    // Fields
    public CameraFollowPlayer cameraFollowPlayer;
    
    // Methods
    public GameFlow.<>c__DisplayClass61_0()
    {
    
    }
    internal void <OnGameStart>b__0()
    {
        if(this.cameraFollowPlayer != null)
        {
                this.cameraFollowPlayer.enabled = true;
            return;
        }
        
        throw new NullReferenceException();
    }

}
