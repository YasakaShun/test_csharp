using System;

namespace SelfCSharp.Chap09
{
    class EnumString {
        static void Main(string[] args)
        {
            var s = Season.Spring;
            Console.WriteLine(s);
            Console.WriteLine(s.ToString());
            Console.WriteLine(s.ToString("D"));
            Console.WriteLine(s.ToString("X"));
        }
    }
}
