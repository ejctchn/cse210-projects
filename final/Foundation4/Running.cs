public class Running : Activity
{
    private double distance;

    public Running(string _date, double _length, double _distance) : base(_date, _length)
    {
        date = _date;
        length = _length;
        distance = _distance;
        type = "Running";
    }

    public override double getDistance()
    {
        return distance;
    }
    public override double getSpeed()
    {
        try
        { 
            return (distance / length);
        }
        catch
        {
            return 60 / getPace();
        }
    }
    public override double getPace()
    {
        try
        {
            return length / distance;
        }
        catch
        {
            return 60 / getSpeed();
        }
    }
}