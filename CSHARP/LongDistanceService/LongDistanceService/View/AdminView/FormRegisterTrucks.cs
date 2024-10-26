using LongDistanceService.Controller;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormRegisterTrucks : Form
    {
        private MainManager _manager;

        private FormRegisterTrucks()
        {
            InitializeComponent();

            _manager = MainManager.GetManager();
            comboBoxBrand.SelectedIndex = 0;
        }

        public static DialogResult Open() => new FormRegisterTrucks().ShowDialog();

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

        private async void buttonRegister_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxLicensePlate.Text = textBoxLicensePlate.Text.ToUpper();

                if (textBoxLicensePlate.Text.Length != 6) throw new LicensePlateException();

                for (int i = 0; i < 2; i++)
                    if ((textBoxLicensePlate.Text[i] < 65 || textBoxLicensePlate.Text[i] > 90)
                         && (textBoxLicensePlate.Text[i] < 1040 || textBoxLicensePlate.Text[i] > 1071))
                        throw new LicensePlateException();

                for (int i = 2; i < 5; i++)
                    if (textBoxLicensePlate.Text[i] < 48 || textBoxLicensePlate.Text[i] > 57)
                        throw new LicensePlateException();

                if ((textBoxLicensePlate.Text[5] < 65 || textBoxLicensePlate.Text[5] > 90)
                     && (textBoxLicensePlate.Text[5] < 1040 || textBoxLicensePlate.Text[5] > 1071))
                    throw new LicensePlateException();
            }
            catch (LicensePlateException exception)
            {
                exception.ShowErrorMessage();
                return;
            }

            if (await _manager.AddNewTruckAsync(textBoxLicensePlate.Text, comboBoxBrand.Text, (int)numericUpDownLoadCapacity.Value, pictureBoxPhoto.Image))
            {
                LDSMessageBox.Show("The truck was successfully added to the database", "Wow");
                this.Close();
            }
            else
                LDSMessageBox.Show("The truck was not successfully added to the database! Perhaps he is already ", "Error");
        }

        private void FormRegisterTrucks_Load(object sender, EventArgs e) =>
            FormPlacer.ToScreenCenter(this);
    }

    class LicensePlateException : Exception
    {
        public LicensePlateException() : base("The license plate is made incorrectly!") { }

        public void ShowErrorMessage() =>
            LDSMessageBox.Show(Message, "Error!");
    }
}