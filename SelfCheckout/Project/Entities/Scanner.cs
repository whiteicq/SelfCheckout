using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SelfCheckout
{ 
    class Scanner
    {
        ApplicationContext BD;
        // Кладется продукт и тем самым заносится в БД
        public Scanner() { }
        public void ScanProduct(Product product)
        {
            BD.Products.Add(product);
        } // переименовать ApplicationContext в BD;
    }
}
