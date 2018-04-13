using NUnit.Framework;

namespace TheCalculatorProject.Tests
{
    [TestFixture]
    public class FractionTests
    {
        [Test]
        public void InitializationOfFraction()
        {
            // Arrange
            int numerator = 1;
            int denominator = 2;

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(numerator, fractionInstance.Numerator);
            Assert.AreEqual(denominator, fractionInstance.Denominator);
        }

        [Test]
        public void InitializationOfFraction_NegativeNumerator()
        {
            // Arrange
            int numerator = -1;
            int denominator = 2;

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(numerator, fractionInstance.Numerator);
            Assert.AreEqual(denominator, fractionInstance.Denominator);
        }

        [Test]
        public void InitializationOfFraction_NegativeDenominator()
        {
            // Arrange
            int numerator = 1;
            int denominator = -2;

            int expectedNumerator = -1;
            int expectedDenominator = 2;

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedNumerator, fractionInstance.Numerator);
            Assert.AreEqual(expectedDenominator, fractionInstance.Denominator);
        }

        [Test]
        public void InitializationOfFraction_BothNegative()
        {
            // Arrange
            int numerator = -1;
            int denominator = -2;

            int expectedNumerator = 1;
            int expectedDenominator = 2;

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedNumerator, fractionInstance.Numerator);
            Assert.AreEqual(expectedDenominator, fractionInstance.Denominator);
        }

        [Test]
        [ExpectedException]
        public void InitializationOfFraction_DenominatorEqualToZero()
        {
            // Arrange
            int numerator = 1;
            int denominator = 0;

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
        }

        [Test]
        public void TextRepresentation()
        {
            // Arrange
            int numerator = 1;
            int denominator = 2;
            string expectedRepresentation = "1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void TextRepresentation_DoNotNormalizeOnCreation()
        {
            // Arrange
            int numerator = 2;
            int denominator = 4;
            string expectedRepresentation = "2/4";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void TextRepresentation_NegativeRepresentation()
        {
            // Arrange
            int numerator = 1;
            int denominator = -2;
            string expectedRepresentation = "-1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void TextRepresentation_BothNegative()
        {
            // Arrange
            int numerator = -1;
            int denominator = -2;
            string expectedRepresentation = "1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void Normalization()
        {
            // Arrange
            int numerator = 2;
            int denominator = 4;
            string expectedRepresentation = "1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void NormalizationLotsOfOptionsToNormalize()
        {
            // Arrange
            int numerator = 128;
            int denominator = 256;
            string expectedRepresentation = "1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void DoNotNormalizeWhenNotPossible()
        {
            // Arrange
            int numerator = 17;
            int denominator = 31;
            string expectedRepresentation = "17/31";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void NormalizeNegativeNumeratorDenumerator()
        {
            // Arrange
            int numerator = -2;
            int denominator = -4;
            string expectedRepresentation = "1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void NormalizeNegativeNumerator()
        {
            // Arrange
            int numerator = -2;
            int denominator = 4;
            string expectedRepresentation = "-1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void NormalizeNegativeDenominator()
        {
            // Arrange
            int numerator = 2;
            int denominator = -4;
            string expectedRepresentation = "-1/2";

            // Act
            var fractionInstance = new Fraction(numerator, denominator);
            fractionInstance.Normalize();

            // Assert
            Assert.AreEqual(expectedRepresentation, fractionInstance.ToString());
        }

        [Test]
        public void Test_RationalNumber()
        {
            // Arrange

            // 0.(3)
            decimal fixedPart = 0m;
            int digitsOfCycle = 1;
            int cycleValue = 3;

            string expectedTextRepresentation = "1/3";

            // Act
            var fraction = new Fraction(fixedPart, digitsOfCycle, cycleValue);
            var textRepresentation = fraction.ToString();

            // Assert
            Assert.AreEqual(expectedTextRepresentation, textRepresentation);
        }

        [Test]
        public void Test_RationalNumber_WithFixedPart()
        {
            // Arrange

            // 0.1(3)
            decimal fixedPart = 0.1m;
            int digitsOfCycle = 1;
            int cycleValue = 3;

            string expectedTextRepresentation = "4/30";

            // Act
            var fraction = new Fraction(fixedPart, digitsOfCycle, cycleValue);
            var textRepresentation = fraction.ToString();

            // Assert
            Assert.AreEqual(expectedTextRepresentation, textRepresentation);
        }

        [Test]
        public void Test_RationalNumber_BiggerCycle()
        {
            // Arrange

            // 0.4(123) = 0.4123123123123123123123.....
            decimal fixedPart = 0.4m;
            int digitsOfCycle = 3;
            int cycleValue = 123;

            string expectedTextRepresentation = "4119/9990";

            // Act
            var fraction = new Fraction(fixedPart, digitsOfCycle, cycleValue);
            var textRepresentation = fraction.ToString();

            // Assert
            Assert.AreEqual(expectedTextRepresentation, textRepresentation);
        }
    }
}
