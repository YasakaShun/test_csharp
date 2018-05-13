using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("あなたの名前は？");
            string name = Console.ReadLine();
            Console.WriteLine("こんにちは、{0}さん！", name);
        }
    }
}
