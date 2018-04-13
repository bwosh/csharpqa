using System;

namespace NNW
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = Fibb(7);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        static int Fibb(int index)
        {
            Console.WriteLine("F({0}) = F({1})+F({2})", index, index - 1, index - 2);
            if (index <= 2)
            {
                Console.WriteLine("F({0})=1 return!", index);
                return 1;
            }

            Console.WriteLine("  -> Calulating F({0})...", index - 1);
            int f1 = Fibb(index - 1);


            Console.WriteLine("  -> Calulating F({0})...", index - 2);
            int f2 = Fibb(index - 2);

            Console.WriteLine("Now I am able to calculate F({0}) = F({1})+F({2}) = {3}", index, index - 1, index - 2, f1 + f2);
            return f1 + f2;
        }
    }
}
