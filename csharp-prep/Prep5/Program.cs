using System;

class Program
{
    static void Main(string[] args)
    {
    
        DisplayMessage ();

        string InputName = PromptUserName ();
        int InputNumber = PromptUserNumber ();

        int SquaredNumber = SquareNumber (InputNumber);
        DisplayResult (InputName, SquaredNumber);
    }

        static void DisplayMessage ()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName ()
        {
            Console.WriteLine("Please enter your name: ");
            string UserName = Console.ReadLine();

            return UserName;
        }

        static int PromptUserNumber ()
        {
            Console.WriteLine("What is your favorite number: ");
            int UserNumber = int.Parse(Console.ReadLine());

            return UserNumber;
        }

        static int SquareNumber (int UserNumber)
        {
            int SquareNum = UserNumber * UserNumber;

            return SquareNum;
        }

        static void DisplayResult (string UserName, int SquaredNumber)
        {
            Console.WriteLine($"{UserName}, the square of your number is {SquaredNumber}.");
        }
}