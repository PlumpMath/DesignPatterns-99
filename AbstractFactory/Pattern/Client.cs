using System;

namespace AbstractFactory
{
    /// <summary>
    /// Класс Client создает и использует продукты, пользуясь исключительно интерфейсом абстрактных классов 
    /// AbstractFactory и AbstractProduct и ему ничего не известно о конкретных классах фабрик и продуктов.
    /// </summary>
    class Client
    {
        private AbstractProductA abstractProductA = null;
        private AbstractProductB abstractProductB = null;

        public Client(AbstractFactory factory)
        {
            this.abstractProductA = factory.CreateProductA();
            this.abstractProductB = factory.CreateProductB();
        }

        public void Run()
        {
            this.abstractProductB.Interact(this.abstractProductA);
        }
    }
}
