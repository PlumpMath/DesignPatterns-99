using System;
using System.Threading;

namespace _005_FM_LazyInit.Lazy1
{
    public class LazyInitialization<T> where T : new()
    {
        protected LazyInitialization() { }

        private static T instance;

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (typeof(T))
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }
                return instance;
            }
        }
    }

    public sealed class BigObject : LazyInitialization<BigObject>
    {
        public BigObject()
        {
            // Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }
    }
}
