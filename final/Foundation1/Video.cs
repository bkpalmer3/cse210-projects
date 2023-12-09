public class Video
{
    private string _title;
    private string _author;
    private int _lengthInSeconds;
    List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
    }

    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {_title} \nAuthor {_author} \nVideo Length {_lengthInSeconds} seconds \n");
    }

    public int CountComments()
    {
        return _comments.Count();
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public void ListComments()
    {
        foreach (Comment c in _comments)
        {
            c.DisplayCommentInfo();
        }
    }
}
