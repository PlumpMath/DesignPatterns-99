using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    interface ICreator
    {
        T CreateProduct<T>();
    }
}
