using System;

namespace AbstractFactory
{
    /// <summary>
    /// Классы конкретных фабрик, наследуются от абстрактной фабрики и реализуют фабричные методы порождающие объекты-продукты.
    /// </summary>
    class ConcreteFactory1 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA1();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB1();
        }
    }
}
