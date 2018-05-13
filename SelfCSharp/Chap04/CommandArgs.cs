using System;

namespace SelfCSharp.Chap04
{
    class CommandArgs
    {
        static void Main(string[] args)
        {
            foreach (var value in args)
            {
                Console.WriteLine($"こんにちは、{value}さん!");
            }
        }
    }
}
