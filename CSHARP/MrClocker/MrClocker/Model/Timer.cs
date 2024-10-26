using System;
using System.Threading.Tasks;

namespace MrClocker.Model
{
    public class Timer
    {
        private int _hour;
        private int _minute;
        private int _second;
        private bool _isTimerActive;

        public event Action<int, int, int> UpdateTime;

        private Timer(int _hour, int _minute, int _second)
        {
            this._hour = _hour;
            this._minute = _minute;
            this._second = _second;

            _isTimerActive = false;
        }

        public static Timer Create(int hour, int minute, int seconds) =>
            new Timer(hour, minute, seconds);

        public void Start()
        {
            if (_isTimerActive) return;

            _isTimerActive = true;
            Task.Run(_start);
        }
        
        private async void _start()
        {
            while (_isTimerActive)
            {
                _second++;

                if (_second >= 60)
                {
                    _second = 0;
                    _minute++;

                    if (_minute >= 60)
                    {
                        _minute = 0;
                        _hour++;

                        if (_hour >= 24) _hour = 0;
                    }
                }

                UpdateTime?.Invoke(_hour, _minute, _second);
                //if (UpdateTime != null)
                //    UpdateTime(_hour, _minute, _second);

                await Task.Delay(1000);
            }
        }

        public void Stop() => _isTimerActive = false;

        public void Clear()
        {
            _hour = 0;
            _minute = 0;
            _second = 0;
        }
    }
}
