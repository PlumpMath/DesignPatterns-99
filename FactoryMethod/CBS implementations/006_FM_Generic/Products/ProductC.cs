using System;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    class ProductC : IProduct
    {
        public ProductC()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
