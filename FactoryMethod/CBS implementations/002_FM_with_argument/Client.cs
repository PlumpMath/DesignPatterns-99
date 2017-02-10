using FactoryMethod.CBS_implementations.FM_with_argument.Creators;
using FactoryMethod.CBS_implementations.FM_with_argument.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_with_argument
{
    class Client
    {
        static void Main()
        {
            Creator creator = new MyCreator();
            Product product = creator.Create(ProductType.THEIRS);
        }
    }
}
