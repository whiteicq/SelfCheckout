using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    interface IStoreAssortment
    {
        void AddProduct(string title, double price, double weight);
        void DeleteProduct(string title, double price);
    }
}
