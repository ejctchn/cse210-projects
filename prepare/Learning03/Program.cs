using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);
        string f1 = fraction1.display();
        string f2 = fraction2.display();
        string f3 = fraction3.display();

        double f11 = fraction1.display_decimal();
        double f22 = fraction2.display_decimal();
        double f33 = fraction3.display_decimal();
        Console.WriteLine($"The fractions are: {f1}, {f2}, {f3}");
        Console.WriteLine($"The decimals are: {f11}, {f22}, {f33}");
    }
}