using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace SHARPex15_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CatManagement.Load();
            CatManagement.UpdateListBox(listBoxCats);

            buttonAdd.Enabled = false;
        }

        private void listBoxCats_SelectedIndexChanged(object sender, EventArgs e) =>
            CatManagement.ShowCat(listBoxCats.SelectedIndex, labelCatName, pictureBoxForCats);

        private void textBoxCatName_TextChanged(object sender, EventArgs e) =>
            buttonAdd.Enabled = !String.IsNullOrEmpty(textBoxCatName.Text);

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            CatManagement.AddCats(textBoxCatName.Text);
            CatManagement.UpdateListBox(listBoxCats);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e) =>        
            CatManagement.Save();
        
    }
}
