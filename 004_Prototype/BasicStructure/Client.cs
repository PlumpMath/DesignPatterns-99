﻿
namespace Prototype.BasicStructure
{
    /// <summary>
    /// Клиент создает экземпляр прототипа. Вызывает на прототипе метод клонирования.
    /// </summary>
    class Client
    {
        static void Main()
        {
            Prototype prototype = null;
            Prototype original = null;

            prototype = new ConcretePrototype1(1);
            original = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            original = prototype.Clone();
        }
    }
}
