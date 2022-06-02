using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class User // Нужен класс Кассы со Сканнером, Весами, Контроллером и через Кассу будет опперировать Юзер
    {
        public double Cash { get; set; }
        public Stack<IProduct> ProductsBasket;
        public User(params IProduct[] products)
        {
            foreach (var product in products)
            {
                ProductsBasket.Push(product);
            }
        }
        public User() { }
        public void Pay()
        {
            
        }
    }
}
