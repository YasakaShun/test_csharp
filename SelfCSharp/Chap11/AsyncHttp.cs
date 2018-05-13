using System;
using System.Net;
using System.Threading.Tasks;

namespace SelfCSharp.Chap11
{
    class AsyncHttp
    {
        //static async Task Main(string[] args)
        //{
        //    var client = new WebClient();
        //    var result = await client.DownloadStringTaskAsync(
        //        "https://codezine.jp/");
        //    Console.WriteLine(result);
        //}

        //従来の非同期通信
        static void Main(string[] args)
        {
            var client = new WebClient();
            client.DownloadStringCompleted += (sender, e) =>
            {
                Console.WriteLine(e.Result);
            };

            client.DownloadStringAsync(new Uri("https://codezine.jp/"));
            Console.ReadLine();
        }
    }
}
