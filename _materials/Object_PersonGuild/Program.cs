using System;
using System.Linq;

namespace ClassSamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PrintPeople(arrayOfPerson);
            int counter = CountUnder18(arrayOfPerson);
            Console.WriteLine(counter);
            string oldestPersonName = OldestPersonName(arrayOfPerson);
            Console.WriteLine("Oldest person name:" + oldestPersonName);
            PrintAverageAge(arrayOfPerson);

            Guild guild = new Guild("iDroids", arrayOfPerson);
            guild.AddNewMember(new Person("Paweł", 20));
            guild.RemoveMemberAtIndex( 1 );*/

            var arrayOfPerson = CreateSamplePeople();

            var lastOne1 = arrayOfPerson[arrayOfPerson.Length - 1];
            var lastOne2 = arrayOfPerson.Last();

            Console.WriteLine(lastOne1);
            Console.WriteLine(lastOne2);

            Console.ReadLine();
        }

        private static void PrintPeople(Person[] arrayOfPerson)
        {
            // in for loop print people on screen
            foreach (var person in arrayOfPerson)
            {
                Console.WriteLine(person);
            }
        }

        private static int CountUnder18(Person[] arrayOfPerson)
        {
            int under18 = 0;

            foreach (var person in arrayOfPerson)
            {
                if (person.Age < 18)
                {
                    under18 = under18 + 1;
                }
            }

            return under18;
        }

        private static string OldestPersonName(Person[] arrayOfPerson)
        {
            var selectedPerson = arrayOfPerson[0];

            foreach (var person in arrayOfPerson)
            {
                if (person.Age > selectedPerson.Age)
                {
                    selectedPerson = person;
                }
            }

            return selectedPerson.Name;
        }

        private static void PrintAverageAge(Person[] arrayOfPerson)
        {
            decimal sum = 0;

            // Sum
            for (int i = 0; i < arrayOfPerson.Length; i++)
            {
                sum += arrayOfPerson[i].Age;
            }

            // Average
            decimal average = sum / arrayOfPerson.Length;

            Console.WriteLine("Average age in this group is: " + average);
        }


        private static Person[] CreateSamplePeople()
        {
            // Create array with 5 sample people
            Person[] array = new Person[5];
            array[0] = new Person("Piotr", 10);
            array[1] = new Person("Kasia", 28);
            array[2] = new Person("Gosia", 25);
            array[3] = new Person("Stefan", 3);
            array[4] = new Person("Tadeusz", 5);
            return array;
        }
    }
}
