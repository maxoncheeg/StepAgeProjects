using System;
using System.ComponentModel;
using System.Windows.Controls;

namespace MrClocker.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private UserControl _analogClock;
        private UserControl _digitalClock;

        string _buttonContent;
        public string ButtonContent
        {
            get => _buttonContent;
            set
            {
                _buttonContent = value;
                Changed("ButtonContent");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private UserControl _activeForm;
        public UserControl ActiveForm { 
            get => _activeForm;
            set 
            {
                _activeForm = value;
                Changed("ActiveForm");
            } 
        }

        public Command ClockChanger => Command.Create(_userControlClick);
        private void _userControlClick(object sender, EventArgs args)
        {
            ActiveForm = _activeForm == _analogClock ? _digitalClock : _analogClock;
            ButtonContent = _activeForm == _analogClock ? "Digital Clock" : "Analog Clock";
        }

        private MainViewModel(UserControl _analogClock, UserControl _digitalClock)
        {
            this._analogClock = _analogClock;
            this._digitalClock = _digitalClock;

            ActiveForm = _analogClock;
            ButtonContent = "Digital Clock";
        }

        public static MainViewModel Create(UserControl analogClock, UserControl digitalClock) =>
            new MainViewModel(analogClock, digitalClock);

        private void Changed(string property)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));
        }
    }
}
