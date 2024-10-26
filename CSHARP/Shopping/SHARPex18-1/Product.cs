using System;

namespace SHARPex18_1
{
    [Serializable]
    public class Product : IComparable<Product>
    {
        public double Price { get; private set; }
        public string Name { get; private set; }
        public string Country { get; private set; }

        private Product(double Price, string Name, string Country)
        {
            this.Price = Price;
            this.Name = Name;
            this.Country = Country;
        }

        public static Product Create(double price, string name, string country)
        {
            return new Product(price, name, country);
        }

        public override string ToString()
        {
            return $"Название: {Name}|Цена: {Price}|Страна: {Country}";
        }

        public int CompareTo(Product other)
        {
            if (Price == other.Price) return 0;
            else if (Price > other.Price) return 1;
            else return -1;
        }
    }
}
