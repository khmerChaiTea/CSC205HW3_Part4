using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Rational
    {
        // 1. Create a new program called Rational.cs that defines a class named Rational.
        // A Rational object should have two integer fields to store the numerator and denominator.

        // Fields to store numerator and denominator
        private int numerator;
        private int denominator;

        // 2. Write a default constructor, one that takes no arguments,
        // and that sets the numerator to 0 and denominator to 1.
        // Default constructor that initializes the rational number to 0/1
        public Rational()
        {
            this.numerator = 0;
            this.denominator = 1;
        }

        // Constructor to initialize the Rational object with numerator and denominator
        // Constructor: Takes two integers (numerator and denominator) and initializes the Rational object.
        // 6. Write a parametric constructor for your class that takes two arguments and that uses them to initialize the fields.
        // Parametric constructor that initializes the rational number with given numerator and denominator
        public Rational(int numerator, int denominator)
        {
            this.numerator = numerator;
            this.denominator = denominator;
            Reduce(); // Reduce the fraction immediately
        }

        // 3. Write a method called WriteRational that takes a Rational object
        // as an argument and outputs it in some reasonable format.
        // Method to write the Rational object to console in a reasonable format
        public static void WriteRational(Rational rational)
        {
            Console.WriteLine($"{rational.numerator}/{rational.denominator}");
        }

        // 7. Write a method called Negate that reverses the sign of a rational number.
        // This method should be a modifier, so it should return void.
        // Add lines to Main to test the new method.
        // Method to negate the rational number (reverse its sign)
        public void Negate()
        {
            this.numerator = -this.numerator;
        }

        // 8. Write a method called Invert that inverts the number by swapping the
        // numerator and denominator. Add lines to Main to test the new method.
        // Method to invert the rational number (swap numerator and denominator)
        public void Invert()
        {
            int temp = this.numerator;
            this.numerator = this.denominator;
            this.denominator = temp;
        }

        // 9. Write a method called ToDouble that converts the rational number
        // to a double(floating-point number) and returns the result. This method
        // is a pure function; it does not modify the object. As always, test the new method.
        // Method to convert the rational number to a double
        public double ToDouble()
        {
            return (double)this.numerator / this.denominator;
        }

        // 10. Write a modifier named Reduce that reduces a rational number to its lowest terms by
        // finding the greatest common divisor (GCD) of the numerator and denominator and dividing through.
        // This method should be a pure function; it should not modify the fields of the object on which it is invoked
        // Method to reduce the rational number to its lowest terms without modifying the object
        public void Reduce()
        {
            int gcd = GCD(Math.Abs(numerator), Math.Abs(denominator));
            numerator /= gcd;
            denominator /= gcd;

            // Ensure the denominator is positive
            if (denominator < 0)
            {
                numerator = -numerator;
                denominator = -denominator;
            }
        }

        // 11. Write a method called Add that takes two Rational numbers as arguments and returns
        // a new Rational object. The return object should contain the sum of the arguments. There
        // are several ways to add fractions. You can use any one you want, but you should make sure
        // that the result of the operation is reduced so that the numerator and
        // denominator have no common divisor (other than 1).
        // Method to add two rational numbers and return a new Rational object with the result
        public static Rational Add(Rational r1, Rational r2)
        {
            int numerator = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            int denominator = r1.denominator * r2.denominator;
            return new Rational(numerator, denominator);
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
