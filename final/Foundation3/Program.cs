using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating the address objects for each event.
        Address addressOutdoor = new Address("1227 Surrey Street","Akron","Ohio","United States");
        Address addressReception = new Address("427 Tinker Way", "Mexico City","State Of Mexico","Mexico");
        Address addressLecture = new Address("1299 Dingey Circle","Fairbanks","Alaska","United States");

        // Creating the event objects.
        Outdoor outdoorEvent = new Outdoor("Partly cloudy","Statue reveal","New statue unveiled at Chihuahua park","12/1/2025","2:00 PM",addressOutdoor);
        Reception receptionEvent = new Reception("2024SchoolGraduation@Yahoo.com","2024 High School Graduation","Come celebrate our high school senior's graduation!","6/2/2024","10:00 AM",addressReception);
        Lecture lectureEvent = new Lecture("Tim Cook",2000,"Technology start up","Tim Cook gives a lecture on how to start a technology company","8/23/2025","3:45 PM", addressLecture);
        
        // Outdoor event details.
        Console.WriteLine();
        Console.WriteLine("==========================================");
        Console.WriteLine(outdoorEvent.getStandardDetailsString());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.getFullDetailsString());
        Console.WriteLine();
        Console.WriteLine(outdoorEvent.getShortDescriptionString());
        Console.WriteLine("==========================================");
        Console.WriteLine();
        
        // Reception event details.
        Console.WriteLine("==========================================");
        Console.WriteLine(receptionEvent.getStandardDetailsString());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.getFullDetailsString());
        Console.WriteLine();
        Console.WriteLine(receptionEvent.getShortDescriptionString());
        Console.WriteLine("==========================================");
        Console.WriteLine();

        // Lecture event details.
        Console.WriteLine("==========================================");
        Console.WriteLine(lectureEvent.getStandardDetailsString());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.getFullDetailsString());
        Console.WriteLine();
        Console.WriteLine(lectureEvent.getShortDescriptionString());
        Console.WriteLine("==========================================");
        Console.WriteLine();
    }
}