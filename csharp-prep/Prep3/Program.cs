using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,101);

        int guess = 9999999;

        int counter = 0;

        while (guess != number)
        {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());

                if (guess == number)
                {
                    counter = counter +1;
                    Console.WriteLine("Correct!");
                    Console.WriteLine($"It took you {counter} attempts to guess correctly.");
                }

                else if (guess > number)
                {
                    Console.WriteLine("Lower");
                    counter = counter +1;
                }

                 else if (guess < number)
                {
                    Console.WriteLine("Higher");
                    counter = counter + 1;
                }
        }
    }
}