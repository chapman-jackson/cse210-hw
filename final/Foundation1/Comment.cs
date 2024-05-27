public class Comment
{
    private string _commenter;
    private string _context;

    public Comment(string commenter, string context)
    {
        _commenter = commenter;
        _context = context;
    }

    public string returnComments()
    {
        return $"Commenter: {_commenter} Text: {_context}";
    }
}