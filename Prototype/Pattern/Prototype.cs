using System;

namespace Prototype
{
    /// <summary>
    /// Предоставляет интерфейс для клонирования себя.
    /// </summary>
    abstract class Prototype
    {
        public int Id { get; private set; }

        public Prototype(int id)
        {
            this.Id = id;
        }

        public abstract Prototype Clone();
    }
}
