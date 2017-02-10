using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.BasicStructure
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
