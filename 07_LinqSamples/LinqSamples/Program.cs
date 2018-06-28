using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person(17, "Przemek", SexType.Male, 0.4f);
            var j = new Person(160, "Janek", SexType.Male, 0.3f);
            var k = new Person(15, "Kasia", SexType.Female, 0.2f);
            var a = new Person(14, "Arek", SexType.Male, 0.1f);

            var peopleList = new List<Person>();
            var peopleQueue = new Queue<Person>();
            var peopleStack = new Stack<Person>();

            // List
            peopleList.Add(a);
            peopleList.AddRange(new[] { p, j, k });

            //peopleList.RemoveAt(2);

            // Queue
            peopleQueue.Enqueue(a);
            peopleQueue.Enqueue(k);
            var nextPerson = peopleQueue.Dequeue();
            Console.WriteLine(nextPerson);

            // Stack
            peopleStack.Push(j);
            peopleStack.Push(p);
            var onTheTop = peopleStack.Pop();
            Console.WriteLine(onTheTop);

            p.Name = "RODO";

            // life without LINQ 
            var youngerThan15 = new List<Person>();
            for (int i = 0; i < peopleList.Count; i++)
            {
                if (peopleList[i].Age < 15)
                {
                    youngerThan15.Add(peopleList[i]);
                }
            }

            foreach (var person in peopleList)
            {
                if (person.Age < 15)
                {
                    youngerThan15.Add(person);
                }
            }

            // LINQ
            var yt15 = peopleList.Where(pe => pe.Age < 15);
            var yt15a = peopleList.Where(CheckIfPersonIsBelow15);
            var userNames = peopleList.Select(pe => pe.Name).ToList();
            var orderedByAge = peopleList.OrderBy(pe => pe.Age);
            //var orderedByAge = peopleList.OrderByDescending(pe => pe.Name);
            var anyFemale = peopleList.Any(pe => pe.Sex == SexType.Female);
            var anyFemale2 = peopleList.Where(pe => pe.Sex == SexType.Female).ToList().Count > 0;
            var onlyMale = peopleList.All(pe => pe.Sex == SexType.Male);

            var x = new List<Person>().Any(pe=>true);
            var y = new List<Person>().All(pe => true);

            var lastPerson = peopleList.Last();
            var lastEmptyPerson = new List<Person>().LastOrDefault();
            var firstPerson = peopleList.First(pe=>pe.Sex==SexType.Female);

            int aaa = 1;
            int? bbb = 1;
            Nullable<int> bbb2 = 1;

            int ccc = aaa + bbb.Value;

            var women = peopleList.Single(pe => pe.Sex == SexType.Female);

            var allMan = peopleList.Where(z => z.Sex == SexType.Male);
            var olderThen14 = peopleList.Where(z => z.Age > 14);

            var concetenated = allMan.Concat(olderThen14).ToList();
            var union = allMan.Union(olderThen14).ToList();
            var intersect = allMan.Intersect(olderThen14).ToList();
            var except = allMan.Except(olderThen14).ToList();

            var winners = peopleList.Where(pe =>
            {
                Console.WriteLine(pe.Age);
                return pe.Age > 15;
            }).Union(peopleList.Where(c => c.Weight > 0.34));
        }

        static bool CheckIfPersonIsBelow15(Person p)
        {
            return p.Age < 15;
        }
    }
}
