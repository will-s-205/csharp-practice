// use in terminal: 
// dotnet run .\mathOperations.cs
// to see the output of the program
using System;

public class Program
{
    public static void Main()
    {
        int sum = 7 + 5;
        int difference = 7 - 5;
        int product = 7 * 5;
        int quotient = 7 / 5;
        decimal decimalQuotientA = 7.0m / 5; // at least one of numbers being divided must be of type decimal
        decimal decimalQuotientB = 7 / 5.0m; // at least one of numbers being divided must be of type decimal
        int first = 7;
        int second = 5;
        decimal quotientCast = (decimal)first / (decimal)second; // casting both numbers to decimal before division
        int value1 = 3 + 4 * 5;
        int value2 = (3 + 4) * 5;

        Console.WriteLine(); // blank line for better readability
        // Output the results of the operations
        Console.WriteLine("Sum: " + sum); // Output: Sum: 12
        Console.WriteLine("Difference: " + difference); // Output: Difference: 2
        Console.WriteLine("Product: " + product); // Output: Product: 35
        Console.WriteLine("Quotient: " + quotient); // Output: Quotient: 1 // int cannot contain values after the decimal

        Console.WriteLine(); // blank line for better readability
        // at least one of numbers being divided must be of type decimal
        Console.WriteLine($"Decimal quotient A: {decimalQuotientA}"); // Output: Decimal quotient A: 1.4
        Console.WriteLine($"Decimal quotient B: {decimalQuotientB}"); // Output: Decimal quotient A: 1.4

        Console.WriteLine(); // blank line for better readability
        // Casting both numbers to decimal before division
        Console.WriteLine($"Decimal cast: {quotientCast}");

        Console.WriteLine(); // blank line for better readability
        // The modulus operator is useful for checking if a number is even or odd, or if a number is divisible by another number.
        // If the remainder is 0, then the number is even. If the remainder is not 0, then the number is odd.
        Console.WriteLine($"Modulus of 200 / 5 : {200 % 5}"); // Output: Modulus of 200 / 5 : 0
        Console.WriteLine($"Modulus of 7 / 5 : {7 % 5}"); // Output: Modulus of 7 / 5 : 2

        Console.WriteLine(); // blank line for better readability
        // In math, PEMDAS is an acronym that helps students remember the order of operations
        // The order of operations is important in mathematics. In C#, the order of operations follows the same rules as in mathematics. The order of operations is as follows:
        // 1. Parentheses  
        // 2. Exponents
        // 3. Multiplication and Division (from left to right)
        // 4. Addition and Subtraction (from left to right)
        Console.WriteLine(value1); // Output: 23
        Console.WriteLine(value2); // Output: 35
    }
}
