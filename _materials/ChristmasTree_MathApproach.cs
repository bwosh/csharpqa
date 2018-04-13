using System;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 10;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 2 * (n / 2 - i / 2) + (i % 2 == 0 ? 1 : 0); j > 0; j--)
                {
                    Console.Write(' ');
                }

                for (int j = 1; j < i; j++)
                {
                    Console.Write("* ");
                }

                Console.WriteLine("*");
            }

            Console.ReadLine();
        }
    }
}
