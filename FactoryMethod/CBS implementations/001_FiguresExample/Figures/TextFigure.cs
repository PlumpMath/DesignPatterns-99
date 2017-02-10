using FactoryMethod.CBS_implementations.FiguresExample.Manipulators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FiguresExample.Figures
{
    class TextFigure : Figure
    {
        // Положение фигуры на форме.
        Point startPoint;

        public TextFigure(Point startPoint)
        {
            this.startPoint = startPoint;
            manipulator = CreateManipulator();
        }

        // Фабричный метод возвращающий манипулятор соответствующий данной фигуре.
        public override Manipulator CreateManipulator()
        {
            return new TextManipulator(startPoint);
        }
    }
}
