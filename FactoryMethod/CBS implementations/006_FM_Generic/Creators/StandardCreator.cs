using System;

namespace FactoryMethod.CBS_implementations.FM_Generic
{
    class StandardCreator : ICreator
    {
        public T CreateProduct<T>()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
