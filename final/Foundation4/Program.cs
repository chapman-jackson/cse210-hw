using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Swimming swimmingActivity = new Swimming("7/7/2024",20,12);
        activities.Add(swimmingActivity);

        Running runningActivity = new Running("7/8/2024",60,3);
        activities.Add(runningActivity);

        Biking bikingActivity = new Biking("7/9/2024",60,15.00,15);
        activities.Add(bikingActivity);

        foreach (var exerciseActivity in activities)
        {
            Console.WriteLine(exerciseActivity.getActivitySummaryString());
            Console.WriteLine();
        }
        
    }
}