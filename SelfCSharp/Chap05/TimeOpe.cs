using System;

namespace SelfCSharp.Chap05
{
    class TimeOpe
    {
        static void Main(string[] args)
        {
            var dt1 = new DateTime(2018, 02, 15, 13, 17, 23);
            var dt2 = new DateTime(2009, 08, 05, 05, 15, 10);
            var span = new TimeSpan(3, 15, 30, 0);
            Console.WriteLine(dt1 + span);
            Console.WriteLine(dt1 - span);
            Console.WriteLine(dt1 == dt2);
            Console.WriteLine(dt1 >= dt2);
        }
    }
}
