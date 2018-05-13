using System;
using System.Globalization;

namespace SelfCSharp.Chap05
{
    class TimeParse
    {
        static void Main(string[] args)
        {
            var dt1 = "2018/02/15 13:17:23";
            Console.WriteLine(DateTime.Parse(dt1));

            var dt2 = "平成30年2月15日 13時17分23秒";
            Console.WriteLine(DateTime.Parse(dt2));

            var dt3 = "Donnerstag, 15. Februar 2018 13:17:23";
            Console.WriteLine(DateTime.Parse(dt3, new CultureInfo("de-DE")));
        }
    }
}
