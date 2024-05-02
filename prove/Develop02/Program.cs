// The program has an else statement that tells the user
// to pick a valid option between one and five if another number is selected.
// The program will keep repeating this until a valid option is chosen.
using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("This is a journal program.");

        int choice = -999999999;

        while (choice != 5)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice =int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                //PromptGenerator prompt = new PromptGenerator();
  
                //Console.WriteLine(prompt);
                Console.WriteLine("");
                string entryNew = System.Console.ReadLine();
                List<string> entries = new List<string>();
                DateTime CurrentTime = DateTime.Now;
                string dateText = CurrentTime.ToShortDateString();

                Entry entry = new Entry();
                entry._date = dateText;
                entry._promptText = "";
                entry._entryText = entryNew;

                entry.Display();
            }

            else if (choice == 2)
            {
                Journal myJournal = new Journal();
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {

                Console.WriteLine("What file do you want to load from?");
                string file = Console.ReadLine();

                
            }

            else if (choice == 4)
            {

                Console.WriteLine("What is the file you want to save to?");
                string fileName = Console.ReadLine();
                Journal myJournal = new Journal();

                
            }

             else if (choice == 5)
            {
                Console.WriteLine("Goodbye.");
            }

            else 
            {
                Console.WriteLine("That is not a valid option. Please make sure you select an option that has a number between one and five.");
            }
        }
    }

}