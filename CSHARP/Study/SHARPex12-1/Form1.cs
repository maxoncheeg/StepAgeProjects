using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex12_1
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> cppBook;

        public Form1()
        {
            InitializeComponent();

            cppBook = new Dictionary<string, string>();

            buttonChapter.Enabled = false;
            buttonDescription.Enabled = false;

            cppBook.Add("Типы данных", "int от -2147483648 до 2147483647 | bool - true/false | char - лучший тип в C++");
            cppBook.Add("Тернарный оператор", "<условие> ? <тогда, если правда> : <тогда, если ложь>");
            cppBook.Add("Циклы", "while, for, do/while | break - выйти из цикла | continue - перейти на следующую итерацию");
            cppBook.Add("Массивы", "<тип данных> <имя>[<размерность>]");
            cppBook.Add("Указатели", "Автор учебника не разобрался как их использовать((((");

            comboBoxChapters.Items.Add("Типы данных");
            comboBoxChapters.Items.Add("Тернарный оператор");
            comboBoxChapters.Items.Add("Циклы");
            comboBoxChapters.Items.Add("Массивы");
            comboBoxChapters.Items.Add("Указатели");

            comboBoxChapters.SelectedIndex = 0;

            textBoxEvenChapter.Text = "Типы данных";
            textBoxEvenDiscription.Text = cppBook["Типы данных"];
            textBoxOddChapter.Text = "Тернарный оператор";
            textBoxOddDiscription.Text = cppBook["Тернарный оператор"];

            hScrollBar.Maximum = 3;

            labelSecond.Text = "1";
        }

        private void buttonChapter_Click(object sender, EventArgs e)
        {
            foreach (var key in cppBook.Keys)            
                if(key.ToUpper() == textBoxChapter.Text.ToUpper())
                {
                    MessageBox.Show($"Название главы \"{textBoxChapter.Text}\" уже существует!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            cppBook.Add(textBoxChapter.Text, "");
            comboBoxChapters.Items.Add(textBoxChapter.Text);

            hScrollBar.Maximum = (cppBook.Count + 1) / 2;

            GoScroll();//хотелось, чтобы текст автоматом обновлялся, а что передовать в это событие я не знаю.
        }

        private void buttonDescription_Click(object sender, EventArgs e)
        {
            foreach (var key in cppBook.Keys)
                if (key.ToUpper() == comboBoxChapters.Text.ToUpper())
                {
                    cppBook[key] = textBoxDescription.Text;
                    break;
                }

            GoScroll();//хотелось, чтобы текст автоматом обновлялся, а что передовать в это событие я не знаю.
        }

        private void textBoxChapter_TextChanged(object sender, EventArgs e)
        {
            buttonChapter.Enabled = String.IsNullOrEmpty(textBoxChapter.Text) ? false : true;
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            buttonDescription.Enabled = String.IsNullOrEmpty(textBoxDescription.Text) ? false : true;
        }

        private void comboBoxChapters_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var key in cppBook.Keys)            
                if (key.ToUpper() == comboBoxChapters.Text.ToUpper())
                    textBoxDescription.Text = cppBook[key];         
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            GoScroll();//хотелось, чтобы текст автоматом обновлялся, а что передовать в это событие я не знаю.
        }
       
        private void GoScroll()
        {
            labelFirst.Text = (hScrollBar.Value * 2).ToString();
            labelSecond.Text = (hScrollBar.Value * 2 + 1).ToString();
            textBoxEvenChapter.Text = comboBoxChapters.Items[Convert.ToInt32(labelFirst.Text)].ToString();
            foreach (var key in cppBook.Keys)
                if (textBoxEvenChapter.Text == key)
                {
                    textBoxEvenDiscription.Text = cppBook[key];
                    break;
                }

            if (hScrollBar.Value * 2 + 1 < cppBook.Count)
            {
                textBoxOddChapter.Text = comboBoxChapters.Items[Convert.ToInt32(labelSecond.Text)].ToString();
                foreach (var key in cppBook.Keys)
                    if (textBoxOddChapter.Text == key)
                    {
                        textBoxOddDiscription.Text = cppBook[key];
                        break;
                    }
            }
            else
            {
                textBoxOddChapter.Text = "";
                textBoxOddDiscription.Text = "";
            }
        }
    }
}
