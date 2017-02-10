using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CBS_implementations.HouseBuilder
{
    class Client
    {
        public static void Main()
        {
            Builder builder = new ConcreteBuilder();
            Foreman foreman = new Foreman(builder);
            foreman.Construct();

            House house = builder.GetResult();

            // Delay.
            Console.ReadKey();
        }
    }
}
