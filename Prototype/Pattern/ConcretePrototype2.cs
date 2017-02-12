using System;

namespace Prototype
{
    /// <summary>
    /// Реализует операцию клонирования себя.
    /// </summary>
    class ConcretePrototype2 : Prototype
    {
        public ConcretePrototype2(int id)
            : base(id)
        {
        }

        public override Prototype Clone()
        {
            return new ConcretePrototype2(Id);
        }
    }
}
