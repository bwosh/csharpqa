using System;
using System.IO;

namespace LinesCount
{
    class Program
    {
        static void Main(string[] args)
        {
            long linesCount = 0;

            Console.WriteLine("Counting lines in file {0}", args[0]);

            using (var fs = new FileStream(args[0], FileMode.Open))
            {
                using (var bs = new StreamReader(fs))
                {
                    while (true)
                    {
                        var line = bs.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        linesCount++;
                        if (linesCount%500000 == 0)
                        {
                            Console.WriteLine("Counting lines... {0}...", linesCount);
                        }

                    }
                }
            }

            Console.WriteLine("There are {0} lines.", linesCount);
        }
    }
}
