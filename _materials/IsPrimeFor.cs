using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12prime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number > ");
            int number = int.Parse(Console.ReadLine());
            bool isPrime = true;

            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    Console.WriteLine("Divides by " + i);
                    isPrime = false;
                }
            }

            Console.WriteLine(isPrime ? "Is Prime" : "Is Not Prime");
            Console.ReadLine();
        }
    }
}
