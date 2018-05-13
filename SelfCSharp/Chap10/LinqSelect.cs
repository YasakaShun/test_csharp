using System;
using System.Linq;

namespace SelfCSharp.Chap10
{
    class LinqSelect
    {
        static void Main(string[] args)
        {
            //クエリ構文
            var bs = from b in AppTables.Books
                     select new
                     {
                         ShortTitle = b.Title.Substring(0, 5),
                         TaxedPrice = b.Price * 1.08,
                         Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
                     };

            //メソッド構文
            //var bs = AppTables.Books
            //        .Select(b => new
            //        {
            //            ShortTitle = b.Title.Substring(0, 5),
            //            TaxedPrice = b.Price * 1.08,
            //            Released = (b.Published <= DateTime.Now ? "発売中" : "発売予定")
            //        });

            foreach (var b in bs)
            {
                Console.WriteLine(b);
            }

        }
    }
}
