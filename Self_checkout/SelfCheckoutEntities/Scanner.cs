using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    class Scanner
    {
        public Scanner() { }
        public double ScanProducts(List<IProduct> products)
        {
            double sum = 0;
            foreach (var product in products)
            {
                sum += product.Price;
            }
            return sum;
        }

    }
}
