using System;

namespace SelfCSharp.Chap03
{
    class Shortcut
    {
        static void Main(string[] args)
        {
            string str = null;
            //string str = "http://www.wings.msn.to/";
            if (str != null && str.StartsWith("http://"))
            {
                Console.WriteLine("「http://～」で始まります。");
            }

        }
    }
}
