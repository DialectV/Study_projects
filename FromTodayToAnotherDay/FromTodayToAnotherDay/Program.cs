using System;

namespace FromTodayToAnotherDay
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Скажи, какой сегодня день недели и число месяца");
            string line = Console.ReadLine();
            string[] splitLine = line.Split(" ");

            string todayDay = splitLine[0];
            int todayNum = Convert.ToInt32(splitLine[1]);
            int bias = 0;
            switch (todayDay) {
                case "Воскресенье":
                    bias = 7 - (todayNum % 7);
                    break;
                case "Понедельник":
                    bias = 8 - (todayNum % 7);
                    break;
                case "Вторник":
                    bias = 9 - (todayNum % 7);
                    break;
                case "Среда":
                    bias = 10 - (todayNum % 7);
                    break;
                case "Четверг":
                    bias = 11 - (todayNum % 7);
                    break;
                case "Пятница":
                    bias = 11 - (todayNum % 7);
                    break;
                case "Суббота":
                    bias = 12 - (todayNum % 7);
                    break;
                default:
                    Console.WriteLine("Не понял тебя... Будем считать, что сегодня 1-ое число, понедельник");
                    break;
            }
            Console.WriteLine("Теперь я знаю, когда какой день недели будет!");
            while (true) {
                Console.WriteLine("Назови любое другое число того же месяца.");
                int anotherDay = Convert.ToInt32(Console.ReadLine());
                switch ((anotherDay + bias) % 7)
                {
                    case 0:
                        Console.WriteLine($"{anotherDay} - это воскресенье!");
                        break;
                    case 1:
                        Console.WriteLine($"{anotherDay} - это понедельник!");
                        break;
                    case 2:
                        Console.WriteLine($"{anotherDay} - это вторник!");
                        break;
                    case 3:
                        Console.WriteLine($"{anotherDay} - это среда!");
                        break;
                    case 4:
                        Console.WriteLine($"{anotherDay} - это четверг!");
                        break;
                    case 5:
                        Console.WriteLine($"{anotherDay} - это пятница!");
                        break;
                    case 6:
                        Console.WriteLine($"{anotherDay} - это суббота!");
                        break;
                    default:
                        Console.WriteLine("Такого не может быть...");
                        break;
                }
                Console.WriteLine("Давай ещё! Набери <Y>, если согласен!");
                if (Console.ReadKey().Key != ConsoleKey.Y) {
                    Console.WriteLine("Жаль...");
                    break;
                }
            }
            
        }
    }
}
