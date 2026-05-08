using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int userInput = -1;
        while (userInput != 0)
        {
            Console.Write("Enter a number, type 0 when finished: ");
            userInput = int.Parse(Console.ReadLine());
            if (userInput != 0)
            {
                numbers.Add(userInput);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }       
        Console.WriteLine("The sum of the numbers is: " + sum);

        float average = (float)sum / numbers.Count;
        Console.WriteLine("The average of the numbers is: " + average);

        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The largest number is:{max}");
        
        int smallestpositive = int.MaxValue;
        foreach (int number in numbers)        {
            if (number > 0 && number < smallestpositive)
            {
                smallestpositive = number;
            }
        }
        Console.WriteLine($"The smallest positive number is:{smallestpositive}");

        List<int> sortedNumbers = new List<int>(numbers);
        sortedNumbers.Sort();
        foreach (int number in sortedNumbers)
        {
            Console.WriteLine(number);
        }
    
    }
}