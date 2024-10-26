using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace SHARPex19_1
{
    public partial class Form1 : Form
    {
        private bool _isMusicPlaying;
        private SoundPlayer _soundPlayer;

        public Form1()
        {
            InitializeComponent();

            _soundPlayer = new SoundPlayer("someMusic.wav");
            _isMusicPlaying = false;

            XmlOrders.CheckFile();
            XmlOrders.GetOrdersName(listBoxOrders);
        }

        private void listBoxOrders_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex == -1) return;

            XmlOrders.ShowOrder(listBoxOrders.SelectedItem.ToString());
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            XmlOrders.AddOrder();
            XmlOrders.GetOrdersName(listBoxOrders);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxOrders.SelectedIndex == -1) return;

            XmlOrders.DeleteOrder(listBoxOrders.SelectedItem.ToString());
            XmlOrders.GetOrdersName(listBoxOrders);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (System.IO.File.Exists("orders.xml"))
                System.IO.File.Delete("orders.xml");

            XmlOrders.CheckFile();
            XmlOrders.GetOrdersName(listBoxOrders);
        }

        private void MusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_isMusicPlaying)
            {
                _soundPlayer.Stop();
                buttonClose.Image = null;
                buttonClose.ForeColor = Color.Black;
            }
            else
            {
                _soundPlayer.PlayLooping();
                buttonClose.Image = Image.FromFile("SERIOUSBOMB.png");
                buttonClose.ForeColor = Color.LimeGreen;
            }

            _isMusicPlaying = !_isMusicPlaying;
        }
    }
}
