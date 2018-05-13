using System;

namespace SelfCSharp.Chap04
{
    class ForComma
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 6; Console.WriteLine($"{i}番目のループです。"), i++) ;
        }
    }
}
