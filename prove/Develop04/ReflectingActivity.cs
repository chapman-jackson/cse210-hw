
public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "---Think about a time the Holy Ghost helped you.---",
        "---Think about an enjoyable experience you had.---",
        "---Think about a trial you overcame.---",
        "---Think about an event that happened recently.---",
        "---Think about a time you were able to help someone.---",
    };

    private List<string> _questions = new List<string>{
        "How did you feel when you experienced this?",
        "What did you do that led to this?",
        "How would you implement what you learned from this in the future?",
        "How did the experience help you spiritually?",
        "What did you learn from this experience?",
        "How will you use what you learned to help others?",
        "Do you want an experience that is similar to this moment in the future?",
        "What would you change about this experience later on?",
    };

    public ReflectingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //"Reflecting Activity"
        //"This activity will help you reflect on your day. A prompt will be displayed for you to think about and then you will see questions to think about."
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        Console.WriteLine("Get ready.");
        ShowSpinner(5);

        Console.WriteLine("Here is a prompt for you to think about.");
        Console.WriteLine(GetRandomPrompt());

        Console.WriteLine("When you are ready, press enter to continue.");
        string ready = Console.ReadLine();
        Console.WriteLine("You may begin in:");
        ShowCountDown(5);


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.WriteLine(GetRandomQuestion());
            ShowSpinner(5);
        }
        
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0,_prompts.Count);
       
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random random = new Random();
        int index = random.Next(0,_questions.Count);
       
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        GetRandomPrompt();
    }

    public void DisplayQuestions()
    {
        GetRandomQuestion();
    }
}