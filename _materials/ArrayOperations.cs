using System;
using System.Globalization;

namespace NieMaLipy
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { -5, -4, 3, -8};

            PrintTable(values);
            Sort(values);

            PrintTable(values);
            Console.ReadKey();
        }

        static void Sort(int[] table)
        {
            for (int sortedElements = 0; sortedElements < table.Length; sortedElements++)
            {
                int minimumIndex = GetMinValueIndex(table, sortedElements);
                SwapValues(table, minimumIndex, sortedElements);
            }
        }

        private static void SwapValues(int[] table, int indexA, int indexB)
        {
            int temp = table[indexA];
            table[indexA] = table[indexB];
            table[indexB] = temp;
        }

        // 1 2 3 | 55 44 33 22    
        static int GetMinValueIndex(int[] array, int fromIndex)
        {
            int minumumIndex = fromIndex; 

            for (int i = fromIndex + 1; i < array.Length; i++)
            {
                if (array[i] < array[minumumIndex])
                {
                    minumumIndex = i;
                }
            }

            return minumumIndex;
        }

        private static void PrintTable(int[] values)
        {
            Console.Write("Values: ");
            for (int i = 0; i < values.Length; i++)
            {
                Console.Write("{0} ", values[i]);
            }

            Console.WriteLine();
        }

        private static string ReverseSample()
        {
            string text = "Ja ni umiem. Dooooookoła.";

            string reversed = Reverse2(text);
            return reversed;
        }

        private static string Reverse(string text)
        {
            string result = "";

            for (int i = text.Length - 1; i >= 0; i--)
            {
                result = result + text[i];
            }

            return result;
        }

        private static string Reverse2(string text)
        {
            // String to char[] --> .ToCharArray()
            char[] array = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                array[i] = text[i];
            }

            // Implementation
            for (int i = 0; i < text.Length / 2; i++)
            {
                //array[0] <--> array[text.Length-1]
                // array[0+i] <--> array[text.Length-1 -i]
                char temp = array[i];
                array[i] = array[text.Length - 1 - i];
                array[text.Length - 1 - i] = temp;
            }

            // new string(array)
            string result = "";
            for (int i = 0; i < array.Length; i++)
            {
                result = result + array[i];
            }

            return result;
        }


    }
}
