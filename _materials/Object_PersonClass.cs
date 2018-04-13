using System;
using System.Threading;

namespace PersonClass
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] table = CreatePeople();


            Person temp = table[0];
            table[0] = table[1];
            table[1] = temp;

            //PrintPeople(table);
            //PrintAdultPeople(table,18);
            //PrintOldestPerson(table);
            PrintPeopleByAge(table);


            Console.ReadLine();
        }

        private static void PrintPeopleByAge(Person[] table)
        {
            // Sort people (rearrange table)
            for (int alreadySorted = 0; alreadySorted < table.Length; alreadySorted++)
            {
                int minValueIndex = FindYoungestIndex(table, alreadySorted);

                if (minValueIndex != alreadySorted)
                {
                    Person temp = table[alreadySorted];
                    table[alreadySorted] = table[minValueIndex];
                    table[minValueIndex] = temp;
                }
            }

            // Print result on screen
            PrintPeople(table);
        }

        private static int FindYoungestIndex(Person[] table, int alreadySorted)
        {
            int youngestAge = table[alreadySorted].GetAge();
            int youngestPersonIndex = alreadySorted;

            for (int i = alreadySorted + 1; i < table.Length; i++)
            {
                if (table[i].GetAge() < youngestAge)
                {
                    youngestAge = table[i].GetAge();
                    youngestPersonIndex = i;
                }
            }

            return youngestPersonIndex;
        }


        private static void PrintOldestPerson(Person[] people)
        {
            int maxAge = FindMaxAge(people);

            foreach (Person person in people)
            {
                if (person.GetAge() == maxAge)
                {
                    Console.WriteLine(person);
                }
            }


            /*
            //int max = people[0].GetAge();
            int indexMax = 0;

            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].GetAge() > people[indexMax].GetAge())
                {
                    //max = people[i].GetAge();
                    indexMax = i;
                }
            }

            Console.WriteLine(people[indexMax]);*/
        }

        private static int FindMaxAge(Person[] people)
        {
            int maxAge = people[0].GetAge();
            for (int i = 1; i < people.Length; i++)
            {
                if (people[i].GetAge() > maxAge)
                {
                    maxAge = people[i].GetAge();
                }
            }

            return maxAge;
        }

        private static void PrintAdultPeople(Person[] people, int age)
        {
            foreach (var person in people)
            {
                if (person.GetAge() >= age)
                {
                    Console.WriteLine(person);
                }
            }
        }

        private static void PrintPeople(Person[] table)
        {
            foreach (Person person in table)
            {
                Console.WriteLine(person);
            }
        }


        private static Person[] CreatePeople()
        {
            Person[] table = new Person[10];

            table[0] = new Person("Jan", "Kowalski", 24, 175.5m);
            table[1] = new Person("Adam", "Kowalski", 27, 105.5m);
            table[2] = new Person("Pawel", "Kowalski", 31, 134.5m);
            table[3] = new Person("Bartosz", "Nowak", 28, 156.5m);
            table[4] = new Person("Jan", "Kowalski", 12, 179.5m);
            table[5] = new Person("Katarzyna", "Kowalska", 45, 125.5m);
            table[6] = new Person("Jan", "Kowalski", 12, 114.5m);
            table[7] = new Person("Jan", "Kowalski", 6, 211.5m);
            table[8] = new Person("Jan", "Kowalski", 45, 205.5m);
            table[9] = new Person("Anna", "Nowak", 16, 160.5m);

            return table;
        }
    }

    class Person
    {
        private string _name;
        private string _surname;
        private int _age;
        private decimal _height;

        public int GetAge()
        {
            return _age;
        }

        public Person(string name, string surname, int age, decimal height)
        {
            _name = name;
            _surname = surname;
            _age = age;
            _height = height;
        }

        public string GetName()
        {
            return _name;
        }

        public override string ToString()
        {
            //return "[Name:" + _name + ", Surname:" + _surname + ", Age:" + _age + ", Height:" + _height + "]";

            return string.Format("[Name: {0}, Surname: {1}, Age: {2}, Height: {3}]", _name, _surname, _age, _height);
        }
    }



    public class Calculator
    {
        private decimal value;

        public decimal GetCurrentValue()
        {
            return value;
        }

        public void Add(decimal a)
        {
            
        }

        public void Subtract(decimal b)
        {
            
        }

        public void MultipleBy(decimal b)
        {

        }

        public void DivideBy(decimal b)
        {
            
        }

        public void Clear()
        {
            
        }

        // M+
        public void MemoryAdd()
        {
            
        }

        // M-
        public void MemorySubtract()
        {
            
        }

        // MR
        public void MemoryRecall()
        {
            
        }

        // MC
        public void MemoryClear()
        {
            
        }
    }































}
