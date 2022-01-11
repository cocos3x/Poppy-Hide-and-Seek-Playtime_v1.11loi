using UnityEngine;

namespace Game.States
{
    public sealed class GamePlaySeekState : BaseGamePlayState
    {
        // Methods
        public override void Initialize()
        {
            var val_7;
            this.Initialize();
            UnityEngine.GameObject val_1 = mem[-3458764513820540856].gameObject;
            val_1.SetActive(value:  false);
            label_10:
            val_7 = mem[-3458764513820540904];
            if((5 - 4) >= ((mem[-3458764513820540904] + 24) << ))
            {
                goto label_7;
            }
            
            val_1.CreateEnemy(unit:  mem[-3458764513820540904] + 40, isVictim:  true);
            var val_3 = 5 + 1;
            if(val_7 != 0)
            {
                goto label_10;
            }
            
            throw new NullReferenceException();
            label_7:
            (5 - 4) + 56.SetTarget(target:  mem[-3458764513820540904] + 32.gameObject);
            mem[-3458764513820540904] + 24 + 32.SetOutline(materials:  mem[-3458764513820540904] + 24 + 24 + 72);
            this.AddMediator<GameHud>(mediator:  new Game.UI.GameHudMediator(isHided:  false), hud:  System.Collections.Generic.KeyValuePair<System.Int64, System.Object> System.Array::InternalArray__get_Item<System.Collections.Generic.KeyValuePair<System.Int64, System.Object>>(int index));
            this.AddMediator<Game.UI.UnitsHolderHud>(mediator:  new Game.UI.UnitsHolderHudMediator(isHided:  false), hud:  "w788qs");
            Game.HearStepsManager val_7 = new Game.HearStepsManager(isShowEffects:  true);
            this.AddMediator<Game.LevelView>(mediator:  val_7, hud:  "w788qs");
            val_7.add_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlaySeekState::TimerOnONE_SECOND_TICK()));
        }
        public override void Dispose()
        {
            this.Dispose();
            469778432.SetTarget(target:  0);
            remove_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlaySeekState::TimerOnONE_SECOND_TICK()));
            Dispose();
        }
        private void TimerOnONE_SECOND_TICK()
        {
            if(UnityEngine.Time.time <= S1)
            {
                goto label_15;
            }
            
            469778432.ZoomTo(zoom:  0.GetValue(param:  6), duration:  1f);
            469778432.CreatePlayer(unit:  mem[4611686018427401574], isVictim:  false);
            mem[4611686018427401574] + 72.gameObject.SetActive(value:  true);
            mem[1152921507300025688] = 2155872256;
            label_18:
            if((5 - 4) >= (mem[4611686018427401574] + 24 + 24))
            {
                goto label_15;
            }
            
            mem[4611686018427401574] + 24 + 40.IsVissible = false;
            if((mem[4611686018427401574] + 24) != 0)
            {
                goto label_18;
            }
            
            throw new NullReferenceException();
            label_15:
            if((mem[4611686018427401574] + 24 + 28) == 0)
            {
                goto label_20;
            }
            
            label_33:
            5 + 1.remove_ONE_SECOND_TICK(value:  new System.Action(object:  this, method:  System.Void Game.States.GamePlaySeekState::TimerOnONE_SECOND_TICK()));
            System.Byte[].__il2cppRuntimeField_18 + 64.Dispose();
            UnityEngine.GameObject val_7 = System.Byte[].__il2cppRuntimeField_18 + 32.gameObject;
            val_7.SetActive(value:  false);
            this.AddMediator<Game.UI.EndGameHud>(mediator:  new Game.UI.EndGameHudMediator(isWin:  (val_7.EnemiesCount < 1) ? 1 : 0), hud:  Game.UI.EndGameHudMediator.__il2cppRuntimeField_this_arg);
            return;
            label_20:
            if((mem[4611686018427401574] + 24 + 40.EnemiesCount) <= 0)
            {
                goto label_33;
            }
        
        }
        public GamePlaySeekState()
        {
        
        }
    
    }

}
