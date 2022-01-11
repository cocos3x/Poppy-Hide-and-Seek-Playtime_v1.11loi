using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleSprite
    {
        // Methods
        public static DG.Tweening.Tweener DOColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass0_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass0_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass0_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass0_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration), target:  (DOTweenModuleSprite.<>c__DisplayClass0_0)[1152921507229329376].target);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.SpriteRenderer target, float endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass1_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass1_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass1_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass1_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleSprite.<>c__DisplayClass1_0)[1152921507229492576].target);
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.SpriteRenderer target, UnityEngine.Gradient gradient, float duration)
        {
            DG.Tweening.Sequence val_1 = DG.Tweening.DOTween.Sequence();
            if(val_2.Length < 1)
            {
                    return val_1;
            }
            
            var val_12 = 0;
            do
            {
                if((val_12 == 0) && (null <= 0f))
            {
                    target.color = new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f};
            }
            else
            {
                    if((val_2.Length - 1) == val_12)
            {
                    float val_5 = duration - (DG.Tweening.TweenExtensions.Duration(t:  val_1, includeLoops:  false));
            }
            else
            {
                    if(val_12 != 0)
            {
                    var val_6 = val_12 - 1;
            }
            
            }
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.DOTweenModuleSprite.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f}, duration:  (null - null) * duration), ease:  1));
            }
            
                val_12 = val_12 + 1;
                if(val_12 >= (long)val_2.Length)
            {
                    return val_1;
            }
            
            }
            while(val_12 < val_2.Length);
            
            throw new IndexOutOfRangeException();
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.SpriteRenderer target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleSprite.<>c__DisplayClass3_0 val_1 = new DOTweenModuleSprite.<>c__DisplayClass3_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            .to = 0;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleSprite.<>c__DisplayClass3_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleSprite.<>c__DisplayClass3_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleSprite.<>c__DisplayClass3_0)[1152921507229898848].target);
        }
    
    }

}
