using System;

namespace AbstractFactory
{
    /// <summary>
    /// Абстрактные классы продуктов предоставляют абстрактные интерфейсы взаимодействия с объектами-продуктами производных конкретных классов.
    /// </summary>
    abstract class AbstractProductB
    {
        public abstract void Interact(AbstractProductA a);
    }
}
