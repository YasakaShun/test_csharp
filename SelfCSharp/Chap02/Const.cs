using System;

namespace SelfCSharp.Chap02
{
    class Const
    {
        static void Main(string[] args)
        {
            const double Tax = 1.08;
            int price = 1000;
            double sum =  price * Tax;
            Console.WriteLine(sum);
        }
    }
}
