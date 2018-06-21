using System;

namespace Objects2
{
    interface INamedObject
    {
        string Name { get; }
        string Name2 { get; }
    }

    abstract class Figure
    {
        protected int x;

        public abstract double CalculateArea();
        public abstract string GetDescription();

        protected Figure()
        {
            Console.WriteLine("sdasdsad");
        }
    }

    class Rectangle : Figure, INamedObject
    {
        private readonly double _a;
        private readonly double _b;

        public Rectangle(double a, double b)
        {
            _a = a;
            _b = b;
        }

        public override double CalculateArea()
        {
            return _a*_b;
        }

        public override string GetDescription()
        {
            return "dsfsd";
        }

        public string Name
        {
            get { return "Rectangle " + _a + "*" + _b; }
        }

        public virtual string Name2
        {
            get { return "Rectangle " + _a + "*" + _b; }
        }
    }

    class Square : Rectangle
    {
        private readonly int _a;

        public Square(int a) : base(a,a)
        {
            _a = a;
        }

        public new string Name
        {
            get { return "Square " + _a + "*" + _a; }
        }

        public override string Name2
        {
            get { return "Square " + _a + "*" + _a; }
        }
    }
}
