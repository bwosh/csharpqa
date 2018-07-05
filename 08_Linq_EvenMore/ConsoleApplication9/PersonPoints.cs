namespace ConsoleApplication9
{
    class PersonPoints
    {
        public Person Person { get; set; }
        public int Points { get; set; }

        public override string ToString()
        {
            return Person.ToString() + ", points: " + Points;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }

        public Person(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public override string ToString()
        {
            return Name + " " + Surname;
        }
    }
}