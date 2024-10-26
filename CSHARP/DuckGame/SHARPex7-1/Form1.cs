using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex7_1
{
    public partial class Form1 : Form
    {
        CardDeck cardDeck;
        DuckGame duckGame;
        public Form1()
        {
            InitializeComponent();

            cardDeck = new CardDeck(imageListGame, pictureBoxMain, pictureBoxChanging);
            duckGame = new DuckGame(cardDeck, timerGame, labelLevel, labelScore, labelInformation, labelWin, this);
        }

        private void buttonMatch_Click(object sender, EventArgs e)
        {
            duckGame.MatchCheck();
        }

        private void timerGame_Tick(object sender, EventArgs e)
        {
            duckGame.TimerTick();
            //if (cardDeck.IsMatch() && timerGame.Interval > 0) // Бот, если лень играть
            //{
            //    duckGame.MatchCheck();
            //}
        }
    }
}
