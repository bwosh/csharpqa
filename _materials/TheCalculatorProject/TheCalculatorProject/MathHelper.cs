using System;

namespace TheCalculatorProject
{
    class MathHelper
    {
        public static int BiggestCommonDivider(int a, int b)
        {
            int aWithoutSign = Math.Abs(a); // a >= 0 ? a : -a;
            int bWithoutSign = Math.Abs(b); //b >= 0 ? b : -b;

            int min = Math.Min(aWithoutSign, bWithoutSign);
            for (int i = min; i >= 2; i--)
            {
                if (aWithoutSign % i == 0 && bWithoutSign % i == 0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
