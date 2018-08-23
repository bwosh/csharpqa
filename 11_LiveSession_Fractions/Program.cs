using System;

namespace a
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new Fraction("1,3", "3333");
            Console.WriteLine(f.ToString());
        }
    }

    class Fraction
    {
        public bool Sign { get; set; } // true +, false -
        public int Nominator { get; set; }
        public int Denominator { get; set; }

        public Fraction(string fixedDecimal) : this(fixedDecimal, null) // optionally add parameter with culture for parsing
        {
            // nothing more to do
        }

        // 1.23(44444) -->   1.23 | 4
        public Fraction(string fixedPart, string periodicPart)
        {
            // TODO
            decimal parsedValue;
            if (!decimal.TryParse(fixedPart, out parsedValue))
            {
                throw new Exception("Could not parse fixed part");
            }

            // Fixed part calculation
            Sign = parsedValue >= 0;

            var absParsedValue = Math.Abs(parsedValue);

            int numbersAfterDot = GetNumbersAfterDot(absParsedValue);

            Denominator = Pow10(numbersAfterDot);
            checked
            {
                Nominator = (int)(absParsedValue * (decimal)Denominator); // TODO what if overflows
            }

            // Periodic part calculation
            if (periodicPart != null)
            {
                var periodicFraction = GetPeriodicPart(periodicPart);
                periodicFraction.Denominator *= Denominator;

                Console.WriteLine(this.ToString()+"+"+periodicFraction.ToString());
                var added = Add(this, periodicFraction);
                this.Nominator = added.Nominator;
                this.Denominator = added.Denominator;
            }

            Simplify();
        }

        private static Fraction Add(Fraction a, Fraction b)
        {
            var result = new Fraction("0", null);

            result.Nominator = b.Nominator*a.Denominator+b.Denominator*a.Nominator;
            result.Denominator = a.Denominator*b.Denominator;
            //result.Simplify();
            return result;
        }

        private Fraction GetPeriodicPart(string text)
        {
            // TODO handle empty string

            var result = new Fraction("0", null);
            result.Nominator = int.Parse(text); // TODO handle negative values 
            result.Denominator = Pow10(text.Length)-1;

            return  result;
        }

        private void Simplify()
        {
            var gcd = GCD(Nominator, Denominator);
            Nominator /= gcd;
            Denominator /= gcd;
        }

        private static int GCD(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }

            if (b == 0)
            {
                return a;
            }

            return GCD(b, a % b);
        }

        private static int GetNumbersAfterDot(decimal value)
        {
            if (value == Math.Floor(value))
            {
                return 0;
            }

            return 1 + GetNumbersAfterDot(value * 10);
        }

        private static int Pow10(int exponent)
        {
            int result = 1;

            for (int i = 0; i < exponent; i++)
            {
                result *= 10;
            }

            return result;
        }

        public override string ToString()
        {
            string result = "";

            if (!Sign)
            {
                result += "-";
            }

            result += Nominator.ToString();
            result += "/";
            result += Denominator.ToString();

            return result;
        }
    }
}
