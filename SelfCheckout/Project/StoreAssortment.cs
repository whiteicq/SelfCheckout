using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCheckout
{
    class StoreAssortment // будет как класс-контейнер опер. с БД
    {
        private ApplicationContext DB = new ApplicationContext();
        private static StoreAssortment isInstance; 
        private StoreAssortment()
        {
            List<Product> BaseAssortment = new List<Product>
            {
            new Product { Title = "Хлеб", Weight = 100, Price = 200 },
            new Product { Title = "Колбаса", Weight = 50, Price = 375 },
            new Product { Title = "Курица", Weight = 1000, Price = 500 },
            new Product { Title = "Макароны", Weight = 250, Price = 90 },
            new Product { Title = "Яблоко", Weight = 1000, Price = 75 }
            };
            foreach(var product in BaseAssortment)
            {
                DB.Products.Add(product);
            }
            DB.SaveChanges();
        }

        public static StoreAssortment CreateStoreAssortment()
        {
            if(isInstance == null)
            {
                return new StoreAssortment();
            }
            return isInstance;
        }

        public void AddProduct(string title, double price, double weight)
        {
            using (ApplicationContext bd = new ApplicationContext())
            {
                DB.Products.Add(new Product(title, price, weight));
                DB.SaveChanges();
            }
        }

        
    }
}
