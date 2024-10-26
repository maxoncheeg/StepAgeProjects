using System;
using System.Windows.Controls;
using TwentyFortyEight.ViewModel;

namespace TwentyFortyEight.View
{
    /// <summary>
    /// Логика взаимодействия для GameWinScreen.xaml
    /// </summary>
    public partial class GameWinScreen : UserControl
    {
        public GameWinScreen(EventHandler method)
        {
            InitializeComponent();

            DataContext = new GameWinViewModel(method);
        }
    }
}
