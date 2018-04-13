using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string x;

            X(() => x = Set());
        }


        private static  void X(Action a)
        {
            a.Invoke();
        }

        static string Set()
        {
            return "dasfdsf";
        }
    }
}
