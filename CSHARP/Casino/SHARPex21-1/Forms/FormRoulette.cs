using System;
using System.Windows.Forms;

namespace SHARPex21_1.Forms
{
    public partial class FormRoulette : Form
    {
        private CasinoManager _manager;
        private RouletteStatistic _statistic;

        public FormRoulette()
        {
            InitializeComponent();

            _manager = CasinoManager.Create(_statistic = RouletteStatistic.FromFile("C23A232S44I55N67O"));
            timerChecker.Start();

            pictureBoxRoulette.Image = imageListRoulette.Images[0];
        }

        private void buttonSpin_Click(object sender, EventArgs e)
        {
            int bet = 200;
            if (radioButton200.Checked) bet = 200;
            else if (radioButton1000.Checked) bet = 1000;
            else if (radioButton5000.Checked) bet = 5000;

            _manager.ButtonSpin(bet, pictureBoxRoulette, imageListRoulette);
        }

        private void timerChecker_Tick(object sender, EventArgs e)
        {
            buttonSpin.Enabled = numericUpDownPlayerNumber.Enabled = !_manager.CheckTheRouletteSpin();

            if (!_manager.CheckTheRouletteSpin())
            {
                if (_manager.CheckMoney(this, timerChecker))
                {
                    timerChecker.Stop();

                    _manager = CasinoManager.Create(_statistic);

                    timerChecker.Start();
                }

                _manager.UpdateForm(labelPlayerMoney, labelEnemyMoney, labelEnemyNumber);
            }
        }

        private void numericUpDownPlayerNumber_ValueChanged(object sender, EventArgs e)
        {
            _manager.ChangePlayerNumber((int)numericUpDownPlayerNumber.Value);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxBetterThanBasicMessageBox.Show("The 17th of January\n\r2022", "Information");
        }

        private void FormRoulette_FormClosed(object sender, FormClosedEventArgs e)
        {
            _statistic.Save("C23A232S44I55N67O");
        }

        private void showStatisticToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistic form = new FormStatistic(_statistic);

            form.ShowDialog();
        }

        private void StartNewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _manager = CasinoManager.Create(_statistic);
        }

        private void fToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBoxBetterThanBasicMessageBox.Show("NO RULES", "RULES");
        }
    }
}

