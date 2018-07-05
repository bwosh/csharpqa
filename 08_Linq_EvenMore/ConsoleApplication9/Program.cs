using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            var p1 = new Person("Arek", "G");
            var p2 = new Person("Jan", "G");
            var p3 = new Person("Kasia", "W");
            var p4 = new Person("Przemo", "J");
            var p5 = new Person("Błażej", "M");
            var p6 = new Person("Piotr", "B");
            var p7 = new Person("PrzemoX", "P");

            List<PersonPoints> personPoints = new List<PersonPoints>();

            personPoints.Add(new PersonPoints { Person = p1, Points = 12 });
            personPoints.Add(new PersonPoints { Person = p2, Points = 12 });
            personPoints.Add(new PersonPoints { Person = p3, Points = 523 });
            personPoints.Add(new PersonPoints { Person = p4, Points = 5 });
            personPoints.Add(new PersonPoints { Person = p5, Points = 12 });
            personPoints.Add(new PersonPoints { Person = p6, Points = 5 });
            personPoints.Add(new PersonPoints { Person = p7, Points = 3 });

            var first5people = personPoints.Skip(1).Take(3);
            Debug.WriteLine(GetPeopleText(first5people));

            //string y = personPoints.Count > 10 ? "tak" : "nie";

            //var sum = personPoints.Select(pp => pp.Points).Sum();
            //Debug.WriteLine(sum);

            // dictinct points
            var distinctPoints = personPoints.Select(pp => pp.Points).Distinct();

            // sort, 
            var sortedDistinctPoints = distinctPoints.OrderByDescending(p => p);

            // get top 3
            var top3pointValues = sortedDistinctPoints.Take(3);

            // get people with those points & assign people
            //var top3PointsPeople = personPoints.Where(pp => top3pointValues.Contains(pp.Points));
            var top3PointsPeople = top3pointValues.Select(p => personPoints.Where(pp => pp.Points == p).ToList()).ToList();

            // write the result
            for (int i = 1; i <= top3PointsPeople.Count(); i++)
            {
                var listOfPeople = top3PointsPeople[i - 1];
                for (int l = 0; l < listOfPeople.Count; l++)
                {
                    var personWithPoints = listOfPeople[l];
                    Console.WriteLine(i.ToString() + " - " + personWithPoints.Points + " - " + personWithPoints.Person.ToString());
                }
            }


        }

        static string GetPeopleText(IEnumerable<PersonPoints> listOfPeopleWithPoints)
        {
            return listOfPeopleWithPoints.Aggregate("", (previous, item) => previous == "" ? item.ToString() : previous + "," + item.ToString());
        }
    }
}
