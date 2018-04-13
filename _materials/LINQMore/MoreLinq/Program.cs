using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MoreLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Sets();
            Strings();

            var paulina = new Person("PG", "c#, seLeNiuM");

            var pizzaGuild = new Guild("Software Assasination");
            pizzaGuild.AddPerson(new Person("G", "C#, UnitTests, EatPizza"));
            pizzaGuild.AddPerson(new Person("J", "c#, testing"));
            pizzaGuild.AddPerson(paulina);

            var ddd = new Guild("DDDD");
            ddd.AddPerson(new Person("PI", "C#,Unittests  ,  C++"));
            ddd.AddPerson(paulina);

            List<Guild> allIntiveGuilds = new List<Guild>();
            allIntiveGuilds.Add(pizzaGuild);
            allIntiveGuilds.Add(ddd);

            //ListAllPeopleInGuilds(allIntiveGuilds);
            ListUniqueSkills(allIntiveGuilds);

            Console.WriteLine("ENTER to exit.");
            Console.ReadLine();
        }

        private static void Strings()
        {

            var text1 = "Ala ma kota i psa.";
            var text2 = "mA kota";

            var c = text1.Contains(text2);

            var found = text1.IndexOf(text2, StringComparison.InvariantCultureIgnoreCase) >= 0;

            ////text2.StartsWith()
            //text2.EndsWith()

        }

        private static void Sets()
        {
            List<int> a = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> b = new List<int>() { 4, 5, 6, 7, 8, 9 };

            var i = a.Intersect(b);
            var e = a.Except(b);
            var u = a.Union(b);
            var c = a.Concat(b);

            string x = a.Aggregate("", (s, element) => s == String.Empty ? element.ToString() : s + ", " + element.ToString());


        }

        private static void ListUniqueSkills(List<Guild> guilds)
        {
            var allSkills =
                guilds.SelectMany(g => g.People).SelectMany(p => p.skills).Select(skill => skill.Name).Distinct(new IgnoreCaseComparer());

            allSkills.ToList().ForEach(Console.WriteLine);
        }

        private static void ListAllPeopleInGuilds(List<Guild> guilds)
        {
            var merged1 = guilds.SelectMany(g => g.People).Select(person => person.Name).Distinct();

            merged1.ToList().ForEach(Console.WriteLine);

            /*var merged2 = guilds.Select(g => g.People);


            foreach (var guild in guilds)
            {
                foreach (var person in guild.People)
                {
                    Console.WriteLine(person);
                }
                
            }*/
        }
    }

    internal class IgnoreCaseComparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return string.Equals(x, y, StringComparison.InvariantCultureIgnoreCase);
        }

        public int GetHashCode(string obj)
        {
            return 1;
        }
    }
}
