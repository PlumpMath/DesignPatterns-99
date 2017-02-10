using AbstractFactory.CBS_implementations.CocaCola_Pepsi_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.CocaCola_Pepsi_example
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        // Клиент не знает, с чем он работает. Конкретная фабрика передается в конструкторе.
        public Client(Abstract.AbstractFactory factory)
        {
            // Абстрагирование процесса инстанцирования.
            water = factory.CreateWater();
            bottle = factory.CreateBottle();
        }

        public void Run()
        {
            // Абстрагирование вариантов использования.
            bottle.Interact(water);
        }
    }
}
