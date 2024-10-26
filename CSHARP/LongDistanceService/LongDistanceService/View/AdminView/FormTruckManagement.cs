using LongDistanceService.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormTruckManagement : Form
    {
        private MainManager _manager;

        private FormTruckManagement(string licensePlate)
        {
            InitializeComponent();

            string temp = "";

            for (int i = 0; i < 6; i++)
                temp += licensePlate[i];

            textBoxLicensePlate.Text = temp;   

            _manager = MainManager.GetManager();

            FormClosed += FormTruckManagement_FormClosed;
        }

        private void FormTruckManagement_FormClosed(object sender, FormClosedEventArgs e) =>
            DialogResult = DialogResult.OK;

        public static DialogResult Open(string licensePlate)
        {
            FormTruckManagement form = new FormTruckManagement(licensePlate);

            return form.ShowDialog();
        }

        private async void FormTruckManagement_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);

            if (!await _manager.GetTruckByLicensePlateAsync(textBoxLicensePlate, textBoxBrand, numericUpDownLoadCapacity, textBoxTrucker, textBoxOrder, pictureBoxPhoto))
            {
                DialogResult = DialogResult.Cancel;
                Close();
            }
        }

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
            if(await _manager.UpdateTruckAsync(textBoxLicensePlate.Text, (int)numericUpDownLoadCapacity.Value, pictureBoxPhoto.Image))
            {
                LDSMessageBox.Show("Truck successfully updated", "Yes!");

                if (!await _manager.GetTruckByLicensePlateAsync(textBoxLicensePlate, textBoxBrand, numericUpDownLoadCapacity, textBoxTrucker, textBoxOrder, pictureBoxPhoto))
                {
                    DialogResult = DialogResult.Cancel;
                    Close();
                }
            }
            else
                LDSMessageBox.Show("Truck failed to update", "NOOO!");
        }

        private async void buttonDelete_Click(object sender, EventArgs e)
        {
            if (await _manager.DeleteTruckAsync(textBoxLicensePlate.Text))
            {
                LDSMessageBox.Show("Truck successfully deleted", "Yes!");
                this.Close();
            }
            else
                LDSMessageBox.Show("Truck failed to deleted", "NOOO!");
        }
    }
}
