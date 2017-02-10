using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FM_work_in_constructor_example.Second
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

    // Создатели --------------------------------------------------------

    abstract class Creator
    {
        protected Product product = null;

        public Creator()
        {
            product = FactoryMethod();
            Console.WriteLine(product.GetType().Name + " in Creator class.");
        }

        // Виртуальный фабричный метод базового класса вызовется 
        // при его замещении в производном классе.
        public virtual Product FactoryMethod()
        {
            return new DefaultProduct();
        }
    }

    class ConcreteCreator : Creator
    {
        public ConcreteCreator()
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

    class Client
    {
        static void Main()
        {
            Creator creator = new ConcreteCreator();

            // В этом примере на экран будет выведено: 
            // DefaultProduct  -  работа конструктора базового класса
            // SpecialProduct  -  работа конструктора производного класса

            // Delay.
            Console.ReadKey();
        }
    }
}