using System;

namespace SelfCSharp.Chap04
{
    class BreakNest
    {
        static void Main(string[] args)
        {
            for (var i = 1; i < 10; i++)
            {
                for (var j = 1; j < 10; j++)
                {
                    var result = i * j;
                    if (result > 40)
                    {
                        break;
                    }
                    Console.Write($"{result,2} ");
                }
                Console.WriteLine();
            }
        }
    }
}
