using UnityEngine;

namespace Game.Core
{
    public sealed class Timer
    {
        // Fields
        private readonly OneListener _tickListener;
        private readonly OneListener _postTickListener;
        private readonly OneListener _oneSecondTickListener;
        private float _unscaledTime;
        private float _lastTime;
        private float _deltaTime;
        private float _scaleTime;
        private float _time;
        
        // Properties
        public static float time { get; }
        public float Time { get; }
        public float DeltaTime { get; }
        public float TimeScale { get; set; }
        public float UnscaladeTime { get; }
        
        // Methods
        public static float get_time()
        {
            return UnityEngine.Time.time;
        }
        public void add_TICK(System.Action value)
        {
            this._tickListener.Add(action:  value);
        }
        public void remove_TICK(System.Action value)
        {
            this._tickListener.Remove(action:  value);
        }
        public void add_POST_TICK(System.Action value)
        {
            this._postTickListener.Add(action:  value);
        }
        public void remove_POST_TICK(System.Action value)
        {
            this._postTickListener.Remove(action:  value);
        }
        public void add_ONE_SECOND_TICK(System.Action value)
        {
            this._oneSecondTickListener.Add(action:  value);
        }
        public void remove_ONE_SECOND_TICK(System.Action value)
        {
            this._oneSecondTickListener.Remove(action:  value);
        }
        public Timer()
        {
            this._tickListener = new OneListener();
            this._postTickListener = new OneListener();
            this._oneSecondTickListener = new OneListener();
            float val_5 = 1000f;
            this._time = 0f;
            val_5 = (float)System.Environment.TickCount / val_5;
            this._deltaTime = 0f;
            this._scaleTime = 1f;
            this._lastTime = val_5;
        }
        public float get_Time()
        {
            return (float)this._time;
        }
        public float get_DeltaTime()
        {
            return (float)this._deltaTime;
        }
        public float get_TimeScale()
        {
            return (float)this._scaleTime;
        }
        public void set_TimeScale(float value)
        {
            this._scaleTime = System.Math.Max(val1:  0f, val2:  value);
        }
        public float get_UnscaladeTime()
        {
            return (float)this._unscaledTime;
        }
        public void Update()
        {
            float val_3;
            float val_4 = 1000f;
            val_3 = this._lastTime;
            float val_3 = (float)System.Environment.TickCount;
            float val_2 = val_3 / val_4;
            val_3 = val_2 - val_3;
            val_4 = this._unscaledTime + val_3;
            val_3 = val_3 * this._scaleTime;
            this._deltaTime = val_3;
            val_3 = val_3 + this._time;
            this._unscaledTime = val_4;
            this._time = val_3;
            val_3 = this._lastTime;
            this._lastTime = val_2;
            this._tickListener.Invoke();
            if(val_2 <= S9)
            {
                    return;
            }
            
            this._oneSecondTickListener.Invoke();
        }
        public void LateUpdate()
        {
            if(this._postTickListener != null)
            {
                    this._postTickListener.Invoke();
                return;
            }
            
            throw new NullReferenceException();
        }
        private float GetTime()
        {
            float val_2 = 1000f;
            val_2 = (float)System.Environment.TickCount / val_2;
            return (float)val_2;
        }
    
    }

}
