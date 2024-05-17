public class Activity {
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description,int duration)
    {
        _name = name;
        _description= description;
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}.");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        
    }

    public void DisplayEndingMessage()
    {
        Console.Clear();
        Console.WriteLine("Well done!");
        Console.WriteLine($"You have completed {_duration} seconds of the {_name}.");
        ShowSpinner(5);
    }

    public void ShowSpinner(int seconds)
    {  
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        List <string> characters = new List<string>{
            "|",
            "/",
            "-",
            "\\",
            "|",
            "/",
            "-",
            "\\"
        };

        while (DateTime.Now < endTime)
        {
            string symbol = characters[i];
            Console.Write(symbol);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i++;

            if (i >= characters.Count)
            {
                i = 0;
            }

        }
    }

    public void ShowCountDown(int seconds)
    {
      for (int number = seconds; number > 0; number --)
      {
        Console.Write(number);
        Thread.Sleep(1000);
        Console.Write("\b \b");
      }
    }
}