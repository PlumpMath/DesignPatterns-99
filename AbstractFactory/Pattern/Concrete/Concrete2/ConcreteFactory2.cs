using System;

namespace AbstractFactory
{
    /// <summary>
    /// Классы конкретных фабрик, наследуются от абстрактной фабрики и реализуют фабричные методы порождающие объекты-продукты.
    /// </summary>
    class ConcreteFactory2 : AbstractFactory
    {
        public override AbstractProductA CreateProductA()
        {
            return new ConcreteProductA2();
        }
        public override AbstractProductB CreateProductB()
        {
            return new ConcreteProductB2();
        }
    }
}
