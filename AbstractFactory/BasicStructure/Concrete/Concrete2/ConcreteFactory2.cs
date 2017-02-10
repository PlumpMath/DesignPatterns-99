using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.BasicStructure.Abstract;

namespace AbstractFactory.BasicStructure.Concrete.Concrete2
{
    /// <summary>
    /// Классы конкретных фабрик, наследуются от абстрактной фабрики и реализуют фабричные методы порождающие объекты-продукты.
    /// </summary>
    class ConcreteFactory2 : Abstract.AbstractFactory
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
