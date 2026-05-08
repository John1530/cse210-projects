using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What was the percentage you scored in the recent exam? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);
        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
            Console.WriteLine("Congratulations! You scored an A! Keep up the great work!");
        }
        else if (percentage >= 80)
        {
            letter = "B";
            Console.WriteLine("Good job! You're doing well!");
        }
        else if (percentage >= 70)
        {
            letter = "C";
            Console.WriteLine("Not bad, but there's room for improvement.");
        }
        else if (percentage >= 60)
        {
            letter = "D";
            Console.WriteLine("You passed, but consider studying more for better results.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("Don't be discouraged. Use this as a learning opportunity and try again!");
        }   
        {
            Console.WriteLine($"Your grade is: {letter}");
        }
        
    }
}