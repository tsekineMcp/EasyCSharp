using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 2;
            Console.WriteLine("a={0}, b={1}", a, b);
            Swap<int>(ref a, ref b); // invoking Swap against int
            Console.WriteLine("a={0}, b={1}", a, b);

            string c = "右";
            string d = "左";

            Console.WriteLine("c={0}, d={1}", c, d);
            Swap(ref c, ref d); // invoking Swap, but not declare a data type, in this case, C# guess the type.
            Console.WriteLine("c={0}, d={1}", c, d);

            Console.ReadLine();
        }

        static void Swap<T>(ref T v1, ref T v2)
        {
            T b = v1;
            v1 = v2;
            v2 = b;
        }
    }

}
