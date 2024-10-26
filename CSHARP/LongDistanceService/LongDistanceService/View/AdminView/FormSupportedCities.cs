using LongDistanceService.Controller;
using System;
using System.Windows.Forms;

namespace LongDistanceService.View.AdminView
{
    public partial class FormSupportedCities : Form
    {
        private MainManager _manager;
        private Boolean _isUpdate = false;

        private FormSupportedCities()
        {
            InitializeComponent();

            _manager = MainManager.GetManager();
            listBoxCities.DoubleClick += ListBoxCities_DoubleClick;
        }

        public static DialogResult Open() => new FormSupportedCities().ShowDialog();

        private async void ListBoxCities_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxCities.SelectedIndex == -1) return;

            if (await _manager.DeleteSupportedCityAsync(listBoxCities.Items[listBoxCities.SelectedIndex].ToString()))
            {
                LDSMessageBox.Show("City is successfully deleted from database!", "WOW");

                if (!_isUpdate)
                {
                    _isUpdate = true;
                    await _manager.GetSupportedCitiesAsync(listBoxCities);
                    _isUpdate = false;
                }
            }
            else
                LDSMessageBox.Show("City is not deleted from database!", "NOO");
        }

        private async void FormSupportedCities_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);

            if (!_isUpdate)
            {
                _isUpdate = true;
                await _manager.GetSupportedCitiesAsync(listBoxCities);
                _isUpdate = false;
            }
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxCountry.Text == string.Empty || textBoxCity.Text == string.Empty)
                return;

            if (await _manager.AddSupportedCityAsync(textBoxCountry.Text, textBoxCity.Text))
            {
                LDSMessageBox.Show("City is successfully added to database!", "WOW");

                if (!_isUpdate)
                {
                    _isUpdate = true;
                    await _manager.GetSupportedCitiesAsync(listBoxCities);
                    _isUpdate = false;
                }
            }
            else
                LDSMessageBox.Show("City is not added to database!", "NOO");
        }

        private async void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!_isUpdate)
            {
                _isUpdate = true;
                await _manager.GetSupportedCitiesAsync(listBoxCities);
                _isUpdate = false;
            }
        }
    }
}
