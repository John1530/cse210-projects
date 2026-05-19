using System;

public class Fraction
{
    // Private member variables
    private int _top;
    private int _bottom;

    // Default constructor
    public Fraction()
    {
        // Default fraction is 1/1
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters
    public Fraction(int top, int bottom)
    {
        _top = top;

        // Prevent division by zero
        if (bottom == 0)
        {
            _bottom = 1;
        }
        else
        {
            _bottom = bottom;
        }
    }

    // Getter for top number
    public int GetTop()
    {
        return _top;
    }

    // Setter for top number
    public void SetTop(int top)
    {
        _top = top;
    }

    // Getter for bottom number
    public int GetBottom()
    {
        return _bottom;
    }

    // Setter for bottom number
    public void SetBottom(int bottom)
    {
        if (bottom != 0)
        {
            _bottom = bottom;
        }
        else
        {
            Console.WriteLine("Denominator cannot be zero.");
        }
    }

    // Returns fraction as a string
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Returns decimal value
    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}