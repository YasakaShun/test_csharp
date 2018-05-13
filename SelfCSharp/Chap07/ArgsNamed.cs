namespace SelfCSharp.Chap07.MethodArgs
{
    class ArgsNamed
    {
        static void Main(string[] args)
        {
            var p = new Person()
            {
                lastName = "山田",
                firstName = "太郎"
            };
            p.Show(title: "氏");
            p.Show(title: "氏", greeting: "おはよう");
        }
    }
}
