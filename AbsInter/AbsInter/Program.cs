using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsInter
{
    class Program
    {
        static void Main(string[] args)
        {
            Card card = new SpadeAce();
            card.Show();
        }
    }

    abstract class Card // 抽象クラス
    {
        abstract public string Mark { get; } // マークを表すプロパティが抽象化 abstract修飾
        abstract public string Number { get; } // 数を表すプロパティが抽象化 abstract修飾
        public void Show()
        {
            Console.Write(Mark);
            Console.Write(Number);
            Console.ReadLine();
        }
    }

    class SpadeAce : Card // 派生クラス
    {
        public override string Mark // Spadeのマークしか出せない。具体的な実装記述
        {
            get { return "Spade"; }
        }
        public override string Number // Aしか出せない。具体的な実装記述
        {
            get { return "A"; }
        }
    }
}
