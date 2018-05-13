using System;
using System.IO;

namespace SelfCSharp.Chap09
{
    class ThrowRe
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
                throw;
            }
        }
    }
}
