public class PromptGenerator

{

  public List<string> _prompts = new List<string>(){
  
    "What was your favorite part about today?",

    "What did you learn about in your gospel study?",

    "What interesting conversation did you have with someone?",

    "What did you enjoy seeing today?",

    "If there is one thing you could improve, what would it be?"
  };
  public string GetRandomPrompt()
    {
      Random random = new Random();
      int index = random.Next(0,_prompts.Count);
       
      return _prompts[index];
    }
    
}
