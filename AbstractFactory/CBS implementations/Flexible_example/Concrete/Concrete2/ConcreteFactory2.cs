using AbstractFactory.CBS_implementations.Flexible_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.Flexible_example.Concrete.Concrete2
{
    class ConcreteFactory2 : IAbstractFactory
    {
        dynamic product;

        public dynamic Make(Product product)
        {
            // Получение полного квалифицированного имени продукта семейства - 2.
            string name = this.GetType().Namespace + "." + product.ToString() + "2";

            // Динамическое создание продукта семейства - 2. 
            this.product = Activator.CreateInstance(Type.GetType(name));

            return this.product;
        }
    }
}
