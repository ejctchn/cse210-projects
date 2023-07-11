public class Lectures : Event
{
    private string speaker;
    private int capacity;
    private List<string> possible_speakers = new List<string>();
    Random rnd = new Random();

    public Lectures(string _title, string _desc, string _date, string _time, string _address, string _speaker, int _capacity) : base(_title, _desc, _date, _time, _address)
    {
        type = "Lecture";
        speaker = _speaker;
        capacity = _capacity;

        possible_speakers.Add("Harry Potter");
        possible_speakers.Add("Matt Murdock");
        possible_speakers.Add("Chelsey Kneederman");
        possible_speakers.Add("Voldermort");
        possible_speakers.Add("Chandler Bing");
        possible_speakers.Add("Eli Cutchen");
        possible_speakers.Add("Bethany Podcast");
    }

    public string chooseSpeaker()
    {
        return possible_speakers[rnd.Next(possible_speakers.Count)];
    }
    public override string standardMessage()
    {
        return $"Title: {title}\nDescription: {desc}\nDate/Time: {date} {time}\nAddress: {address}";
    }
    public override string fullMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDescription: {desc}\nSpeaker: {speaker}\nMax Capacity: {capacity}\nDate/Time: {date} {time}\nAddress: {address}";
    }
    public override string shortMessage()
    {
        return $"Event Type: {type}\nTitle: {title}\nDate: {date}";
    }
}