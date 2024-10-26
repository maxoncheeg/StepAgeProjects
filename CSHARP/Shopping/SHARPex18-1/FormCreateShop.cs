using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SHARPex18_1
{
    public partial class FormCreateShop : Form
    {
        private List<Shop> _shops;

        public FormCreateShop(List<Shop> _shops)
        {
            InitializeComponent();
            this._shops = _shops;
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxName.Text)) return;

            _shops.Add(Shop.Create(textBoxName.Text));

            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
