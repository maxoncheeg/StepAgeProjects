using System;
using System.Windows;
using TwentyFortyEight.ViewModel;

namespace TwentyFortyEight.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = MainViewModel.Create(new Game(), new GameWinScreen(FormClose), new GameLossScreen(FormClose));
        }

        private void FormClose(object sender, EventArgs eventArgs) =>
            Close();
    }
}
