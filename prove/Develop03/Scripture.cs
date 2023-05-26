class Scripture
{
    public Reference Reference { get; }
    public string Text { get; }

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Text = text;
    }
}
