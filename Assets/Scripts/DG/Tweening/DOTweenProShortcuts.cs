using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenProShortcuts
    {
        // Methods
        private static DOTweenProShortcuts()
        {
            DG.Tweening.Plugins.SpiralPlugin val_1 = new DG.Tweening.Plugins.SpiralPlugin();
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Transform target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_14;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            val_14 = depth;
            val_15 = frequency;
            val_16 = duration;
            DOTweenProShortcuts.<>c__DisplayClass1_0 val_1 = new DOTweenProShortcuts.<>c__DisplayClass1_0();
            .target = target;
            val_17 = 0f;
            val_18 = 1f;
            if((mode & 0) != 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_18 = axis.HasValue;
            val_17 = axis.HasValue >> 32;
            val_14 = val_14;
            val_15 = val_15;
            val_19 = ((UnityEngine.Mathf.Approximately(a:  speed, b:  val_17)) != true) ? (val_18) : speed;
            val_16 = val_16;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = mode}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                goto label_9;
            }
            
            label_4:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            label_9:
            mem2[0] = snapping;
            mem2[0] = val_19;
            mem2[0] = val_15;
            mem2[0] = val_14;
            mem2[0] = W4 & 1;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  DG.Tweening.Plugins.SpiralPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenProShortcuts.<>c__DisplayClass1_0::<DOSpiral>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenProShortcuts.<>c__DisplayClass1_0::<DOSpiral>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_16), target:  (DOTweenProShortcuts.<>c__DisplayClass1_0)[1152921507261729584].target);
        }
        public static DG.Tweening.Tweener DOSpiral(UnityEngine.Rigidbody target, float duration, System.Nullable<UnityEngine.Vector3> axis, DG.Tweening.SpiralMode mode = 0, float speed = 1, float frequency = 10, float depth = 0, bool snapping = False)
        {
            float val_14;
            float val_15;
            float val_16;
            float val_17;
            float val_18;
            float val_19;
            val_14 = depth;
            val_15 = frequency;
            val_16 = duration;
            .target = target;
            val_17 = 0f;
            val_18 = 1f;
            if((mode & 0) != 0)
            {
                goto label_4;
            }
            
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_18 = axis.HasValue;
            val_17 = axis.HasValue >> 32;
            val_14 = val_14;
            val_15 = val_15;
            val_19 = ((UnityEngine.Mathf.Approximately(a:  speed, b:  val_17)) != true) ? (val_18) : speed;
            val_16 = val_16;
            if((UnityEngine.Vector3.op_Equality(lhs:  new UnityEngine.Vector3() {x = val_18, y = val_17, z = mode}, rhs:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z})) == false)
            {
                goto label_9;
            }
            
            label_4:
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.forward;
            label_9:
            mem2[0] = snapping;
            mem2[0] = val_19;
            mem2[0] = val_15;
            mem2[0] = val_14;
            mem2[0] = W4 & 1;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>>(t:  DG.Tweening.DOTween.To<UnityEngine.Vector3, UnityEngine.Vector3, DG.Tweening.Plugins.SpiralOptions>(plugin:  DG.Tweening.Plugins.SpiralPlugin.Get(), getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  new DOTweenProShortcuts.<>c__DisplayClass2_0(), method:  UnityEngine.Vector3 DOTweenProShortcuts.<>c__DisplayClass2_0::<DOSpiral>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  (DOTweenProShortcuts.<>c__DisplayClass2_0)[1152921507261920432].target, method:  public System.Void UnityEngine.Rigidbody::MovePosition(UnityEngine.Vector3 position)), endValue:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, duration:  val_16), target:  (DOTweenProShortcuts.<>c__DisplayClass2_0)[1152921507261920432].target);
        }
    
    }

}
