using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SHARPex18_1
{
    public partial class FormAddProduct : Form
    {
        private List<Product> _products;

        public FormAddProduct(List<Product> _products)
        {
            InitializeComponent();
            this._products = _products;
        }

        public DialogResult ShowDialog(Product product)
        {
            textBoxName.Text = product.Name;
            textBoxCountry.Text = product.Country;
            numericUpDownRubles.Value = (int)product.Price;
            numericUpDownPenny.Value = (int)(product.Price * 100) % 100;

            buttonAdd.Text = "Изменить";
            this.Text = "Изменить продукт";

            return this.ShowDialog();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (numericUpDownRubles.Value == 0 && numericUpDownPenny.Value == 0) return;
            if (string.IsNullOrEmpty(textBoxName.Text) || string.IsNullOrEmpty(textBoxCountry.Text)) return;

            _products.Add(Product.Create((double)numericUpDownRubles.Value + (double)numericUpDownPenny.Value / 100.0f, textBoxName.Text, textBoxCountry.Text));

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
