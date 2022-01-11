using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleUnityVersion
    {
        // Methods
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, float duration)
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
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f}, duration:  (null - null) * duration), ease:  1));
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
        public static DG.Tweening.Sequence DOGradientColor(UnityEngine.Material target, UnityEngine.Gradient gradient, string property, float duration)
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
                    target.SetColor(name:  property, value:  new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f});
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
            
                DG.Tweening.Sequence val_11 = DG.Tweening.TweenSettingsExtensions.Append(s:  val_1, t:  DG.Tweening.TweenSettingsExtensions.SetEase<DG.Tweening.Tweener>(t:  DG.Tweening.ShortcutExtensions.DOColor(target:  target, endValue:  new UnityEngine.Color() {r = 4.896174E-12f, g = 4.896174E-12f, b = 4.896174E-12f, a = 4.896174E-12f}, property:  property, duration:  (null - null) * duration), ease:  1));
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
        public static UnityEngine.CustomYieldInstruction WaitForCompletion(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForCompletion val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForCompletion();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForRewind(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForRewind val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForRewind();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForKill(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForKill val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForKill();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForElapsedLoops(DG.Tweening.Tween t, int elapsedLoops, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForElapsedLoops val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForElapsedLoops();
                .t = t;
                .elapsedLoops = elapsedLoops;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForPosition(DG.Tweening.Tween t, float position, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForPosition val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForPosition();
                .t = t;
                .position = position;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
        public static UnityEngine.CustomYieldInstruction WaitForStart(DG.Tweening.Tween t, bool returnCustomYieldInstruction)
        {
            var val_2;
            if((t.<active>k__BackingField) != false)
            {
                    DOTweenCYInstruction.WaitForStart val_1 = null;
                val_2 = val_1;
                val_1 = new DOTweenCYInstruction.WaitForStart();
                .t = t;
                return (UnityEngine.CustomYieldInstruction)val_2;
            }
            
            if(DG.Tweening.Core.Debugger._LogPrefix >= 1)
            {
                    DG.Tweening.Core.Debugger.LogInvalidTween(t:  t);
            }
            
            val_2 = 0;
            return (UnityEngine.CustomYieldInstruction)val_2;
        }
    
    }

}
