using System;
using System.Media;
using System.Windows.Forms;
using SHARPex21_1.Forms;
using SHARPex21_1.Classes;

namespace SHARPex21_1
{
    class CasinoManager
    {
        private event EventHandler _statistic;

        private Roulette _roulette = new Roulette();
        private Player _player;
        private Enemy _enemy;
        private SoundPlayer _sound;

        private string _spinTitle;
        private string _spinText;

        private bool _isNeedToShowMessageBox;

        private CasinoManager(RouletteStatistic _statistic)
        {
            _isNeedToShowMessageBox = false;

            this._statistic += _statistic.UpdateStatistic;

            _sound = new SoundPlayer("RouletteSpin.wav");
            _player = new Player() { Money = 20000, IsWin = false, HiddenRouletteNumber = 1 };
            _enemy = new Enemy() { Money = 20000, IsWin = false, HiddenRouletteNumber = 1 };

            _roulette = new Roulette();

            _roulette.RouletteWheel += _player.SpinRoulette;
            _roulette.RouletteWheel += _enemy.SpinRoulette;

            _roulette.RouletteWheel += delegate(object sender, EventArgs args)
                                       {
                                           if (sender is Roulette)
                                           {
                                               SetStatistic();

                                               if (_player.IsWin && _enemy.IsWin)
                                               {
                                                   _player.Money += _roulette.Bet / 2;
                                                   _enemy.Money += _roulette.Bet / 2;

                                                   _spinTitle = $"You and your enemy are right!";
                                                   _spinText = $"The player is given ${_roulette.Bet / 2}\n\r\n\r" +
                                                   $"The enemy is given ${_roulette.Bet / 2}";
                                               }
                                               else if (_player.IsWin)
                                               {
                                                   _player.Money += _roulette.Bet;

                                                   _spinTitle = $"You are right!";
                                                   _spinText = $"The player is given ${_roulette.Bet}\n\r\n\r" +
                                                   $"${_roulette.Bet / 2} is taken away from the enemy";
                                               }
                                               else if (_enemy.IsWin)
                                               {
                                                   _enemy.Money += _roulette.Bet;

                                                   _spinTitle = $"The enemy is right!";
                                                   _spinText = $"The enemy is given ${_roulette.Bet}\n\r\n\r" +
                                                   $"${_roulette.Bet / 2} is taken away from the player";
                                               }
                                               else
                                               {
                                                   _spinTitle = $"NO ONE IS RIGHT!";
                                                   _spinText = $"${_roulette.Bet / 2} is taken away from the enemy\n\r\n\r" +
                                                   $"${_roulette.Bet / 2} is taken away from the player";
                                               }

                                               _isNeedToShowMessageBox = true;

                                               _roulette.Bet = 0;

                                               _player.IsWin = false;
                                               _enemy.IsWin = false;
                                           }
                                       };
        }

        public static CasinoManager Create(RouletteStatistic statistic) => new CasinoManager(statistic);

        public void ButtonSpin(int bet, PictureBox roulette, ImageList rouletteNumbers)
        {
            _player.Money -= bet;
            _enemy.Money -= bet;
            _roulette.Bet = bet * 2;

            _roulette.SpinTheRouletteWheel(roulette, rouletteNumbers);
            _sound.Play();
        }

        public bool CheckTheRouletteSpin() => _roulette.IsThreadActive;

        public void ChangePlayerNumber(int number) => _player.HiddenRouletteNumber = number;

        public void UpdateForm(Label playerMoney, Label enemyMoney, Label enemyNumber)
        {
            if (_isNeedToShowMessageBox)
            {
                _isNeedToShowMessageBox = false;
                _sound.Stop();

                MessageBoxBetterThanBasicMessageBox.Show(_spinText, _spinTitle);//ну правда же лучше...
            }

            playerMoney.Text = $"${_player.Money}";
            enemyMoney.Text = $"${_enemy.Money}";
            enemyNumber.Text = _enemy.HiddenRouletteNumber.ToString();
        }

        public int GetSomeNumberForStatistic() => _roulette.Bet;

        public bool[] GetSomeBoolValuesForStatistic() => new bool[2] { _player.IsWin, _enemy.IsWin };

        public bool CheckMoney(FormRoulette form, Timer timer)
        {
            
            if(_player.Money < 200 || _enemy.Money < 200)
            {
                timer.Stop();
                if (MessageBox.Show("You or your opponent have no money to bet! Start over?", "Wow!", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                     == DialogResult.Yes)
                    return true;
                else form.Close();
            }

            return false;
        }

        private void SetStatistic()
        {
            BoxWithPoliteMessage box = BoxWithPoliteMessage.Pack("Hello, Mr. Statistic!");

            if (_statistic != null)
                _statistic(this, box);
        }
    }
}
