using System;

namespace SelfCSharp.Chap04
{
    class WhileBasic
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i < 6)
            {
                Console.WriteLine($"{i}番目のループです。");
                i++;
            }
        }
    }
}
