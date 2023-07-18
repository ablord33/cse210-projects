public class OutdoorGathering : Event
{
    public OutdoorGathering(string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
    }

    public string GetWeather()
    {
        // Use a weather API to get the weather forecast based on the address
        // Replace 'YOUR_API_KEY' with your actual API key
        string apiKey = "YOUR_API_KEY";
        string url = $"https://api.weatherapi.com/v1/forecast.json?key={apiKey}&q={GetAddress()}&days=1";
        // Perform API request and retrieve the weather forecast
        // ...

        return "Sunny"; // Placeholder result
    }

    public override string GenerateFullDetails()
    {
        string details = base.GenerateFullDetails();
        string weatherForecast = GetWeather();
        details += $"\nType: Outdoor Gathering\nWeather: {weatherForecast}";
        return details;
    }
}
