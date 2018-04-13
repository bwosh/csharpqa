using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            // -----------------------------------------------

            var a = new Person("Zdam", 39);
            var b = new Person("Farbara", 15);
            var c = new Person("Telina", 24);
            var d = new Person("Aamian", 11);

            var people = new List<Person>();

            people.Add(a);
            people.Add(b);
            people.Add(c);
            people.Add(d);


            // -----------------------------------------------

            var i = new Person("dsfdsfsdf", 87);
            var j = new Person("sdfdsf", 33);
            var k = new Person("hhhhhA", 11);
            var l = new Person("cccccc", 56);

            var weirdNames = new List<Person>();

            weirdNames.Add(i);
            weirdNames.Add(j);
            weirdNames.Add(k);
            weirdNames.Add(l);
            weirdNames.Add(a);

            // -----------------------------------------------

            /*string a = "sdfsdf";
            bool result = a.Contains("a");*/

            var merged = people.Union(weirdNames);

            var peopleWithAInName = merged.Where(p => HasLetter(p.Name) );

            foreach (var person in peopleWithAInName)
            {
                //Console.WriteLine(person.Name);
            }

            //Console.WriteLine(sorted);

            string msg1 = "User has entered 445 ...";
            string[] splited = msg1.Split(' ');

            foreach (var s in splited)
            {
                Console.WriteLine(s);
            }

            Console.ReadLine();

        }

        private static bool HasLetter(string name)
        {
            // TODO string contains...
            //return String.c  // name.Contains("a",
            return true;
        }

        public static string Trick(string text)
        {
            return "***" + text + "***";
        }

        class Person
        {
            private string _name;
            private int _age;

            public Person(string name, int age)
            {
                _name = name;
                _age = age;
            }

            public string Name
            {
                get { return _name; }
            }

            public int Age
            {
                get { return _age; }
            }
            public string GetName()
            {
                return _name;
            }

            public int GetAge()
            {
                return _age;
            }
        }
    }


}
