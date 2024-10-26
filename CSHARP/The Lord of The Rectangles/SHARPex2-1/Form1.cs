using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex2_1
{
    public partial class Form1 : Form
    {
        int figure;
        enum Figure
        {
            Rectangle = 1,
            Square = 2,
            Circle = 3,
            Trapezoid = 4
        }
        public Form1()
        {
            InitializeComponent();

            labelFirst.Visible = false;
            labelSecond.Visible = false;
            labelThird.Visible = false;

            numericUpDownFirst.Visible = false;
            numericUpDownSecond.Visible = false;
            numericUpDownThird.Visible = false;

            buttonCalculate.Enabled = false;
        }

        public void ButtonsEnabled()
        {
            buttonCalculate.Enabled = true;
            buttonCircle.Enabled = false;
            buttonSquare.Enabled = false;
            buttonRectangle.Enabled = false;
            buttonTrapezoid.Enabled = false;

            numericUpDownFirst.Value = 0;
            numericUpDownSecond.Value = 0;
            numericUpDownThird.Value = 0;
        }

        private void buttonRectangle_Click(object sender, EventArgs e)
        {
            figure = (int)Figure.Rectangle;

            labelFirst.Visible = true;
            labelSecond.Visible = true;

            numericUpDownFirst.Visible = true;
            numericUpDownSecond.Visible = true;

            labelFirst.Text = "Length:";
            labelSecond.Text = "Height:";

            ButtonsEnabled();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            if (figure == (int)Figure.Rectangle)
            {
                if (numericUpDownFirst.Value == 0 || numericUpDownSecond.Value == 0)
                {
                    MessageBox.Show("You didn't input numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelOutput.Text = "Area = " + Geometry.RectangleArea(numericUpDownFirst.Value, numericUpDownSecond.Value);
            }
            else if (figure == (int)Figure.Square)
            {
                if (numericUpDownFirst.Value == 0)
                {
                    MessageBox.Show("You didn't input numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelOutput.Text = "Area = " + Geometry.SquareArea(numericUpDownFirst.Value);
            }
            else if (figure == (int)Figure.Circle)
            {
                if (numericUpDownFirst.Value == 0)
                {
                    MessageBox.Show("You didn't input numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelOutput.Text = "Area = " + Geometry.CircleArea(numericUpDownFirst.Value);
            }
            else if (figure == (int)Figure.Trapezoid)
            {
                if (numericUpDownFirst.Value == 0 || numericUpDownSecond.Value == 0 || numericUpDownThird.Value == 0)
                {
                    MessageBox.Show("You didn't input numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                labelOutput.Text = "Area = " + Geometry.TrapezoidArea(numericUpDownThird.Value, numericUpDownFirst.Value, numericUpDownSecond.Value);
            }

            buttonCalculate.Enabled = false;
            buttonCircle.Enabled = true;
            buttonSquare.Enabled = true;
            buttonRectangle.Enabled = true;
            buttonTrapezoid.Enabled = true;

            labelFirst.Visible = false;
            labelSecond.Visible = false;
            labelThird.Visible = false;

            numericUpDownFirst.Visible = false;
            numericUpDownSecond.Visible = false;
            numericUpDownThird.Visible = false;
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            figure = (int)Figure.Circle;

            labelFirst.Visible = true;

            numericUpDownFirst.Visible = true;

            labelFirst.Text = "Radius:";

            ButtonsEnabled();
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            figure = (int)Figure.Square;

            labelFirst.Visible = true;

            numericUpDownFirst.Visible = true;

            labelFirst.Text = "Length:";

            ButtonsEnabled();
        }

        private void buttonTrapezoid_Click(object sender, EventArgs e)
        {
            figure = (int)Figure.Trapezoid;

            labelFirst.Visible = true;
            labelSecond.Visible = true;
            labelThird.Visible = true;

            numericUpDownFirst.Visible = true;
            numericUpDownSecond.Visible = true;
            numericUpDownThird.Visible = true;

            labelFirst.Text = "Base 1:";
            labelSecond.Text = "Base 2:";
            labelThird.Text = "Height:";

            ButtonsEnabled();
        }
    }
}
