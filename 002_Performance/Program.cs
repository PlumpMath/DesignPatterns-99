using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _002_Performance
{
    class ClassMemberwiseClone : ICloneable
    {
        int a, b;

        public ClassMemberwiseClone()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }

    class ClassConstructor : ICloneable
    {
        int a, b;

        public ClassConstructor()
        {
            Thread.Sleep(1000);
            a = new Random().Next(1, 100);
            Thread.Sleep(1000);
            b = new Random().Next(1, 100);
        }

        public object Clone()
        {
            return new ClassConstructor();
        }
    }

    class Program
    {
        static void Main()
        {
            // 1)
            Console.WriteLine("\tMemberwiseClone:");
            Stopwatch timer = new Stopwatch();

            // Замер времени построения оригинала.
            timer.Start();
            ClassMemberwiseClone originalMemberwiseClone = new ClassMemberwiseClone();
            timer.Stop();
            Console.WriteLine("original построен за {0}", timer.Elapsed.Ticks);

            timer.Reset();

            // Замер времени построения клона.
            timer.Start();
            ClassMemberwiseClone cloneMemberwiseClone = originalMemberwiseClone.Clone() as ClassMemberwiseClone;
            timer.Stop();
            Console.WriteLine("clone    построен за {0}", timer.Elapsed.Ticks);

            // Delay.
            Console.ReadKey();



            //2)
            Console.WriteLine("\tConstructor:");
            timer = new Stopwatch();

            // Замер времени построения оригинала.
            timer.Start();
            ClassConstructor originalConstructor = new ClassConstructor();
            timer.Stop();
            Console.WriteLine("original построен за {0}", timer.Elapsed.Ticks);

            timer.Reset();

            // Замер времени построения клона.
            timer.Start();
            ClassConstructor cloneConstructor = originalConstructor.Clone() as ClassConstructor;
            timer.Stop();
            Console.WriteLine("clone    построен за {0}", timer.Elapsed.Ticks);

            // Delay.
            Console.ReadKey();
        }
    }
}
