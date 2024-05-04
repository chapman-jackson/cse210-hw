using System.IO;
using System.Collections.Generic;
using System.IO.Compression;

public class Journal 
{
    public List<Entry> _entries = new List<Entry>();
    



    public void AddEntry(Entry newEntry)
    {
            _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry journalEntry in _entries)
        {
            Console.WriteLine($"{journalEntry._date} - prompt: {journalEntry._promptText} > {journalEntry._entryText}");
        }
    }

    public void SaveToFile(String file)
    {
      string fileName = file;

      using (StreamWriter outputFile = new StreamWriter(fileName))
{
    
       foreach (Entry journalEntry in _entries)
        {
            outputFile.WriteLine($"-*-{journalEntry._date}-*- -*- {journalEntry._promptText}-*- -*- {journalEntry._entryText}-*-");
        }
    
   
}
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] fileEntry = System.IO.File.ReadAllLines(file);
        foreach ( string journalEntry in fileEntry)
        {
            string[] segments = journalEntry.Split("-*-");
            string date = segments[0];
            string prompt = segments[1];
            string entry = segments[2];
  
        }
        
    }
}
