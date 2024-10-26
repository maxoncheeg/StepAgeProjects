using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace SHARPex15_1
{
    static class CatManagement
    {
        static private CatList cats = new CatList();


        static public void AddCats(string name)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Picture(png)|*.png";
            openFileDialog.Title = "Find A Cat";
            openFileDialog.InitialDirectory = "Cats";

            if(openFileDialog.ShowDialog() == DialogResult.OK)            
                cats.AddCat(Image.FromFile(openFileDialog.FileName), name);                   
        }

        static public void ShowCat(int index, Label label, PictureBox pictureBox)
        {
            if (index == -1) return;
            else
            {
                label.Text = cats.GetCat(index).Name;
                pictureBox.Image = cats.GetCat(index).Image;
            }
        }

        static public void UpdateListBox(ListBox listBox) =>       
            cats.Show(listBox);
        
        static public void Save()
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using(Stream stream = File.Create("CatsSave"))           
                formatter.Serialize(stream, cats);            
        }

        static public void Load()
        {
            if (File.Exists("CatsSave"))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                using (Stream stream = File.OpenRead("CatsSave"))
                    cats = formatter.Deserialize(stream) as CatList;
            }
        }
    }
}
