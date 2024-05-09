using System;

class Program
{
    static void Main(string[] args)
    {

        var scripture = new Scripture(new Reference("Alma", 3,4,6), "Trust in the Lord with all thine heart;");

        while(!scripture.AllWordsHidden)
        {
            Console.Clear();
            Console.WriteLine(scripture);
            Console.WriteLine("\nPress Enter to hide a word or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input == "quit") return;

            scripture.HideRandomWords();
        }

        Console.Clear();
        Console.WriteLine("All words are hidden!");

    }

    class Reference
    {
        private string _book;
        private int _chapter;
        private int _startVerse;
        private int? _endVerse;

        public Reference(string book, int chapter, int startVerse, int? endVerse = null)
        {
            _book = book;
            _chapter = chapter;
            _startVerse = startVerse;
            _endVerse = endVerse;
        }

        public override string ToString() => $"{_book} {_chapter}:{_startVerse}" + (_endVerse.HasValue ? $"-{_endVerse}" : "");
    }

    class Scripture
    {
        private Reference _Reference;
        private List<Word> _Words;

        public Scripture(Reference reference, string text)
        {
            _Reference = reference;
            _Words = text.Split(' ').Select(w => new Word(w)).ToList();
        }

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

    class Word
    {
        private string _text;
        public bool _isHidden;

        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }

        public void Hide()
        {
            _isHidden = true;
        }

        public override string ToString() => _isHidden ? "______" : _text;
    }
}