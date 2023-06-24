using System;

class Program
{
    static void Main(string[] args)
    {
        bool continue_program = true;
        int total_points = 0;
        List<string> goals_list = new List<string>();

        Menu menu = new Menu();
        SimpleGoal simple = new SimpleGoal();

        while(continue_program)
        {
            Console.WriteLine($"You have {total_points} points");
            bool int_entered = false;
            int choice = menu.displayMenu();

            switch(choice)
            {
                case 1:
                    while(!int_entered)
                    {
                        int type = 0;
                        Console.WriteLine("The types of goals are:");
                        Console.WriteLine("\t1. Simple Goal");
                        Console.WriteLine("\t2. Eternal Goal");
                        Console.WriteLine("\t3. Checklist Goal");
                        Console.Write("Which type of goal would you like to create? ");
                        try
                        {
                            type = Convert.ToInt32(Console.ReadLine());
                            int_entered = true;
                        }
                        catch
                        {
                            Console.WriteLine("\nPlease only enter integers");
                        }
                        
                        if(type == 1)
                        {
                            goals_list.Add(simple.questions());
                        }
                        else if(type == 2)
                        {
                            Console.WriteLine("testing 2");
                        }
                        else if(type == 3)
                        {
                            Console.WriteLine("testing 3");
                        }

                    }
                    break;
                case 2:
                    Console.WriteLine(goals_list);
                    break;
                case 3:
                    Console.WriteLine("You chose 3");
                    break;
                case 4:
                    Console.WriteLine("You chose 4");
                    break;
                case 5:
                    Console.WriteLine("You chose 5");
                    break;
                case 6:
                    Console.WriteLine("quitting...");
                    continue_program = false;
                    break;
                default:
                    break;
            }
        }
    }
}