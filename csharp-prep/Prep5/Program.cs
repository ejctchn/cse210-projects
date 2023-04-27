using System;

class Program
{
    static void displayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string promptUserName()
    {
        Console.Write("What is your name? ");
        string username = Console.ReadLine();
        return username;
    }
    static int promptUserNumber()
    {
        Console.Write("What is your favorite number? ");
        int num = Convert.ToInt32(Console.ReadLine());
        return num;
    }
    static int squareNumber(int number)
    {
        int squared = number * number;
        return squared;
    }
    static void displayResult(string name, int squared)
    {
        Console.WriteLine(name + ", the square of your number is " + squared);
    }
    static void Main(string[] args)
    {
        displayWelcome();
        string name = promptUserName();
        int number = promptUserNumber();
        int squared = squareNumber(number);
        displayResult(name, squared);
    }

}