using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class Scales // на Весы кладется товар после скана для задания веса и последующего его сравнения во избежание обмана покупателем
    {
        ApplicationContext bd;
        private double Weight;
        private List<Product> products;
        public Scales() 
        {
            products = 
        }
        public bool CompareWeights()
        {
            return false;
        }
    }
}
