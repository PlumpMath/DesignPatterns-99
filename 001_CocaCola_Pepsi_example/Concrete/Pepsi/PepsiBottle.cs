using System;

namespace _001_CocaCola_Pepsi_example
{
    class PepsiBottle : AbstractBottle
    {
        public override void Interact(AbstractWater water)
        {
            Console.WriteLine(this + " interacts with " + water);
        }
    }
}
