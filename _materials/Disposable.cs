using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            var data = Enumerable.Range(1, 100);

            Debug.WriteLine(">>>>>");
            StringBuilder aggregate = new StringBuilder();

            var enumerable = Test(data);

            foreach (var text in enumerable)
            {
                aggregate.Append(text);
                //break;
            }
            
            Debug.WriteLine("<<<<");

        }


        static IEnumerable<string> Test(IEnumerable<int> data)
        {
            using (new MyDisposable())
            {
                Debug.WriteLine("Start");
                foreach (var i in data)
                {
                    Debug.WriteLine("Reurning next...");
                    yield return i.ToString();
                }
                Debug.WriteLine("Stop");
            }
        }
    }


    class MyDisposable : IDisposable
    {
        public MyDisposable()
        {
            Debug.WriteLine("CTOR");
        }
        public void Dispose()
        {
            Debug.WriteLine("Disposing");
        }
    }
}
