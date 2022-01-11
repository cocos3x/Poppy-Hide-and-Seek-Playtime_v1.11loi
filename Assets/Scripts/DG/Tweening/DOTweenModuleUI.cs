using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUI
    {
        // Methods
        public static DG.Tweening.Tweener DOFade(UnityEngine.CanvasGroup target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass0_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass0_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass0_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass0_0::<DOFade>b__1(float x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass0_0)[1152921507231119200].target);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass1_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass1_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass1_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass1_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass1_0)[1152921507231282400].target);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Graphic target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass2_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass2_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass2_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass2_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass2_0)[1152921507231445600].target);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass3_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass3_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass3_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass3_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass3_0)[1152921507231608800].target);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Image target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass4_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass4_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass4_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass4_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass4_0)[1152921507231772000].target);
        }
        public static DG.Tweening.Tweener DOFillAmount(UnityEngine.UI.Image target, float endValue, float duration)
        {
            float val_5;
            DOTweenModuleUI.<>c__DisplayClass5_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass5_0();
            val_5 = 1f;
            .target = target;
            if(endValue > val_5)
            {
                    return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__1(float x)), endValue:  val_5 = 0f, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass5_0)[1152921507231935200].target);
            }
            
            val_5 = endValue;
            if(endValue >= 0)
            {
                    return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__1(float x)), endValue:  val_5, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass5_0)[1152921507231935200].target);
            }
            
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass5_0::<DOFillAmount>b__1(float x)), endValue:  val_5, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass5_0)[1152921507231935200].target);
        }
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.UI.Image target, UnityEngine.Gradient gradient, float duration)
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
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.DOTweenModuleUI.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f}, duration:  (null - null) * duration), ease:  1));
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
        public static DG.Tweening.Tweener DOFlexibleSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass7_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass7_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass7_0::<DOFlexibleSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass7_0::<DOFlexibleSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass7_0)[1152921507232337376].target);
        }
        public static DG.Tweening.Tweener DOMinSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass8_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass8_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass8_0::<DOMinSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass8_0::<DOMinSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass8_0)[1152921507232508768].target);
        }
        public static DG.Tweening.Tweener DOPreferredSize(UnityEngine.UI.LayoutElement target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass9_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass9_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass9_0::<DOPreferredSize>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass9_0::<DOPreferredSize>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass9_0)[1152921507232680160].target);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Outline target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass10_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass10_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass10_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass10_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass10_0)[1152921507232847456].target);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Outline target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass11_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass11_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass11_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass11_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass11_0)[1152921507233010656].target);
        }
        public static DG.Tweening.Tweener DOScale(UnityEngine.UI.Outline target, UnityEngine.Vector2 endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass12_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass12_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass12_0::<DOScale>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass12_0::<DOScale>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass12_0)[1152921507233173856].target);
        }
        public static DG.Tweening.Tweener DOAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass13_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass13_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass13_0::<DOAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass13_0::<DOAnchorPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass13_0)[1152921507233341152].target);
        }
        public static DG.Tweening.Tweener DOAnchorPosX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass14_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass14_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass14_0::<DOAnchorPosX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass14_0::<DOAnchorPosX>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  2, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass14_0)[1152921507233516640].target);
        }
        public static DG.Tweening.Tweener DOAnchorPosY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass15_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass15_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass15_0::<DOAnchorPosY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass15_0::<DOAnchorPosY>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass15_0)[1152921507233696224].target);
        }
        public static DG.Tweening.Tweener DOAnchorPos3D(UnityEngine.RectTransform target, UnityEngine.Vector3 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass16_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass16_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass16_0::<DOAnchorPos3D>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass16_0::<DOAnchorPos3D>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = endValue.x, y = endValue.y, z = endValue.z}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass16_0)[1152921507233871712].target);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DX(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass17_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass17_0();
            .target = target;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass17_0::<DOAnchorPos3DX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass17_0::<DOAnchorPos3DX>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration), axisConstraint:  2, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass17_0)[1152921507234047200].target);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DY(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass18_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass18_0();
            .target = target;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass18_0::<DOAnchorPos3DY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass18_0::<DOAnchorPos3DY>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration), axisConstraint:  4, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass18_0)[1152921507234226784].target);
        }
        public static DG.Tweening.Tweener DOAnchorPos3DZ(UnityEngine.RectTransform target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass19_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass19_0();
            .target = target;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass19_0::<DOAnchorPos3DZ>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass19_0::<DOAnchorPos3DZ>b__1(UnityEngine.Vector3 x)), endValue:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, duration:  duration), axisConstraint:  8, snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass19_0)[1152921507234406368].target);
        }
        public static DG.Tweening.Tweener DOAnchorMax(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass20_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass20_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass20_0::<DOAnchorMax>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass20_0::<DOAnchorMax>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass20_0)[1152921507234581856].target);
        }
        public static DG.Tweening.Tweener DOAnchorMin(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass21_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass21_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass21_0::<DOAnchorMin>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass21_0::<DOAnchorMin>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass21_0)[1152921507234753248].target);
        }
        public static DG.Tweening.Tweener DOPivot(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass22_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass22_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector2, UnityEngine.Vector2, DG.Tweening.Plugins.Options.VectorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass22_0::<DOPivot>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass22_0::<DOPivot>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass22_0)[1152921507234920544].target);
        }
        public static DG.Tweening.Tweener DOPivotX(UnityEngine.RectTransform target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass23_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass23_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  endValue, y:  0f);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass23_0::<DOPivotX>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass23_0::<DOPivotX>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  2, snapping:  false), target:  (DOTweenModuleUI.<>c__DisplayClass23_0)[1152921507235091936].target);
        }
        public static DG.Tweening.Tweener DOPivotY(UnityEngine.RectTransform target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass24_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass24_0();
            .target = target;
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  0f, y:  endValue);
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass24_0::<DOPivotY>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass24_0::<DOPivotY>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y}, duration:  duration), axisConstraint:  4, snapping:  false), target:  (DOTweenModuleUI.<>c__DisplayClass24_0)[1152921507235271520].target);
        }
        public static DG.Tweening.Tweener DOSizeDelta(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass25_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass25_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass25_0::<DOSizeDelta>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass25_0::<DOSizeDelta>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass25_0)[1152921507235447008].target);
        }
        public static DG.Tweening.Tweener DOPunchAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 punch, float duration, int vibrato = 10, float elasticity = 1, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass26_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass26_0();
            .target = target;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = punch.x, y = punch.y});
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Punch(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass26_0::<DOPunchAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass26_0::<DOPunchAnchorPos>b__1(UnityEngine.Vector3 x)), direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, duration:  duration, vibrato:  vibrato, elasticity:  elasticity), target:  (DOTweenModuleUI.<>c__DisplayClass26_0)[1152921507235618400].target), snapping:  snapping);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, float strength = 100, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            DOTweenModuleUI.<>c__DisplayClass27_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass27_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Shake(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass27_0::<DOShakeAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass27_0::<DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)), duration:  duration, strength:  strength, vibrato:  vibrato, randomness:  randomness, ignoreZAxis:  true, fadeOut:  fadeOut), target:  (DOTweenModuleUI.<>c__DisplayClass27_0)[1152921507235793888].target), mode:  2), snapping:  snapping);
        }
        public static DG.Tweening.Tweener DOShakeAnchorPos(UnityEngine.RectTransform target, float duration, UnityEngine.Vector2 strength, int vibrato = 10, float randomness = 90, bool snapping = False, bool fadeOut = True)
        {
            DOTweenModuleUI.<>c__DisplayClass28_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass28_0();
            .target = target;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector2.op_Implicit(v:  new UnityEngine.Vector2() {x = strength.x, y = strength.y});
            return DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Vector3, UnityEngine.Vector3[], DG.Tweening.Plugins.Options.Vector3ArrayOptions>>(t:  DG.Tweening.DOTween.Shake(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector3>(object:  val_1, method:  UnityEngine.Vector3 DOTweenModuleUI.<>c__DisplayClass28_0::<DOShakeAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector3>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass28_0::<DOShakeAnchorPos>b__1(UnityEngine.Vector3 x)), duration:  duration, strength:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, vibrato:  vibrato, randomness:  randomness, fadeOut:  fadeOut), target:  (DOTweenModuleUI.<>c__DisplayClass28_0)[1152921507235973472].target), mode:  2), snapping:  snapping);
        }
        public static DG.Tweening.Sequence DOJumpAnchorPos(UnityEngine.RectTransform target, UnityEngine.Vector2 endValue, float jumpPower, int numJumps, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass29_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass29_0();
            .target = target;
            .endValue = endValue;
            mem[1152921507236235028] = endValue.y;
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
            UnityEngine.Vector2 val_17 = new UnityEngine.Vector2(x:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921507236234976].endValue, y:  0f);
            DG.Tweening.Sequence val_24 = DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Sequence>(t:  DG.Tweening.TweenSettingsExtensions.Join(s:  DG.Tweening.TweenSettingsExtensions.Append(s:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921507236234976].s, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__3()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__4(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_17.x, y = val_17.y}, duration:  duration), axisConstraint:  2, snapping:  val_8), ease:  1)), t:  DG.Tweening.TweenSettingsExtensions.OnStart<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetLoops<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetRelative<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = val_6.x, y = val_6.y}, duration:  val_27), axisConstraint:  4, snapping:  val_8), ease:  6)), loops:  val_2, loopType:  1), action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__2()))), target:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921507236234976].target), ease:  DG.Tweening.DOTween.defaultEaseType);
            DG.Tweening.Sequence val_26 = DG.Tweening.TweenSettingsExtensions.OnUpdate<DG.Tweening.Sequence>(t:  (DOTweenModuleUI.<>c__DisplayClass29_0)[1152921507236234976].s, action:  new DG.Tweening.TweenCallback(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass29_0::<DOJumpAnchorPos>b__5()));
            return (DG.Tweening.Sequence)(DOTweenModuleUI.<>c__DisplayClass29_0)[1152921507236234976].s;
        }
        public static DG.Tweening.Tweener DONormalizedPos(UnityEngine.UI.ScrollRect target, UnityEngine.Vector2 endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass30_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass30_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Vector2>(object:  val_1, method:  UnityEngine.Vector2 DOTweenModuleUI.<>c__DisplayClass30_0::<DONormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Vector2>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass30_0::<DONormalizedPos>b__1(UnityEngine.Vector2 x)), endValue:  new UnityEngine.Vector2() {x = endValue.x, y = endValue.y}, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass30_0)[1152921507236488288].target);
        }
        public static DG.Tweening.Tweener DOHorizontalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass31_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass31_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass31_0::<DOHorizontalNormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass31_0::<DOHorizontalNormalizedPos>b__1(float x)), endValue:  endValue, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass31_0)[1152921507236659680].target);
        }
        public static DG.Tweening.Tweener DOVerticalNormalizedPos(UnityEngine.UI.ScrollRect target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass32_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass32_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass32_0::<DOVerticalNormalizedPos>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass32_0::<DOVerticalNormalizedPos>b__1(float x)), endValue:  endValue, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass32_0)[1152921507236831072].target);
        }
        public static DG.Tweening.Tweener DOValue(UnityEngine.UI.Slider target, float endValue, float duration, bool snapping = False)
        {
            DOTweenModuleUI.<>c__DisplayClass33_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass33_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleUI.<>c__DisplayClass33_0::<DOValue>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass33_0::<DOValue>b__1(float x)), endValue:  endValue, duration:  duration), snapping:  snapping), target:  (DOTweenModuleUI.<>c__DisplayClass33_0)[1152921507237002464].target);
        }
        public static DG.Tweening.Tweener DOColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass34_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass34_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass34_0::<DOColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass34_0::<DOColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass34_0)[1152921507237169760].target);
        }
        public static DG.Tweening.Tweener DOFade(UnityEngine.UI.Text target, float endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass35_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass35_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.DOTween.ToAlpha(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass35_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass35_0::<DOFade>b__1(UnityEngine.Color x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleUI.<>c__DisplayClass35_0)[1152921507237332960].target);
        }
        public static DG.Tweening.Tweener DOText(UnityEngine.UI.Text target, string endValue, float duration, bool richTextEnabled = True, DG.Tweening.ScrambleMode scrambleMode = 0, string scrambleChars)
        {
            DOTweenModuleUI.<>c__DisplayClass36_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass36_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Tweener>(t:  DG.Tweening.TweenSettingsExtensions.SetOptions(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.String>(object:  val_1, method:  System.String DOTweenModuleUI.<>c__DisplayClass36_0::<DOText>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.String>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass36_0::<DOText>b__1(string x)), endValue:  endValue, duration:  duration), richTextEnabled:  richTextEnabled, scrambleMode:  scrambleMode, scrambleChars:  scrambleChars), target:  (DOTweenModuleUI.<>c__DisplayClass36_0)[1152921507237526880].target);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Graphic target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass37_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass37_0();
            .target = target;
            UnityEngine.Color val_2 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a});
            .to = 0;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass37_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass37_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass37_0)[1152921507237702368].target);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Image target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass38_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass38_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            .to = 0;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass38_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass38_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass38_0)[1152921507237881952].target);
        }
        public static DG.Tweening.Tweener DOBlendableColor(UnityEngine.UI.Text target, UnityEngine.Color endValue, float duration)
        {
            DOTweenModuleUI.<>c__DisplayClass39_0 val_1 = new DOTweenModuleUI.<>c__DisplayClass39_0();
            .target = target;
            UnityEngine.Color val_2 = target.color;
            UnityEngine.Color val_3 = UnityEngine.Color.op_Subtraction(a:  new UnityEngine.Color() {r = endValue.r, g = endValue.g, b = endValue.b, a = endValue.a}, b:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
            .to = 0;
            return (DG.Tweening.Tweener)DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>>(t:  DG.Tweening.Core.Extensions.Blendable<UnityEngine.Color, UnityEngine.Color, DG.Tweening.Plugins.Options.ColorOptions>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<UnityEngine.Color>(object:  val_1, method:  UnityEngine.Color DOTweenModuleUI.<>c__DisplayClass39_0::<DOBlendableColor>b__0()), setter:  new DG.Tweening.Core.DOSetter<UnityEngine.Color>(object:  val_1, method:  System.Void DOTweenModuleUI.<>c__DisplayClass39_0::<DOBlendableColor>b__1(UnityEngine.Color x)), endValue:  new UnityEngine.Color() {r = val_3.r, g = val_3.g, b = val_3.b, a = val_3.a}, duration:  duration)), target:  (DOTweenModuleUI.<>c__DisplayClass39_0)[1152921507238061536].target);
        }
    
    }

}
