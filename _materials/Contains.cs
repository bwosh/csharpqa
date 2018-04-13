using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Hej!";
            char[] notAllowed = new[] { '!', '.', ',' };


            if (text.Any(c => notAllowed.Contains(c)))
            {
                Console.WriteLine("Boom");
            }


            Console.ReadLine();
        }
    }
}
