using System;
using System.Runtime.CompilerServices;

class Scripture
{
    private Reference _Reference;
    private List<Word> _Words;

    // This is the constructor of the scripture part of the program. 
    public Scripture(Reference reference, string text)
    {
        _Reference = reference;
        _Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }


    //The next part of the code is use to get the randomness of the words to hide.
    public void HideRandomWords()
    {
        Random rand = new Random();
        var wordToHide = _Words[rand.Next(_Words.Count)];
        if(wordToHide._isHidden != true)
        {
            wordToHide.Hide();
        }
        else 
        {
            HideRandomWords();
        }
    }

    public bool AllWordsHidden => _Words.All(w => w._isHidden);

    public override string ToString() => $"{_Reference} -" + string.Join(" ", _Words);
}