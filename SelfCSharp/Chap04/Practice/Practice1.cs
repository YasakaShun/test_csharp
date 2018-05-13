using System;

namespace SelfCSharp.Chap04
{
    class Practice1
    {
        static void Main(string[] args)
        {
            var sum = 0;

            for (var i = 100; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                sum += i;
            }

            Console.WriteLine($"合計値は{sum}です。");
        }
    }
}
