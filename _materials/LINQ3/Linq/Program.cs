using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var arrayOfpeople = CreateArrayOfPeople();

            //var avgAge = arrayOfpeople.Average(person => person.Age);
            //var maxAge = arrayOfpeople.Max(person => person.Age);
            //var minAge = arrayOfpeople.Min(person => person.Age);
            //var count = arrayOfpeople.Count();

            //var first = arrayOfpeople.SingleOrDefault(p=>p.Name == "Z");

            //arrayOfpeople.Last();

            var minAge = arrayOfpeople.Min(person => person.Age);
            var youngestPeople = arrayOfpeople
                .Where(p => p.Age == minAge)
                .Select(p => new {NameX = p.Name, SurnameX = p.Surname})
                .OrderBy(x=>x.NameX);

            var alternative = 
                from p in arrayOfpeople
                where p.Age == minAge
                select new {NameX = p.Name, SurnameX = p.Surname};
                               

            var peopleByAge = arrayOfpeople.OrderBy(p => p.Age);
            
            //arrayOfpeople.Reverse()
            string text = "asdfghjkl";

            string reversed = new string(text.Reverse().ToArray());
            Console.WriteLine(reversed);

            //PrintStrings(arrayOfpeople.Select(p=>p.Name).Distinct());
            //Console.WriteLine(youngestPeople.ToList());
            Console.ReadLine();

        }

        private static void PrintStrings(IEnumerable<string> enumerable)
        {
            enumerable.ToList().ForEach(i => Console.WriteLine(i));
        }

        private static void PrintPeople(IEnumerable<Person> people)
        {
            people.ToList().ForEach(i => Console.WriteLine(i));
        }

        private static Person[] CreateArrayOfPeople()
        {
            List<Person> listOfPerson = new List<Person>();

            listOfPerson.Add(new Person("A", 100, "Aj"));
            listOfPerson.Add(new Person("B", 2, "AD"));
            listOfPerson.Add(new Person("C", 3, "Ad"));
            listOfPerson.Add(new Person("A", 4, "As"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("B", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("A", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("E", 2, "Aa"));
            listOfPerson.Add(new Person("C", 2, "Aa"));
            listOfPerson.Add(new Person("C", 2, "Aa"));
            listOfPerson.Add(new Person("C", 2, "Aa"));

            return listOfPerson.ToArray();
        }
    }

    class Person
    {
        public string Surname { get; }
        public string Name { get; }
        public int Age { get; }

        public Person(string name, int age, string surname)
        {
            Surname = surname;
            Name = name;
            Age = age;
        }

        public override string ToString()
        {
            return $"Surname: {Surname}, Name: {Name}, Age: {Age}";
        }
    }

    class MyList<T>
    {
        private T[] myArray;

        public MyList()
        {
            myArray = new T[0];
        }

        public void Add(T item)
        {
            var newArray = new T[myArray.Length + 1];

            for (int i = 0; i < myArray.Length; i++)
            {
                newArray[i] = myArray[i];
            }

            newArray[myArray.Length] = item;
            myArray = newArray;
        }

        void RemoveLast()
        {
            // ...
        }

        private int Count
        {
            get { return myArray.Length; }
        }
    }

}
