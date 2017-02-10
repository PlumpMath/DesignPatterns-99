using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.BasicStructure
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
