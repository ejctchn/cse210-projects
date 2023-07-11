using System;

class Program
{
    static void Main(string[] args)
    {
        //Lecture Tests
        Console.WriteLine("\nLECTURE EXAMPLE");

        string title = "The best title ever!";
        string desc = "The purpose of this discussion is to show how awesome I can be.";
        string date = "10/18/2023";
        string time = "7:00pm";
        string address = "123 Peach Rd Fairbanks, AK 99703";
        string speaker = "Jason Bourne";
        int capacity = 250;

        Lectures lectures = new Lectures(title, desc, date, time, address, speaker, capacity);
        Console.WriteLine($"\nStandard:\n{lectures.standardMessage()}");
        Console.WriteLine($"\nLong:\n{lectures.fullMessage()}");
        Console.WriteLine($"\nShort:\n{lectures.shortMessage()}");
        
        //Receptions Tests
        Console.WriteLine("\nRECEPTION EXAMPLE");

        string rec_title = "Underwater Theme";
        string rec_desc = "James and Rebecca Crawford's wedding reception for friends and family.";
        string rec_date = "01/22/2024";
        string rec_time = "9:00pm";
        string rec_address = "528491 Inception Way Anchorage, AK 99501";
        string email = "email@example.com";

        Receptions receptions = new Receptions(rec_title, rec_desc, rec_date, rec_time, rec_address, email);
        Console.WriteLine($"\nStandard:\n{receptions.standardMessage()}");
        Console.WriteLine($"\nFull:\n{receptions.fullMessage()}");
        Console.WriteLine($"\nShort:\n{receptions.shortMessage()}");

        //Outdoor Gatherings Tests
        Console.WriteLine("\nOUTDOOR GATHERING EXAMPLE");

        string outdoor_title = "Clean Control Halloween Party";
        string outdoor_desc = "Yearly October company party for Clean Control Corp.";
        string outdoor_date = "10/29/2023";
        string outdoor_time = "6:00pm";
        string outdoor_address = "867-5309 Jenny St Juneau, AK 99801";
        string weather = "Overcast, with a high near 89. Southwest wind 10 to 15 mph.";

        Outdoor outdoor = new Outdoor(outdoor_title, outdoor_desc, outdoor_date, outdoor_time, outdoor_address, weather);
        Console.WriteLine($"\nStandard:\n{outdoor.standardMessage()}");
        Console.WriteLine($"\nFull:\n{outdoor.fullMessage()}");
        Console.WriteLine($"\nShort:\n{outdoor.shortMessage()}");
    }
}