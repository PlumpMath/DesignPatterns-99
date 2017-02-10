using System;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    class ProductA : IProduct
    {
        public ProductA()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
