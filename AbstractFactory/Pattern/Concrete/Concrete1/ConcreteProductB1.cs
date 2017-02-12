using System;

namespace AbstractFactory
{
    /// <summary>
    /// Конкретные классы продукты, наследуются от абстрактных классов продуктов. 
    /// Объекты-продукты конкретных классов предполагается создавать в телах фабричных 
    /// методов реализаций соответствующих фабрик.
    /// </summary>
    class ConcreteProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);
        }
    }
}
