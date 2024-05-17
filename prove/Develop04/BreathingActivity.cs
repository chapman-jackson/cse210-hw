
using System.ComponentModel.Design;
using System.Reflection.PortableExecutable;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int duration) : base(name, description, duration)
    {
        //"Breathing Activity"
        //"This activity will help you focus on controlled breathing."
        _name = name;
        _description = description;  
        _duration = duration;    
    }

    public void Run()
    {
        Console.Clear();


        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.WriteLine("Get ready.");
        ShowSpinner(5);


        while (DateTime.Now < endTime)
        {
            Console.WriteLine();
            Console.WriteLine("Breathe in.");
            upAnimation();
            Console.WriteLine();
            Console.WriteLine("Breathe out.");
            downAnimation();           
        }
        

        DisplayEndingMessage();
    }

    public void upAnimation()
    {
        int ascendAnimation = 0;

        while (ascendAnimation < 5)
        {
            Console.Write("=");
            Thread.Sleep(1000);

            ascendAnimation = ascendAnimation + 1;
        }
    }

    public void downAnimation()
    {

        Console.Write("=====");
        int descendAnimation = 0;

        while (descendAnimation < 5)
        {
                Console.Write("\b \b");
                Thread.Sleep(1000);
    
                descendAnimation = descendAnimation + 1;
        }
    }
}