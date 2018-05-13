using System;

namespace SelfCSharp.Chap07
{
    class Constants
    {
        //public static const int Value = 10;
        public const int Value = 10;
    }

    class ConstantsBasic
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Constants.Value);
        }
    }
}
