using System.Windows;

namespace WpfSharpEx1_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator _calculator;
        private string _errorMessage;

        public MainWindow()
        {
            InitializeComponent();

            buttonZero.Click += buttonZero_Click;
            buttonOne.Click += buttonOne_Click;
            buttonTwo.Click += buttonTwo_Click; ;
            buttonThree.Click += buttonThree_Click;
            buttonFour.Click += buttonFour_Click;
            buttonFive.Click += buttonFive_Click;
            buttonSix.Click += buttonSix_Click;
            buttonSeven.Click += buttonSeven_Click;
            buttonEight.Click += buttonEight_Click;
            buttonNine.Click += buttonNine_Click;

            buttonCE.Click += buttonCE_Click;
            buttonC.Click += buttonC_Click;
            buttonDelete.Click += buttonDelete_Click;

            buttonDot.Click += buttonDot_Click;
            buttonDivision.Click += buttonDivision_Click;
            buttonMultiplication.Click += ButtonMultiplication_Click;
            buttonMinus.Click += ButtonMinus_Click;
            buttonPlus.Click += ButtonPlus_Click;

            buttonEqual.Click += ButtonEqual_Click;
            buttonEqualBack.Click += ButtonEqualBack_Click;

            MouseMove += MainWindow_MouseMove;
            textBoxEqual.TextChanged += TextBoxEqual_TextChanged;

            _errorMessage = "error";
            _calculator = Calculator.Create();
        }

        private void TextBoxEqual_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (textBoxEqual.Text == "*" || textBoxEqual.Text == "/")
                textBoxEqual.Text = "";

            if (textBoxEqual.Text.Length > 2)           
                if (textBoxEqual.Text[textBoxEqual.Text.Length - 1] == '*')
                {
                    string temp = "";

                    if (textBoxEqual.Text[textBoxEqual.Text.Length - 2] == '*')
                    {
                        for (int i = 0; i < textBoxEqual.Text.Length - 1; i++)
                            temp += textBoxEqual.Text[i];

                        textBoxEqual.Text = temp;
                    }
                    else if (textBoxEqual.Text[textBoxEqual.Text.Length - 2] == '/')
                    {
                        for (int i = 0; i < textBoxEqual.Text.Length - 2; i++)
                            temp += textBoxEqual.Text[i];

                        textBoxEqual.Text = $"{temp}*";
                    }
                }
                else if (textBoxEqual.Text[textBoxEqual.Text.Length - 1] == '/')
                {
                    string temp = "";

                    if (textBoxEqual.Text[textBoxEqual.Text.Length - 2] == '/')
                    {
                        for (int i = 0; i < textBoxEqual.Text.Length - 1; i++)
                            temp += textBoxEqual.Text[i];

                        textBoxEqual.Text = temp;
                    }
                    else if (textBoxEqual.Text[textBoxEqual.Text.Length - 2] == '*')
                    {
                        for (int i = 0; i < textBoxEqual.Text.Length - 2; i++)
                            temp += textBoxEqual.Text[i];

                        textBoxEqual.Text = $"{temp}/";
                    }
                }
        }

        private void MainWindow_MouseMove(object sender, System.Windows.Input.MouseEventArgs e)
        {
            _calculator.PreCalculate(textBoxEqual.Text);
            textBlockPreEqual.Text = _calculator.PreCalculateLine;
        }

        private void ButtonEqualBack_Click(object sender, RoutedEventArgs e)
        {
            textBoxEqual.Text = textBlockLastEqual.Text;
            textBlockLastEqual.Text = "";
        }

        private void ButtonEqual_Click(object sender, RoutedEventArgs e)
        {
            textBoxEqual.Text = _calculator.Calculate(textBoxEqual.Text, _errorMessage);
            textBlockLastEqual.Text = _calculator.LastLine;
        }

        private void ButtonPlus_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text += "+";

        private void ButtonMinus_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text += "-";

        private void ButtonMultiplication_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text += "*";

        private void buttonDivision_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text += "/";

        private void buttonDot_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text += ",";

        private void buttonCE_Click(object sender, RoutedEventArgs e) =>
            textBoxEqual.Text = "";

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            string temporaryLine = "";

            for (int i = 0; i < textBoxEqual.Text.Length - 1; i++)
                temporaryLine += textBoxEqual.Text[i];

            textBoxEqual.Text = temporaryLine;
        }

        private void buttonC_Click(object sender, RoutedEventArgs e)
        {
            textBoxEqual.Text = "";
            textBlockLastEqual.Text = "";
        }

        private void buttonZero_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "0";

        private void buttonOne_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "1";

        private void buttonTwo_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "2";

        private void buttonThree_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "3";

        private void buttonFour_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "4";

        private void buttonFive_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "5";

        private void buttonSix_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "6";

        private void buttonSeven_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "7";

        private void buttonEight_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "8";

        private void buttonNine_Click(object sender, RoutedEventArgs e) =>
           textBoxEqual.Text += "9";
    }
}
