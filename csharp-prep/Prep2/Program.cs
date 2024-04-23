using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        if (grade >= 90)
        {
            Console.WriteLine("Your grade is an A. You passed the class!");
        }

        else if (grade >= 90 && grade < 94)
        {
            Console.WriteLine("Your grade is an A-. You passed the class!");
        }

        else if (grade >= 87 && grade < 90)
        {
            Console.WriteLine("Your grade is a B+. You passed the class!");
        }

        else if (grade >= 80 && grade < 84)
        {
            Console.WriteLine("Your grade is a B-. You passed the class!");
        }

        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("Your grade is a B. You passed the class!");
        }

        else if (grade >= 77 && grade < 80)
        {
            Console.WriteLine("Your grade is a C+. You passed the class!");
        }

        else if (grade >= 70 && grade < 74)
        {
            Console.WriteLine("Your grade is a C-. You passed the class!");
        }

        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("Your grade is a C. You passed the class!");
        }

        else if (grade >= 67 && grade < 70)
        {
            Console.WriteLine("Your grade is a D+. You did not pass the class.");
        }

         else if (grade >= 60 && grade < 64)
        {
            Console.WriteLine("Your grade is a D-. You did not pass the class.");
        }

         else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("Your grade is a D. You did not pass the class.");
        }

        else if (grade < 60)
        {
            Console.WriteLine("Your grade is a F. You did not pass the class.");
        }
    }
}