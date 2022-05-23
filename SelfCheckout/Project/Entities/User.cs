using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class User: IUser
    {
        private double _money;
        public double Money 
        { 
            get
            {
                return _money;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception();
                }
                else
                {
                    _money = value;
                }
            }
        }
        public User(double money)
        {
            Money = money;
        }
        public void MakePurchase(double sum)
        {
            Money -= sum;
        }
    }
}
