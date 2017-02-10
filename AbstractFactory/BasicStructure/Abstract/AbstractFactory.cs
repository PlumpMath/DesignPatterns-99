using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.BasicStructure.Abstract
{
    /// <summary>
    /// Класс AbstractFactory содержит в себе набор абстрактных фабричных методов. 
    /// Эти абстрактные методы описывают интерфейс взаимодействия с объектами-фабриками и имеют возвращаемые значения типа абстрактных-продуктов, 
    /// тем самым предоставляя возможность применять технику абстрагирования процесса инстанцирования. 
    /// Класс AbstractFactory не занимается созданием объектов-продуктов, 
    /// ответственность за их создание ложится на производный класс ConcreteFactory.
    /// </summary>
    abstract class AbstractFactory
    {
        public abstract AbstractProductA CreateProductA();
        public abstract AbstractProductB CreateProductB();
    }
}
