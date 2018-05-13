using System;
using System.IO;
using MyFile = SelfCSharp.Chap09.Other.FileInfo;

namespace SelfCSharp.Chap09.Ns
{
    class NamespaceAlias2
    {
        static void Main(string[] args)
        {
            var f = new MyFile(@"C:\data\sample.txt");
        }
    }
}
