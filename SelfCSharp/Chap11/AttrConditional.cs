#define DEBUG
using System;
using System.Diagnostics;

namespace SelfCSharp.Chap11
{
    class AttrConditional
    {
        [Conditional("DEBUG")]
        //[Conditional("TEST")]
        static void Message()
        {
            Console.WriteLine("デバッグ時にだけ表示します。");
        }

        static void Main(string[] args)
        {
            Message();
            Console.WriteLine("終了しました。");
        }
    }
}
