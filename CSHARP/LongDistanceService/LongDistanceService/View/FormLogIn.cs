using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LongDistanceService.Controller;
using LongDistanceService.View.AdminView;

namespace LongDistanceService.View
{
    public partial class FormLogIn : Form
    {
        private bool _isPasswordVisible;
        private bool _isButtonLogInClicked;
        private LogInManager _manager;      

        public FormLogIn()
        {
            InitializeComponent();

            _isPasswordVisible = false;
            _manager = LogInManager.GetManager();

            this.Load += FormLogIn_Load;
            this.FormClosed += FormLogIn_FormClosed;
        }

        private void FormLogIn_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);

        private void FormLogIn_FormClosed(object sender, FormClosedEventArgs e) => _manager.Dispose();

        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (_isButtonLogInClicked) return;

            _isButtonLogInClicked = true;

            if (!checkBoxIAmTrucker.Checked)
            {
                if (await _manager.LogInAsync(textBoxLogin.Text, textBoxPassword.Text))
                {
                    if (_manager.GetCurrentUserAccessRight() > 0) FormAdminMenu.Show(this);
                    else if (_manager.GetCurrentUserAccessRight() == 0) CustomerView.FormCustomerMenu.Show(this);
                }
                else
                    LDSMessageBox.Show("Incorrect password or login!", "Warning!");
            }
            else
            {
                if(await _manager.LogInTruckerAsync(textBoxLogin.Text, textBoxPassword.Text))

                else
                    LDSMessageBox.Show("Incorrect password or login!", "Warning!");
            }

            _isButtonLogInClicked = false;
        }

        private void pictureBoxPasswordVisible_Click(object sender, EventArgs e)
        {
            if (!_isPasswordVisible)
            {
                pictureBoxPasswordVisible.Image = Properties.Resources.eyeOpen;
                textBoxPassword.PasswordChar = (char)0;
            }
            else
            {
                pictureBoxPasswordVisible.Image = Properties.Resources.eyeClose;
                textBoxPassword.PasswordChar = '*';
            }

            _isPasswordVisible = !_isPasswordVisible;
        }

        private void buttonRegisterAsCustomer_Click(object sender, EventArgs e)
        {
            Register.FormCustomerRegister register = new Register.FormCustomerRegister();

            register.ShowDialog();
        }

        private void buttonTruckerRegister_Click(object sender, EventArgs e)
        {
            Register.FormTruckerRegister form = new Register.FormTruckerRegister();

            form.ShowDialog();
        }
    }
}
