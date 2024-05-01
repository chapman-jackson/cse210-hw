using System;

    public class Job
     {
        public string _company;
        public string _title;
        public int _start;
        public int _end;

        public void Display()
        {
            Console.WriteLine($"{_title} ({_company}) {_start}-{_end}");
        }
    }