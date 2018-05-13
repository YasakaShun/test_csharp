using System;
using System.IO;

namespace SelfCSharp.Chap09
{
    class TryMulti
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader sr = new StreamReader(@"C:\nothing.dat"))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch (Exception ex) when (
              ex is FileNotFoundException ||
              ex is ArgumentException
            )
            {
                Console.WriteLine("ファイルにアクセスできません。");
                Console.WriteLine(ex.StackTrace);
            }
        }
    }
}
