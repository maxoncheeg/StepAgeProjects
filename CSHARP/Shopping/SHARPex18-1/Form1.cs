using System;
using System.Windows.Forms;

namespace SHARPex18_1
{
    public partial class Form1 : Form
    {
        private MyMenu _menu;

        public Form1()
        {
            InitializeComponent();

            _menu = MyMenu.FromFile("MYFAVORITESAVE");
            _menu.ShowShops(listBoxShops);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            if (listBoxShops.SelectedIndex == -1) return;

            _menu.OpenShop(listBoxShops.SelectedIndex);
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            _menu.CreateShop();
            _menu.ShowShops(listBoxShops);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxShops.SelectedIndex == -1) return;

            _menu.DeleteShop(listBoxShops.SelectedIndex);
            _menu.ShowShops(listBoxShops);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            _menu.Save();
        }
    }
}
