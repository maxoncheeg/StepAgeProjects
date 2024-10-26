using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TwentyFortyEight.Model;

namespace TwentyFortyEight.ViewModel
{
    class MainViewModel : INotifyPropertyChanged
    {
        private UserControl _game;
        private UserControl _winScreen;
        private UserControl _lossScreen;

        private UserControl _activeUserControl;

        public event PropertyChangedEventHandler PropertyChanged;
        private void Changed(string property) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property));

        public UserControl ActiveUserControl
        {
            get => _activeUserControl;
            set
            {
                _activeUserControl = value;
                Changed("ActiveUserControl");
            }
        }

        private MainViewModel(UserControl _game, UserControl _winScreen, UserControl _lossScreen)
        {
            this._game = _game;
            this._winScreen = _winScreen;
            this._lossScreen = _lossScreen;

            ActiveUserControl = this._game;
            (_game.DataContext as GameViewModel).GameIsWon += GameWin;
            (_game.DataContext as GameViewModel).GameIsLost += GameLoss;
        }

        public static MainViewModel Create(UserControl game, UserControl winScreen, UserControl lossScreen) =>
            new MainViewModel(game, winScreen, lossScreen);

        private void GameLoss(object sender, EventArgs eventArgs)
        {
            ActiveUserControl = _lossScreen;
            (_lossScreen.DataContext as GameLossViewModel).Score = (eventArgs as ScoreEventArgs).Score;
        }

        private void GameWin(object sender, EventArgs eventArgs)
        {
            ActiveUserControl = _winScreen;
            (_winScreen.DataContext as GameWinViewModel).Score = (eventArgs as ScoreEventArgs).Score;
        }
    }
}
