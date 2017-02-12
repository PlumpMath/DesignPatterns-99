using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализует интерфейс предоставляемый базовым классом Product.
    /// </summary>
    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
