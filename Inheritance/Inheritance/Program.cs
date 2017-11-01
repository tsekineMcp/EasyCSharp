using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            InheritsClass x = new InheritsClass();
        }
    }

    class BaseClass
    {
        public void ShowBase()
        {
            Console.WriteLine("I am a member of BaseClass.");
        }
    }

    class InheritsClass : BaseClass
    {
        public void Show()
        {
            ShowBase();
        }
    }
}

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            AlarmClock a = new AlarmClock();　
            Clock b = a;　// AlarmClock型の instanceを Clock型の変数bに代入
            AlarmClock c = (AlarmClock)b; // AlarmClock型にキャストして、AlarmClock型の変数cに代入
            Clock d = new AlarmClock(); // AlarmClock型のinstanceを生成した参照を Clock型の変数dに代入
            //AlarmClock e = new Clock(); これはコンパイルエラー
        }

    }

    class Clock
    {
        // omit implements
    }

    class AlarmClock : Clock
    {
        // omit implements
    }
}

namespace Override
{
    class Program
    {
        public override void Method()
        {
            Console.WriteLine("overrideで置き換えたメソッドで表示");
        }
    }
}