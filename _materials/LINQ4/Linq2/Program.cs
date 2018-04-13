using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq2
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompareStrings("a", "A");

            Person p1 = new Person("Stefan");
            p1.Skills.Add("C++");

            Person p2 = new Person("Kasia");
            p2.Skills.Add("c++");
            p2.Skills.Add("C#");
            p2.Skills.Add("PHP");
            p2.Skills.Add("Java");

            Person p3 = new Person("Jadzia");
            p3.Skills.Add("PHP");

            Guild automation = new Guild("Automation");
            Guild pizza = new Guild("Pizza");

            automation.Add(p1);
            automation.Add(p2);

            pizza.Add(p2);
            pizza.Add(p3);

            var firstGroup = automation.People;
            var secondGroup = pizza.People;

            PrintPeopleInTwoGuilds(firstGroup, secondGroup);

            PrintSkillsOfGuilds(pizza, automation);

            string longString =
                "   dakfjsarkjfhreklfjlkadsjfkljsdalkfjdasklfjadsklfjladskfjlearjflksajgtHlkadsjgewrsgdfgdtytrfdcghytrfyt======";

            // This below works but is not what we want
            bool contains = longString.Contains('j', new MyAwesomeCharacterCompparer());

            bool containsString = longString.IndexOf("gth", StringComparison.CurrentCultureIgnoreCase) >= 0;

            Console.WriteLine("Contains:" + contains);
            //longString.StartsWith("da");
            //longString.EndsWith("da");
            string shorter = longString.Trim(' ', '=');
            string shorter1 = longString.TrimStart(' ', '!', '.');
            string shorter2 = longString.TrimEnd('=');


            //charactersToTrim.ToList().ForEach();
            string result = longString.Trim("ytda =".ToArray());

            Console.ReadLine();
        }

        private static void CompareStrings(string a, string b)
        {
            bool areEqual = a.Equals(b, StringComparison.CurrentCultureIgnoreCase);

            Console.WriteLine("Are {0} {1} equal ? {2}", a, b, areEqual);
        }

        private static void PrintSkillsOfGuilds(params Guild[] guilds)
        {
            var skillsList = guilds.SelectMany(g => g.People).SelectMany(p => p.Skills).Distinct().ToList();
            skillsList.ForEach(Console.WriteLine);
        }


        private static void PrintPeopleInTwoGuilds(List<Person> firstGroup, List<Person> secondGroup)
        {
            /*var bothGroupsPeople = firstGroup.Concat(secondGroup);
            var groupsIntersectPeople = firstGroup.Union(secondGroup);

            foreach (var person in groupsIntersectPeople)
            {
                Console.WriteLine(person.Name);
            }*/

            IEqualityComparer<string> comparer = new MyAwesomeStringCompparer();

            var a = firstGroup.Concat(secondGroup).Select(i => i.Name);
            var uniqueNamesList = a.Distinct(comparer).ToList();
            uniqueNamesList.ForEach(Console.WriteLine);

            /*foreach (var name in uniqueNames)
            {
                Console.WriteLine(name);
            }*/
        }
    }

    public class MyAwesomeStringCompparer : IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return true; //x.Length == y.Length; //x.Equals(y, StringComparison.CurrentCultureIgnoreCase);
        }


        // TODO what is this hash method
        public int GetHashCode(string obj)
        {
            return 0;
        }
    }

    public class MyAwesomeCharacterCompparer : IEqualityComparer<char>
    {
        public bool Equals(char x, char y)
        {
            return false;
        }


        // TODO what is this hash method
        public int GetHashCode(char obj)
        {
            return 0;
        }
    }
}
