using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter your first name: ");
        string fname = Console.ReadLine();
        Console.Write("Please enter your last name: ");
        string lname = Console.ReadLine();

        Console.WriteLine("Your name is " + lname + ", " + fname + " " + lname + ".");
    }
}