using System;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormAdminMenu : Form
    {
        private FormLogIn _formLogIn;

        private FormAdminMenu(FormLogIn _formLogIn)
        {
            InitializeComponent();

            this._formLogIn = _formLogIn;

            pictureBoxAnim.Image = DateTime.Now.Hour > 8 && DateTime.Now.Hour < 18 ?
                Properties.Resources.truckDayRide : Properties.Resources.truckNightRide;
        }

        public static void Show(FormLogIn formLogIn)
        {
            FormAdminMenu formMenu = new FormAdminMenu(formLogIn);

            formLogIn.Visible = false;
            formMenu.ShowDialog();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            FormUsers.Open();
        }

        private void FormAdminMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            _formLogIn.Visible = true;
        }

        private void personalAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FormPersonalProfile.Open() == DialogResult.Abort) 
                Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void buttonRegisterTrucks_Click(object sender, EventArgs e) =>
            FormRegisterTrucks.Open();

        private void FormAdminMenu_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);

        private void buttonTrucks_Click(object sender, EventArgs e)
        {
            FormTrucks trucks = new FormTrucks();
            trucks.ShowDialog();
        }

        private void toolStripMenuItemSupportedCities_Click(object sender, EventArgs e) =>
            FormSupportedCities.Open();

        private void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            FormMakeOrder form = new FormMakeOrder();
            form.ShowDialog();
        }

        private void buttonTruckers_Click(object sender, EventArgs e)
        {
            FormTruckers form = new FormTruckers();
            form.ShowDialog();
        }

        private void buttonDoOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
