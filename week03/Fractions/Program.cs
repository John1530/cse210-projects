using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== FRACTION PROGRAM ===\n");

        // Default constructor
        Fraction f1 = new Fraction();
        DisplayFraction(f1);

        // Constructor with one parameter
        Fraction f2 = new Fraction(5);
        DisplayFraction(f2);

        // Constructor with two parameters
        Fraction f3 = new Fraction(3, 4);
        DisplayFraction(f3);

        Fraction f4 = new Fraction(1, 3);
        DisplayFraction(f4);

        Console.WriteLine("=== TESTING GETTERS & SETTERS ===\n");

        Fraction customFraction = new Fraction();

        customFraction.SetTop(7);
        customFraction.SetBottom(9);

        Console.WriteLine($"Top Number: {customFraction.GetTop()}");
        Console.WriteLine($"Bottom Number: {customFraction.GetBottom()}");
        Console.WriteLine($"Fraction: {customFraction.GetFractionString()}");
        Console.WriteLine($"Decimal Value: {customFraction.GetDecimalValue()}");
    }

    static void DisplayFraction(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
        Console.WriteLine();
    }
}