using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SHARPex18_1
{
    [Serializable]
    public class Shop
    {
        private string _name;

        public List<Product> Products { get; set; } = new List<Product>();

        public int PriceMax { get; set; } = 0;
        public int PriceMin { get; set; } = 0;

        private Shop(string _name)
        {
            this._name = _name;
            if (Products.Count == 0)
            {
                PriceMax = 0;
                PriceMin = 0;
            }
            else if (Products.Count == 1) {
                PriceMax = (int)Products[0].Price;
                PriceMin = (int)Products[0].Price;
            }
            else
            {
                PriceMax = (int)Products[0].Price;
                PriceMin = (int)Products[0].Price;

                foreach (var item in Products)
                {
                    if (PriceMax < item.Price)
                        PriceMax = (int)item.Price;
                    if (PriceMin > item.Price)
                        PriceMin = (int)item.Price;
                }
            }
        }

        public static Shop Create(string name)
        {
            return new Shop(name);
        }

        public static Shop Create(string name, List<Product> products)
        {
            Shop newShop = new Shop(name);
            newShop.Products = products;

            return newShop;
        }

        public override string ToString()
        {
            return $"Магазин \"{_name}\"";
        }

        public void Show(ListBox listBox, double maxPrice)
        {
            Products.Sort();
            listBox.Items.Clear();

            foreach (var item in Products)
                if (item.Price <= maxPrice)
                    listBox.Items.Add(item.ToString());
        }

        public void ChangeMaxMinValues()
        {
            if (Products.Count == 0)
            {
                PriceMax = 0;
                PriceMin = 0;
            }
            else if (Products.Count == 1)
            {
                PriceMax = (int)Products[0].Price;
                PriceMin = (int)Products[0].Price;
            }
            else
            {
                PriceMax = (int)Products[0].Price;
                PriceMin = (int)Products[0].Price;

                foreach (var item in Products)
                {
                    if (PriceMax < item.Price)
                        PriceMax = (int)item.Price;
                    if (PriceMin > item.Price)
                        PriceMin = (int)item.Price;
                }
            }
        }
    }
}
