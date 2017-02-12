using System;

namespace _001_CocaCola_Pepsi_example
{
    class PepsiFactory : AbstractFactory
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
