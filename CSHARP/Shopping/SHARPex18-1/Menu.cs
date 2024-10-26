using System;
using System.Collections.Generic;

namespace SHARPex18_1
{
    [Serializable]
    class MyMenu
    {
        private List<Shop> _shops = new List<Shop>();

        public static MyMenu FromFile(string wayToFile)
        {
            MyMenu menu = new MyMenu();

            if (System.IO.File.Exists(wayToFile))
            {
                try
                {
                    using (System.IO.Stream stream = System.IO.File.OpenRead(wayToFile))
                    {
                        System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter =
                            new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                        menu = formatter.Deserialize(stream) as MyMenu;
                    }
                }
                catch
                {
                    System.Windows.Forms.MessageBox.Show("Не удалось открыть файл! По окончанию программы создатся новый файл с сохранением прогресса", "Ошибка",
                        System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                    return menu;
                }
            }
            
            return menu;
        }


        public void CreateShop()
        {
            FormCreateShop form = new FormCreateShop(_shops);

            form.ShowDialog();
        }

        public void AddShop(string name, List<Product> products)//думал пригодится
        {
            _shops.Add(Shop.Create(name, products));
        }

        public void DeleteShop(int index)
        {
            _shops.RemoveAt(index);
        }

        public void OpenShop(int index)
        {
            FormShop form = new FormShop(_shops, index);

            form.ShowDialog();
        }

        public void ShowShops(System.Windows.Forms.ListBox listBox)
        {
            listBox.Items.Clear();

            foreach (var item in _shops)
            {
                listBox.Items.Add(item.ToString());
            }       
        }

        public void Save()
        {
            using (System.IO.Stream stream = System.IO.File.Create("MYFAVORITESAVE"))
            {
                System.Runtime.Serialization.Formatters.Binary.BinaryFormatter formatter =
                    new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

                formatter.Serialize(stream, this);
            }
        }
    }
}
