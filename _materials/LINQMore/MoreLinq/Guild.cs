using System.Collections.Generic;

namespace MoreLinq
{
    internal class Guild
    {
        private readonly List<Person> _people;
        public string Name { get; }

        public IReadOnlyList<Person> People
        {
            get { return (IReadOnlyList<Person>)_people; }
        }

        public Guild(string name)
        {
            Name = name;
            _people = new List<Person>();
        }

        public void AddPerson(Person person)
        {
            _people.Add(person);
        }

        public override string ToString()
        {
            return $"Name: {Name}, People: {People}";
        }
    }
}