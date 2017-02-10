using AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Concrete.CocaCola;
using AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Concrete.Pepsi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.CocaCola_Pepsi_example
{
    class ClientUser
    {
        public static void Main()
        {
            Client client = null;

            client = new Client(new CocaColaFactory());
            client.Run();

            client = new Client(new PepsiFactory());
            client.Run();
        }
    }
}
