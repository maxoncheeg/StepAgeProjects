using System;
using System.Windows.Input;

namespace TwentyFortyEight.ViewModel
{
    public class Command : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private Command(EventHandler method) =>
            CanExecuteChanged += method;

        public static Command Create(EventHandler method) =>
            new Command(method);

        public bool CanExecute(object parameter) =>
            CanExecuteChanged != null;

        public void Execute(object parameter) =>
            CanExecuteChanged?.Invoke(null, null);
    }
}
