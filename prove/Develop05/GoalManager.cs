public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();

    private int _score;

    public GoalManager(int score)
    {
        _score = score;
    }

    public void Start()
    {

        int userChoice = -999999999;
        
        while (userChoice != 6)
        {
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine("Menu Options;");
            Console.WriteLine("1: Create New Goal");
            Console.WriteLine("2: List Goals");
            Console.WriteLine("3: Save Goals");
            Console.WriteLine("4: Load Goals");
            Console.WriteLine("5: Record Event");
            Console.WriteLine("6: Quit");
            Console.WriteLine("Select a choice from the menu: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                CreateGoal();
            }

            else if (userChoice == 2)
            {
                ListGoalDetails();
            }

            else if (userChoice == 3)
            { 
              SaveGoals();
            }

            else if (userChoice == 4)
            {
                LoadGoals();
            }

            else if (userChoice == 5)
            {
                RecordEvent();
            }

            else if (userChoice == 6)
            {
                Console.WriteLine("Goodbye.");
            }

            else
            {
                Console.WriteLine("You entered a number that does not correspond with a valid choice.");
                Console.WriteLine("Please make sure you enter a valid number.");
            }
        }


        
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        // loop through list of goals and display
        // the _names
        // use Console.Write(); for the name and Console.WriteLine(); for displaying the goal???

    }

    public void ListGoalDetails()
    {
        // to display an asterisk to indicate if a goal is done, use if and else if statements to write an asterisk if completed or an underscore if not.
           Console.WriteLine("The goals are:");
           int bulletCounter = 1;
            foreach (Goal goalEntry in _goals)
            {
                if (goalEntry.IsComplete())
                {
                    Console.WriteLine($"{bulletCounter}. [*] {goalEntry.GetDetailsString()}");
                }
                else
                {         
                    Console.WriteLine($"{bulletCounter}. [ ] {goalEntry.GetDetailsString()}");
                }
                bulletCounter = bulletCounter + 1;
            }
    }

    public void CreateGoal()
    {

        int goalChoice = 0;

        Console.WriteLine("The typed of Goals are:");
        Console.WriteLine("1: Simple Goal");
        Console.WriteLine("2: Eternal Goal");
        Console.WriteLine("3: Checklist Goal");
        Console.WriteLine("Which goal would you like to create?");
        goalChoice = int.Parse(Console.ReadLine());

        if (goalChoice == 1)
        {
            Console.WriteLine("What is the name of your goal?");
            string nameGoal = Console.ReadLine();

            Console.WriteLine("Write a short description for your goal.");
            string describeGoal = Console.ReadLine();

            int specifyPoints = 0;
            Console.WriteLine("How many points do you want to associate with this goal?");
            specifyPoints = int.Parse(Console.ReadLine());

            SimpleGoal goalS = new SimpleGoal("SimpleGoal",nameGoal,describeGoal,specifyPoints,false);
            _goals.Add(goalS);
        }

        else if (goalChoice == 2)
        {
            Console.WriteLine("What is the name of your goal?");
            string nameGoal = Console.ReadLine();

            Console.WriteLine("Write a short description for your goal.");
            string describeGoal = Console.ReadLine();

            int specifyPoints = 0;
            Console.WriteLine("How many points do you want to associate with this goal?");
            specifyPoints = int.Parse(Console.ReadLine());

            EternalGoal goalE = new EternalGoal("EternalGoal",nameGoal, describeGoal, specifyPoints);
            _goals.Add(goalE);
        }

         else if (goalChoice == 3)
        {
            Console.WriteLine("What is the name of your goal?");
            string nameGoal = Console.ReadLine();

            Console.WriteLine("Write a short description for your goal.");
            string describeGoal = Console.ReadLine();

            int specifyPoints = 0;
            Console.WriteLine("How many points do you want to associate with this goal?");
            specifyPoints = int.Parse(Console.ReadLine());

            int targetTimes = 0;
            Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
            targetTimes = int.Parse(Console.ReadLine());

            int bonusPoints = 0;
            Console.WriteLine("What is number of bonus points for accomplishing that goal?");
            bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal goalCL = new ChecklistGoal("ChecklistGoal",nameGoal,describeGoal,specifyPoints,bonusPoints,targetTimes);
            _goals.Add(goalCL);
        }

        else
        {
            Console.WriteLine("Please select a valid goal type.");
        }
    }

    public void RecordEvent()
    {
        ListGoalDetails();

        int completeGoal = 0;
        Console.WriteLine("What goal did you do?");
        completeGoal = int.Parse(Console.ReadLine())-1;
        int recordedGoal = _goals[completeGoal].RecordEvent();

        Console.WriteLine($"You earned {recordedGoal} points!");

        _score = _score + recordedGoal;
        Console.WriteLine($"You now have {_score} points.");

        if (_score >= 1000 && _score < 2500)
        {
            Console.WriteLine("Congratulations on reaching 1000 points! You are putting in good effort so far!");
        }

        else if (_score >= 2500 && _score < 5000)
        {
            Console.WriteLine("Congratulations on reaching 2500 points! You put in some serious effort on those goals!");
        }

        else if (_score >= 5000)
        {
            Console.WriteLine("Congratulations on reaching 5000 points! You are a goal achieving master!");
            _score = 0;
            Console.WriteLine("Your points have been reset to zero so you can work on more goals. :)");
        }
    }

    public void SaveGoals()
    {

        Console.WriteLine("What file do you want to save to?");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"{_score}");

            foreach (Goal goalEntry in _goals)
            {
                outputFile.WriteLine(goalEntry.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved.");
    }

    public void LoadGoals()
    {

        Console.WriteLine("What file do you want to load from?");
        string file = Console.ReadLine();

        string[] fileEntry = System.IO.File.ReadAllLines(file);
        int goalScore = int.Parse(fileEntry[0]);
        _score = _score + goalScore;
        
        if (fileEntry.Length > 0)
        {
            fileEntry = fileEntry.Skip(1).ToArray();
        }

        int goalPoints = 0;
        foreach (string goalEntry in fileEntry)
        {
            string[] pieces = goalEntry.Split("---");

            string typeGoal = pieces[0];
            string  goalName = pieces[1];
            string typeDescription = pieces[2];
            goalPoints = int.Parse(pieces[3]);

            if (pieces[0] == "EternalGoal")
            {
                EternalGoal eternal = new EternalGoal(typeGoal,goalName,typeDescription,goalPoints);
                _goals.Add(eternal);
            }
            if (pieces[0] == "ChecklistGoal")
            {
                int goalBonus = 0;
                goalBonus = int.Parse(pieces[4]);

                int goalTarget = 0;
                goalTarget = int.Parse(pieces[5]);

                int goalAmount = 0;
                goalAmount = int.Parse(pieces[6]);
                ChecklistGoal checklist = new ChecklistGoal(typeGoal,goalName,typeDescription,goalPoints,goalBonus,goalTarget,goalAmount);
                _goals.Add(checklist);
            }

            if (pieces[0] == "SimpleGoal")
            {
                bool goalBoolean;
                goalBoolean = bool.Parse(pieces[4]);
                SimpleGoal simple = new SimpleGoal(typeGoal,goalName,typeDescription,goalPoints,goalBoolean);
                _goals.Add(simple);
            }
        }
        Console.WriteLine("Goals loaded successfully.");
    }

}