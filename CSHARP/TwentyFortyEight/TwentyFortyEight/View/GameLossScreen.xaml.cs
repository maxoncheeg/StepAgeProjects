using System;
using System.Windows.Controls;
using TwentyFortyEight.ViewModel;

namespace TwentyFortyEight.View
{
    /// <summary>
    /// Логика взаимодействия для GameLossScreen.xaml
    /// </summary>
    public partial class GameLossScreen : UserControl
    {
        public GameLossScreen(EventHandler method)
        {
            InitializeComponent();

            DataContext = new GameLossViewModel(method);
        }
    }
}
