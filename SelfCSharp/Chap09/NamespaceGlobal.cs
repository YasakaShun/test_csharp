class Util
{
    public static void Run() { }
}

namespace SelfCSharp.Chap09.Util
{
    class NamespaceGlobal
    {
        static void Main(string[] args)
        {
            //Util.Run();
            global::Util.Run();
        }
    }
}

