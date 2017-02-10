using FactoryMethod.CBS_implementations.FiguresExample.Manipulators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FiguresExample.Figures
{
    /// <summary>
    /// Абстрактный класс Figure предоставляет фабричный метод CreateManipulator(), 
    /// позволяющий создать манипулятор соответствующий определенной фигуре. 
    /// </summary>
    // 
    public abstract class Figure
    {
        public Manipulator manipulator { get; set; }
        public abstract Manipulator CreateManipulator();
    }
}
