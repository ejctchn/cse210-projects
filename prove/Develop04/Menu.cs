class Menu
{
    Sleep sleep = new Sleep();
    bool keep_going;
    int userselection;
    public int MenuSelection()
    {
        keep_going = true;
        while(keep_going)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("\t1. Start breathing activity");
            Console.WriteLine("\t2. Start reflecting activity");
            Console.WriteLine("\t3. Start listing activity");
            Console.WriteLine("\t4. Quit");
            Console.Write("Select a choice from the menu: ");
            
            try
            {
                userselection = Convert.ToInt32(Console.ReadLine());
                keep_going = false;
            }
            catch
            {
                Console.WriteLine("\nPlease only enter integers. "); 
                sleep.SleepingSpinner();
            }
        }
        return userselection;
    }
}