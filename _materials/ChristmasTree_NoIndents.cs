using System;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int levels = 20;

            for (int n = 1; n <= levels; n++)
            {
                for (int m = 1; m <= n; m++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
