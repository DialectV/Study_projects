using System;

namespace ConsoleApp1
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Нажми <H>, чтобы поприветствовать мир");
            Console.WriteLine("Иначе будет запущен конвертор decimal в hex");
            if (Console.ReadKey().Key == ConsoleKey.H)
            {
                printHelloWorld();
            }
            else
            {
                Console.WriteLine("Введите целое десятичное число!");
                Console.WriteLine($"Ваше число в 16-ой системе равно {decimalToHex(Console.ReadLine())}");
            }

        }

        static void printHelloWorld()
        {
            Console.WriteLine("Hello World!");
        }

        static string decimalToHex(string input)
        {
            int x = int.Parse(input);

            string answer = "";
            string hexabc = "0123456789abcdef";

            while (true)
            {
                if (x / 16 >= 1)
                {
                    answer = hexabc[x % 16] + answer;
                    x /= 16;
                }
                else
                {
                    answer = hexabc[x % 16] + answer;
                    break;
                }
            }

            return answer;
        }
    }

}
