using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class Product: IProduct //у Кассы будет Сканер который читает условный штрих-код, заносит в бд. Потом на выходе будут Весы, кот. будут сравнивать вес продуктов во избежание обмана
    { // Вероятно будет еще Магазин или Склад с продуктами
        private double _price;
        private double _weight;
        private int _id;
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value != 0 && value > 0)
                {
                    _price = value;
                }
            }
        }
        public double Weight
        {
            get
            {
                return _weight;
            }
            set
            {
                if(value != 0 && value > 0)
                {
                    _weight = value;
                }
            }
        }
        public Product() { }
        public Product(string title, double price, double weight)
        {
            Title = title;
            Price = price;
            Weight = weight;
        }
        public override string ToString()
        {
            return $"{Title}: {Price}, {Weight}";
        }
    }
}
