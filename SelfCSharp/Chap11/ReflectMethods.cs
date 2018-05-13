using System;

namespace SelfCSharp.Chap11
{
    class ReflectMethods
    {
        static void Main(string[] args)
        {
            var t = typeof(string);
            foreach (var m in t.GetMethods())
            {
                Console.WriteLine(m.Name);
            }
        }
    }
}
