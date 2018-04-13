using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace LINQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // person class

            Person[] group = new Person[]
            {
                new Person(20, "Jan"),
                new Person(30, "Kasia"),
                new Person(36, "Stefan"),
                new Person(39, "Agata"),
                new Person(20, "Bartek")
            };

            //Homework, rewrite line below to non-linq
            var x = group.Where(p => p.Age > 20).Select(p => p.Name).OrderBy(s => s);






            var y = group.Where(p => p.Age > 20).OrderBy(p => p.Name);

            // earlier
            double avgAge = GetAverageAge(group);

            // with LINQ
            var fasterAvgAge = group.Average(item => item.Age);

            var minAge = group.Min(p => p.Age);
            var maxAge = group.Max(p => p.Age);

            var youngestPeople = group.Where(p => p.Age == minAge).OrderBy(p=>p.Name);

            var youngestPerson = group.First(p => p.Age == minAge);
            var aPerson = group.FirstOrDefault(p => p.Age == 12);
            var thePerson = group.Single(p => p.Age == 39);
            var aThePerson = group.SingleOrDefault(p => p.Age == 202);

            if (group.Any(p => p.Age == 135))
            {

            }

            if (group.All(p => p.Age >= 18))
            {

            }
            else
            {

            }

            var ages = group.Select(p => p.Age).Distinct();

            var youngestPeopleNames = group.Where(p => p.Age == minAge).Select(p => p.Name);

            //var youngestPersonName = group.Where(p => p.Age == minAge);

            //

            // avg, count, 
            // group vs generic group


            Group g = new Group();
            g.Add(new Person(20, "sddasf"));

            MyList<Person> list = new MyList<Person>();
            list.Add(new Person(20, "sddasf"));

            List<Person> personList = new List<Person>()
            {
                new Person(20, "Jan"),
                new Person(30, "Kasia"),
                new Person(36, "Stefan"),
                new Person(39, "Agata"),
                new Person(20, "Bartek")
            };

            //personList.Average()

            //group[0]
            //personList[0]
            //personList.Add(new Person(234,"very old person"));
            personList.RemoveAll(p => p.Name.Contains("t"));
            //personList.cl
            IEnumerable<Person> evenMoreChaos = personList;
            //evenMoreChaos.Average()

            Console.WriteLine(avgAge);
            Console.WriteLine(fasterAvgAge);
            Console.ReadLine();

            int accountBalance1 = 23;
            int accountBalance2 = -2;

        }

        private static double GetAverageAge(Person[] people)
        {
            if (people == null || people.Length == 0)
            {
                throw new Exception("There are no people.");
            }

            double sumOfAge = 0;
            foreach (var person in people)
            {
                sumOfAge += person.Age;
            }

            return sumOfAge / people.Length;
        }
    }

    class Group
    {
        Person[] people;

        public void Add(Person newPerson)
        {
            //....
        }

        public void Remove(string name)
        {
            //
        }
    }

    class AccountHistory
    {
        private int[] balance;

        public void Add(int newPerson)
        {
            //....
        }

        public void Remove(int id)
        {
            //
        }
    }

    class MyList<T>
    {
        T[] table;

        public void Add(T item)
        {
            if (table == null)
            {
                table = new T[1];
                table[0] = item;
            }
            else
            {
                // go away!
                var newTable = new T[table.Length + 1];
                for (int i = 0; i < table.Length; ++i)
                {
                    newTable[i] = table[i];
                }
                newTable[table.Length] = item;
                table = newTable;
            }
        }
    }
}
