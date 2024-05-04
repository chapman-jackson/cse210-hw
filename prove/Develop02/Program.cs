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

        Journal myJournal = new Journal();

        while (choice != 5)
        {
            Console.WriteLine("Please choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            choice = int.Parse(Console.ReadLine());

            

            if (choice == 1)
            {
                PromptGenerator promptGenerator = new PromptGenerator();
                string newPrompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine($"{newPrompt}");
                Console.WriteLine("");
                string entryNew = System.Console.ReadLine();
                DateTime CurrentTime = DateTime.Now;
                string dateText = CurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                newEntry._date = dateText;
                newEntry._promptText = newPrompt;
                newEntry._entryText = entryNew;

                myJournal.AddEntry(newEntry);
            }

            else if (choice == 2)
            {
                myJournal.DisplayAll();
            }

            else if (choice == 3)
            {
                Console.WriteLine("What file do you want to load from?");
                string file = Console.ReadLine();

                myJournal.LoadFromFile(file);        
                Entry newEntry = new Entry();
                newEntry._date = "";
                newEntry._promptText = "";
                newEntry._entryText = "";

                myJournal.AddEntry(newEntry);
                Console.WriteLine("Journal loaded.")  ;                   

            }

            else if (choice == 4)
            {
                Console.WriteLine("What is the file you want to save to?");
                string file = Console.ReadLine();
                
                
                myJournal.SaveToFile(file);
                Console.WriteLine("Entry saved.");
                
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