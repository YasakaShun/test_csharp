using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqSingle
    {
        static void Main(string[] args)
        {
            var bs = AppTables.Books
                     .Single(b => b.Isbn == "978-4-7981-3547-2");

            //var bs = AppTables.Books
            //         .SingleOrDefault(b => b.Isbn == "978-4-7981-3547-2");

            Console.WriteLine(bs);  
        }
    }
}
