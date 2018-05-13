using System;
using System.IO;

namespace SelfCSharp.Chap09
{
    class TryCatch
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

            catch (FileNotFoundException ex)
            {
                Console.WriteLine("ファイルが見つかりませんでした。");
                Console.WriteLine(ex.StackTrace);
            }        
        }
    }
}
