using System;

namespace _002_Flexible_example
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
