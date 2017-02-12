using System;

namespace _002_Flexible_example
{
    class ProductB2 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " взаимодействует с " + a.GetType().Name);
        }
    }
}
