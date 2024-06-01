using System;

public class Video
{
    private string _name;
    private string _author;
    private double _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string name, string author, double length)
    {
        _name = name;
        _author = author;
        _length = length;
    }

    public void ListComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int CountComments()
    {
        int count = 0;
        count = _comments.Count();
        return count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine();
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine();
        int commentCount = CountComments();
        Console.WriteLine($"Number of comments: {commentCount}");
        Console.WriteLine("Comments");
        foreach (Comment comment in _comments)
        {
            comment.DisplayInfo();
        }
    }
}