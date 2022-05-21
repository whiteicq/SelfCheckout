using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{ // мб сделать класс Штрих-кода где будет реальная расшифровка кода по всем правилам и реально будет считать инфу про товар
    interface IProduct // общий интерфейс для любого товара в магазине
    {
        double Weight { get; }
        double Price { get; set; }
        string Title { get; }
        int Id { get; }


    }
}
