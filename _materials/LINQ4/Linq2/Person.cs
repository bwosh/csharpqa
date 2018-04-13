using System.Collections.Generic;

namespace Linq2
{
    class Person
    {
        public string Name { get; }

        public List<string> Skills { get; } 

        public Person(string name)
        {
            Name = name;
            Skills = new List<string>();
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }
    }

    class Guild
    {
        public string Name { get; }

        public List<Person> People
        {
            get { return _people; }
        }

        private readonly List<Person> _people;

        public Guild(string name)
        {
            Name = name;
            _people = new List<Person>();
        }

        public void Add(Person person)
        {
            _people.Add(person);
        }
    }
}