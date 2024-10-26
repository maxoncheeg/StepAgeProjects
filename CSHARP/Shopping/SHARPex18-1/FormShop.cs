using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SHARPex18_1
{
    public partial class FormShop : Form
    {
        private List<Shop> _shops;
        private int _index;

        public FormShop(List<Shop> _shops, int _index)
        {
            InitializeComponent();

            this._shops = _shops;
            this._index = _index;
            this.Text = this._shops[this._index].ToString();

            UpdateNumericUpDown();
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex == -1) return;

            FormAddProduct form = new FormAddProduct(_shops[_index].Products);

            if(form.ShowDialog(_shops[_index].Products[listBoxProducts.SelectedIndex]) == DialogResult.OK)
                _shops[_index].Products.RemoveAt(listBoxProducts.SelectedIndex);

            _shops[_index].ChangeMaxMinValues();
            UpdateNumericUpDown();
            _shops[_index].Show(listBoxProducts, (double)numericUpDownPrice.Value);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddProduct form = new FormAddProduct(_shops[_index].Products);

            form.ShowDialog();

            _shops[_index].ChangeMaxMinValues();
            UpdateNumericUpDown();
            _shops[_index].Show(listBoxProducts, (double)numericUpDownPrice.Value);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxProducts.SelectedIndex == -1) return;

            _shops[_index].Products.RemoveAt(listBoxProducts.SelectedIndex);
            _shops[_index].ChangeMaxMinValues();
            UpdateNumericUpDown();
            _shops[_index].Show(listBoxProducts, _shops[_index].PriceMax);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDownPrice_ValueChanged(object sender, EventArgs e)
        {
            _shops[_index].Show(listBoxProducts, (double)numericUpDownPrice.Value);
        }

        private void UpdateNumericUpDown()
        {
            numericUpDownPrice.Maximum = this._shops[_index].PriceMax + 1;
            numericUpDownPrice.Minimum = this._shops[_index].PriceMin;

            numericUpDownPrice.Value = this._shops[_index].PriceMax + 1;
        }
    }
}
