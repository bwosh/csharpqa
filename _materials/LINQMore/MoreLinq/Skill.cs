namespace MoreLinq
{
    internal class Skill
    {
        public string Name { get; set; }

        public Skill(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return $"Name: {Name}";
        }


    }
}