using UnityEngine;

namespace Game.States
{
    public sealed class GamePlayHideState : BaseGamePlayState
    {
        // Methods
        public override void Initialize()
        {
            var val_7;
            this.Initialize();
            var val_8 = 6;
            label_6:
            val_7 = 13638;
            if((val_8 - 4) >= (mem[4611686018427401566] << ))
            {
                goto label_3;
            }
            
            this.CreateEnemy(unit:  mem[4611686018427401590], isVictim:  true);
            val_8 = val_8 + 1;
            if(val_7 != 0)
            {
                goto label_6;
            }
            
            throw new NullReferenceException();
            label_3:
            this.CreatePlayer(unit:  mem[4611686018427401582], isVictim:  true);
            mem[4611686018427401598].SetTarget(target:  mem[4611686018427401566] + 64 + 24.gameObject);
            this.AddMediator<GameHud>(mediator:  new Game.UI.GameHudMediator(isHided:  true), hud:  System.Collections.Generic.KeyValuePair<System.Int64, System.Object> System.Array::InternalArray__get_Item<System.Collections.Generic.KeyValuePair<System.Int64, System.Object>>(int index));
            this.AddMediator<Game.UI.UnitsHolderHud>(mediator:  new Game.UI.UnitsHolderHudMediator(isHided:  true), hud:  "w788qs");
            this.AddMediator<GameHud>(mediator:  new Game.UI.RadarHudMediator(), hud:  UnityEngine.UIVertex System.Array::InternalArray__IReadOnlyList_get_Item<UnityEngine.UIVertex>(int index));
            Game.HearStepsManager val_6 = new Game.HearStepsManager(isShowEffects:  false);
            this.AddMediator<Game.LevelView>(mediator:  val_6, hud:  UnityEngine.UIVertex System.Array::InternalArray__IReadOnlyList_get_Item<UnityEngine.UIVertex>(int index));
            val_6.add_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlayHideState::TimerOnONE_SECOND_TICK()));
        }
        public override void Dispose()
        {
            this.Dispose();
            469778432.SetTarget(target:  0);
            remove_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlayHideState::TimerOnONE_SECOND_TICK()));
            Dispose();
        }
        private void TimerOnONE_SECOND_TICK()
        {
            if(UnityEngine.Time.time > S1)
            {
                    0.CreateEnemy(unit:  mem[4611686018427401574], isVictim:  false);
                mem[1152921507299486232] = 2155872256;
            }
            
            if((mem[2155872320] + 24 + 32) != 2)
            {
                    if((mem[2155872320] + 24 + 32 + 28) == 0)
            {
                    return;
            }
            
            }
            
            remove_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlayHideState::TimerOnONE_SECOND_TICK()));
            gameObject.SetActive(value:  false);
            "Option A".__il2cppRuntimeField_18 + 64.Dispose();
            this.AddMediator<Game.UI.EndGameHud>(mediator:  new Game.UI.EndGameHudMediator(isWin:  (("Option A".__il2cppRuntimeField_18 + 32) != 2) ? 1 : 0), hud:  null);
        }
        public GamePlayHideState()
        {
        
        }
    
    }

}
