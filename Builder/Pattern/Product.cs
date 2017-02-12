using System;
using System.Collections;

namespace Builder
{
    /// <summary>
    /// ѕредставл€ет собой класс сложно-конструируемого объекта-продукта и содержит в себе 
    /// набор методов дл€ сборки конечного результата-продукта из частей. 
    ///  ласс продукта может быть св€зан св€з€ми отношений агрегации, 
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
