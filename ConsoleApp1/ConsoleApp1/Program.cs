﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
			Random random = new Random();
            int number = random.Next(0, 101);
            int attempts = 10;

            Console.WriteLine("Угадайте число от 0 до 100. У вас 10 попыток.");
			            {
			while (attempts > 0)
            {
                Console.Write("Попытка №" + (11 - attempts) + ": ");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess == number)
                {
                    Console.WriteLine("Вы угадали число!");
                    return;
                }
                else if (guess < number)
                {
                    Console.WriteLine("Загаданное число больше.");
                }
				else
                {
                    Console.WriteLine("Загаданное число меньше.");
                }

                attempts--;
            }

            Console.WriteLine("Вы не угадали число. Загаданное число: " + number);
        }
    }
}