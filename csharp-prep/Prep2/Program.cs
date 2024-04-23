using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?");
        string number = Console.ReadLine();
        int grade = int.Parse(number);

        string letter = "";
        if (grade >= 90)
        {
            letter ="A";
        }

        else if (grade >= 90 && grade < 94)
        {
            letter = "A-";
        }

        else if (grade >= 87 && grade < 90)
        {
            letter = "B+";
        }

        else if (grade >= 80 && grade < 84)
        {
            letter = "B-";
        }

        else if (grade >= 80 && grade < 90)
        {
            letter = "B";
        }

        else if (grade >= 77 && grade < 80)
        {
            letter = "C+";
        }

        else if (grade >= 70 && grade < 74)
        {
            letter = "C-";
        }

        else if (grade >= 70 && grade < 80)
        {
            letter = "C";
        }

        else if (grade >= 67 && grade < 70)
        {
           letter = "D+"; 
        }

         else if (grade >= 60 && grade < 64)
        {
            letter = "D-";
        }

         else if (grade >= 60 && grade < 70)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        if (grade >= 70)
        {
            Console.WriteLine($"Your grade is a {letter}. You passed the class!");
        }

        else
        {
            Console.WriteLine($"Your grade is a {letter}. You did not pass the class. I know you can do it next time.");
        }
    }
}