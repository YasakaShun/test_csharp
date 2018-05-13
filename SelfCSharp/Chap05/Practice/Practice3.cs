using System.IO;
using System.Text;

namespace SelfCSharp.Chap05
{
    class Practice3
    {
        static void Main(string[] args)
        {
            using (var writer = new StreamWriter(@"c:\data\data.dat", true,
                Encoding.GetEncoding("Shift-JIS")))
            {
                writer.WriteLine(string.Join(",", args));
            }
        }
    }
}
