using System;
using System.Threading;

namespace _005_FM_LazyInit.Lazy3
{
    public sealed class BigObject
    {
        public BigObject()
        {
            // Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }

        public void Operation()
        {
            Console.WriteLine("Operation");
        }
    }
}
