using FactoryMethod.CBS_implementations.ServiceLocator.Locator;
using FactoryMethod.CBS_implementations.ServiceLocator.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.ServiceLocator
{
    class Client
    {
        static void Main()
        {
            IServiceLocator serviceLocator = new Locator.ServiceLocator();

            IServiceA serviceA = serviceLocator.GetService<IServiceA>();
            IServiceB serviceB = serviceLocator.GetService<IServiceB>();
            IServiceC serviceC = serviceLocator.GetService<IServiceC>();

            // Задержка.
            Console.ReadKey();
        }
    }
}
