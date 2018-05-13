using System.IO;
using SelfCSharp.Chap09.Other;

namespace SelfCSharp.Chap09.Ns
{
    class NamespaceSame
    {
        static void Main(string[] args)
        {
            //var f = new FileInfo(@"C:\data\sample.txt");
            var f = new System.IO.FileInfo(@"C:\data\sample.txt");
        }
    }
}
