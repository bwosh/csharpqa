using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InOut
{
    class Program
    {
        static void Main(string[] args)
        {
            // Value types: int, long.... struct
            // reference types: object 

            int x = 13;
            MyClass classValue = new MyClass(123);

            //MakeMagic(x);
            MakeMagic(classValue);

            MakeMagic(x);

            Console.WriteLine("Class-outside:{0}", classValue);
            Console.WriteLine("Outside:{0}", x);
            Console.ReadLine();
        }

        private static void MakeMagic(int i)
        {
            i = 34;
            Console.WriteLine("Inside:{0}", i);
        }

        private static void MakeMagic(out int i)
        {
            i = 34;
            Console.WriteLine("Inside:{0}", i);
        }

        private static void MakeMagic(MyClass classValue)
        {
            classValue.Increase();
            Console.WriteLine("Class-inside:{0}", classValue);
        }
    }
}
