using System;
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
        }
    }
}
