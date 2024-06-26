// For the grader:
// The user can enter the reference and scripture passage of their choosing into the program.
using System;
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter a Book of Mormon book title.");
        string bOfm = Console.ReadLine();

        int bOfmChapter = 0;
        Console.WriteLine("Enter the chapter.");
        bOfmChapter = int.Parse(Console.ReadLine());

        int chapterVerse = 0;
        Console.WriteLine("Enter the starting verse of the scripture you want to memorize.");
        chapterVerse = int.Parse( Console.ReadLine());

        int EndChapterVerse = 0;
        Console.WriteLine("Enter the ending verse of the scripture. Type '0' if it is only one verse.");
        EndChapterVerse = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the words of the scripture you want to memorize.");
        string scriptureWords = Console.ReadLine();

        Console.WriteLine("Press 'enter' to begin memoriing.");
        string enter = Console.ReadLine();

        string userInput = "placeholder";

        Reference reference = new Reference(bOfm,bOfmChapter,chapterVerse,EndChapterVerse);
        Scripture scripture = new Scripture(reference,scriptureWords);
        
        
        while (!scripture.IsCompletelyHidden() && userInput != "quit")

        {
            Console.Clear();

            scripture.HideRandomWords(3);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to end the program.");
            userInput = Console.ReadLine();

            
             if (scripture.IsCompletelyHidden())
             {
                Console.WriteLine("Good job memorizing!");
             }

             else
             {
                Console.WriteLine("Keep up the great work!");
             }
        }

    }
}