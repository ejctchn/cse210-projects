public class Circle : Shape
{
    double radius;

    public Circle(string _color, double _radius) : base(_color)
    {
        radius = _radius;
    }

    public override double GetArea()
    {
        return Math.Pow(radius, radius) * Math.PI;
    }
}