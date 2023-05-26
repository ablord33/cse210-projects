class Reference
{
    public string Book { get; }
    public int Chapter { get; }
    public int Verse { get; }
    public int? EndVerse { get; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = null;
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        Book = book;
        Chapter = chapter;
        Verse = verse;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndVerse.HasValue)
            return $"{Book} {Chapter}:{Verse}-{EndVerse}";
        else
            return $"{Book} {Chapter}:{Verse}";
    }
}