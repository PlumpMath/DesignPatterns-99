using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Отложенная (ленивая) инициализация (англ. Lazy initialization). 
    Приём в программировании, когда некоторая ресурсоёмкая операция (создание объекта, вычисление значения) 
    выполняется непосредственно перед тем, как будет использован её результат. 
    Таким образом, инициализация выполняется «по требованию», а не заблаговременно. 
    Аналогичная идея находит применение в самых разных областях: 
    например, компиляция «на лету» и логистическая концепция «Точно в срок». 
    
    Частный случай ленивой инициализации — создание объекта в момент обращения к нему — 
    является одним из порождающих шаблонов проектирования. 
    Как правило, он используется в сочетании с такими шаблонами как Фабричный метод, Одиночка и Заместитель.
*/

namespace _005_FM_LazyInit
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1)
            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            Console.WriteLine(Lazy1.BigObject.Instance);

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            Console.WriteLine(Lazy1.BigObject.Instance);

            // Delay.
            Console.ReadKey();



            //2)
            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            Console.WriteLine(Lazy2.BigObject.GetInstance());

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            Console.WriteLine(Lazy2.BigObject.GetInstance());

            // Delay.
            Console.ReadKey();



            //3)
            System.Lazy<Lazy3.BigObject> lazy = new Lazy<Lazy3.BigObject>();

            Console.WriteLine("Первое обращение к экземпляру BigObject...");
            // Создание объекта происходит только при этом обращении к объекту.
            lazy.Value.Operation();

            Console.WriteLine("Второе обращение к экземпляру BigObject...");
            lazy.Value.Operation();

            // Delay.
            Console.ReadKey();
        }
    }
}
