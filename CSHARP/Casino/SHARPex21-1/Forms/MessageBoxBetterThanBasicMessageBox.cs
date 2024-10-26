using System;
using System.Windows.Forms;

namespace SHARPex21_1.Forms
{
    public partial class MessageBoxBetterThanBasicMessageBox : Form
    {
        private MessageBoxBetterThanBasicMessageBox()
        {
            InitializeComponent();
        }

        public static void Show(string text, string title)
        {
            MessageBoxBetterThanBasicMessageBox messageBox = new MessageBoxBetterThanBasicMessageBox();

            messageBox.Text = title;
            foreach (var item in messageBox.Controls)
            {
                if(item is Label)
                {
                    Label label = item as Label;
                    label.Text = text;
                    break;
                }
            }

            messageBox.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
