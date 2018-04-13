using System;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = 15;

            for (int row = 1; row < numberOfRows; row++)
            {
                for (int star = 1; star < row; star++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();



        }
    }
}
