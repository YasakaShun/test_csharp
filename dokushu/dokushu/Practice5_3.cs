using System;

namespace dokushu
{
    class Practice5_3
    {

        public static void Exec1()
        {
            var dt = DateTime.Parse("2018/02/15 13:17:23");
            Console.WriteLine(dt.ToString("dd日HH時"));
        }

        public static void Exec2()
        {
            var dt = DateTime.Today;
            var result = dt.AddDays(15);
            Console.WriteLine(result.ToShortDateString());
        }
    }
}