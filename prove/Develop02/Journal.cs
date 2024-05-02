using System.IO;

public class Journal 
{
    public List<Entry> _entries;

    public void AddEntry(Entry newEntry)
    {

    }

    public void DisplayAll()
    {
        string fileName = "journal.txt";
        string[]entries = System.IO.File.ReadAllLines(fileName);
        foreach (string entry in entries)

        {
            string [] sections = entry.Split("---");
            string segments = sections[0];
            
        }
        
    }

    public void SaveToFile(String file)
    {
                string fileName = "journal.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(file);
        }
    }

    public void LoadFromFile(String file)
    {
         file = "journal.txt";
        string[]entries = System.IO.File.ReadAllLines(file);
        foreach (string entry in entries)

        {
            string [] sections = entry.Split("---");
            string segments = sections[0];
            string newSegments = sections[1];
        }
    }
}