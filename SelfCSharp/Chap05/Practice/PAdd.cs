using System;

namespace SelfCSharp.Chap05
{
    class PAdd
    {
        static void Main(string[] args)
        {
            var dt = DateTime.Now;
            Console.WriteLine(dt.AddDays(15));
        }
    }
}
