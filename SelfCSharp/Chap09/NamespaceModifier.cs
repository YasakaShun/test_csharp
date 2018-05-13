using System;
using Chapter = SelfCSharp.Chap09.Other;


namespace SelfCSharp.Chap09.Ns
{
    class NamespaceModifier
    {
        static void Main(string[] args)
        {
            //var f = new Chapter.FileInfo(@"C:\data\sample.txt");
            var f = new Chapter::FileInfo(@"C:\data\sample.txt");
        }
    }

    class Chapter
    {
    }
}
