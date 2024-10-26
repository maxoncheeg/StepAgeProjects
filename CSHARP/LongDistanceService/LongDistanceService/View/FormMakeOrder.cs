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

namespace LongDistanceService.View
{
    public partial class FormMakeOrder : Form
    {
        private MainManager _mainManager;
        private LogInManager _logInManager;

        public FormMakeOrder()
        {
            InitializeComponent();

            _mainManager = MainManager.GetManager();
            _logInManager = LogInManager.GetManager();
        }

        private async void buttonMakeOrder_Click(object sender, EventArgs e)
        {
            if (textBoxOrderName.Text == string.Empty) return;

            if (await _mainManager.MakeOrderAsync(textBoxOrderName.Text, (int)numericUpDownCargoWeight.Value,
                textBoxDescription.Text, comboBoxFrom.Text, comboBoxTo.Text))
            {
                if(await _logInManager.AddOrderMadeToCurrentUser())
                    LDSMessageBox.Show("The order has been added. Wait for the call.", "Yes");
            }
            else
                LDSMessageBox.Show("The order has not been added. Please try again later.", "Oh");
        }

        private async void FormMakeOrder_Load(object sender, EventArgs e)
        {
            FormPlacer.ToScreenCenter(this);

            await _mainManager.GetSupportedCitiesAsync(comboBoxFrom);

            foreach (var item in comboBoxFrom.Items)            
                comboBoxTo.Items.Add(item);
            
            comboBoxFrom.SelectedIndex = 0;
            comboBoxTo.SelectedIndex = 0;
        }
    }
}
