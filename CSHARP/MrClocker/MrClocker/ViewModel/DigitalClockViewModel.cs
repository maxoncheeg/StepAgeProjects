using MrClocker.Model;
using System;
using System.ComponentModel;

namespace MrClocker.ViewModel
{
    class DigitalClockViewModel : INotifyPropertyChanged
    {
        private Timer _clock;
        public event PropertyChangedEventHandler PropertyChanged;

        private int _second;
        public string Second
        {
            get => _second < 10 ? $"0{_second}" : _second.ToString();
        }

        private int _minute;
        public string Minute
        {
            get => _minute < 10 ? $"0{_minute}" : _minute.ToString();
        }

        private int _hour;
        public string Hour
        {
            get => _hour < 10 ? $"0{_hour}" : _hour.ToString();
        }

        public DigitalClockViewModel()
        {
            _clock = Timer.Create(0, 0, 0);
            _clock.UpdateTime += _timeChanged;
        }
        private void _timeChanged(int hour, int minute, int second)
        {
            _second = second;
            _minute = minute;
            _hour = hour;

            Changed("Second");
            Changed("Minute");
            Changed("Hour");
        }

        public Command Start => Command.Create(_start);
        private void _start(object sender, EventArgs args) =>
            _clock.Start();

        public Command Stop => Command.Create(_stop);
        private void _stop(object sender, EventArgs args) =>
            _clock.Stop();

        public Command Clear => Command.Create(_clear);
        private void _clear(object sender, EventArgs args)
        {
            _clock.Clear();

            _second = 0;
            _minute = 0;
            _hour = 0;

            Changed("Second");
            Changed("Minute");
            Changed("Hour");
        }

        private void Changed(string property) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
    }
}
