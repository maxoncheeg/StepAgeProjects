using LongDistanceService.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDistanceService.View
{
    public partial class FormPersonalProfile : Form
    {
        private LogInManager _manager;
        private FormPersonalProfile()
        {
            InitializeComponent();
            _manager = LogInManager.GetManager();
            _manager.GetCurrentUserInfo(textBoxLogin, textBoxPassword, textBoxName, textBoxAccessRights, textBoxOrdersMade, textBoxDescription, pictureBoxPhoto);        
        }

        public static DialogResult Open() => new FormPersonalProfile().ShowDialog();

        private void buttonChangePhoto_Click(object sender, EventArgs e)
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
        }

        private async void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == string.Empty || textBoxPassword.Text == string.Empty) return;

            if (await _manager.UpdateCurrentUserAsync(textBoxLogin, textBoxPassword, textBoxName, textBoxDescription, pictureBoxPhoto))
                LDSMessageBox.Show("The data has been successfully updated!", "Wow!");
            else
                LDSMessageBox.Show(" Failed to update data!", "Error");
        }

        private async void buttonChangeProfile_Click(object sender, EventArgs e)
        {
            if (_manager.GetCurrentUserAccessRight() > 0)
            {
                LDSMessageBox.Show("The only admin cannot delete himself!", "Error");
                return;
            }

            if (await _manager.DeleteCurrentUserAsync()) {
                DialogResult = DialogResult.Abort;
                LDSMessageBox.Show("The data has been successfully deleted!", "Wow!");
                Close();
            }
            else
                LDSMessageBox.Show("Amazing! You could not be deleted!", "Wow!");

        }

        private void FormPersonalProfile_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);
    }
}
