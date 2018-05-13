using System;
using System.IO;
using System.Text.RegularExpressions;

namespace dokushu
{
    class Test5
    {
        public static void Exec1()
        {
            Exec1_1();
            Exec1_2();
            Exec1_3();
            Exec1_4();
            Exec1_5();
        }

        private static void Exec1_1()
        {
            Console.WriteLine("1_1");
            var str = "となりのきゃくはよくきゃくくうきゃくだ";
            Console.WriteLine(str.LastIndexOf("きゃく"));
        }

        private static void Exec1_2()
        {
            Console.WriteLine("1_2");
            var city = "弘前";
            var temp = 15.156;
            Console.WriteLine(String.Format("{0}の気温は{1:F1}℃です。", city, temp));
        }

        private static void Exec1_3()
        {
            Console.WriteLine("1_3");
            var str = "ボクの名前は太郎です。";
            Console.WriteLine(str.Replace("ボク", "私"));

        }

        private static void Exec1_4()
        {
            Console.WriteLine("1_4");
            var dt = DateTime.Now;
            var ret = dt.AddDays(5).AddHours(4);
            Console.WriteLine("{0} -> {1}", dt.ToString(), ret.ToString());
        }

        private static void Exec1_5()
        {
            Console.WriteLine("1_5");
            var start = DateTime.Today;
            var end = DateTime.Today;
            if (!DateTime.TryParse("2018/02/13", out start))
            {
                Console.WriteLine("Parse Error.");
            }
            if (!DateTime.TryParse("2020/08/04", out end))
            {
                Console.WriteLine("Parse Error.");
            }

            var diff = end.Subtract(start);
            Console.WriteLine("diff: {0}days", diff.ToString("%d"));

        }

        public static void Exec2()
        {
            var rgx = new Regex(@"http(s)?://([\w-]+\.)+[\w-]+(/[a-z_0-9-./?%&=]*)?", RegexOptions.IgnoreCase);
            using (var reader = new StreamReader(@"Q:\test_csharp\dokushu\dokushu\Chap05\sample.dat"))
            {
                while (!reader.EndOfStream)
                {
                    var result = rgx.Matches(reader.ReadLine());
                    foreach (Match m in result)
                    {
                        Console.WriteLine(m.ToString());
                    }
                }
            }
        }

        public static void Exec3(string[] aArgs)
        {
            var str = String.Join(", ", aArgs);
            using (var writer = new StreamWriter(@"Q:\test_csharp\dokushu\dokushu\Chap05\data.dat", append: true, encoding: System.Text.Encoding.GetEncoding("Shift-JIS")))
            {
                writer.WriteLine(str);
            }
        }

        public static void Exec4()
        {
            Exec4_1();
            Exec4_2();
            Exec4_3();
        }

        private static void Exec4_1()
        {
            var result = Math.Pow(5, 3);
            Console.WriteLine($"5^3 = {result}");
        }

        private static void Exec4_2()
        {
            var result = Math.Abs(-12);
            Console.WriteLine($"|-12| = {result}");
        }

        private static void Exec4_3()
        {
            var ary = new[] { 105, 18, 25, 30 };
            Array.Sort(ary);
            Console.WriteLine(String.Join(", ", ary));
        }

    }
}