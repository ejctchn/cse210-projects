public class Swimming : Activity
{
    private double num_of_laps;
    //private double lap_miles;

    public Swimming(string _date, double _length, double _num_of_laps) : base(_date, _length)
    {
        date = _date;
        length = _length;
        num_of_laps = _num_of_laps;
        //lap_miles = (num_of_laps * 50) / 1609.34;
        type = "Swimming";
    }

     public override double getDistance()
    {
        return (num_of_laps * 50) / 1000 * 0.62;
    }
    public override double getSpeed()
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
    public override double getPace()
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
}