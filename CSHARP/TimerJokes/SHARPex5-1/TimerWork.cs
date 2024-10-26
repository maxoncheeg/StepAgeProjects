using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex5_1
{
    class TimerWork
    {
        private int _milliseconds;
        private bool _active;
        private bool _buttonDirection;
        private Random random;
        private int _pictureBox;
        private TimerWork(int _milliseconds)
        {
            this._milliseconds = _milliseconds;
            _active = false;
            _buttonDirection = true;
            random = new Random();
            _pictureBox = 0;
        }

        public static TimerWork GiveTime(int _milliseconds = 0)
        {
            return new TimerWork(_milliseconds);
        }

        public void ChangePicture(PictureBox pictureBox)
        {
            if (_milliseconds == 500 || _milliseconds == 999)
            {
                bool exit = true;
                while (exit)
                {
                    //гифки делал для своего сервера в Discord
                    switch (random.Next(0, 3))
                    {
                        case 0:
                            if (_pictureBox != 0)
                            {
                                pictureBox.Image = Properties.Resources.goose;
                                _pictureBox = 0;
                                exit = !exit;
                            }
                            break;

                        case 1:
                            if (_pictureBox != 1)
                            {
                                pictureBox.Image = Properties.Resources.mushroom;
                                _pictureBox = 1;
                                exit = !exit;
                            }
                            break;

                        case 2:
                            if (_pictureBox != 2)
                            {
                                pictureBox.Image = Properties.Resources.zhukasGO;
                                _pictureBox = 2;
                                exit = !exit;
                            }
                            break;
                    }
                }

            }
        }

        public void ChangeColor(Form form)
        {
            if(_milliseconds == 1000)
            {
                form.BackColor = System.Drawing.Color.FromArgb((byte)random.Next(0, 255), (byte)random.Next(0, 255), (byte)random.Next(0, 255));
                _milliseconds = 0;
            }
        }

        public void TimerSwitch(Timer timer1, Timer timer2, Timer timer3)
        {
            if(!_active){
                timer1.Enabled = true;
                timer2.Enabled = true;
                timer3.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
                timer2.Enabled = false;
                timer3.Enabled = false;
            }
            _active = !_active;
            _milliseconds = 0;
        }

        public void ButtonMove(Button button, Form form)
        {
            _milliseconds++;

            if(button.Location.X == form.Size.Width - button.Size.Width || button.Location.X == 0)            
                _buttonDirection = !_buttonDirection;
            
            if(_buttonDirection) button.Left += 1;
            else button.Left -= 1;
        }
    }
}
