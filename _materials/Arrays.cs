using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //SimpleMethodsExample();
            //StringExamples();
            //CountCharactersExample();
            TableValuesExample();

            Console.ReadLine();
        }

        private static void SimpleMethodsExample()
        {
            int[] table = {11, 2, 3, 11, 5, 6, 7, 8, 9};
            //int[] weight = { 2, 1, 1, 1, 1, 1, 1, 1, 1 };
            PrintTable(table);

            int sum = Sum(table);
            Console.WriteLine("Sum of elements is {0}.", sum);

            int min = Min(table);
            Console.WriteLine("Min value is : {0}.", min);

            int max = Max(table);
            Console.WriteLine("Max value is : {0}.", max);

            double avg = Avg(table);
            Console.WriteLine("Avg value is : {0}.", avg);
        }

        private static void CountCharactersExample()
        {
            int howManyA = CountCharacters("This is sample text for all of us.", 'a');
            Console.WriteLine("Number of a-s:{0}", howManyA);
        }

        private static void StringExamples()
        {
            char[] tableOfChars = new char[10];
            tableOfChars[0] = 'b';

            string text = "asdfghjk";

            Console.WriteLine(tableOfChars[0]);
            Console.WriteLine(text[0]);

            tableOfChars[1] = 'd';
        }

        private static void TableValuesExample()
        {
            int[] elements = new int[10];

            // V1
            // elements[0] => 0
            // elements[1] => 1
            // elements[2] => 4
            // elements[9] => 81

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = i*i;
            }

            PrintTable(elements);

            // V2
            // elements[0] => 1
            // elements[1] => 4
            // elements[2] => 9
            // elements[9] => 100

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = (i + 1)*(i + 1);
            }

            PrintTable(elements);

            // V3
            // elements[0] => 100
            // elements[1] => 81
            // elements[2] => 64
            // elements[9] => 1

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = (elements.Length - i)*(elements.Length - i);
            }

            PrintTable(elements);
        }

        static int CountCharacters(string text, char character)
        {
            int counter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == character)
                {
                    counter++;
                }
            }

            return counter;
        }

        static string Reverse(string inputText)
        {
            char[] result = new char[inputText.Length];

            // N-1-->0
            // N-2 ->1
            // ...
            // 0 -> N-1 

            // TODO Homework 1

            return new string(result);
        }

        static void Sort(int[] table)
        {
            // input : 4, 6, 1, 3 ==> 1, 3, 4, 6

            // 1. find minumum 4,6,[1],3
            // 2. swap to beginning of table [1],6,[4],3

                // temp = table[a];
                // table[a] = table[b]
                // table[b] = temp;

            // 3. remember where are sorted elements  1 | 6,4,3
            // 4. repeat for all elements 1|6,4,3 ==> 1,3|4,6 ==>1,3,4|6 ==> 1,3,4,6
        }

        /*
        HW: String Reverse, Sort
            */

        static int Sum(int[] table)
        {
            int sum = 0;

            for (int i = 0; i < table.Length; i++)
            {
                sum = sum + table[i];
            }

            return sum;
        }

        static int Min(int[] table)
        {
            if (table.Length == 0)
            {
                // ???????????
                return 0;
            }

            int minimum = table[0];

            for (int i = 1; i < table.Length; i++)
            {
                if (table[i] < minimum)
                {
                    minimum = table[i];
                }
            }

            return minimum;
        }

        static int Max(int[] table)
        {
            if (table.Length == 0)
            {
                // ???????????
                return 0;
            }

            int maximum = table[0];

            for (int i = 1; i < table.Length; i++)
            {
                if (table[i] > maximum)
                {
                    maximum = table[i];
                }
            }

            return maximum;
        }

        static double Avg(int[] table)
        {
            double sum = Sum(table);
            double count = table.Length;
            return sum / count;
        }

        static void PrintTable(int[] table)
        {
            Console.Write("Contents of table: ");

            // Iterate through elements and write
            for (int i = 0; i < table.Length; i++)
            {
                int value = table[i];
                Console.Write("{0} ", value);
            }

            Console.WriteLine();
        }
    }
}
