using UnityEngine;

namespace DG.Tweening
{
    public static class DOTweenModuleAudio
    {
        // Methods
        public static DG.Tweening.Tweener DOFade(UnityEngine.AudioSource target, float endValue, float duration)
        {
            float val_5;
            DOTweenModuleAudio.<>c__DisplayClass0_0 val_1 = new DOTweenModuleAudio.<>c__DisplayClass0_0();
            val_5 = 0f;
            .target = target;
            if(endValue < 0)
            {
                    return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__1(float x)), endValue:  val_5 = 1f, duration:  duration), target:  (DOTweenModuleAudio.<>c__DisplayClass0_0)[1152921507217554272].target);
            }
            
            val_5 = endValue;
            if(endValue <= 1f)
            {
                    return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__1(float x)), endValue:  val_5, duration:  duration), target:  (DOTweenModuleAudio.<>c__DisplayClass0_0)[1152921507217554272].target);
            }
            
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleAudio.<>c__DisplayClass0_0::<DOFade>b__1(float x)), endValue:  val_5, duration:  duration), target:  (DOTweenModuleAudio.<>c__DisplayClass0_0)[1152921507217554272].target);
        }
        public static DG.Tweening.Tweener DOPitch(UnityEngine.AudioSource target, float endValue, float duration)
        {
            DOTweenModuleAudio.<>c__DisplayClass1_0 val_1 = new DOTweenModuleAudio.<>c__DisplayClass1_0();
            .target = target;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleAudio.<>c__DisplayClass1_0::<DOPitch>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleAudio.<>c__DisplayClass1_0::<DOPitch>b__1(float x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleAudio.<>c__DisplayClass1_0)[1152921507217717472].target);
        }
        public static DG.Tweening.Tweener DOSetFloat(UnityEngine.Audio.AudioMixer target, string floatName, float endValue, float duration)
        {
            DOTweenModuleAudio.<>c__DisplayClass2_0 val_1 = new DOTweenModuleAudio.<>c__DisplayClass2_0();
            .target = target;
            .floatName = floatName;
            return DG.Tweening.TweenSettingsExtensions.SetTarget<DG.Tweening.Core.TweenerCore<System.Single, System.Single, DG.Tweening.Plugins.Options.FloatOptions>>(t:  DG.Tweening.DOTween.To(getter:  new DG.Tweening.Core.DOGetter<System.Single>(object:  val_1, method:  System.Single DOTweenModuleAudio.<>c__DisplayClass2_0::<DOSetFloat>b__0()), setter:  new DG.Tweening.Core.DOSetter<System.Single>(object:  val_1, method:  System.Void DOTweenModuleAudio.<>c__DisplayClass2_0::<DOSetFloat>b__1(float x)), endValue:  endValue, duration:  duration), target:  (DOTweenModuleAudio.<>c__DisplayClass2_0)[1152921507217888864].target);
        }
        public static int DOComplete(UnityEngine.Audio.AudioMixer target, bool withCallbacks = False)
        {
            withCallbacks = withCallbacks;
            return DG.Tweening.DOTween.Complete(targetOrId:  target, withCallbacks:  withCallbacks);
        }
        public static int DOKill(UnityEngine.Audio.AudioMixer target, bool complete = False)
        {
            complete = complete;
            return DG.Tweening.DOTween.Kill(targetOrId:  target, complete:  complete);
        }
        public static int DOFlip(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Flip(targetOrId:  target);
        }
        public static int DOGoto(UnityEngine.Audio.AudioMixer target, float to, bool andPlay = False)
        {
            andPlay = andPlay;
            return DG.Tweening.DOTween.Goto(targetOrId:  target, to:  to, andPlay:  andPlay);
        }
        public static int DOPause(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Pause(targetOrId:  target);
        }
        public static int DOPlay(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Play(targetOrId:  target);
        }
        public static int DOPlayBackwards(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.PlayBackwards(targetOrId:  target);
        }
        public static int DOPlayForward(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.PlayForward(targetOrId:  target);
        }
        public static int DORestart(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Restart(targetOrId:  target, includeDelay:  true, changeDelayTo:  -1f);
        }
        public static int DORewind(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.Rewind(targetOrId:  target, includeDelay:  true);
        }
        public static int DOSmoothRewind(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.SmoothRewind(targetOrId:  target);
        }
        public static int DOTogglePause(UnityEngine.Audio.AudioMixer target)
        {
            return DG.Tweening.DOTween.TogglePause(targetOrId:  target);
        }
    
    }

}
