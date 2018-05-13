using System;

namespace SelfCSharp.Chap04
{
    class WhileOmit
    {
        static void Main(string[] args)
        {
            var i = 1;
            while (i < 6)
                Console.WriteLine(i++);
                Console.WriteLine("--------");
        }
    }
}
