using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int number = 3;

        while (number != 0)
        {
            Console.WriteLine("Enter number:");

            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        
        int total = 0;
        foreach (int digit in numbers)
        {
            total += digit;
        }


        Console.WriteLine($"Sum: {total}");

        float average_num = ((float)total)/ numbers.Count;

        Console.WriteLine($"Average: {average_num}");

        int maximum = numbers[0];

        foreach (int digits in numbers)
        {
            if (digits > maximum)
            {
                maximum = digits;
            }
        }

        Console.WriteLine($"Highest number: {maximum}");
    }
}