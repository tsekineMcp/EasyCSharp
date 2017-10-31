using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSample
{
    // Diceをふって出た目をチェックするというプログラムを考える
    class Dice
    {
        private Random _rnd;　// フィールド
        public Dice() // コンストラクタ
        {
            int t = Environment.TickCount;
            while (t == Environment.TickCount) {}
            _rnd = new Random();
            _value = 1;
        }

        private int _value; // フィールド
        public int Value
        {
            // 上面の値
            get
            {
                return _value;
            }
        }

        public void Throw() // ダイスを振る動作
        {
            _value = _rnd.Next(6) + 1; // _valueがさいころの上面
            // アクセス修飾子がprivateの変数は、アンスコをつけるのが慣習
            // これはPythonの時も同じでした
        }
    }
}
