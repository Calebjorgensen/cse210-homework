using System;

public class Comment
{
    private string _user;
    private string _words;

    public Comment(string user, string words)
    {
        _user = user;
        _words = words;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"{_user} - {_words}");
    }
}