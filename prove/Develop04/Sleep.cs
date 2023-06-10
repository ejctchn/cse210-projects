class Sleep
{
    int wait;
    public void SleepingSpinner()
    {
        wait = 2;
        while(wait != 0)
        { 
            Console.Write("-");
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the + character
            Console.Write("\\"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the - character
            Console.Write("|"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b"); // Erase the - character
            Console.Write("/"); // Replace it with the - character
            Thread.Sleep(500);
            Console.Write("\b \b"); // Erase the - character
            wait--;
        }
    }
    public void Countdown()
    {
        wait = 4;
        while(wait != 0)
        {
            Console.Write(wait);
            Thread.Sleep(1000);
            Console.Write("\b \b"); // Erase the - character
            wait--;
        }
    }
}