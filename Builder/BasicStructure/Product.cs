using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.BasicStructure
{
    /// <summary>
    /// Представляет собой класс сложно-конструируемого объекта-продукта и содержит в себе 
    /// набор методов для сборки конечного результата-продукта из частей. 
    /// Класс продукта может быть связан связями отношений агрегации, 
    /// с классами которые описывают составные части создаваемого продукта.
    /// </summary>
    class Product
    {
        ArrayList parts = new ArrayList();

        public void Add(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
