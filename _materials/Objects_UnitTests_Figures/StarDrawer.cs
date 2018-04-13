using System;

namespace Figures
{
    public class StarDrawer
    {
        public void DrawStars(int starsNumber)
        {
            for (int i = 0; i < starsNumber; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();
        }

        public void DrawStarsWithSpaces(int starsNumber)
        {
            for (int i = 0; i < starsNumber; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }

        public void DoubleStarPower(int n)
        {
            for (int j = 0; j < 2; j++)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("  **    ");
                }
                Console.WriteLine();
            }
        }
    }
}
