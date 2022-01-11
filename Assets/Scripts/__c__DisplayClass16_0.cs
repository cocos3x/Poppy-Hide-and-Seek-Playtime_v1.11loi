using UnityEngine;
private sealed class GameManager.<>c__DisplayClass16_0
{
    // Fields
    public Game.UnitView unitView;
    
    // Methods
    public GameManager.<>c__DisplayClass16_0()
    {
    
    }
    internal bool <Kill>b__0(Game.Enemy.EnemyController temp)
    {
        return UnityEngine.Object.op_Equality(x:  temp._view, y:  this.unitView);
    }

}
