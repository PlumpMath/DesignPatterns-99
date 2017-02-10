using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.BasicStructure
{
    /// <summary>
    /// Предоставляет интерфейс (абстрактные фабричные методы) для порождения продуктов. 
    /// В частных случаях класс Creator может предоставлять реализацию фабричных методов, 
    /// которые возвращают экземпляры продуктов (ConcreteProduct).
    /// </summary>
    abstract class Creator
    {
        Product product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }
}
