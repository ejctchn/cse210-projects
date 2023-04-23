using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        int grade = Convert.ToInt32(Console.ReadLine());

        if(grade >= 90)
        {
            Console.WriteLine("Your letter grade is A");
        }
        else if(grade >= 80 & grade <= 89)
        {
            Console.WriteLine("Your letter grade is B");
        }
        else if(grade >= 70 & grade <= 79)
        {
            Console.WriteLine("Your letter grade is C");
        }
        else if(grade >= 60 & grade <= 69)
        {
            Console.WriteLine("Your letter grade is D");
        }
        else if(grade < 60)
        {
            Console.WriteLine("Your letter grade is F");
        }
    }
}