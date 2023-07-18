public class Reception : Event
{
    private string _rsvpEmail;

    public Reception(string title, string description, string date, string time, Address address, string rsvpEmail)
        : base(title, description, date, time, address)
    {
        _rsvpEmail = rsvpEmail;
    }

    public string GetRsvpEmail()
    {
        return _rsvpEmail;
    }

    public override string GenerateFullDetails()
    {
        string details = base.GenerateFullDetails();
        details += $"\nType: Reception\nRSVP Email: {GetRsvpEmail()}";
        return details;
    }
}
