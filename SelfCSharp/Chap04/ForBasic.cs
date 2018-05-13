using System;

namespace SelfCSharp.Chap04
{
    class ForBasic
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 6; i++)            
            {
                Console.WriteLine($"{i}番目のループです。");
            }
        }
    }
}
