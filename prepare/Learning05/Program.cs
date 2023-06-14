using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        
        List<Shape> list_of_shapes = new List<Shape>();

        Square square = new Square("Blue", 5.5);
        Rectangle rec = new Rectangle("Red", 10, 20);
        Circle cir = new Circle("Green", 5);

        //Test Square
        string get_color_square = square.GetColor();
        double get_area_square = square.GetArea();

        Console.WriteLine("\nSquare: ");
        Console.WriteLine(get_color_square);
        Console.WriteLine(get_area_square);

        //Testing Rectangle
        string get_color_rec = rec.GetColor();
        double get_area_rec = rec.GetArea();

        Console.WriteLine("\nRectangle: ");
        Console.WriteLine(get_color_rec);
        Console.WriteLine(get_area_rec);

        //Testing Circle
        string get_color_cir = cir.GetColor();
        double get_area_cir = cir.GetArea();

        Console.WriteLine("\nCircle: ");
        Console.WriteLine(get_color_cir);
        Console.WriteLine(get_area_cir);

        //Testing list
        list_of_shapes.Add(square);
        list_of_shapes.Add(rec);
        list_of_shapes.Add(cir);

        foreach(Shape s in list_of_shapes)
        {
            string list_color = s.GetColor();
            double list_area = Math.Round(s.GetArea(), 2);

            //display color and area
            Console.WriteLine($"\n The color is {list_color}, and the area is {list_area}");
        }
    }
}