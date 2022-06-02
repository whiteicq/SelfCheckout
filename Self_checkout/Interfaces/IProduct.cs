using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_checkout
{
    interface IProduct
    {
        string Title { get; set; }
        double Price { get; set; }
        double Weight { get; set; }
    }
}
