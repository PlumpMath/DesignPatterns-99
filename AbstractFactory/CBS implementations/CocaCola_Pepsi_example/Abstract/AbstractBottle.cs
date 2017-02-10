using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Abstract
{
    abstract class AbstractBottle
    {
        public abstract void Interact(AbstractWater water);
    }
}
