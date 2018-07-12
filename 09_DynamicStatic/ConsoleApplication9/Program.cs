using System;
using System.Collections.Generic;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.Add(2);
            a.Add(7);
            a.Add(9);
            a.Add(11);
            a.Add(12);
            
            var evenNumbers = a.GiveMeElements(Magic);

            //Func<int,bool> f = ((i) => i%2 == 0);
            //var evenNumbers = a.GiveMeElements(f);

            //var evenNumbers = a.GiveMeElements((i) => i%2 == 0);
        }

        static bool Magic(int x)
        {
            return x > 3;
        }
    }


    class MyClass
    {
        List<int> elements = new List<int>(); 

        public MyClass()
        {
            
        }

        public void Add(int x)
        {
            elements.Add(x);
        }

        public List<int> GiveMeElements(Func<int,bool> func)
        {
            var result = new List<int>();

            foreach (var element in elements)
            {
                if (func(element))
                {
                    result.Add(element);
                }
            }

            return result;
        }
    }
}
