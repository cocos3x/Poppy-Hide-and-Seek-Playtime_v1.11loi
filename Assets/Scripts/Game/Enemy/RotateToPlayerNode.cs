using UnityEngine;

namespace Game.Enemy
{
    public sealed class RotateToPlayerNode : TimeNode
    {
        // Fields
        private Game.GameManager _gameManager;
        private Game.Enemy.EnemyController _enemyController;
        
        // Methods
        public override void Process()
        {
            this.Process();
            UnityEngine.Vector2 val_1 = this._enemyController._view.Position;
            float val_10 = val_1.y;
            val_10 = 270f - (Utilities.MathUtil.GetAngle(start:  new UnityEngine.Vector2() {x = val_1.x, y = val_10}, end:  new UnityEngine.Vector2() {x = this._enemyController.<LastHearVictim>k__BackingField, y = V10.16B}));
            float val_5 = UnityEngine.Time.deltaTime * this._enemyController.RotationSpeed;
            float val_9 = this._enemyController._view.Rotation;
            val_9 = (UnityEngine.Mathf.Clamp(value:  UnityEngine.Mathf.DeltaAngle(current:  this._enemyController._view.Rotation, target:  val_10), min:  -val_5, max:  val_5)) + val_9;
            this._enemyController._view.Rotation = val_9;
        }
        public RotateToPlayerNode()
        {
            val_1 = new UnityEngine.StateMachineBehaviour();
        }
    
    }

}
