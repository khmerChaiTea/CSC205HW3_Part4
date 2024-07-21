using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RationalNumber
{
    public class Program
    {
        // Main method to demonstrate usage
        public static void Main(string[] args)
        {
            // Create a Rational object using default constructor
            Rational r1 = new Rational();
            Console.Write("Default rational number: ");
            r1.WriteRational();  // Output: 0/1

            // Create a Rational object using parametric constructor
            Rational r2 = new Rational(3, 5);
            Console.Write("Parametric rational number: ");
            r2.WriteRational();  // Output: 3/5

            // Test Negate method
            Console.Write("Negating r2: ");
            r2.Negate();
            r2.WriteRational();  // Output: -3/5

            // Test Invert method
            Console.Write("Inverting r2: ");
            r2.Invert();
            r2.WriteRational();  // Output: 5/-3 (reduced form will be handled by WriteRational method)

            // Test ToDouble method
            Console.WriteLine($"r2 as a double: {r2.ToDouble()}");  // Output: -1.66666666666667

            // Test Reduce method
            Rational r3 = new Rational(16, 24);
            Console.Write("Reduced form of 16/24: ");
            r3.Reduce();
            r3.WriteRational();  // Output: 2/3

            // Test Add method
            Rational r4 = new Rational(1, 2);
            r4.Add(new Rational(1, 3));
            Console.Write("Sum of 1/2 and 1/3: ");
            r4.WriteRational();  // Output: 5/6

            //// 2. Make a few mistakes. Try invoking static methods as if they were instance methods
            //// and vice-versa. Try to get a sense for what is legal and what is not,
            //// and for the error messages that you get when you mess up.
            //// Attempting to call a static method as an instance method
            //MathOperations math = new MathOperations();
            //int result = math.Add(3, 5); // This will cause a compilation error
            //// Error: CS0176  Member 'MathOperations.Add(int, int)' cannot be accessed
            //// with an instance reference; qualify it with a type name instead

            //// Attempting to call an instance method as a static method
            //Person.SayHello(); // This will cause a compilation error
            //// Error: CS0120 An object reference is required for the non-static field,
            //// method, or property 'Person.SayHello()'

            // Conclusion:
            // When encountering errors related to method invocation in C#, always ensure that:
            // Static methods are accessed using the class name(ClassName.MethodName()).
            // Instance methods are called on an instance of the class (instance.MethodName()).
        }
    }
}
