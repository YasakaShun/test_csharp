using SelfCSharp.Chap08.ExtensionBasic;
using System;

namespace SelfCSharp.Chap08.ExtensionUse
{
    class ExtensionClient
    {
        static void Main(string[] args)
        {
            var data = "ありがとう！";
            Console.WriteLine(data.Repeat(3));
        }
    }
}
