using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.ServiceLocator.Locator
{
    interface IServiceLocator
    {
        T GetService<T>();
    }
}
