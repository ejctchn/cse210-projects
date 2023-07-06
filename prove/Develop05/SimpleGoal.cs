public class SimpleGoal : Goal
{
    int goal_type = 1;
    int completed;
    string output;
    string goal_name;
    string goal_desc;
    int goal_points;
    bool int_entered = false;

    // public SimpleGoal(string _goal_type, string _goal_name, string _goal_desc, int _goal_points)
    // {
    //     goal_type = _goal_type;
    //     goal_name = _goal_name;
    //     goal_desc = _goal_desc;
    //     goal_points = _goal_points;
    // }
    public override string questions()
    {
        Console.Write("What is the name of your Goal? ");
        goal_name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        goal_desc = Console.ReadLine();
        while(!int_entered)
        {
            Console.Write("How many points are accociated with this goal? ");
            try
            {
                goal_points = Convert.ToInt32(Console.ReadLine());
                int_entered = true;
            }
            catch
            {
                Console.WriteLine("\nPlease only enter integers");
            }
        }
        output = $"{goal_type}+{completed}+{goal_name}+{goal_desc}+{goal_points}";
        return output;
    }
}