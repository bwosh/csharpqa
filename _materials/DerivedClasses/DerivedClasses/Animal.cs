using System;

namespace DerivedClasses
{
    class Animal
    {
        protected string typeName;
        protected bool hasTail = false;

        public Animal()
        {
            Console.WriteLine("Constructor Animal");
            typeName = "AnimalType";
        }

        public string GetTypeName()
        {
            Console.WriteLine("Animal-GetTypeName");
            return typeName;
        }

        public override string ToString()
        {
            return string.Format("Animal {1} (hasTail={0})", hasTail, typeName);
        }
    }

    class AnimalWithLegs : Animal
    {
        private int numberOfLegs;

        public AnimalWithLegs(int legs)
        {
            Console.WriteLine("Constructor AnimalWithLegs");
            typeName = "AnimalWithLegs";
            numberOfLegs = legs;
        }

        public bool HasTail()
        {
            Console.WriteLine("AnimalWithLegs-HasTail");
            return hasTail;
        }

        public override string ToString()
        {
            return string.Format("AnimalWithLegs legs={0} ({1})", numberOfLegs, base.ToString());
        }
    }
}
