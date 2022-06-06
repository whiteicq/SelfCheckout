using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class SelfCheckout
    {
        private static SelfCheckout IsIstance;
        public Scanner scanner;
        public double CommonSum { get; set; }
        private SelfCheckout()
        {
            scanner = new Scanner();
        }

        public static SelfCheckout CreateSelfCheckout()
        {
            if (IsIstance is null)
            {
                IsIstance = new SelfCheckout();
            }
            return IsIstance;
        }
        
    }
}
