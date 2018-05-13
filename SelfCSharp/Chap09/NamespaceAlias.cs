using System;
using System.IO;
using Cs = SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns
{
    class NamespaceAlias
    {
        static void Main(string[] args)
        {
            var f = new Cs.FileInfo(@"C:\data\sample.txt");
        }
    }
}
