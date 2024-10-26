using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex5_1
{
    public partial class form1 : Form
    {
        TimerWork worker;

        public form1()
        {
            InitializeComponent();
       
            worker = TimerWork.GiveTime();
        }

        private void buttonSwitch_Click(object sender, EventArgs e)
        {
            worker.TimerSwitch(timerButton, timerColor, timerPicture);
        }

        private void timerButton_Tick(object sender, EventArgs e)
        {
            worker.ButtonMove(buttonSwitch, this);
        }

        private void timerPicture_Tick(object sender, EventArgs e)
        {
            worker.ChangePicture(pictureBoxOut);
        }

        private void timerColor_Tick(object sender, EventArgs e)
        {
            worker.ChangeColor(ActiveForm);
        }
    }
}
