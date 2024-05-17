using System;

class Program
{
    static void Main(string[] args)
    {
        int userChoice = -999;


        while (userChoice != 4)
        {
            Thread.Sleep(4000);
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine("Select a choice from the menu:  ");
            userChoice = int.Parse(Console.ReadLine());

            

            if (userChoice == 1)
            {
                int duration = 0;
                BreathingActivity bActivity = new BreathingActivity("breathing activity","This activity will help you focus on controlled breathing.",duration);
                bActivity.DisplayStartingMessage();        
                Console.WriteLine("How long do you want to do this activity in seconds?");
                duration = int.Parse(Console.ReadLine());
                BreathingActivity breathingActivity = new BreathingActivity("breathing Activity","",duration);
                breathingActivity.Run();
                
            }

            else if (userChoice == 2)
            {
                int duration = 0;
                Console.Clear();
                ReflectingActivity rActivity = new ReflectingActivity("reflecting activity","This activity will help you reflect on your day. A prompt will be displayed for you to think about and then you will see questions to think about.",duration);
                rActivity.DisplayStartingMessage();
                Console.WriteLine("How long do you want to do this activity in seconds?");
                duration = int.Parse(Console.ReadLine());
                ReflectingActivity reflectingActivity = new ReflectingActivity("Reflecting activity","",duration);
                reflectingActivity.Run();
            }

            else if (userChoice == 3)
            {
                int duration = 0;
                Console.Clear();
                ListingActivity lActivity = new ListingActivity("listing Activity","This activity will give you a prompt that you write down answers for.",duration);
                lActivity.DisplayStartingMessage();

                Console.WriteLine("How long do you want to do this activity in seconds?");
                duration = int.Parse(Console.ReadLine());
                ListingActivity listingActivity = new ListingActivity("listing activity","",duration);
                listingActivity.Run();
            }

            else if (userChoice == 4)
            {
                Console.Clear();
                Console.WriteLine("Goodbye.");
            }

            else
            {
                Console.WriteLine("The number you entered does not correspond with a valid choice.");
                Console.WriteLine("Please make sure you select a number between one and four.");
            }
        }
    }
}