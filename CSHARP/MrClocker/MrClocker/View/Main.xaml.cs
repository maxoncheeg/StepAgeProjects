using System.Windows;
using MrClocker.ViewModel;

namespace MrClocker.View
{
    /// <summary>
    /// Логика взаимодействия для Main.xaml
    /// </summary>
    public partial class Main : Window
    {
        public Main()
        {
            InitializeComponent();

            DataContext = MainViewModel.Create(new AnalogClock(), new DigitalClock());
        }
    }
}
