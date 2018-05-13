using System;
using System.Collections.Generic;

namespace dokushu
{
    class Practice6_2
    {
        public static void Exec1()
        {
            var list = new List<int> { 10, 15, 30, 60 };
            list[3] = 75;
            list.Remove(15);
            list.Insert(2, 108);

            foreach (var v in list)
            {
                Console.WriteLine(v);
            }
        }
    }
}