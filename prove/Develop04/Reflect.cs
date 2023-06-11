class Reflect : Activity
{
    private bool keep_going;
    public Reflect(bool _keep_going) : base(_keep_going)
    {
        keep_going = _keep_going;
    }
    Sleep sleep = new Sleep();
    Prompt prompt = new Prompt();
    int duration;
    //bool keep_going = true;
    int counter;
    public void ReflectionActivity()
    {
        while(keep_going)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Reflection Activity.");
            Console.WriteLine("\nThis activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            Console.Write("\nHow long, in seconds, would you like for your session? ");

            try
            {
                duration = Convert.ToInt32(Console.ReadLine());

                keep_going = false;

                Console.WriteLine("Get ready... ");
                sleep.SleepingSpinner();

                Console.WriteLine("Consider the following prompt: ");
                string rand_prompt = prompt.ReturnPrompt(1);
                Console.WriteLine($"\n--- {rand_prompt} ---");
                Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
                Console.ReadLine();
                Console.WriteLine("Now ponder on each of the following questions as they relate to this experience.");
                Console.Write($"You may begin in: ");
                sleep.Countdown();
                Console.Clear();
                
                counter = 0;
                while(counter <= duration)
                {
                    string rand_question = prompt.ReturnPrompt(2);
                    Console.WriteLine($"> {rand_question} ");
                    sleep.SleepingSpinner(); //4 seconds each - 8 seconds total
                    sleep.SleepingSpinner();
                    counter += 8;
                } 
            }
            catch
            {
                Console.WriteLine("\nPlease only enter integers.");
                sleep.SleepingSpinner();
            }

            Console.Write("\nWell Done!");
            sleep.SleepingSpinner();
            Console.Write($"\nYou have completed {duration} seconds of the Reflection Activity.");
            sleep.SleepingSpinner();
        }
    }
}