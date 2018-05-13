#define DEBUG

using System;

namespace SelfCSharp.Chap04
{
    class PreIf
    {
        static void Main(string[] args)
        {
            //...中略...
        #if DEBUG
            Console.WriteLine("デバッグ時にだけ表示します。");
        #endif
        }
    }
}
