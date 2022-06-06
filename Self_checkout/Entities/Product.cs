using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class Product: IProduct // for ComboBox
    {
        public string Title { get; set; }
        public double Price { get; set; }
        public double Weight { get; set; }
        public Product() { }

        public Product(string title, double price, double weight)
        {
            Title = title;
            Price = price;
            Weight = weight;
        }

        public override string ToString()
        {
            return $"{Title}: {Price} руб, {Weight} гр";
        }
    }
}
