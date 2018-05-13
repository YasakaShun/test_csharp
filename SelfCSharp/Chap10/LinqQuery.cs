using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqQuery
    {
        static void Main(string[] args)
        {
            var bs = from b in AppTables.Books
                     where b.Price < 2000
                     select b.Title;

            //var bs = from b in AppTables.Books
            //         where b.Price < 2000
            //         select new { Title = b.Title, Price = b.Price };


            //var bs = AppTables.Books
            //    .Where(b => b.Price < 2000)
            //    .Select(b => b.Title);

            //メソッド構文
            //var bs = AppTables.Books
            //      .Where(b => b.Price < 2000)
            //      .Select(b => b.Title);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
