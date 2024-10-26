using System;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using TwentyFortyEight.ViewModel;

namespace TwentyFortyEight.View
{
    /// <summary>
    /// Логика взаимодействия для Game.xaml
    /// </summary>
    public partial class Game : UserControl
    {
        public Game()
        {
            InitializeComponent();

            Image[,] array = new Image[4,4];

            foreach (Border border in gameGrid.Children)
                border.Child = new Image() { Source = new BitmapImage(new Uri("/Resource/Empty.png", UriKind.Relative)) { CreateOptions = BitmapCreateOptions.IgnoreImageCache } };

            for (int i = 0, o = 0; i < 4; i++)
                for (int k = 0; k < 4; k++)
                    array[k, i] = (gameGrid.Children[o++] as Border).Child as Image;

            DataContext = GameViewModel.Create(array);
            this.Loaded += Game_Loaded;
        }

        private void Game_Loaded(object sender, RoutedEventArgs e)
        {
            buttonUp.Focus();
        }

        private void ButtonClick(Button button)
        {
            ButtonAutomationPeer peer = new ButtonAutomationPeer(button);
            IInvokeProvider invokeProv = peer.GetPattern(PatternInterface.Invoke) as IInvokeProvider;
            invokeProv.Invoke();
        }

        private void UserControl_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.W:
                    ButtonClick(buttonUp);
                    break;

                case Key.S:
                    ButtonClick(buttonDown);
                    break;

                case Key.A:
                    ButtonClick(buttonLeft);
                    break;

                case Key.D:
                    ButtonClick(buttonRight);
                    break;

                default:
                    break;
            }
        }
    }
}
