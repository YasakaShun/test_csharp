using System;
using System.IO;

namespace SelfCSharp.Chap05
{
    class StreamRead
    {
        static void Main(string[] args)
        {
            using (var reader = new StreamReader(@"c:\data\sample.txt"))
            {
                Console.WriteLine(reader.ReadToEnd());
            }
        }
    }
}
