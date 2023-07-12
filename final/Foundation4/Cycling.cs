public class Cycling : Activity
{
    private double speed;

    public Cycling(string _date, double _length, double _speed) : base(_date, _length)
    {
        date = _date;
        length = _length;
        speed = _speed;
        type = "Cycling";
    }

    public override double getDistance()
    {
        return (speed * length) / 60;
    }
    public override double getSpeed()
    {
        return speed;
    }
    public override double getPace()
    {
        try
        {
            return length / getDistance();
        }
        catch
        {
            return 60 / speed;
        }
    }
}