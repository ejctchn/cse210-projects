public class Activity
{
    protected string date;
    protected double length;
    
    protected string type;

    public Activity(string _date, double _length)
    {
        date = _date;
        length = _length;
        type = "";
    }

    public virtual double getDistance()
    {
        return (getSpeed() * length) / 60;
    }
    public virtual double getSpeed()
    {
        try
        { 
            return (getDistance() / length) * 60;
        }
        catch
        {
            return 60 / getPace();
        }
    }
    public virtual double getPace()
    {
        try
        {
            return length / getDistance();
        }
        catch
        {
            return 60 / getSpeed();
        }
    }
    public virtual string getSummary()
    {
        return $"{date} {type} ({length} min) - Distance: {Math.Round(getDistance(), 1)} miles, Speed: {Math.Round(getSpeed(), 1)} mph, Pace: {Math.Round(getPace(), 1)} min per mile";
    }
}