using System;

namespace SelfCSharp.Chap05
{
    class StrFor
    {
        static void Main(string[] args)
        {
            var str = "ウイングス";
            foreach (var s in str)
            {
                Console.WriteLine(s);                 
            }
        }
    }
}
