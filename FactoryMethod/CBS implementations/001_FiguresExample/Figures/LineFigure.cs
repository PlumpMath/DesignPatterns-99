using FactoryMethod.CBS_implementations.FiguresExample.Manipulators;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod.CBS_implementations.FiguresExample.Figures
{
    class LineFigure : Figure
    {
        // Положение фигуры на форме.
        Point endPoint;
        Point startPoint;

        public LineFigure(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
            manipulator = CreateManipulator();
        }

        // Фабричный метод возвращающий манипулятор соответствующий данной фигуре.
        public override Manipulator CreateManipulator()
        {
            return new LineManipulator(startPoint, endPoint);
        }
    }
}
