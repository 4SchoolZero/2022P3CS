using System;

namespace namespacesss
{
    class Names
    {
        public static void call()
        {
            Console.WriteLine("This is insinde of a namespaces");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Names.call();
        }
    }
}
