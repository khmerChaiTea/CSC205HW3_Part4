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
            System.Console.SetOut(sw);
            string expected = "1/2\r\n"; // Expected output from WriteRational

            // Act
            Rational.WriteRational(rational);
            string actual = sw.ToString();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}