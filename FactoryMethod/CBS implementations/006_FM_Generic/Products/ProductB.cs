using System;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    class ProductB : IProduct
    {
        public ProductB()
        {
            Console.WriteLine(this.GetType().Name);
        }
    }
}
