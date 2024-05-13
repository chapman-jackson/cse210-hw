using System;

class Program 
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Bob Marley","Calculus");
        string homework = assignment.GetSummary();
        Console.WriteLine(homework);
        Console.WriteLine();
        
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Section 7.3", "Fractions", "Problems 8-19");
        string homeworkOne = mathAssignment.GetHomeworkList();
        Console.WriteLine(mathAssignment.GetSummary());
        Console.WriteLine(homeworkOne);
        Console.WriteLine();

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters","The causes of World War II","European History");
        string homeworkTwo = writingAssignment.GetWritingInformation();
        Console.WriteLine(writingAssignment.GetSummary());
        Console.WriteLine(homeworkTwo);
    }
}