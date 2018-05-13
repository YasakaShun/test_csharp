using System;

namespace SelfCSharp.Chap08.Practice
{
    static class StringExtensions
    {
        public static string ToTitleCase(this string str)
        {
            return str.Substring(0, 1).ToUpper() + str.Substring(1).ToLower();
        }
    }

    class Practice2
    {
        static void Main(string[] args)
        {
            Console.WriteLine(StringExtensions.ToTitleCase("wings"));
        }
    }
}
