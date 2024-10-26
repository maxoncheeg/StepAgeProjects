using System;
using System.Collections.Generic;

namespace SHARPex15_1
{
    [Serializable]
    class CatList
    {
        private List<Cat> _cats = new List<Cat>();

        public void Show(System.Windows.Forms.ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (var cat in _cats)            
                listBox.Items.Add(cat.Name);           
        }

        public void AddCat(System.Drawing.Image image, string name) =>       
            _cats.Add(Cat.CreateCat(image, name));

        public Cat GetCat(int index) => _cats[index]; 
    }
}
