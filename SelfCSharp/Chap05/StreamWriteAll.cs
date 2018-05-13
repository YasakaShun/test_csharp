using System.IO;

namespace SelfCSharp.Chap05
{
    class StreamWriteAll
    {
        static void Main(string[] args)
        {
            var lines = new[] { "2017/12/31 23:59:59", "2018/01/01 06:15:30" };
            File.WriteAllLines(@"c:\data\data.log", lines);
        }
    }
}
