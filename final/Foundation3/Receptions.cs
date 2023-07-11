public class Receptions : Event
{
    private string email;
    public Receptions(string _title, string _desc, string _date, string _time, string _address, string _email) : base(_title, _desc, _date, _time, _address)
    {
        type = "Reception";
        email = _email;
    }

    public override string standardMessage()
    {
        return $"Title: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}";
    }
    public override string fullMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}\nEmail (for RSVP): {email}";
    }
    public override string shortMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDate: {date}";
    }
}