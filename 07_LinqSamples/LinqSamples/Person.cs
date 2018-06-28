namespace LinqSamples
{
    class Person
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public SexType Sex { get; set; }
        public float Weight { get; set; }

        public Person(int age, string name, SexType sex, float weight)
        {
            Age = age;
            Name = name;
            Sex = sex;
            Weight = weight;
        }

        public override string ToString()
        {
            return Name + "," + Age;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}