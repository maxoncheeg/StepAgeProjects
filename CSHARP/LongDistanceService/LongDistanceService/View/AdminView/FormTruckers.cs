using LongDistanceService.Controller;
using System;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormTruckers : Form
    {
        private bool _isUpdate = false;
        private LogInManager _manager;

        public FormTruckers()
        {
            InitializeComponent();

            _manager = LogInManager.GetManager();
            Clear();

            listBoxTruckers.DoubleClick += ListBoxTruckers_DoubleClick;
        }

        private void ListBoxTruckers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTruckers.SelectedIndex == -1) return;

            textBoxNumberPhone.Text = listBoxTruckers.Items[listBoxTruckers.SelectedIndex].ToString();

            _manager.GetInfoAboutTruckerByNumberPhone(textBoxNumberPhone, textBoxName, textBoxStatus, textBoxExp, textBoxOrdersCompleted, pictureBoxPhoto);
        }
        
        private async void buttonDeleteTrucker_Click(object sender, EventArgs e)
        {
            if (textBoxNumberPhone.Text == string.Empty) return;

            if (await _manager.DeleteTruckerAsync(textBoxNumberPhone.Text))
                LDSMessageBox.Show("Trucker is successfully deleted!", "Yeah");
            else
                LDSMessageBox.Show("Trucker is not deleted!", "No");

            Clear();

            if (!_isUpdate)
            {
                _isUpdate = true;
                Clear();
                labelLastConnection.Text = (await _manager.UpdateTruckersListAsync()).ToString();
                _manager.GetTruckersToListAsync(listBoxTruckers);
                _isUpdate = false;
            }
        }

        private async void FormTruckers_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);

            if (!_isUpdate)
            {
                _isUpdate = true;
                Clear();
                labelLastConnection.Text = (await _manager.UpdateTruckersListAsync()).ToString();
                _manager.GetTruckersToListAsync(listBoxTruckers);
                _isUpdate = false;
            }
        }

        private async void buttonUpdateConnection_Click(object sender, EventArgs e)
        {
            if (!_isUpdate)
            {
                _isUpdate = true;
                Clear();
                labelLastConnection.Text = (await _manager.UpdateTruckersListAsync()).ToString();
                _manager.GetTruckersToListAsync(listBoxTruckers);
                _isUpdate = false;
            }
        }

        private void Clear()
        {
            textBoxNumberPhone.Text = "";
            textBoxName.Text = "";
            textBoxOrdersCompleted.Text = "";
            textBoxExp.Text = "";
            textBoxStatus.Text = "";
            pictureBoxPhoto.Image = null;
        }
    }
}
