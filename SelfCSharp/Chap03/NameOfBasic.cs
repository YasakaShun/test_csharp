using System;

namespace SelfCSharp.Chap03
{
    class NameOfBasic
    {
        int data = 1;

        static void Main(string[] args)
        {
            Console.WriteLine(nameof(NameOfBasic));
            Console.WriteLine(nameof(data));
        }
    }
}
