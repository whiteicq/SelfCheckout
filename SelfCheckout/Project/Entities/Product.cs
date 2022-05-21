using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class Product: IProduct //у Кассы будет Сканер который читает условный штрих-код, заносит в бд. Потом на выходе будут Весы, кот. будут сравнивать вес продуктов во избежание обмана
    { // Вероятно будет еще Магазин или Склад с продуктами
        private int _id;
        private double _price;
        private double _weight;
        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }
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
        public Product(string title, double weight, double price)
        {
            Id++;
        }
        public override string ToString()
        {
            return $"{Title}: {Weight}, {Price}";
        }
    }
}
