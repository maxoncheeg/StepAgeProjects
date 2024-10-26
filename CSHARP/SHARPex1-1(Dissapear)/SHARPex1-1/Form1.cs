using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex1_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Up_Click(object sender, EventArgs e)
        {
            if ((int)Label.TextAlign !=  1 && (int)Label.TextAlign != 2 && (int)Label.TextAlign != 4)
            {
                int factor = (int)Label.TextAlign % 10;
                if (factor == 6) factor = 1;
                Label.TextAlign -= (int)Label.TextAlign / (16*factor) != 16 ? 15*factor : 240*factor; //сложный способ
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {
            if ((int)Label.TextAlign != 4 && (int)Label.TextAlign != 64 && (int)Label.TextAlign != 1024)            
                Label.TextAlign += (int)Label.TextAlign % 1000;//наилегчайший способ          
        }

        private void Down_Click(object sender, EventArgs e)
        {
            if ((int)Label.TextAlign != 256 && (int)Label.TextAlign != 512 && (int)Label.TextAlign != 1024)
                Label.TextAlign += 15 * ((int)Label.TextAlign % 100);//легкий способ
        }

        private void Left_Click(object sender, EventArgs e)
        {
            if ((int)Label.TextAlign != 1 && (int)Label.TextAlign != 16 && (int)Label.TextAlign != 256)
                Label.TextAlign -= ((int)Label.TextAlign / 2);//среднячок
        }
    }
}
