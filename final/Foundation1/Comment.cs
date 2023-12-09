public class Comment
{
    private string _author;
    private string _comment;

    public Comment(string author, string comment)
    {
        _author = author;
        _comment = comment;
    }

    public void DisplayCommentInfo()
    {
        Console.WriteLine($"{_author}: \n{_comment} \n");
    }
}   