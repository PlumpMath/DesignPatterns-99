using FactoryMethod.CBS_implementations.FM_with_argument.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_with_argument.Creators
{
    class MyCreator : Creator
    {
        public override Product Create(ProductType productType)
        {
            if (productType == ProductType.THEIRS)
                return new TheirProduct();

            return base.Create(productType);
        }
    }
}
