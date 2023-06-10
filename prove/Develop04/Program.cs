using System;

class Program
{
    static void Main(string[] args)
    {
        Sleep sleep = new Sleep();
        Menu menu = new Menu();
        Breathing breathing = new Breathing();
        Reflect reflect = new Reflect();

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
                Console.Write("selected 3... ");
                break;
            case 4:
                Console.Write("Quitting... ");
                sleep.SleepingSpinner();
                Console.Clear();
                break;
            default:
                Console.WriteLine("There was an issue with the switch statement");
                break;
        }
    }
}