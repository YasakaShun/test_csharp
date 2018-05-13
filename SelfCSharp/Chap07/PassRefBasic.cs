using System;

namespace SelfCSharp.Chap07
{
    class PassRefBasic
    {
        public int CountUp(ref int data)
        {
            data++;
            return data;
        }

        static void Main(string[] args)
        {
            var data = 1;
            var p = new PassRefBasic();
            Console.WriteLine(p.CountUp(ref data));
            Console.WriteLine(data);
        }
    }
}
