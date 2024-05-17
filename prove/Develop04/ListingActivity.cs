using System.Collections.Specialized;

public class ListingActivity : Activity
{
    private int _count;

    private List<string> _prompts = new List<string>{
        "What did you do to push through a trial?",
        "What scriptures have infuenced the decisions you make?",
        "How has the Holy Ghost helped you today?",
        "How were your interactions with the people in your life?",
        "What are the best habits you made?",
    };

    public ListingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //"Listing Activity"
        //"This activity will give you a prompt that you write down answers for."
        _name = name;
        _description = description;
        _duration = duration;
    }

    public void Run()
    {
        Console.Clear();
        Console.WriteLine("Get ready.");
        ShowSpinner(5);
        Random random = new Random();
        int index = random.Next(0,_prompts.Count);
        Console.WriteLine("This is the prompt you will be writing about:");
        Console.WriteLine($"{_prompts[index]}");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        Console.WriteLine("you may begin in:");
        ShowCountDown(5);
        while (DateTime.Now < endTime)
        {
            Console.ReadLine();
            _count = _count + 1;
        }
        Console.WriteLine($"You wrote down {_count} items.");
        Thread.Sleep(3000);

        DisplayEndingMessage();
    }

}