
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture( Reference reference, string text)
    {
        _reference = reference;

        string[] words = text.Split(" ");

        foreach (string word in words)
        {
           Word objectWord = new Word(word);
           _words.Add(objectWord);
        }
        
    }

    public void HideRandomWords(int numberToHide)
    {
        
            Random random = new Random();

            for (int number = 0; number < numberToHide; number++)
            {
                int index = random.Next(0,_words.Count);
                _words[index].Hide();
            } 
    }

    public string GetDisplayText()
    {
    
        string passage = $"{_reference.GetDisplayText()}";
        foreach (Word word in _words) 
        {
        passage = passage + " " + word.GetDisplayText() + " ";
        }
        return passage;
    }

    public bool IsCompletelyHidden()
    {
       foreach (Word word in _words)
       {
        if (!word.IsHidden())
        {
            return false;
        }
       }
    
        return true;

    }

}