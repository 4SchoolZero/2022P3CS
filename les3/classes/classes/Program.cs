using System;

namespace classes
{   
    public class RekenMachine
    {
        public static void multy(int x, int y)
        {
            int calc = x + y;
            Console.WriteLine(calc);
        }
        public static void times(int x, int y)
        {
            int calc = x * y;
            Console.WriteLine(calc);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            RekenMachine.multy(2, 5);
            RekenMachine.times(2, 5);
        }
    }
}
