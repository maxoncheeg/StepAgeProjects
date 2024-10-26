using System;
using System.ComponentModel;

namespace TwentyFortyEight.ViewModel 
{
    class GameWinViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed(string property) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public event EventHandler FormClose;

        private int _score;
        public int Score
        {
            get => _score;
            set
            {
                _score = value;
                Changed("Score");
            }
        }

        public Command Close => Command.Create(_Close);
        private void _Close(object sender, EventArgs eventArgs) =>
            FormClose?.Invoke(null, null);

        public GameWinViewModel(EventHandler method) =>
            FormClose += method;
    }
}
