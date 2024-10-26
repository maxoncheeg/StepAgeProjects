using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TwentyFortyEight.ViewModel
{
    class GameLossViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed(string property) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public event EventHandler FormClose;

        private Brush _textColor;
        public Brush TextColor
        {
            get => _textColor;
            set
            {
                _textColor = value;
                Changed("TextColor");
            }
        }

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

        public GameLossViewModel(EventHandler method)
        {
            //Task.Run(ChangeColor);
            TextColor = Brushes.Bisque;

            FormClose += method;
        }

        private async void ChangeColor()
        {
            Random rand = new Random();

            while (true)
            {
                Brush brush = new SolidColorBrush(Color.FromRgb((byte)rand.Next(0, 255), (byte)rand.Next(0, 255), (byte)rand.Next(0, 255)));
                TextColor = brush;
                await Task.Delay(100);
            }
        }

    }
}
