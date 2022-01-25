using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            Random random = new Random();
            Random rand = new Random();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Добро пожаловать в блекджек на минималках!", 30);
            Console.WriteLine("Сколько раздать карт?");
            int cards = int.Parse(Console.ReadLine());
            for (int i = 0; i < cards; i++)
            {
                int points = random.Next(2, 11);
                if (points >= 10)
                {
                    char[] symbol = new char[4] { 'J', 'Q', 'K', 'T' };
                    int numb = rand.Next(1, 4);
                    Console.WriteLine($"Ваша карта: {symbol[numb]}");
                    sum = sum + 10;
                }
                else
                {
                    Console.WriteLine($"Ваша карта: {points}");
                    sum = sum + points;
                }

            }
            Console.WriteLine();
            Console.WriteLine(sum);
            if (sum == 21)
            {
                Console.WriteLine("Отлично! Вы победили!");
            }
            if (sum < 21)
            {
                Console.WriteLine("Увы! Недобор!");
            }
            if (sum > 21)
            {
                Console.WriteLine("Увы! Перебор!");
            }

            Console.ReadKey();
        }
    }
}
