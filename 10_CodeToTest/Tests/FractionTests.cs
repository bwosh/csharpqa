using CodeToTest;
using NUnit.Framework;

namespace Tests
{
    public class FractionTests
    {
        [Test]
        public void OneDigitFraction()
        {
            // Assign
            var classToTest = new ClassToTest();

            string input = "0.2";
            int expectedNumerator = 1;
            int expectedDenominator = 5;

            // Act
            var result = classToTest.ToFraction(input);

            // Assert
            Assert.IsNotNull(result,"No fraction was returned.");
            Assert.AreEqual(expectedNumerator, result.Numerator, "Numerator value was incorrect.");
            Assert.AreEqual(expectedDenominator, result.Denominator,"Denominator value was incorrect.");
        }

        [Test]
        [ExpectedException]
        public void ExpectedExceptionSample()
        {
            
        }

        /*
         * useful methods:
         * int.Parse("34")
         * ".".StartsWith(".")
         * ".".EndsWith(".")
         * ",".Replace(",",".")
         *
            0     0/0
            -1    -1/1
            20    20/1
            abc   Exception    
            ;     Exception
            ;;    Exception
            ""    Exception
            NULL  Exception 
            12.34 617/50
            12:34 Exception
            12'34 Exception
            0.6   3/5
            0.6.1 Exception
            0.    Exception
            .     Exception
            .2    Exception
            0.123456789  123456789/10000000000
            0.100000000  1/10
            -0.1         -1/10
            -0.6         -3/5
            -0           Exception
            -.4          Exception
            -.           Exception
            3;4;5;       Exception
            (2)          Exception
            (3,4)        Exception
            2 3          Exception
            4. 5         Exception
            4.5 (space in the end) Exception
            2147483647.0       2147483647/1
            2147483647.1       Exception
            214748364.7        2147483647/10
            214748364.8        Exception
            0.0000000001       1/10000000000
            0.00000000001      Exception
            1,2.3 Exception
            12,34   617/50
         */
    }
}
