// use in terminal: 
// dotnet run .\mathOperations.cs
// to see the output of the program
// or in Visual Studio, click on the "Run" button or press F5 to run the program and see the output in the console window.
// System.Console.WriteLine("Hello, World!");

int firstNumber = 12; // declaring and initializing an integer variable
int secondNumber = 7; // declaring and initializing another integer variable
System.Console.WriteLine(firstNumber+secondNumber); // basic addition with two integers, output will be 19

string firstName = "Bob"; // declaring and initializing a string variable
int widgetsSold = 7;
System.Console.WriteLine(firstName + " sold " + widgetsSold + 7 + " widgets."); // concatination will be done first, so the output will be "Bob sold 77 widgets."
// OR
System.Console.WriteLine(firstName + " sold " + (widgetsSold + 7) + " widgets."); // selecting the sum of widgetsSold + 7 first, so the output will be "Bob sold 14 widgets."
// OR
System.Console.WriteLine($"{firstName} sold {widgetsSold + 7} widgets."); // interpolation will be done first, so the output will be "Bob sold 14 widgets."
