using UnityEngine;

namespace Game.Enemy.States
{
    public sealed class EnemyLiveState : EnemyState
    {
        // Fields
        private Game.Core.Timer _timer;
        private Game.Enemy.EnemyController _enemyController;
        private Injection.Injector _injector;
        private Game.GameManager _gameManager;
        private Game.Enemy.Node _currentNode;
        
        // Methods
        public override void Initialize()
        {
            this._enemyController._view.RestartNodes();
            System.Delegate val_2 = System.Delegate.Combine(a:  this._enemyController._view.NodeEntered, b:  new System.Action<Game.Enemy.Node>(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::NodeEntered(Game.Enemy.Node node)));
            if(val_2 != null)
            {
                    if(null != null)
            {
                goto label_10;
            }
            
            }
            
            this._enemyController._view.NodeEntered = val_2;
            this._timer.add_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::TimerOnPOST_TICK()));
            System.Delegate val_5 = System.Delegate.Combine(a:  this._gameManager.UNIT_SOUND, b:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::OnHearUnit(UnityEngine.Vector3 position)));
            if(val_5 != null)
            {
                    if(null != null)
            {
                goto label_10;
            }
            
            }
            
            this._gameManager.UNIT_SOUND = val_5;
            return;
            label_10:
        }
        public override void Dispose()
        {
            if(0 != this._currentNode)
            {
                    this._currentNode = 0;
            }
            
            System.Delegate val_3 = System.Delegate.Remove(source:  this._enemyController._view.NodeEntered, value:  new System.Action<Game.Enemy.Node>(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::NodeEntered(Game.Enemy.Node node)));
            if(val_3 != null)
            {
                    if(null != null)
            {
                goto label_12;
            }
            
            }
            
            this._enemyController._view.NodeEntered = val_3;
            this._timer.remove_POST_TICK(value:  new System.Action(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::TimerOnPOST_TICK()));
            System.Delegate val_6 = System.Delegate.Remove(source:  this._gameManager.UNIT_SOUND, value:  new System.Action<UnityEngine.Vector3>(object:  this, method:  System.Void Game.Enemy.States.EnemyLiveState::OnHearUnit(UnityEngine.Vector3 position)));
            if(val_6 != null)
            {
                    if(null != null)
            {
                goto label_12;
            }
            
            }
            
            this._gameManager.UNIT_SOUND = val_6;
            return;
            label_12:
        }
        private void NodeEntered(Game.Enemy.Node node)
        {
            bool val_1 = UnityEngine.Object.op_Inequality(x:  0, y:  this._currentNode);
            this._currentNode = node;
            this._injector.Inject(value:  node);
        }
        private void TimerOnPOST_TICK()
        {
            UnityEngine.Collider val_1 = this._enemyController._view.GetSeenVictim();
            if(0 != val_1)
            {
                    this._gameManager.Kill(unitView:  val_1.GetComponent<Game.UnitView>());
            }
            
            if(0 == this._currentNode)
            {
                    return;
            }
            
            if(this._currentNode.IsCompleted != false)
            {
                    this._currentNode = 0;
            }
        
        }
        private void OnHearUnit(UnityEngine.Vector3 position)
        {
            float val_8 = position.z;
            if(this._enemyController._view._isVictim == true)
            {
                    return;
            }
            
            UnityEngine.Vector2 val_1 = new UnityEngine.Vector2(x:  position.x, y:  val_8 = position.z);
            UnityEngine.Vector2 val_2 = UnityEngine.Vector2.zero;
            if((UnityEngine.Vector2.op_Equality(lhs:  new UnityEngine.Vector2() {x = this._enemyController.<LastHearVictim>k__BackingField, y = val_8}, rhs:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y})) != true)
            {
                    UnityEngine.Vector2 val_4 = this._enemyController._view.Position;
                val_8 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = val_1.x, y = val_1.y}, b:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
                UnityEngine.Vector2 val_6 = this._enemyController._view.Position;
                float val_7 = UnityEngine.Vector2.Distance(a:  new UnityEngine.Vector2() {x = this._enemyController.<LastHearVictim>k__BackingField, y = val_4.x}, b:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y});
                if(val_8 >= 0)
            {
                    return;
            }
            
            }
            
            this._enemyController.<LastHearVictim>k__BackingField = val_1.x;
        }
        public EnemyLiveState()
        {
            val_1 = new System.Object();
        }
    
    }

}
