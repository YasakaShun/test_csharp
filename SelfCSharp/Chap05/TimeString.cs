using System;

namespace SelfCSharp.Chap05
{
    class TimeString
    {
        static void Main(string[] args)
        {
            var dt = new DateTime(2018, 02, 15, 13, 17, 23);
            Console.WriteLine(dt.ToString("f"));
            Console.WriteLine(dt.ToString("yy/MM/dd（ddd）tt hh:mm:ss"));
        }
    }
}
