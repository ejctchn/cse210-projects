public class Outdoor : Event
{
    string weather;

    public Outdoor(string _title, string _desc, string _date, string _time, string _address, string _weather) : base(_title, _desc, _date, _time, _address)
    {
        type = "Outdoor Gathering";
        weather = _weather;
    }

    public override string standardMessage()
    {
        return $"Title: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}";
    }
    public override string fullMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}\nWeather: {weather}";
    }
    public override string shortMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDate: {date}";
    }
}