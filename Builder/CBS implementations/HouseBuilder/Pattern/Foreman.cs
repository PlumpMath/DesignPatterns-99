    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.CBS_implementations.HouseBuilder
{
    class Foreman
    {
        Builder builder;

        public Foreman(Builder builder)
        {
            this.builder = builder;
        }

        public void Construct()
        {
            // Требуется дать команды строителю в правильном порядке.
            // Сначала строить подвал, потом этаж и в последнюю очередь крышу.
            builder.BuildBasement();
            builder.BuildStorey();
            builder.BuildRoof();
        }
    }
}
