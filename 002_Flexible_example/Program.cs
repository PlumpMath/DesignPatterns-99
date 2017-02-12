using System;

namespace _002_Flexible_example
{
    class Program
    {
        public static void Main()
        {
            Client client = new Client(Factory.ConcreteFactory1);
            client.Run();

            client = new Client(Factory.ConcreteFactory2);
            client.Run();

            // Задержка.
            Console.ReadKey();
        }
    }
}
