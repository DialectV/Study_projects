using System;

namespace ConsoleApp1
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажми <H>, чтобы поприветствовать мир");
            if (Console.ReadKey().Key == ConsoleKey.H)
            {
                printHelloWorld();
            }
        }

        static void printHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
    }

}
