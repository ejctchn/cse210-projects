using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> summary = new List<string>();

        string date = "18 Oct 2022";
        double time = 60;
        double distance = 120;
        Running running = new Running(date, time, distance);

        summary.Add(running.getSummary());

        string date2 = "13 Jul 2023";
        double time2 = 120;
        double speed = 5;
        Cycling cycling = new Cycling(date2, time2, speed);

        summary.Add(cycling.getSummary());

        string date3 = "02 Jun 2023";
        double time3 = 30;
        double laps = 5;
        Swimming swimming = new Swimming(date3, time3, laps);

        summary.Add(swimming.getSummary());

        for(int i = 0; i < summary.Count; i++)
        {
            Console.WriteLine(summary[i]);
        }
    }
}