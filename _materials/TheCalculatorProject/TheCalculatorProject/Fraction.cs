using System;

namespace TheCalculatorProject
{
    public class Fraction
    {
        private int _numerator;
        private int _denominator;

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;

            if (denominator == 0)
            {
                throw new DivideByZeroException("Denominator should be different then 0.");
            }

            if (_denominator < 0)
            {
                SwitchNegativityOfNumeratorAndDenominator();
            }
        }

        // 0.43(12) -> Fraction(0.43, 2, 12);
        public Fraction(decimal fixedPart, int numberOfDigitsForCycle, int cycleValue)
        {
            // TODO implement me please :)
        }

        public int Numerator
        {
            get { return _numerator; }
        }

        public int Denominator
        {
            get { return _denominator; }
        }

        public void Normalize()
        {
            int bcd = MathHelper.BiggestCommonDivider(Numerator, Denominator);
            _denominator = _denominator / bcd;
            _numerator = _numerator / bcd;

            if (_denominator < 0 && _numerator < 0)
            {
                SwitchNegativityOfNumeratorAndDenominator();
            }
        }

        private void SwitchNegativityOfNumeratorAndDenominator()
        {
            _denominator = -_denominator; // two different ways of mltiplying by -1
            _numerator *= -1;
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}", Numerator, Denominator);
        }
    }
}
