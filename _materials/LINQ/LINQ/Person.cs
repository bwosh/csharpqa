using System;

namespace LINQTest
{
    class Person
    {
        private readonly int _age;
        private readonly string _name;

        public int Age
        {
            get { return _age; }
        }

        public string Name
        {
            get { return _name; }
        }

        public Person(int age, string name)
        {
            _age = age;
            _name = name;
        }

        public override string ToString()
        {
            return String.Format("Age: {0}, Name: {1}", Age, Name);
        }
    }
}