using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class User 
    {
        public delegate void SendWarning(string message);
        public event SendWarning Warning;
        private double _cash;
        public double Cash
        {
            get
            {
                return _cash;
            }
            set
            {
                if (value >= 0)
                {
                    _cash = value;
                }
            }
        }
        public List<IProduct> ProductsBasket;
        public User(double cash, params Product[] products)
        {
            ProductsBasket = new List<IProduct>();
            foreach (var product in products)
            {
                ProductsBasket.Add(product);
            }
        }
        public User(double cash)
        {
            Cash = cash;
            ProductsBasket = new List<IProduct>();
        }
        public User() { }
        public void TakeProduct(IProduct product)
        {
            ProductsBasket.Add(product);
        }
        public void PutProduct(IProduct product)
        {
            ProductsBasket.Remove(product);
        }
        public void Pay(double sum)
        {
            if (Cash >= sum)
            {
                Cash -= sum;
            }
            else
            {
                Warning?.Invoke("Недостаточно средств");
            }
        }
    }
}
