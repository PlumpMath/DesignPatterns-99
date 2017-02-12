using System;

namespace _001_CocaCola_Pepsi_example
{
    class Client
    {
        private AbstractWater water;
        private AbstractBottle bottle;

        // Клиент не знает, с чем он работает. Конкретная фабрика передается в конструкторе.
        public Client(AbstractFactory factory)
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
