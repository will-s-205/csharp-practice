using System;

public class Program
{
    public static void Main()
    {
        float fahrenheit = 94.3f; // float is used to store decimal numbers with single precision
        float miles = 10.9f; // same for float here

        Console.WriteLine($"{fahrenheit} degree by Fahrenheit is a {Math.Round((fahrenheit - 32) * (5 / 9.0), 1)} degree by Celsius"); // 94 degree by Fahrenheit is a 34 degree by Celsius
        Console.WriteLine($"{miles} miles is a {Math.Round((miles * 1.60934), 1)} kilometers"); // 10 miles is a 16 kilometers
    }
}
