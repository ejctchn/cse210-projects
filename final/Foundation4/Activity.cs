public class Activity
{
    private string date;
    private int length;

    public Activity(string _date, int _length)
    {
        date = _date;
        length = _length;
    }

    public virtual int getDistance()
    {
        return length;
    }
    public virtual int getSpeed()
    {
        return (distance / minutes) * 60;
    }
    public virtual int getPace()
    {
        return 60 / speed;
    }
    public virtual string getSummary()
    {
        return $"{date} {type} ({length}) - Distance: {distance} miles, Speed: {speed} mph, Pace: {pace} min per mile";
    }
}