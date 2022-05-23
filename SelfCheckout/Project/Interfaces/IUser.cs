using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    interface IUser
    {
        double Money { get; set; }
        void MakePurchase(double sum);
    }
}
