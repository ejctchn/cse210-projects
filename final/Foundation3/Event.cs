public class Event
{
    protected string type;
    protected string title;
    protected string desc;
    protected string date;
    protected string time;
    protected string address;

    public Event(string _title, string _desc, string _date, string _time, string _address)
    {
        title = _title;
        desc = _desc;
        date = _date;
        time = _time;
        address = _address;
    }
    public virtual string shortMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDate: {date}";
    }
    public virtual string standardMessage()
    {
        return $"Title: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}";
    }
    public virtual string fullMessage()
    {
        return $"Event Type: {type}\n Title: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}";
    }
}