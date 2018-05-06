using System;
using System.Text.RegularExpressions;

namespace dokushu
{
    /// <summary>
    /// 
    /// </summary>
    public class Practice5_2
    {
        public Practice5_2()
        {
        }

        public static void Exec1()
        {
            var str = "住所は〒184-0000 鎌ヶ谷市梶野町0-0-0です。\nあなたの住所は〒273-0000 嬬小石大野町0-9-9ですね。";
            var matches = Regex.Matches(str, @"\d{3}-\d{4}");
            foreach(var m in matches)
            {
                Console.WriteLine(m);
            }
        }

        public static void Exec2()
        {
            var str = "お問い合わせはhoge@example.comまで";
            var rgx = new Regex(@"[a-z_0-9]+([-+.][a-z_0-9]+)*@[a-z_0-9]+([-.][a-z_0-9]+)*\.[a-z_0-9]+([-.][a-z_0-9]+)*");
            Console.WriteLine(rgx.Replace(str, "<a href=\"mailto:$0\">$0</a>"));
        }
    }
}