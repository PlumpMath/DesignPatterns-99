using System;

namespace FactoryMethod
{
    /// <summary>
    /// Реализует интерфейс (фабричные методы) предоставляемый базовым классом Creator.
    /// </summary>
    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
