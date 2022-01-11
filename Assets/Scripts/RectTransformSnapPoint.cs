using UnityEngine;
public class RectTransformSnapPoint
{
    // Fields
    public UnityEngine.RectTransform rectTransform;
    public UnityEngine.Vector2 initializedPosition;
    public UnityEngine.Vector2 targetPosition;
    
    // Methods
    public RectTransformSnapPoint(UnityEngine.RectTransform rt, float deltaX, float deltaY, bool moveTo = False)
    {
        this.rectTransform = rt;
        UnityEngine.Vector2 val_1 = rt.anchoredPosition;
        this.initializedPosition = val_1;
        mem[1152921507177684076] = val_1.y;
        if(moveTo != false)
        {
            
        }
        else
        {
                val_1.x = val_1.x + deltaX;
            val_1.y = val_1.y + deltaY;
        }
        
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  val_1.x, y:  val_1.y);
        this.targetPosition = val_2.x;
    }
    public DG.Tweening.Tween MoveToTargetPosition(float duration, bool resetAtStart = True)
    {
        if(resetAtStart == false)
        {
                return DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectTransform, endValue:  new UnityEngine.Vector2() {x = this.targetPosition}, duration:  duration, snapping:  false);
        }
        
        this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = this.initializedPosition};
        return DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectTransform, endValue:  new UnityEngine.Vector2() {x = this.targetPosition}, duration:  duration, snapping:  false);
    }
    public DG.Tweening.Tween MoveToInitializedPosition(float duration, bool resetAtStart = True)
    {
        if(resetAtStart == false)
        {
                return DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectTransform, endValue:  new UnityEngine.Vector2() {x = this.initializedPosition}, duration:  duration, snapping:  false);
        }
        
        this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = this.targetPosition};
        return DG.Tweening.DOTweenModuleUI.DOAnchorPos(target:  this.rectTransform, endValue:  new UnityEngine.Vector2() {x = this.initializedPosition}, duration:  duration, snapping:  false);
    }
    public void ResetToInitializedPosition()
    {
        if(this.rectTransform != null)
        {
                this.rectTransform.anchoredPosition = new UnityEngine.Vector2() {x = this.initializedPosition};
            return;
        }
        
        throw new NullReferenceException();
    }

}
