using Microsoft.VisualStudio.TestTools.UnitTesting;
using RationalNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber.Tests
{
    [TestClass]
    public class RationalTests
    {
        [TestMethod]
        public void WriteRationalTest()
        {
            // Arrange
            Rational rational = new Rational(1, 2);
            System.IO.StringWriter sw = new System.IO.StringWriter();
            Console.SetOut(sw);  // Redirect console output to StringWriter
            string expected = "1/2\r\n"; // Expected output from WriteRational

            // Act
            rational.WriteRational();  // Call instance method on the object

            // Capture console output
            string actual = sw.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AddTest()
        {
            // Arrange
            Rational r1 = new Rational(1, 2);
            Rational r2 = new Rational(1, 3);
            Rational expected = new Rational(5, 6); // Expected result of adding 1/2 and 1/3

            // Act
            r1.Add(r2);

            // Assert
            Assert.AreEqual(expected.Numerator, r1.Numerator);
            Assert.AreEqual(expected.Denominator, r1.Denominator);
        }

        [TestMethod]
        public void InvertTest()
        {
            // Arrange
            Rational r = new Rational(3, 5);
            Rational expected = new Rational(5, 3); // Expected result after inverting 3/5

            // Act
            r.Invert();

            // Assert
            Assert.AreEqual(expected.Numerator, r.Numerator);
            Assert.AreEqual(expected.Denominator, r.Denominator);
        }

        [TestMethod]
        public void ToDoubleTest()
        {
            // Arrange
            Rational r = new Rational(2, 5);
            double expected = 0.4; // Expected result of converting 2/5 to double

            // Act
            double actual = r.ToDouble();

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ReduceTest()
        {
            // Arrange
            Rational r = new Rational(16, 24);
            Rational expected = new Rational(2, 3); // Expected result after reducing 16/24

            // Act
            r.Reduce();

            // Assert
            Assert.AreEqual(expected.Numerator, r.Numerator);
            Assert.AreEqual(expected.Denominator, r.Denominator);
        }
    }
}