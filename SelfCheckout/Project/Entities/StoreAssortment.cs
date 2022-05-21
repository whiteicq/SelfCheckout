using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class StoreAssortment
    {
        private static StoreAssortment isInstance;
        private StoreAssortment() { }
        public static StoreAssortment CreateAssortment()
        {
            if(isInstance is null)
            {
                return new StoreAssortment();
            }
            return isInstance;
        }
    }
}
