﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FactoryMethod.CBS_implementations.FiguresExample.Manipulators
{
    /// <summary>
    /// Абстрактний класс Manipulator который реализует взаимодействие и контролирует состояние
    /// обьекта-манипулятора. Манипуляторы представлены пользовательскими элементами управления.
    /// </summary>
    public abstract class Manipulator : Control
    {
        // Состояние манипулятора на форме. 
        public Point StartPoint { get; protected set; }
        public Point EndPoint { get; protected set; }

        // Задание базовых параметров контрола.
        public Manipulator()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Opaque, true);
            this.BackColor = Color.Transparent;
            this.DoubleBuffered = false;
        }

        // Задание параметров необходимых при создании элемента управления.
        protected override CreateParams CreateParams
        {
            get
            {
                const int WS_EX_TRANSPARENT = 0x00000020;
                CreateParams createParams = base.CreateParams;
                createParams.ExStyle |= WS_EX_TRANSPARENT;
                return createParams;
            }
        }
    }
}
