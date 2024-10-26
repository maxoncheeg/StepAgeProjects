using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex7_1
{
    class DuckGame
    {
        private CardDeck _cardDeck;

        private Timer _timer;

        private Form _form;

        private Label _labelLevel;
        private Label _labelScore;
        private Label _labelInformation;
        private Label _labelWin;

        private int _levelValue;
        private int _score;
        private double _scoreMultiplier;
        private Medal _medal;

        enum Medal
        {
            NONE = 4,
            BRONZE = 3,
            SILVER = 2,
            GOLD = 1
        }

        public DuckGame(CardDeck _cardDeck, Timer _timer, Label _labelLevel, Label _labelScore, Label _labelInformation, Label _labelWin, Form _form)
        {
            this._cardDeck = _cardDeck;
            this._timer = _timer;
            this._labelLevel = _labelLevel;
            this._labelScore = _labelScore;
            this._labelInformation = _labelInformation;
            this._labelWin = _labelWin;
            this._form = _form;

            _cardDeck.ChangeMainPicture();
            _cardDeck.ChangeChangingPicture();

            _levelValue = 0;
            _score = 0;
            _scoreMultiplier = 1;
            _timer.Interval = 1275;
            _medal = Medal.NONE;

            _labelWin.Text = "15000";

            NextLevel();

            _timer.Start();
        }

        private void NextLevel()
        {
            if (_timer.Interval - 25 == 0) {
                _timer.Stop();
                MessageBox.Show("Interval is too small\n" +
                    "You have received " + _score + " points", "End Game", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _form.Close(); 
            }

            _timer.Interval -= 25;
            
            _levelValue++;

            _labelLevel.Text = _levelValue.ToString();
            _labelInformation.Text += "Next Level!\n\n";
            _labelInformation.Text += "Picture changes every " + _timer.Interval + "ms\n";
        }

        public void MatchCheck()
        {
            _labelInformation.Text = "";
            if (_cardDeck.IsMatch())
            {
                _score += (int)(100 * _scoreMultiplier);
                _labelInformation.Text += _levelValue.ToString() + ": +" + 100 * _scoreMultiplier + " points\n";
                _scoreMultiplier += 0.5;

                WinCheck();
                NextLevel();
            }
            else
            {
                _score -= 175;
                if (_score < 0) _score = 0;
                _scoreMultiplier = 1;
                _labelInformation.Text += _levelValue.ToString() + ": -175 points\n";
            }
            _labelScore.Text = _score.ToString();
            _cardDeck.ChangeMainPicture();
        }

        public void TimerTick()
        {
            _cardDeck.ChangeChangingPicture();
        }

        private void WinCheck()
        {
            _timer.Stop();
            if (_score >= 15000 && _medal == Medal.NONE)
            {
                _medal = Medal.BRONZE;
                if (DialogResult.Yes != MessageBox.Show("You have received a bronze medal!\n" +
                    "Do you want to get a silver medal(20000 points)?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    _form.Close();
                _labelWin.Text = "20000";
            }
            else if (_score >= 20000 && _medal == Medal.BRONZE)
            {
                _medal = Medal.SILVER;
                if (DialogResult.Yes != MessageBox.Show("You have received a silver medal!\n" +
                    "Do you want to get a gold medal(25000 points)?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    _form.Close();
                _labelWin.Text = "25000";
            }
            else if (_score >= 25000 && _medal == Medal.SILVER)
            {
                _medal = Medal.GOLD;
                if (DialogResult.Yes != MessageBox.Show("You have received a gold medal!\n" +
                    "Do you want to continue playing?", "Congratulations!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk))
                    _form.Close();
                _labelWin.Text = "30000+";
            }
            _timer.Start();
        }
    }
}
