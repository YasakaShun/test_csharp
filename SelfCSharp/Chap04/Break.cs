using System;

namespace SelfCSharp.Chap04
{
    class Break
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;

            for (i = 1; i <= 100; i++)
            {
                sum += i;
                if (sum > 1000) { break; }
            }

            Console.WriteLine($"合計が1000を超えるのは、1～{i}を加算したときです。");
        }
    }
}
