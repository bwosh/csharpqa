using System;

namespace FirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");

            string text = Console.ReadLine();
            int value = int.Parse(text);

            if (value % 2 == 0 )
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
            

            Console.ReadLine();
        }
    }
}
