using System;

namespace AbsInter
{
    class Program
    {
        static void Main (string[] args)
        {
            ICalculator[] a = {
                new A(), new B(), new C()
            };

            foreach(ICalculator calc in a)
            {
                int r = calc.Execute(3, 2);
                Console.WriteLine(r);
            }
        }
    }

    interface ICalculator
    {
        int Execute(int a, int b);
    }

    class A : ICalculator
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }

    class B: ICalculator
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }

    class C: ICalculator
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}