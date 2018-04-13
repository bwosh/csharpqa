using System;

namespace FirstLessonGroup2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("> ");

            string text = Console.ReadLine();
            int value = int.Parse(text);

            if (value % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            Console.ReadKey();
        }
    }
}
