using System;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    class Client
    {
        static void Main()
        {
            ICreator creator = new StandardCreator();

            IProduct productA = creator.CreateProduct<ProductA>();
            IProduct productB = creator.CreateProduct<ProductB>();
            IProduct productC = creator.CreateProduct<ProductC>();

            // Задержка.
            Console.ReadKey();
        }
    }
}
