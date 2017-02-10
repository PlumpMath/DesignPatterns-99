using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_with_argument.Products
{
    abstract class Product
    {
        public Product()
        {
            System.Console.WriteLine(this.GetType().Name);
        }
    }
}
