using System;

namespace SelfCSharp.Chap07
{
    class AnonymousShort
    {
        static void Main(string[] args)
        {
            var info1 = new { Title = "速習C#", Price = 1000 };
            var info2 = new { info1.Title, info1.Price };
            Console.WriteLine(info2.Title);
        }
    }
}
