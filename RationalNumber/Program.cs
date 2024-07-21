using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Program
    {
        // 4. Write a Main method that creates a new object with type Rational,
        // sets its fields to some values, and writes the object.
        // Main method to demonstrate usage
        // 5. At this stage, you have a minimal testable program. Test it and, if necessary, debug it.
        public static void Main(string[] args)
        {
            // Test the WriteRational method with a specific rational number
            Rational r1 = new Rational(3, 5);
            Console.Write("Rational number: ");
            Rational.WriteRational(r1);
            Console.WriteLine();

            // Test the default constructor and WriteRational method
            Rational r2 = new Rational();
            Console.Write("Default rational number: ");
            Rational.WriteRational(r2);
            Console.WriteLine();

            // Test parametric constructor and WriteRational method
            Rational r3 = new Rational(3, 5);
            Console.Write("Parametric rational number: ");
            Rational.WriteRational(r3);
            Console.WriteLine();

            // Test Negate method
            Console.Write("Negated rational number: ");
            r3.Negate();
            Rational.WriteRational(r3);
            Console.WriteLine();

            // Test Invert method
            Console.Write("Inverted rational number: ");
            r3.Invert();
            Rational.WriteRational(r3);
            Console.WriteLine();

            // Test ToDouble method
            Console.WriteLine($"Rational number as double: {r3.ToDouble()}");
            Console.WriteLine();

            // Test Add method
            Rational r4 = new Rational(1, 2);
            Rational r5 = new Rational(1, 3);
            Rational sum = Rational.Add(r4, r5);
            Console.Write("Sum of two rationals: ");
            Rational.WriteRational(sum);
            Console.WriteLine();
        }
    }
}
