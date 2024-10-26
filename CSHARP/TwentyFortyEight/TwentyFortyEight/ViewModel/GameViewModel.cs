using System;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using TwentyFortyEight.Model;

namespace TwentyFortyEight.ViewModel
{
    public class GameViewModel : INotifyPropertyChanged
    {
        private Image[,] _tiles;
        private TwentyFortyEightGame _game;

        private Action Update;
        private void UpdateForm() =>
            Update?.Invoke();

        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed(string property) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public event EventHandler GameIsWon;
        public event EventHandler GameIsLost;


        public Command Up => Command.Create(_Up);
        private void _Up(object sender, EventArgs eventArgs)
        {
            if (!_game.Up())
                GameIsLost?.Invoke(this, ScoreEventArgs.Create(_score));
            else if (_game.CheckWin())
                GameIsWon?.Invoke(this, ScoreEventArgs.Create(_score));
            
            UpdateForm();

            LastCommand = "Up";
        }

        public Command Down => Command.Create(_Down);
        private void _Down(object sender, EventArgs eventArgs)
        {
            if (!_game.Down())
                GameIsLost?.Invoke(this, ScoreEventArgs.Create(_score));
            else if (_game.CheckWin())
                GameIsWon?.Invoke(this, ScoreEventArgs.Create(_score));

            UpdateForm();

            LastCommand = "Down";
        }

        public Command Left => Command.Create(_Left);
        private void _Left(object sender, EventArgs eventArgs)
        {
            if (!_game.Left())
                GameIsLost?.Invoke(this, ScoreEventArgs.Create(_score));
            else if (_game.CheckWin())
                GameIsWon?.Invoke(this, ScoreEventArgs.Create(_score));

            UpdateForm();

            LastCommand = "Left";
        }

        public Command Right => Command.Create(_Right);
        private void _Right(object sender, EventArgs eventArgs)
        {
            if (!_game.Right())
                GameIsLost?.Invoke(this, ScoreEventArgs.Create(_score));
            else if (_game.CheckWin())
                GameIsWon?.Invoke(this, ScoreEventArgs.Create(_score));

            UpdateForm();

            LastCommand = "Right";
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

        private string _lastCommand;
        public string LastCommand
        {
            get => _lastCommand;
            set
            {
                _lastCommand = value;
                Changed("LastCommand");
            }
        }

        private GameViewModel(Image[,] _tiles)
        {
            this._tiles = _tiles;
           
            _game = TwentyFortyEightGame.Create();

            Update += _UpdateField;
            Update += _UpdateScore;

            UpdateForm();
        }

        public static GameViewModel Create(Image[,] tiles) => new GameViewModel(tiles);

        private void _UpdateField()
        {
            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    _tiles[i, k].Source = new BitmapImage(new Uri($"/Resource/{(_game.PlayingField[i, k] == null ? "Empty" : _game.PlayingField[i, k].Denomination.ToString())}.png", UriKind.Relative)) { CreateOptions = BitmapCreateOptions.IgnoreImageCache };
        }

        private void _UpdateScore()
        {
            int score = 0;

            for (int i = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    score += _game.PlayingField[i, k] is null ? 0 : (int)_game.PlayingField[i, k].Denomination;

            Score = score;
        }
    }
}
