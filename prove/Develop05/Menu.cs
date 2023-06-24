public class Menu
{
    int choice;

    public int displayMenu()
    {
        bool int_entered = false;
        while(!int_entered)
        {
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("\t1. Create New Goal");
            Console.WriteLine("\t2. List Goals");
            Console.WriteLine("\t3. Save Goals");
            Console.WriteLine("\t4. Load Goals");
            Console.WriteLine("\t5. Record Event");
            Console.WriteLine("\t6. Quit");
            Console.Write("Select a choice from the menu: ");

            try
            {
                choice = Convert.ToInt32(Console.ReadLine());
                int_entered = true;
            }
            catch
            {
                Console.WriteLine("Please only enter integers.");
            }
        }

        return choice;
    }
}