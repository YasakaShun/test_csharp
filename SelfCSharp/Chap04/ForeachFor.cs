using System;

namespace SelfCSharp.Chap04
{
    class ForeachFor
    {
        static void Main(string[] args)
        {
            var data = new[]{ "うめ", "さくら", "もも" };
            for (var i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
