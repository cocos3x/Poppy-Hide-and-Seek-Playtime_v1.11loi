using UnityEngine;

namespace Game
{
    public sealed class GameManager : IDisposable
    {
        // Fields
        public System.Action<Game.UnitView> UNIT_KILLED;
        public System.Action<Game.UnitView> UNIT_RESCUED;
        public System.Action<Game.UnitView, int> COINS_COLLECTED;
        public System.Action<UnityEngine.Vector3> UNIT_SOUND;
        private Injection.Injector _injector;
        private Injection.Context _context;
        private Game.Player.PlayerController _player;
        private readonly System.Collections.Generic.List<Game.Enemy.EnemyController> _enemies;
        
        // Properties
        public Game.Player.PlayerController Player { get; }
        public int EnemiesCount { get; }
        
        // Methods
        public Game.Player.PlayerController get_Player()
        {
            return (Game.Player.PlayerController)this._player;
        }
        public int get_EnemiesCount()
        {
            return 5171;
        }
        public GameManager()
        {
            this._enemies = new System.Collections.Generic.List<Game.Enemy.EnemyController>();
        }
        public void Dispose()
        {
            List.Enumerator<T> val_1 = this._enemies.GetEnumerator();
            label_4:
            if(((-1631333976) & 1) == 0)
            {
                goto label_2;
            }
            
            if(0 == 0)
            {
                    throw new NullReferenceException();
            }
            
            0.Dispose();
            goto label_4;
            label_2:
            0.Add(driver:  public System.Void List.Enumerator<Game.Enemy.EnemyController>::Dispose(), rectTransform:  null, drivenProperties:  null);
            this._enemies.Clear();
            this._player.Dispose();
            this._player = 0;
        }
        public void CreatePlayer(Game.UnitView unit, bool isVictim)
        {
            Game.Player.PlayerController val_1 = new Game.Player.PlayerController(context:  this._context, player:  unit);
            this._player = val_1;
            this._injector.Inject(value:  val_1);
            this._player.Live(isVictim:  isVictim);
        }
        public void CreateEnemy(Game.UnitView unit, bool isVictim)
        {
            Game.Enemy.EnemyController val_1 = new Game.Enemy.EnemyController(view:  unit, context:  this._context);
            this._injector.Inject(value:  val_1);
            this._enemies.Add(item:  val_1);
            val_1.Live(isVictim:  isVictim);
        }
        public void Kill(Game.UnitView unitView)
        {
            .unitView = unitView;
            ActionExtentions.SafeInvoke<Game.UnitView>(invocationTarget:  this.UNIT_KILLED, arg:  unitView);
            if(this._player._view == ((GameManager.<>c__DisplayClass16_0)[1152921507271009856].unitView))
            {
                    this._player.Kill();
                return;
            }
            
            Game.Enemy.EnemyController val_4 = System.Linq.Enumerable.FirstOrDefault<Game.Enemy.EnemyController>(source:  this._enemies, predicate:  new System.Func<Game.Enemy.EnemyController, System.Boolean>(object:  new GameManager.<>c__DisplayClass16_0(), method:  System.Boolean GameManager.<>c__DisplayClass16_0::<Kill>b__0(Game.Enemy.EnemyController temp)));
            bool val_5 = this._enemies.Remove(item:  val_4);
            val_4.Kill();
        }
        public void Rescue(Game.UnitView unit)
        {
            if(this._player._view == unit)
            {
                    return;
            }
            
            ActionExtentions.SafeInvoke<Game.UnitView>(invocationTarget:  this.UNIT_RESCUED, arg:  unit);
            this.CreateEnemy(unit:  unit, isVictim:  true);
            unit.IsVissible = unit._isVissible;
        }
        public void CollectCoin(Game.UnitView unit, int value)
        {
            ActionExtentions.SafeInvoke<Game.UnitView, System.Int32>(invocationTarget:  this.COINS_COLLECTED, arg1:  unit, arg2:  value);
        }
        public void FireSound(UnityEngine.Vector3 position)
        {
            ActionExtentions.SafeInvoke<UnityEngine.Vector3>(invocationTarget:  this.UNIT_SOUND, arg:  new UnityEngine.Vector3() {x = position.x, y = position.y, z = position.z});
        }
    
    }

}
