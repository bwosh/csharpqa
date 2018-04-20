public static class Algo
{
    public static void Run()
    {
        // 1. Prime numbers: 1-100
        for (int i = 2; i < 100; i++)
        {
            bool isPrime = true;
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    isPrime = false;
                    break; // optional
                }
            }

            if (isPrime)
            {
                System.Console.Write(i);
                System.Console.Write(' ');
            }
        }

        // 1,2,3,4 as methods (variable visibility, parameters, output value, recursion)
        // The device : Sierpinski carpet (recursion on graph), change the device.

        // HW. (method) Greatest common divisor GCD(6,10)=2
        // HW. (method) Least common multiple LCD(6,10)=30
        // HW. (recursion method) Fibbonaci numbers < 100 : f(1) = 1, f(2) = 1, f(n)=f(n-1)+f(n-2)

        // HW: (challange) Highest prime (long) number challange 
        // HW: (chalange) Highest number (long) with maximum number of divisors
        // HW(Hard): The Device: Fibbonaci numbers
        // HW(Hard): The Device: Ulam spiral (prime numbers)

        System.Console.WriteLine();
    }
}