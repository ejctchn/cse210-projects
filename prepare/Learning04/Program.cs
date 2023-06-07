using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your name? ");
        string name = Console.ReadLine();
        Console.Write("What is the topic? ");
        string topic = Console.ReadLine();
        Console.Write("What is the section? ");
        string section = Console.ReadLine();
        Console.Write("What are the problems? ");
        string problems = Console.ReadLine();

        Assignment assignment = new Assignment(name, topic);
        string summary = assignment.GetSummary();
        MathAssignment math = new MathAssignment(name, topic, section, problems);
        string summary2 = math.GetSummary();
        string summary3 = math.GetHomeworkList();
        Console.WriteLine(summary2);
        Console.WriteLine(summary3);
    }
}