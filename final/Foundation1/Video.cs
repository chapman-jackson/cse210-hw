public class Video
{
    private string _title;
    private string _author;
    private string _length;
    private List<Comment> _comments;

    public Video(string title, string author, string length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComments( Comment comment)
    {
        _comments.Add(comment);
    }

    public List<Comment> returnComments()
    {
        return _comments;
    }
    public string returnVideoContent()
    {
        return $"Video title: {_title}  Video author: {_author} Video length: {_length}";
    }
}