using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex21_1.Forms
{
    public partial class FormStatistic : Form
    {
        public FormStatistic(RouletteStatistic statistic)
        {
            InitializeComponent();

            label12.Text = statistic.Draws.ToString();
            label13.Text = statistic.PlayerWins.ToString();
            label14.Text = statistic.EnemyWins.ToString();
            label15.Text = statistic.PlayerLoses.ToString();
            label16.Text = statistic.EnemyLoses.ToString();

            label17.Text = String.Format("{0:f1}k", (double)statistic.MoneyWonByPlayer / 1000);
            label18.Text = String.Format("{0:f1}k", (double)statistic.MoneyWonByEnemy / 1000);
            label19.Text = String.Format("{0:f1}k", (double)statistic.MoneyLostByPlayer / 1000);
            label20.Text = String.Format("{0:f1}k", (double)statistic.MoneyLostByEnemy / 1000);

            label21.Text = statistic.JoyCounter.ToString();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
