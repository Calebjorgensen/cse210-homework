using System;

class Reference
{

    //The goals of the Refenence class are to store the data need such as book, chapter, startverse, and endverse.
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    //This is the constructor for the reference part of the program. 
    public Reference(string book, int chapter, int startVerse, int? endVerse = null)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString() => $"{_book} {_chapter}:{_startVerse}" + (_endVerse.HasValue ? $"-{_endVerse}" : "");
}