using System;

namespace SelfCSharp.Chap04
{
    class PreRegion
    {
        static void Main(string[] args)
        {
        #region 定数／変数の定義
            const string Publisher = "翔泳社";
            const double Tax = 1.08;
            var author = "WINGSプロジェクト";
            var title = "一人で学ぶC#";
            var price = 1000;
        #endregion

            Console.WriteLine($"{title}（{Publisher}刊、{author}著）発売開始");
            Console.WriteLine($"{price * Tax}円");
        }
    }
}
