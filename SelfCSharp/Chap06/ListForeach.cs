using System;
using System.Collections.Generic;

namespace SelfCSharp.Chap06
{
    class ListForeach
    {
        static void Main(string[] args)
        {
            var list = new List<string>
            {
                "バラ",
                "ひまわり",
                "あざみ"
            };

            foreach (var s in list)
            {
                Console.WriteLine(s);
            }

            //var enu = list.GetEnumerator();
            //while (enu.MoveNext())
            //{
            //    string str = enu.Current;
            //    Console.WriteLine(str);
            //}


        }
    }
}
