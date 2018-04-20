using System;
using TheDevice;

public static class Algo
{
    public static void Run()
    {
        //System.Console.WriteLine( IsPrime(31));
        // 1. Prime numbers: 1-100
        for (int p = 2; p < 100; p++)
        {
            if (IsPrime(p))
            {
                System.Console.Write(p);
                System.Console.Write(' ');
            }
        }

        // Sample device to bitmap usage
        TheDevice.TheDevice.Resize(200, 200);
        TheDevice.TheDevice.SetPixel(10, 10, true);
        TheDevice.TheDevice.Visualize(false, "sampleBitmap.bmp");

        // 1,2,3,4 as methods (variable visibility, parameters, output value, recursion)
        // (skip) The device : Sierpinski carpet (recursion on graph), change the device.

        // HW. (method) Greatest common divisor GCD(6,10)=2
        // HW. (method) Least common multiple LCD(6,10)=30
        // (skip) HW. (recursion method) Fibbonaci numbers < 100 : f(1) = 1, f(2) = 1, f(n)=f(n-1)+f(n-2)

        // HW: (challange) Highest prime (long) number challange 
        // HW: (challange) Highest number (long) with maximum number of divisors long.MaxValue
        // HW(Hard): The Device: Fibbonaci numbers
        // HW(Hard): The Device: Ulam spiral (prime numbers)
        TheDevice.TheDevice.Resize(200, 200);
        int x = 100, y = 100, i = 1, n = 30000;
        int movesInDirection = 0, direction = 0;
        int maxMoves = 0;
        int nextMoves = 1;

        System.Console.WriteLine();

        while (i < n)
        {
            movesInDirection++;
            if (IsPrime(i))
            {
                TheDevice.TheDevice.SetPixel(x, y, true);
            }
            System.Console.WriteLine($"{i}: ({x},{y}) dir:{direction} {movesInDirection}/{maxMoves},{nextMoves}");


            if (movesInDirection >= maxMoves)
            {
                direction = (direction + 1) % 4;
                movesInDirection = 0;

                if (nextMoves > maxMoves)
                {
                    maxMoves = nextMoves;
                }
                else
                {
                    nextMoves++;
                }
            }

            if (direction == 1)
            {
                x++;
            }
            if (direction == 2)
            {
                y--;
            }
            if (direction == 3)
            {
                x--;
            }
            if (direction == 0)
            {
                y++;
            }



            i++;
        }
        TheDevice.TheDevice.Visualize(false, "ulam.bmp");


        System.Console.WriteLine();
    }

    private static bool IsPrime(int number)
    {
        bool isPrime = true;

        for (int j = 2; j < number; j++)
        {
            if (number % j == 0)
            {
                isPrime = false;
                break; // optional
            }
        }

        return isPrime;
    }
}