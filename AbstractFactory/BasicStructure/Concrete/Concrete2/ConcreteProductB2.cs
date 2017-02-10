using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasicStructure.Abstract;

namespace AbstractFactory.BasicStructure.Concrete.Concrete2
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
