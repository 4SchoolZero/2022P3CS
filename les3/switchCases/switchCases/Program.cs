using System;

namespace switchCases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            switch (x)
            {
                case 0:
                    Console.WriteLine("This is case 0");
                    break;
                default:
                    Console.WriteLine("This is the default case");
                    break;
            }
        }
    }
}
