using System;

namespace SelfCSharp.Chap05
{
    class TimeSub
    {
        static void Main(string[] args)
        {
            var dt1 = new DateTime(2018, 02, 15, 13, 17, 23);
            var dt2 = new DateTime(2009, 08, 05, 05, 15, 10);
            var sub = dt1.Subtract(dt2);
            Console.WriteLine(sub.ToString("c"));
            Console.WriteLine(sub.ToString(@"d\.h\:m\:s"));
        }
    }
}
