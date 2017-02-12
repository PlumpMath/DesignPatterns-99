using System;

namespace Builder
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
