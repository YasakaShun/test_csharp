using System;

namespace SelfCSharp.Chap05
{
    class PParse
    {
        static void Main(string[] args)
        {
            var str = "2018/02/15 13:17:23";
            var dt = DateTime.Parse(str);
            Console.WriteLine(dt.Day);
            Console.WriteLine(dt.Hour);
        }
    }
}
