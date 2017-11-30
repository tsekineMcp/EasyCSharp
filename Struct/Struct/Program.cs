using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            EchoClass ca = new EchoClass();
            EchoClass cb = ca;
            ca.Value = 1;
            Console.WriteLine(ca.Value);
            Console.WriteLine(cb.Value);

            EchoStruct sa = new EchoStruct();
            EchoStruct sb = sa;
            sa.Value      = 2;
            Console.WriteLine(sa.Value);
            Console.WriteLine(sb.Value);
            Console.ReadLine();
        }
    }

    public class EchoClass
    {
        public int Value {get ; set ;}
    }

    public class EchoStruct
    {
        public int Value {get ; set ;}
    }
}
