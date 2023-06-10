class Breathing
{
    Sleep sleep = new Sleep();
    bool keep_going = true;
    int duration;
    public void BreathingActivity()
    {
        while(keep_going)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Breathing Activity.");
            Console.WriteLine("\nThis activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            Console.Write("\nHow long, in seconds, would you like for your session? ");

            try
            {
                duration = Convert.ToInt32(Console.ReadLine());

                keep_going = false;

                Console.WriteLine("Get ready... ");
                sleep.SleepingSpinner();

                int counter = 0;
                while(counter <= duration)
                {
                    Console.WriteLine("\nBreathe in... ");
                    sleep.Countdown();
                    Console.WriteLine("Breathe out... ");
                    sleep.Countdown();
                    counter += 8;
                }
            }
            catch
            {
                Console.WriteLine("Please only enter integers. ");
                sleep.SleepingSpinner();
            }

            Console.WriteLine("\nWell Done!");
            Console.WriteLine($"\nYou have completed {duration} seconds of the Breathing Activity.");
            sleep.SleepingSpinner();
        }
    }
}