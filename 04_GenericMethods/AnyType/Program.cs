using System;

namespace AnyType
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,5};
            int[] b = Reverse(a);

            Console.WriteLine(b);
            Console.ReadKey();
        }

        static T[] Reverse<T>(T[] input)
        {
            T[] result = new T[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                result[i] = input[input.Length - 1 - i];
            }

            return result;
        }
    }
}
