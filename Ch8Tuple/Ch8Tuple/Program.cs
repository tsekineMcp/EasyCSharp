using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch8Tuple
{
    class Program
    {
        static void Main(string[] args)
        {
            (int, int) a = (1, 2);
            Console.WriteLine(a.Item1);
            Console.WriteLine(a.Item2);

            (int x, int y) b = (1, 2);
            Console.WriteLine(b.x);
            Console.WriteLine(b.y);

            var c = (x: 1, y: 2);
            Console.WriteLine(c.x);
            Console.WriteLine(c.y);
        }
    }
}
