public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;
 
    public MathAssignment(string studentName, string textbookSection, string topic, string problems)
     : base(studentName,topic)
    {
        _problems = problems;
        _textbookSection = textbookSection;
    }
    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}