using System;

namespace SelfCSharp.Chap05
{
    class TimeParseTry
    {
        static void Main(string[] args)
        {
            DateTime dt;
            if (DateTime.TryParse("2018/02/15 13:17:23", out dt))
            //if (DateTime.TryParse("20180215131723", out dt))
            {
                Console.WriteLine(dt);
            }
        }
    }
}
