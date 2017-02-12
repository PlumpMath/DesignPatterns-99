using System;

namespace AbstractFactory
{
    class ConcreteProductB2 : AbstractProductB
    {
        /// <summary>
        /// Конкретные классы продукты, наследуются от абстрактных классов продуктов. 
        /// Объекты-продукты конкретных классов предполагается создавать в телах фабричных 
        /// методов реализаций соответствующих фабрик.
        /// </summary>
        public override void Interact(AbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);
        }
    }
}
