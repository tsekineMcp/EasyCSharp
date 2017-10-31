using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            int s = a + b;
            string m = "{0}足す{1}は{2}です";
            Console.WriteLine(m, a, b, s);
            Console.ReadLine();
        }
    }
}
