using System;

namespace SelfCSharp.Chap09
{
    class OverflowUnchecked
    {
        static void Main(string[] args)
        {
            var i = int.MaxValue;
            Console.WriteLine(unchecked(++i));
        }
    }
}
