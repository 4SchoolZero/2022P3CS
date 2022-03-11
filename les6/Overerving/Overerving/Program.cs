using System;

namespace Overerving
{
    public class Animal
    {
        public string name = "Floppa";
        public void call()
        {
            Console.Write("Come here ");
        }
    }
    public class Horse : Animal
    {
        public string nameHorse = "Brave";
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Horse horse = new Horse();
            horse.call();
            Console.WriteLine(horse.nameHorse + " and " + horse.name);
        }
    }
}
