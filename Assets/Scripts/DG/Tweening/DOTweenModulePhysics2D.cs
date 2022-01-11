using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModulePhysics2D
    {
        // Methods
        public static DG.Tweening.Tweener DOMove(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass0_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass0_0::<DOMove>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass0_0)[1152921507226479072].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass0_0)[1152921507226479072].target);
        }
        public static DG.Tweening.Tweener DOMoveX(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass1_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass1_0::<DOMoveX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass1_0)[1152921507226661728].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  2, snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass1_0)[1152921507226661728].target);
        }
        public static DG.Tweening.Tweener DOMoveY(UnityEngine.Rigidbody2D target, float endValue, float duration, bool snapping = False)
        {
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass2_0(), method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass2_0::<DOMoveY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass2_0)[1152921507226848480].target, method:  public System.Void UnityEngine.Rigidbody2D::MovePosition(UnityEngine.Vector2 position)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  4, snapping:  snapping), target:  (DOTweenModulePhysics2D.<>c__DisplayClass2_0)[1152921507226848480].target);
        }
        public static DG.Tweening.Tweener DORotate(UnityEngine.Rigidbody2D target, float endValue, float duration)
        {
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  new DOTweenModulePhysics2D.<>c__DisplayClass3_0(), method:  System.Single DOTweenModulePhysics2D.<>c__DisplayClass3_0::<DORotate>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  (DOTweenModulePhysics2D.<>c__DisplayClass3_0)[1152921507227028064].target, method:  public System.Void UnityEngine.Rigidbody2D::MoveRotation(float angle)), endValue:  endValue, duration:  duration), target:  (DOTweenModulePhysics2D.<>c__DisplayClass3_0)[1152921507227028064].target);
        }
        public static DG.Tweening.Sequence DOJump(UnityEngine.Rigidbody2D target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            DOTweenModulePhysics2D.<>c__DisplayClass4_0 val_1 = new DOTweenModulePhysics2D.<>c__DisplayClass4_0();
            .target = target;
            .endValue = endValue;
            mem[1152921507227289620] = endValue.y;
            .startPosY = 0f;
            .offsetYSet = false;
            .offsetY = -1f;
            int val_2 = (numJumps > 1) ? numJumps : (0 + 1);
            .s = DG.Tweening.DOTween.Sequence();
            UnityEngine.Vector2 val_6 = new UnityEngine.Vector2(x:  0f, y:  jumpPower);
            val_2 = val_2 << 1;
            float val_27 = (float)val_2;
            val_27 = duration / val_27;
            bool val_8 = snapping;
            .yTween = DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, duration:  val_27), axisConstraint:  4, snapping:  val_8), ease:  6)), loops:  val_2, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__2()));
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].endValue, y:  0f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].s, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__3()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__4(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, duration:  duration), axisConstraint:  2, snapping:  val_8), ease:  1)), t:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].yTween), target:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].target), ease:  DG.Tweening.DOTween.defaultEaseType);
            DG.Tweening.Tween val_26 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Tween>(t:  (DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].yTween, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModulePhysics2D.<>c__DisplayClass4_0::<DOJump>b__5()));
            return (DG.Tweening.Sequence)(DOTweenModulePhysics2D.<>c__DisplayClass4_0)[1152921507227289568].s;
        }
    
    }

}
