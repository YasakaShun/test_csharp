using System;

namespace SelfCSharp.Chap04
{
    class Practice3
    {
        static void Main(string[] args)
        {
            foreach (var tmp in args)
            {
                int i = Int32.Parse(tmp);
                Console.WriteLine(i * 1.5);
            }

        }
    }
}
