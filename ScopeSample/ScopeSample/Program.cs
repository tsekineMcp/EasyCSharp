using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ScopeSample
{
    class Program
    {
        private static int a = 1;
        static void Main(string[] args)
        {
            int b = 2;
            {
                //　ステートメントブロック
                //　ブロックがネストしている場合、親のブロックの変数などは使える
                int s = a + b;
                Console.WriteLine(s);
            }

            //　たとえば、ここでsを呼び出すことはできない（内側のブロックでライフサイクルが終わっている）

            Console.ReadLine();
        }
    }
}
