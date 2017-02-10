using AbstractFactory.CBS_implementations.Flexible_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.Flexible_example.Concrete.Concrete1
{
    class ProductB1 : IAbstractProductB
    {
        public void Interact(IAbstractProductA a)
        {
            Console.WriteLine(this.GetType().Name + " взаимодействует с " + a.GetType().Name);
        }
    }
}
