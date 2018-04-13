using System.Collections.Generic;
using System.Linq;

namespace MoreLinq
{
    class Person
    {
        public string Name { get; set; }
        public List<Skill> skills { get; set; }
        public Person(string name, string commaSeparatedSkills)
        {
            Name = name;
            skills = new List<Skill>();
            var skillNames = commaSeparatedSkills.Split(',').Select(s => s.Trim(' '));

            skills.AddRange(skillNames.Select(str => new Skill(str)));
        }

        public override string ToString()
        {
            return $"Name: {Name}, skills: {skills}";
        }

    }
}