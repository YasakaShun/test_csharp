using System;

namespace SelfCSharp.Chap09.Const
{

    class Season
    {
        public const int Spring = 0;
        public const int Summer = 1;
        public const int Autumn = 2;
        public const int Winter = 3;

        public void ProcessSeason(int season)
        {
            Console.WriteLine(season);
        }
    }

    class SeasonConst
    {
        static void Main(string[] args)
        {
            var sc = new Season();
            sc.ProcessSeason(Season.Spring);
            sc.ProcessSeason(4);
        }
    }
}
