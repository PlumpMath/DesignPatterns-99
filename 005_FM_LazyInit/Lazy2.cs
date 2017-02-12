using System;
using System.Threading;

namespace _005_FM_LazyInit.Lazy2
{
    public class BigObject
    {
        private static BigObject instance;

        private BigObject()
        {
            //Большая работа.
            Thread.Sleep(3000);
            Console.WriteLine("Экземпляр BigObject создан");
        }

        public override string ToString()
        {
            return "Обращение к BigObject";
        }

        // Метод возвращает экземпляр BigObject, при этом он создаёт его, если тот ещё не существует.
        public static BigObject GetInstance()
        {
            // Исключение возможности создания двух объектов в многопоточном приложении.
            if (instance == null)
            {
                lock (typeof(BigObject))
                {
                    if (instance == null)
                        instance = new BigObject();
                }
            }

            return instance;
        }
    }
}
