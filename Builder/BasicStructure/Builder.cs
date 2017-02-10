using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BasicStructure
{
    /// <summary>
    /// Предоставляет набор абстрактных методов (интерфейс) для создания объекта-продукта из частей и получения готового результата.
    /// </summary>
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }
}
