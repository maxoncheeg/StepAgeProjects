using LongDistanceService.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDistanceService.View.Register
{
    public partial class FormCustomerRegister : Form
    {
        private LogInManager _manager;
        private Image _photo;

        public FormCustomerRegister()
        {
            InitializeComponent();

            _manager = LogInManager.GetManager();

        }

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            if(textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty)
                LDSMessageBox.Show("You have not entered a password or login!", "Warning!");

            if (await _manager.RegisterAsCustomerAsync(textBoxLogin.Text, textBoxPassword.Text,
                textBoxName.Text, textBoxDescription.Text, _photo))
            {
                LDSMessageBox.Show("You have successfully registered!", "Congratulate!");
                this.Close();
            }
            else
                LDSMessageBox.Show("Failed to register. Perhaps your LOGIN is already being used by someone.", "Warning!");
        }

        private void buttonChoose_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image|*.png;";

            if (fileDialog.ShowDialog() == DialogResult.Cancel) return;

            if(Image.FromFile(fileDialog.FileName).Width > 301
                || Image.FromFile(fileDialog.FileName).Height > 301)
            {
                LDSMessageBox.Show("The image is too big! The maximum resolution is 300x300!!!", "Error!");
                return;
            }
            
            _photo = Image.FromFile(fileDialog.FileName);
            textBoxPhotoName.Text = fileDialog.FileName;
        }

        private void FormCustomerRegister_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);
    }
}
