﻿namespace Угадай_число__Глад._бои
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number, lower, larger;
            int tryCount = 5;
            Random rand = new Random();
            int userInput;

            number = rand.Next(0, 101);
            lower = rand.Next(number - 10, number);
            larger = rand.Next(number + 1, number + 10);

            Console.WriteLine("Мы загадали число от 0 до 100, оно больче чем " + lower +", но меньше, чем " + larger );
            Console.WriteLine("Что это за число?");

            while (tryCount-- > 0)
            {
                Console.Write("Это число:");
                userInput = Convert.ToInt32(Console.ReadLine());

                if (userInput == number)
                {
                    Console.WriteLine("Вы правы Это было число -" + number + ".");
                    break;
                }
                else
                {
                    Console.WriteLine("Не верно, попробуйте еще раз");
                }
            }
                
        }
    }
}