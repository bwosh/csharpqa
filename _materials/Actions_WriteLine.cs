using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintName("asdasd", (x)=> Console.WriteLine(x) );

            Console.ReadLine();
        }

        static void PrintName(string name, Action<string> action)
        {
            action.Invoke(name);
        }
    }
}
