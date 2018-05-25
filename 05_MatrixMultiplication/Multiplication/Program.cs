using System;

namespace Multiplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = new Matrix(4, 2, new float[] { 1, 4, 6, 10, 2, 7, 5, 3 });
            var n = new Matrix(3, 4, new float[] { 1, 4, 6, 2, 7, 5, 9, 0, 11, 3, 1, 0 });
            var result = m * n;
            Console.WriteLine(m);
            Console.WriteLine("*");
            Console.WriteLine(n);
            Console.WriteLine("=");
            Console.WriteLine(result);

            Console.WriteLine("Adds:" + Matrix.Additions);
            Console.WriteLine("Idx:" + Matrix.IndexCalculations);
            Console.WriteLine("Mults:" + Matrix.Multiplications);
            Console.ReadLine();
        }
    }
}
