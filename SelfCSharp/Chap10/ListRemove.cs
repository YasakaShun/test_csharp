using System;
using System.Collections.Generic;

namespace SelfCSharp.Chap10
{
    class ListRemove
    {
        static void Main(string[] args)
        {
            var list = new List<int> { 1, -15, 30, 60, -50, 40 };
            list.RemoveAll(v => v < 0);
            foreach (var n in list)
            {
                Console.WriteLine(n);
            }
        }
    }
}
