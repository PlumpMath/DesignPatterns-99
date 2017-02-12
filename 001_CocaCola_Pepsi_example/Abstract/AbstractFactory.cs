using System;

namespace _001_CocaCola_Pepsi_example
{
    abstract class AbstractFactory
    {
        public abstract AbstractWater CreateWater();
        public abstract AbstractBottle CreateBottle();
    }
}
