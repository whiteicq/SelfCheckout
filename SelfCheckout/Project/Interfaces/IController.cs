using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    interface IController
    {
        void AddProduct();
        // void RemoveProduct() --- делать отмену может только Админ
        void MakePurchase();
    }
}
