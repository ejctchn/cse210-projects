using System;

class Program
{
    static void Main(string[] args)
    {
        bool keep_going = true;

        Sleep sleep = new Sleep();
        Menu menu = new Menu();
        Breathing breathing = new Breathing(keep_going);
        Reflect reflect = new Reflect(keep_going);
        Listing listing = new Listing(keep_going);

        
        while(keep_going)
        {
            int selection = menu.MenuSelection();
            switch(selection)
            {
                case 1:
                    breathing.BreathingActivity();
                    break;
                case 2:
                    reflect.ReflectionActivity();
                    break;
                case 3:
                    listing.ListingActivity();
                    break;
                case 4:
                    Console.Write("Quitting... ");
                    sleep.SleepingSpinner();
                    keep_going = false;
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("There was an issue with the switch statement");
                    break;
            }
        }
    }
}