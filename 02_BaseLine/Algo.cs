using System;
using TheDevice;

public static class Algo
{
    public static void Run()
    {
        //System.Console.WriteLine( IsPrime(31));
        // 1. Prime numbers: 1-100
        for (int i = 2; i < 100; i++)
        {
            if (IsPrime(i))
            {
                System.Console.Write(i);
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