using AbstractFactory.CBS_implementations.Flexible_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.Flexible_example.Concrete.Concrete1
{
    class ConcreteFactory1 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            // Получение полного квалифицированного имени продукта семейства - 1.
            string name = this.GetType().Namespace + "." + product.ToString() + "1";

            // Динамическое создание продукта семейства - 1. 
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
