using System;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tableOfIntegers = { 11, 25, 34, 41, 58 };
            int[] t = new int[0];

            //PrintTable(tableOfIntegers);
            //Console.WriteLine("Sum of elements is equal {0}", SumOfTable(tableOfIntegers));
            //Console.WriteLine("Minimum value is {0}", Min(tableOfIntegers));
            //Console.WriteLine("Average value is {0}", Avg(tableOfIntegers));

            /*long[] x = {1, 2, 3};

            char[] c = {'s','g','y'};
            string text = "asdfghjklerr";

            Console.WriteLine(c[0]);
            Console.WriteLine(c.Length);
            Console.WriteLine(text[0]);
            Console.WriteLine(text.Length);

            string newText = text + "1" + 'a';*/

            string myAwesomeText = "To jest super tekst.";
            Console.WriteLine(Reverse(myAwesomeText));

            // MIN MAX AVG
            Console.ReadLine();
        }

        static string Reverse(string input)
        {
            string result = "";

            for (int i = input.Length-1; i >= 0; i--)
            {
                result += input[i];
            }

            return result;
        }

        static void PrintTable(int[] table)
        {
            Console.Write("Elements of table: ");

            for (int i = 0; i < table.Length; i++)
            {
                Console.Write(table[i]);
                Console.Write(' ');
            }

            Console.WriteLine();
        }

        static int SumOfTable(int[] table)
        {
            int sum = 0;
            for (int i = 0; i < table.Length; i++)
            {
                sum += table[i];
            }

            return sum;
        }

        static int Min(int[] table)
        {
            if (table.Length == 0)
            {
                // ????
                return 0;
            }
            else
            {
                int minimumValue = table[0];
                for (int i = 1; i < table.Length; i++)
                {
                    if (table[i] < minimumValue)
                    {
                        minimumValue = table[i];
                    }
                }

                return minimumValue;
            }
        }

        static int Avg(int[] table)
        {
            int sum = SumOfTable(table);
            int count = table.Length;

            if (count == 0)
            {
                // ??????
                return 0;
            }

            return sum / count;
        }
    }
}
