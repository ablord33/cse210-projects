public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetDescription()
    {
        return _description;
    }

    public string GetDate()
    {
        return _date;
    }

    public string GetTime()
    {
        return _time;
    }

    public string GetAddress()
    {
        return _address.GetAddress();
    }

    public string GenerateStandardDetails()
    {
        string details = $"Title: {GetTitle()}\nDescription: {GetDescription()}\nDate: {GetDate()}\nTime: {GetTime()}\nAddress: {GetAddress()}";
        return details;
    }

    public virtual string GenerateFullDetails()
    {
        return GenerateStandardDetails();
    }

    public string GenerateShortDescription()
    {
        string shortDescription = $"Type: Event\nTitle: {GetTitle()}\nDate: {GetDate()}";
        return shortDescription;
    }
}
