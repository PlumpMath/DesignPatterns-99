﻿using AbstractFactory.CBS_implementations.Flexible_example.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.CBS_implementations.Flexible_example
{
    class Client
    {
        dynamic factory;
        dynamic productA;
        dynamic productB;

        public Client(Factory factory)
        {
            // Получение полного квалифицированного имени фабрики в строковом представлении.
            string name = this.GetType().Namespace + "." + factory.ToString();

            // Динамическое создание соответствующей фабрики. 
            this.factory = Activator.CreateInstance(Type.GetType(name));

            // Порождение продуктов.
            this.productA = this.factory.Make(Product.ProductA);
            this.productB = this.factory.Make(Product.ProductB);
        }

        public void Run()
        {
            productB.Interact(productA);
        }
    }
}
