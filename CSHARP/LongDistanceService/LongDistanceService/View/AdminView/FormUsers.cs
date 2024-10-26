using LongDistanceService.Controller;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormUsers : Form
    {
        private LogInManager _manager;

        private FormUsers()
        {
            InitializeComponent();

            _manager = LogInManager.GetManager();

            listBoxUsers.DoubleClick += ListBoxUsers_DoubleClick;
        }

        private void ListBoxUsers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndex == -1) return;

            if (!_manager.GetInfoAboutUsers(listBoxUsers.SelectedIndex, textBoxLogin, textBoxName, textBoxAccessRights, textBoxOrdersMade, textBoxDescription, pictureBoxPhoto))
                LDSMessageBox.Show("Failed to load data!", "Error!");           
        }

        public static DialogResult Open() => new FormUsers().ShowDialog();

        private async void buttonUpdateConnection_Click(object sender, EventArgs e) =>
            await ClearFormAsync();

        private async Task<bool> ClearFormAsync()
        {
            textBoxAccessRights.Text = textBoxDescription.Text
                                     = textBoxLogin.Text 
                                     = textBoxName.Text 
                                     = textBoxOrdersMade.Text 
                                     = string.Empty;

            pictureBoxPhoto.Image = null;

            labelLastConnection.Text = (await _manager.GetUsersAsync(listBoxUsers)).ToString();

            if (listBoxUsers.Items.Count > 0) return true;
            return false;
        }

        private async void buttonUpdateUser_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == _manager.GetCurrentUserLogin())
            {
                LDSMessageBox.Show("The only admin cannot update himself!", "Error");
                return;
            }

            if (textBoxLogin.Text == string.Empty) return;

            if (!await _manager.UpdateUserInfoAsync(textBoxLogin.Text, checkBoxDeleteDescription.Checked, checkBoxDeleteName.Checked, checkBoxDeletePhoto.Checked))
                LDSMessageBox.Show("Failed to update user!", "Error");
            else
                LDSMessageBox.Show("The user has been successfully updated", "Info");

            await ClearFormAsync();
        }

        private async void FormUsers_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);
            await ClearFormAsync();             
        }

        private async void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == string.Empty) return;
            if (textBoxLogin.Text == _manager.GetCurrentUserLogin())
            {
                LDSMessageBox.Show("The only admin cannot delete himself!", "Error");
                return;
            }

            if (await _manager.DeleteUserAsync(textBoxLogin.Text))
                LDSMessageBox.Show("The user has been successfully deleted", "Yes!");
            else
                LDSMessageBox.Show("Failed to delete user!", "Error");

            await ClearFormAsync();
        }
    }
}
