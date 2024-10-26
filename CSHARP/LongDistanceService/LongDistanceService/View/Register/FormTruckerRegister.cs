using LongDistanceService.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDistanceService.View.Register
{
    public partial class FormTruckerRegister : Form
    {
        private LogInManager _manager;

        public FormTruckerRegister()
        {
            InitializeComponent();

            _manager = LogInManager.GetManager();

            this.Load += FormTruckerRegister_Load;
        }

        private void FormTruckerRegister_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image|*.png;";

            if (fileDialog.ShowDialog() == DialogResult.Cancel) return;

            if (Image.FromFile(fileDialog.FileName).Width > 301
                || Image.FromFile(fileDialog.FileName).Height > 301)
            {
                LDSMessageBox.Show("The image is too big! The maximum resolution is 300x300!!!", "Error!");
                return;
            }

            pictureBoxPhoto.Image = Image.FromFile(fileDialog.FileName);
            textBoxPhotoName.Text = fileDialog.FileName;
        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxNumberPhone.Text[0] != '8') throw new NumberPhoneException();
                else if (textBoxNumberPhone.Text.Length != 11) throw new NumberPhoneException();
                
                for (int i = 1; i < textBoxNumberPhone.Text.Length; i++)
                    if (textBoxNumberPhone.Text[i] < 48 || textBoxNumberPhone.Text[i] > 57)
                        throw new NumberPhoneException();
            }
            catch(NumberPhoneException exeption)
            {
                exeption.ShowErrorMessage();
                return;
            }

            if (textBoxPassword.Text == string.Empty) return;

            if (await _manager.RegisterAsTruckerAsync(textBoxName.Text, textBoxNumberPhone.Text, textBoxPassword.Text, (int)numericUpDownExperience.Value, pictureBoxPhoto.Image))
            {
                LDSMessageBox.Show("You have successfully registered!", "Congratulate!");
                this.Close();
            }
            else
                LDSMessageBox.Show("Failed to register. Perhaps your phone number is already being used by someone.", "Warning!");

        }


    }
    
    class NumberPhoneException : Exception
    {
        public NumberPhoneException() : base("Phone number entered incorrectly!") { }

        public void ShowErrorMessage() =>
            LDSMessageBox.Show(Message, "Error");
    }
}
