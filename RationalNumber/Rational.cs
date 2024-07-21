using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Rational
    {
        // Fields to store numerator and denominator
        private int numerator;
        private int denominator;

        // Default constructor that initializes the rational number to 0/1
        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        // Parametric constructor that initializes the rational number with given numerator and denominator
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
        }

        // Properties to access numerator and denominator
        public int Numerator { get { return numerator; } }
        public int Denominator { get { return denominator; } }

        // 1. Transform the methods in the Rational class from static methods
        // to instance methods, and make the necessary changes in Main.
        // Method to write rational number
        public void WriteRational()
        {
            Console.WriteLine($"{numerator}/{denominator}");
        }

        // Method to negate the rational number (reverse its sign)
        public void Negate()
        {
            this.numerator = -this.numerator;
        }

        // Method to invert the rational number (swap numerator and denominator)
        public void Invert()
        {
            int temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;
        }

        // Method to convert the rational number to a double
        public double ToDouble()
        {
            return (double)numerator / denominator;
        }

        // Method to reduce the rational number to its lowest terms without modifying the object
        public void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;
        }

        // Method to add another Rational object to this Rational object
        public void Add(Rational other)
        {
            numerator = numerator * other.denominator + other.numerator * denominator;
            denominator *= other.denominator;
            Reduce();
        }

        // Method to calculate the greatest common divisor (GCD) using Euclid's algorithm
        // Ex. GCD(2,3) => (temp = 3, b = 2 % 3 => 2, a = 3) which returned 3 as gcd
        // numerator become 2/3 and denominator become 3/3
        private int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
