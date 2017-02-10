using AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Concrete.Pepsi
{
    class PepsiFactory : Abstract.AbstractFactory
    {
        public override AbstractWater CreateWater()
        {
            return new PepsiWater();
        }

        public override AbstractBottle CreateBottle()
        {
            return new PepsiBottle();
        }
    }
}
