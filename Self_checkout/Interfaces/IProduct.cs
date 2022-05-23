using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    interface IProduct // общий интерфейс для любого товара в магазине
    {
        double Weight { get; }
        double Price { get; set; }
        string Title { get; }
    }
}