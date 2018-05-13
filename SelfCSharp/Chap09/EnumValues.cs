using System;

namespace SelfCSharp.Chap09
{
    class EnumValues
    {
        static void Main(string[] args)
        {
            foreach (var name in Enum.GetValues(typeof(Season)))
            {
                Console.WriteLine($"{(int)name}：{name}");
            }
        }
    }
}
