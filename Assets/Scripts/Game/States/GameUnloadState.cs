using UnityEngine;

namespace Game.States
{
    public sealed class GameUnloadState : GameState
    {
        // Fields
        private Game.States.GameStateManager _gameStateManager;
        
        // Methods
        public override void Initialize()
        {
            UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  0);
            val_1.m_Handle = val_1.m_Handle & 4294967295;
            bool val_2 = UnityEngine.SceneManagement.SceneManager.SetActiveScene(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_1.m_Handle});
            UnityEngine.SceneManagement.SceneManager.add_sceneUnloaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  this, method:  System.Void Game.States.GameUnloadState::SceneManagerOnsceneUnloaded(UnityEngine.SceneManagement.Scene scene)));
            UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  1);
            val_4.m_Handle = val_4.m_Handle & 4294967295;
            UnityEngine.AsyncOperation val_5 = UnityEngine.SceneManagement.SceneManager.UnloadSceneAsync(scene:  new UnityEngine.SceneManagement.Scene() {m_Handle = val_4.m_Handle}, options:  0);
        }
        public override void Dispose()
        {
            UnityEngine.SceneManagement.SceneManager.remove_sceneUnloaded(value:  new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene>(object:  this, method:  System.Void Game.States.GameUnloadState::SceneManagerOnsceneUnloaded(UnityEngine.SceneManagement.Scene scene)));
        }
        private void SceneManagerOnsceneUnloaded(UnityEngine.SceneManagement.Scene scene)
        {
            this._gameStateManager.SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public GameUnloadState()
        {
            val_1 = new System.Object();
        }
    
    }

}
