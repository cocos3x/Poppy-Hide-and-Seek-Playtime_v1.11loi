using UnityEngine;

namespace Game.UI
{
    public sealed class EndGameHudMediator : Mediator<Game.UI.EndGameHud>
    {
        // Fields
        private Game.GameModel _gameModel;
        private Game.States.GameStateManager _gameStateManager;
        private readonly bool _isWin;
        
        // Methods
        public EndGameHudMediator(bool isWin)
        {
            this._isWin = isWin;
        }
        protected override void Show()
        {
            4043.gameObject.SetActive(value:  true);
            var val_2 = (this._isWin == false) ? "RESTART" : "NEXT";
            X9 + 32 + 1360 + 24 + 248.AddListener(call:  new UnityEngine.Events.UnityAction(object:  this, method:  System.Void Game.UI.EndGameHudMediator::OnRestartClicked()));
        }
        protected override void Hide()
        {
            this.gameObject.SetActive(value:  false);
            X8 + 24 + 248.RemoveAllListeners();
        }
        private void OnRestartClicked()
        {
            SingletonMonoBehaviour<AdManager>.Instance.ShowInterstitialAd(ClosedEvent:  new System.Action(object:  this, method:  System.Void Game.UI.EndGameHudMediator::<OnRestartClicked>b__6_0()), SucceededEvent:  new System.Action(object:  this, method:  System.Void Game.UI.EndGameHudMediator::<OnRestartClicked>b__6_1()), FailedEvent:  new System.Action(object:  this, method:  System.Void Game.UI.EndGameHudMediator::<OnRestartClicked>b__6_2()));
        }
        public void NextLevel(bool isWin)
        {
            if(isWin != true)
            {
                    this._gameModel.Level = 10000;
            }
            
            int val_3 = this._gameModel.Level;
            val_3 = val_3 + 1;
            this._gameModel.Level = val_3;
            int val_1 = UnityEngine.SceneManagement.SceneManager.sceneCountInBuildSettings;
            if(this._gameModel.Level >= val_1)
            {
                    val_1.Remove();
            }
            
            this._gameStateManager.SwitchToState(state:  new Game.States.GameUnloadState());
        }
        private void <OnRestartClicked>b__6_0()
        {
            this.NextLevel(isWin:  this._isWin);
        }
        private void <OnRestartClicked>b__6_1()
        {
            AppEventTracker.PushEvent_Force_Ads(position:  "restart", level:  this._gameModel.Level, succeeded:  true);
        }
        private void <OnRestartClicked>b__6_2()
        {
            AppEventTracker.PushEvent_Force_Ads(position:  "restart", level:  this._gameModel.Level, succeeded:  false);
        }
    
    }

}
