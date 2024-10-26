using LongDistanceService.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormTrucks : Form
    {
        private MainManager _manager;
        private bool _isUpdate;

        public FormTrucks()
        {
            InitializeComponent();

            listBoxTrucks.DoubleClick += ListBoxTrucks_DoubleClick;

            _manager = MainManager.GetManager();
            _isUpdate = false;
        }

        private async void ListBoxTrucks_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxTrucks.SelectedIndex == -1) return;

            if(FormTruckManagement.Open(listBoxTrucks.Items[listBoxTrucks.SelectedIndex].ToString()) == DialogResult.Cancel)
                LDSMessageBox.Show("Could not display information about this truck!", "ERROR");

            if (_isUpdate)
            {
                _isUpdate = false;
                await _manager.UpdateTruckListAsync();
                buttonFind_Click(null, null);
                _isUpdate = true;
            }
        }

        private async void FormTrucks_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);

            await _manager.UpdateTruckListAsync();
            _isUpdate = true;

            _manager.GetSortedTruckList(listBoxTrucks, radioButtonAsc.Checked);
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            int filter = 0;

            if (radioButtonLicensePlate.Checked) filter = 1;
            else if (radioButtonBrand.Checked) filter = 2;//Доделац
            else if (radioButtonLoadCapacity.Checked) filter = 3;

            _manager.GetSortedTruckList(listBoxTrucks, radioButtonAsc.Checked, filter);
        }

        private async void buttonUpdateTruckList_Click(object sender, EventArgs e)
        {
            if (_isUpdate)
            {
                _isUpdate = false;
                await _manager.UpdateTruckListAsync();
                buttonFind_Click(null, null);
                _isUpdate = true;
            }
        }
    }
}
