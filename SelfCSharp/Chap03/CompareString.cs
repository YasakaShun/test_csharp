using System;

namespace SelfCSharp.Chap03
{
    class CompareString
    {
        static void Main(string[] args)
        {
            string data = "123";
            int data2 = 123;
            Console.WriteLine(data.Equals(data2));
            //Console.WriteLine(data == data2);
        }
    }
}
