using System;

namespace SelfCSharp.Chap07
{
    class MethodLocal
    {
        static void Main(string[] args)
        {
            double Discount(int price, double rate)
            {
                return price * (1 - rate);
            }

            Console.WriteLine(Discount(1000, 0.2));

            //順番を入れ替えた場合
            //Console.WriteLine(Discount(1000, 0.2));

            //double Discount(int price, double rate)
            //{
            //    return price * (1 - rate);
            //}
        }
    }
}
