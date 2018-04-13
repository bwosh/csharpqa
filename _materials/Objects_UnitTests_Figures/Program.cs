using System;

namespace Figures
{
    public class Program
    {
        static void Main(string[] args)
        {
            // ====== Abstrahuje
            //PiDer abstrahuje = new PiDer();
            //Console.WriteLine(abstrahuje.GetArea());

            // ====== Star drawer
            //StarDrawer s = new StarDrawer();
            //s.DrawStars(12);
            //s.DrawStarsWithSpaces(12);
            //s.DoubleStarPower(4);

            // ===== Class modification methods
            Square s = new Square(1);
            s.DuplicateSideSize();
            s.DuplicateSideSize();
            s.DuplicateSideSize();
            int result = s.GetArea();

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
