using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqBetween
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     where (1500 <= b.Price && b.Price <= 2000)
                     //where(b.Price >= 1500 && b.Price <= 2000)
                     select (b);

            //メソッド構文
            //var bs = AppTables.Books
            //         .Where(b => 1500 <= b.Price && b.Price <= 2000)
            //         .Select(b => b);


            //列記も可能
            //クエリ構文
            //var bs = from b in AppTables.Books
            //       where(b.Price >= 1500)
            //       where(b.Price <= 2000)
            //       select(b);

            //メソッド構文
            //var bs = AppTables.Books
            //         .Where(b => b.Price >= 1500)
            //         .Where(b => b.Price <= 2000)
            //         .Select(b => b);

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }
        }
    }
}
