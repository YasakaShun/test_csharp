using System;

namespace SelfCSharp.Chap04
{
    class PContinue
    {
        static void Main(string[] args)
        {
            var i = 0;
            var sum = 0;

            while (i <= 100)
            {
                i++;
                if (i % 2 != 0)
                {
                    continue;
                }
                sum += i;
            }

            Console.WriteLine($"合計値は{sum}です。");
        }
    }
}
