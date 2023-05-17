public class Fraction
{
    private int top;
    private int bottom;

    public Fraction()
    {
        top = 1;
        bottom = 1;
    }
    public Fraction(int number)
    {
        top = number;
        bottom = 1;
    }
    public Fraction(int _top, int _bottom)
    {
        top = _top;
        bottom = _bottom;
    }
    public string display()
    {
        string text = $"{top}/{bottom}";
        return text;
    }
    public double display_decimal()
    {
        double dec_top = Convert.ToDouble(top);
        double dec_bottom = Convert.ToDouble(bottom);
        double deci = dec_top / dec_bottom;
        return deci;
    }
}



