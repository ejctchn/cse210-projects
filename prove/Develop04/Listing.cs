using System.Diagnostics;
class Listing : Activity
{
    private bool keep_going;
    public Listing(bool _keep_going) : base(_keep_going)
    {
        keep_going = _keep_going;
    }
    Sleep sleep = new Sleep();
    Prompt prompt = new Prompt();
    //Stopwatch stopwatch = new Stopwatch();
    int duration;
    string user_input;
    //int counter;
    List<string> user_list = new List<string>();
    //bool keep_going = true;
    public void ListingActivity()
    {
        while(keep_going)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the Listing Activity.");
            Console.WriteLine("\nThis activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            Console.Write("\nHow long, in seconds, would you like for your session? ");

            try
            {
                duration = Convert.ToInt32(Console.ReadLine());

                keep_going = false;

                Console.WriteLine("Get ready... ");
                sleep.SleepingSpinner();

                Console.WriteLine("List as many responses you can to the following prompt:");
                string rand_prompt = prompt.ReturnPrompt(3);
                Console.WriteLine($"--- {rand_prompt} ---");
                Console.Write("You may begin in: ");
                sleep.Countdown();
                Console.WriteLine("");

                DateTime start = DateTime.Now;
                DateTime current = DateTime.Now;
                while((current.Second - start.Second) <= duration)
                {
                    Console.Write("> ");
                    user_input = Console.ReadLine();
                    user_list.Add(user_input);
                    current = DateTime.Now;
                }

                Console.WriteLine($"You listed {user_list.Count} items!");
                Console.WriteLine("\nWell Done!");
                sleep.SleepingSpinner();
            }
            catch
            {
                Console.WriteLine("\nPlease only enter integers.");
                sleep.SleepingSpinner();
            }
        }
    }
}