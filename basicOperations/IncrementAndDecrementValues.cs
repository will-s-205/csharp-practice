// use in terminal: 
// dotnet run .\mathOperations.cs
// to see the output of the program
// or in Visual Studio, click on the "Run" button or press F5 to run the program and see the output in the console window.
using System;

public class Program
{
    public static void Main()
    {
        int value = 1;

        Console.WriteLine(); // Blank line for separation

        value = value + 1;
        Console.WriteLine("First increment: " + value);

        value += 1;
        Console.WriteLine("Second increment: " + value);

        value++;
        Console.WriteLine("Third increment: " + value);

        value = value - 1;
        Console.WriteLine("First decrement: " + value);

        value -= 1;
        Console.WriteLine("Second decrement: " + value);

        value--;
        Console.WriteLine("Third decrement: " + value);



        Console.WriteLine(); // Blank line for separation
        int valueAgain = 1;
        valueAgain++;
        Console.WriteLine("First: " + valueAgain);
        Console.WriteLine($"Second: {valueAgain++}");
        Console.WriteLine("Third: " + valueAgain);
        Console.WriteLine($"Fourth: {++valueAgain}");
    }
}
