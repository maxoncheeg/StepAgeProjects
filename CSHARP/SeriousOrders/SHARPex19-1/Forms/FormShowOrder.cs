using System;
using System.Drawing;
using System.Windows.Forms;

namespace SHARPex19_1
{
    public partial class FormShowOrder : Form
    {
        public FormShowOrder(string orderName, string weight, string price, string wayToPicture = "NOIMAGE.png")
        {
            InitializeComponent();

            textBoxName.Text = orderName;
            textBoxWeight.Text = weight;
            textBoxPrice.Text = price;
            pictureBoxImage.Image = Image.FromFile(wayToPicture);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
