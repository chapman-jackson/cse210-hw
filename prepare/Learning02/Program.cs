using System;

class Program
{
    static void Main(string[] args)
    {
        Job job1 = new Job ();
        job1._title = "Software Engineer";
        job1._company = "Microsoft";
        job1._start = 2019;
        job1._end = 2022;

        Job job2 = new Job ();
        job2._title = "Manager";
        job2._company = "Apple";
        job2._start = 2022;
        job2._end = 2023;

        Resume jobResume = new Resume();
        jobResume._name = "Jackson Chapman";

        jobResume._jobs.Add(job1);
        jobResume._jobs.Add(job2);

        jobResume.Display();
    }
}