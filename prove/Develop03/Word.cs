class Word
{
    private readonly string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public string GetDisplayText()
    {
        if (_isHidden)
            return "*****";
        else
            return _text;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public bool IsHidden => _isHidden;
}
