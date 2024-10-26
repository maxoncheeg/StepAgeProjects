using MrClocker.Model;
using System;
using System.ComponentModel;

namespace MrClocker.ViewModel
{
    public class AnalogClockViewModel : INotifyPropertyChanged
    {
        private Timer _clock;

        public event PropertyChangedEventHandler PropertyChanged;

        private int _second;
        public int Second
        {
            get => _second * (360 / 60);
            set
            {
                _second = value;
                Changed("Second");
            }
        }

        private int _minute;
        public int Minute
        {
            get => _minute * (360 / 60);
            set
            {
                _minute = value;
                Changed("Minute");
            }
        }

        private int _hour;
        public int Hour
        {
            get => _hour * (360 / 12);
            set
            {
                _hour = value;
                Changed("Hour");
            }
        }

        public AnalogClockViewModel()
        {
            _clock = Timer.Create(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            _clock.UpdateTime += _changedTime;
            //_clock.Start();
        }
        private void _changedTime(int hour, int minute, int second)
        {
            Hour = hour;
            Minute = minute;
            Second = second;
        }

        public Command Start => Command.Create(_start);
        private void _start(object sender, EventArgs args) =>
            _clock.Start();

        public Command Stop => Command.Create(_stop);
        private void _stop(object sender, EventArgs args) =>
            _clock.Stop();

        private void Changed(string property) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
