using System;

namespace Builder
{
    /// <summary>
    /// ѕользу€сь интерфейсом строител€ (Builder), директор дает строителю указание построить продукт.
    /// </summary>
    class Director
    {
        Builder builder;

        public Director(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            builder.BuildPartA();
            builder.BuildPartB();
            builder.BuildPartC();
        }
    }
}
