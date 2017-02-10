using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BasicStructure
{
    /// <summary>
    /// Конструирует объект-продукт собирая его из частей, реализуя интерфейс, 
    /// заданный абстрактным строителем (Builder). Предоставляет доступ к готовому 
    /// продукту (возвращает продукт клиенту или в частном случае директору (Director)).
    /// </summary>
    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
