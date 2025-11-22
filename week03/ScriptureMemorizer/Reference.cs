public class Reference
{
    private string _book;
    private int _startVerse;
    private int? _endVerse; // nullable for single verse

    // Constructor for single verse
    public Reference(string book, int startVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = null;
    }

    // Constructor for verse range
    public Reference(string book, int startVerse, int endVerse)
    {
        _book = book;
        _startVerse = startVerse;
        _endVerse = endVerse;
    }

    public override string ToString()
    {
        if (_endVerse.HasValue)
            return $"{_book} {_startVerse}-{_endVerse}";
        else
            return $"{_book} {_startVerse}";
    }
}
