using System;

namespace DerivedClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Square(2);
            var r = new Rectangle(3, 4);
            var c = new Circle();

            SpecificBehaviour(r);

            Console.ReadLine();
        }

        static void PrintArea(Shape r)
        {
            Console.WriteLine(r.GetArea());
        }

        static void SpecificBehaviour(Shape r)
        {
            if (r is INamedShape)
            {
                INamedShape namedShape = (INamedShape)r;
                Console.WriteLine(namedShape.GetShapeName());
            }
            else
            {
                Console.WriteLine("not supported.");
            }
        }
    }
}
