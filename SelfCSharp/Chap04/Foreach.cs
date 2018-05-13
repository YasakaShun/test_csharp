using System;

namespace SelfCSharp.Chap04
{
    class Foreach
    {
        static void Main(string[] args)
        {
            var data = new[] { "うめ", "さくら", "もも" };
            foreach (var val in data)
            {
                Console.WriteLine(val);
            }
        }
    }
}
