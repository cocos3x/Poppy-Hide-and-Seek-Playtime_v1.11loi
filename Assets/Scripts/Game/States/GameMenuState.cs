using UnityEngine;

namespace Game.States
{
    public sealed class GameMenuState : GameState
    {
        // Fields
        private GameView _gameView;
        private Game.States.GameStateManager _gameStateManager;
        private Game.Config.GameConfig _gameConfig;
        
        // Methods
        public override void Initialize()
        {
            this._gameView.CameraFollower.ResetToDefaultPosition();
            this._gameView.CameraFollower.ZoomTo(zoom:  this._gameConfig.GetValue(param:  7), duration:  0f);
            this._gameView.GameHud.gameObject.SetActive(value:  false);
            this._gameView.MenuHud.gameObject.SetActive(value:  true);
            this._gameView.MenuHud.BtnHide.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Game.States.GameMenuState::OnBtnHideClicked()));
            this._gameView.MenuHud.BtnSeek.m_OnClick.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Game.States.GameMenuState::OnBtnSeekClicked()));
            UnityEngine.SceneManagement.Scene val_6 = UnityEngine.SceneManagement.SceneManager.GetSceneAt(index:  1);
            this._gameView.MenuHud.TxtLevelName.text = val_6.m_Handle.name;
        }
        public override void Dispose()
        {
            this._gameView.MenuHud.gameObject.SetActive(value:  false);
            this._gameView.MenuHud.BtnHide.m_OnClick.RemoveAllListeners();
            this._gameView.MenuHud.BtnSeek.m_OnClick.RemoveAllListeners();
        }
        private void OnBtnHideClicked()
        {
            this._gameView.CameraFollower.ZoomTo(zoom:  this._gameConfig.GetValue(param:  6), duration:  1f);
            this._gameStateManager.SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        private void OnBtnSeekClicked()
        {
            this._gameView.CameraFollower.ZoomTo(zoom:  this._gameConfig.GetValue(param:  8), duration:  1f);
            this._gameStateManager.SwitchToState(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public GameMenuState()
        {
            val_1 = new System.Object();
        }
    
    }

}
