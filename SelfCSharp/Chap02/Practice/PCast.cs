using System;

namespace SelfCSharp.Chap02
{
    class PCast
    {
        static void Main(string[] args)
        {
            long m = 10;
            int i = (int)m;
            Console.WriteLine(m);

            int x = Int32.Parse("15");
            Console.WriteLine(x.GetType());
        }
    }
}
