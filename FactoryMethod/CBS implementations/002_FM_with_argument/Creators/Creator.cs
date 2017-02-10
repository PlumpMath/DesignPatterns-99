using FactoryMethod.CBS_implementations.FM_with_argument.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_with_argument.Creators
{
    class Creator
    {
        public virtual Product Create(ProductType productType)
        {
            if (productType == ProductType.MINE)
                return new MyProduct();
            else if (productType == ProductType.YOURS)
                return new YourProduct();
            else
                return null;
        }
    }
}
