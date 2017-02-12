using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_FM_in_Constructor
{
    // Продукты ---------------------------------------------------------

    abstract class Product
    {
    }

    class DefaultProduct : Product
    {
    }

    class SpecialProduct : Product
    {
    }


    // Абстрактный создатель --------------------------------------------------------
    abstract class Creator
    {
        protected Product product = null;

        public Creator()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name + " in Creator class.");
        }

        // Виртуальный фабричный метод базового класса ВЫЗОВЕТСЯ 
        // при его ЗАМЕЩЕНИИ в производном классе.
        // Виртуальный фабричный метод базового класса НЕ ВЫЗОВЕТСЯ 
        // при его ПЕРЕОПРЕДЕЛЕНИИ в производном классе.
        public virtual Product FactoryMethod()
        {
            return new DefaultProduct();
        }
    }

    // Конкретный создатель, первый вариант --------------------------------------------------------
    class ConcreteCreator1 : Creator
    {
        public ConcreteCreator1()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name + " in ConcreteCreator class.");
        }

        // Переопределение виртуального метода.
        public override Product FactoryMethod()// override
        {
            return new SpecialProduct();
        }
    }

    // Конкретный создатель, второй вариант --------------------------------------------------------
    class ConcreteCreator2 : Creator
    {
        public ConcreteCreator2()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name + " in ConcreteCreator class.");
        }

        // Замещение/перекрытие виртуального метода.
        public new Product FactoryMethod()// new - перекрытие
        {
            return new SpecialProduct();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // 1)
            Creator creator1 = new ConcreteCreator1();

            // В этом примере на экран будет выведено: 
            // SpecialProduct  -  работа конструктора базового класса
            // SpecialProduct  -  работа конструктора производного класса

            // Delay.
            Console.ReadKey();
            
            //2)
            Creator creator2 = new ConcreteCreator2();

            // В этом примере на экран будет выведено: 
            // DefaultProduct  -  работа конструктора базового класса
            // SpecialProduct  -  работа конструктора производного класса

            // Delay.
            Console.ReadKey();
        }
    }
}
