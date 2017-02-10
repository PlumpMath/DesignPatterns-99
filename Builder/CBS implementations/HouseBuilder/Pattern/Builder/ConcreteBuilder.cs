using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CBS_implementations.HouseBuilder
{
    class ConcreteBuilder : Builder
    {
        House house = new House();

        public override void BuildBasement()
        {
            house.Add(new Basement());
        }

        public override void BuildStorey()
        {
            house.Add(new Storey());
        }

        public override void BuildRoof()
        {
            house.Add(new Roof());
        }

        public override House GetResult()
        {
            return house;
        }
    }
}
