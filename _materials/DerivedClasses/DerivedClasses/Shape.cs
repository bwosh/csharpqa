using System;

namespace DerivedClasses
{
    // -----------------------------------------------
    abstract class Shape
    {
        public abstract int GetArea();

        public void PrintArea2()
        {
            Console.WriteLine("My area is {0}", GetArea());
        }
    }

    interface IAwesomeClass
    {
        int GetVertexCount();
        int TereFere();
    }

    interface INamedShape
    {
        string GetShapeName();
        int TereFere();
    }
    // -----------------------------------------------
    class Rectangle : Shape, IAwesomeClass, INamedShape
    {
        private readonly int _a;
        private readonly int _b;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;
        }

        public override int GetArea()
        {
            return _a * _b;
        }

        public int GetVertexCount()
        {
            return 4;
        }

        int IAwesomeClass.TereFere()
        {
            return 123;
        }

        public string GetShapeName()
        {
            return "I am rectangle";
        }

        int INamedShape.TereFere()
        {
            return -123;
        }

        public virtual string GetShapeName2()
        {
            return "I am rectangle";
        }
    }
    // -----------------------------------------------
    class Square : Rectangle, INamedShape
    {
        public Square(int a) : base(a, a)
        {
        }

        public new string GetShapeName()
        {
            return "I am square";
        }

        public override string GetShapeName2()
        {
            return "I am square, but also" + base.GetShapeName2();
        }
    }
    // -----------------------------------------------
    class Circle : Shape
    {
        public override int GetArea()
        {
            return 0;
        }
    }
}
