using System;

namespace GenericClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuple<string, int> a = new Tuple<string, int>();
            a.Value1 = "いち";
            a.Value2 = 1;

            Console.WriteLine(a.Value1);
            Console.WriteLine(a.Value2);

            Tuple<string, Tuple<string, int>> b = new Tuple<string, Tuple<string, int>>();
            b.Value1 = "に";
            b.Value2 = a;

            Console.WriteLine(b.Value1);
            Console.WriteLine(b.Value2.Value1);
            Console.WriteLine(b.Value2.Value2);

            Console.ReadLine();
        }
    }

    class Tuple<T1, T2>
    {
        public T1 Value1 { get; set; }
        public T2 Value2 { get; set; }
    }
}
